using EasyAR;
using MOROPO.CPCC.CinemaStreet.Arsmart.Extensions;
using MOROPO.CPCC.CinemaStreet.Arsmart.UI.Env3D.Components;
using System.Collections.Generic;
using System.Linq;
using Urho;
using Urho.Actions;

namespace MOROPO.CPCC.CinemaStreet.Arsmart.UI.Env3D.Presenters
{
    public class MainARPresenter : Application
    {
        private Scene foregroundScene;
        private Octree foregroundOctree;
        private Camera urhoCameraComponent;
        private EasyARUrhoComponent easyARUrhoComponent;

        private readonly Dictionary<string, Node> targetIdentitficationNodes;

        [Preserve]
        public MainARPresenter(ApplicationOptions options) : base(options)
        {
            targetIdentitficationNodes = new Dictionary<string, Node>();
        }

        public System.EventHandler<MainARPresenterTargetInfoPresentRequestEventArg> TargetInfoPresentRequest;

        protected override void Start()
        {
            base.Start();

            Renderer.NumViewports = 2;

            Init3DScene();
        }

        protected override void Stop()
        {
            base.Stop();

            Input.TouchEnd -= Input_TouchEnd;

            easyARUrhoComponent.ARFrameUpdated -= OnARFrameUpdated;

            easyARUrhoComponent.Dispose();
        }

        private void Init3DScene()
        {
            foregroundScene = new Scene();

            foregroundOctree = foregroundScene.CreateComponent<Octree>();

            var zoneComponent = foregroundScene.CreateComponent<Zone>();

            zoneComponent.AmbientColor = Color.White * 0.25f;

            var cameraNode = foregroundScene.CreateChild();

            cameraNode.Position = new Vector3(0, 0, 0);

            cameraNode.LookAt(new Vector3(0, 0, 1), new Vector3(0, 1, 0));

            urhoCameraComponent = cameraNode.CreateComponent<Camera>();

            var lightNode = foregroundScene.CreateChild();

            lightNode.Position = new Vector3(0, 0, -10);

            var lightComponent = lightNode.CreateComponent<Light>();

            lightComponent.LightType = LightType.Directional;
            lightComponent.SpecularIntensity = 0.5f;

            var foregroundViewport = new Viewport(Context, foregroundScene, urhoCameraComponent, null);

            foregroundViewport.RenderPath = foregroundViewport.RenderPath.Clone();
            foregroundViewport.RenderPath.RemoveCommand(0);

            foregroundViewport.SetClearColor(Color.Transparent);

            easyARUrhoComponent = foregroundScene.CreateComponent<EasyARUrhoComponent>();

            easyARUrhoComponent.ARFrameUpdated += OnARFrameUpdated;

            Input.TouchEnd += Input_TouchEnd;

            Renderer.SetViewport(1, foregroundViewport);
        }

        public void Input_TouchEnd(TouchEndEventArgs eventArgs)
        {
            var cameraRay = urhoCameraComponent.GetScreenRay((float)eventArgs.X / Current.Graphics.Width, (float)eventArgs.Y / Current.Graphics.Height);

            var result = foregroundOctree.RaycastSingle(cameraRay);

            if (result != null)
            {
                var target = result.Value.Drawable as IInfoZoneInterative;

                if (target != null && TargetInfoPresentRequest != null)
                {
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(delegate
                    {
                        TargetInfoPresentRequest.Invoke(this, new MainARPresenterTargetInfoPresentRequestEventArg { TargetInfo = target.TargetInfo });
                    });
                }
            }
        }

        protected void OnARFrameUpdated(OutputFrame oFrame, CameraParameters cameraParameters, float aspectRatio, int rotation)
        {
            var far = 100f;
            var near = 0.01f;

            Matrix44F easyARCameraProjection = cameraParameters.projection(near, far, aspectRatio, rotation, true, false);

            foreach (var unTypedResult in oFrame.results())
            {
                if (unTypedResult.OnSome)
                {
                    if (unTypedResult.Some is ImageTrackerResult result)
                    {
                        int targetIndex = 0;

                        var targetInstances = result.targetInstances();

                        var targetKeys = new List<string>();

                        foreach (TargetInstance targetInstance in targetInstances)
                        {
                            TargetStatus status = targetInstance.status();

                            if (status == TargetStatus.Tracking)
                            {
                                Optional<Target> optionalTarget = targetInstance.target();

                                if (optionalTarget.OnSome)
                                {
                                    Target target = optionalTarget.Some;

                                    if (target is ImageTarget imageTarget)
                                    {
                                        var images = imageTarget.images();

                                        var targetImage = images[0];

                                        var urhoCameraProjection = easyARCameraProjection.ToUrhoMatrix();

                                        urhoCameraProjection.M34 /= 2f;
                                        urhoCameraProjection.M33 = far / (far - near);
                                        urhoCameraProjection.M43 *= -1;

                                        urhoCameraComponent.SetProjection(urhoCameraProjection);

                                        var convertedPoseMatrix = targetInstance.pose().ToUrhoMatrix();

                                        var scale = new Vector3(imageTarget.scale(), imageTarget.scale() * targetImage.height() / targetImage.width(), 1);

                                        UpdateARScene(target, targetIndex, convertedPoseMatrix, scale);

                                        targetKeys.Add(imageTarget.name());

                                        foreach (Image targetImageToRelease in images)
                                        {
                                            targetImageToRelease.Dispose();
                                        }
                                    }

                                    target.Dispose();
                                }
                            }

                            targetInstance.Dispose();

                            targetIndex++;
                        }

                        var targetIdentitficationNodeKeys = targetIdentitficationNodes.Keys.ToArray();

                        foreach (var key in targetIdentitficationNodeKeys)
                        {
                            if (targetKeys.Any(item => item == key)) continue;

                            targetIdentitficationNodes.Remove(key, out var node);

                            node.Remove();
                        }
                    }

                    unTypedResult.Some.Dispose();
                }
            }
        }

        private void UpdateARScene(Target target, int index, Matrix4 poseMatrix, Vector3 scale)
        {
            Node rootNode;

            var calloutNodes = new List<Node>();

            var targetName = target.name();

            //Flatten out the cube
            scale.Z *= 0.005f;

            if (targetIdentitficationNodes.ContainsKey(targetName))
            {
                rootNode = targetIdentitficationNodes[targetName];
            }
            else
            {
                rootNode = foregroundScene.CreateChild();

                var targetNode = rootNode.CreateChild();

                //glowMaterial.SetTechnique(0, CoreAssets.Techniques.NoTextureUnlit);

                switch (targetName)
                {
                    case Providers.ConstantProvider.CINEMA_STREET_TARGET_1:
                        targetNode.Position = new Vector3(0.0f, 0.0f, -1 * 0.5f);

                        ConfigurateInfoZoneNode(targetNode, 0.2f, 0.5f, -1 * 0.35f, 0.1125f, Providers.DataModelProvider.TargetInfos[0]);
                        ConfigurateInfoZoneNode(targetNode, 0.16f, 0.20f, -1 * 0.3625f, -1 * 0.2825f, Providers.DataModelProvider.TargetInfos[1]);

                        ConfigurateInfoZoneNode(targetNode, 0.1425f, 0.24275f, -1 * 0.1225f, 0.2825f, Providers.DataModelProvider.TargetInfos[2]);
                        ConfigurateInfoZoneNode(targetNode, 0.1385f, 0.247125f, -1 * 0.1225f, -1 * 0.0025f, Providers.DataModelProvider.TargetInfos[3]);
                        ConfigurateInfoZoneNode(targetNode, 0.1385f, 0.247125f, -1 * 0.1225f, -1 * 0.285f, Providers.DataModelProvider.TargetInfos[4]);

                        ConfigurateInfoZoneNode(targetNode, 0.1425f, 0.24275f, 0.05125f, 0.2825f, Providers.DataModelProvider.TargetInfos[5]);
                        ConfigurateInfoZoneNode(targetNode, 0.1385f, 0.247125f, 0.04775f, -1 * 0.0025f, Providers.DataModelProvider.TargetInfos[6]);
                        ConfigurateInfoZoneNode(targetNode, 0.1385f, 0.24525f, 0.04785f, -1 * 0.2845f, Providers.DataModelProvider.TargetInfos[7]);

                        ConfigurateInfoZoneNode(targetNode, 0.1425f, 0.24275f, 0.22075f, 0.2825f, Providers.DataModelProvider.TargetInfos[8]);
                        ConfigurateInfoZoneNode(targetNode, 0.1385f, 0.247125f, 0.21875f, -1 * 0.0025f, Providers.DataModelProvider.TargetInfos[9]);
                        ConfigurateInfoZoneNode(targetNode, 0.1385f, 0.24525f, 0.2175f, -1 * 0.2845f, Providers.DataModelProvider.TargetInfos[10]);

                        ConfigurateInfoZoneNode(targetNode, 0.1425f, 0.24275f, 0.39075f, 0.2825f, Providers.DataModelProvider.TargetInfos[11]);
                        ConfigurateInfoZoneNode(targetNode, 0.1385f, 0.247125f, 0.3905f, -1 * 0.0025f, Providers.DataModelProvider.TargetInfos[12]);
                        ConfigurateInfoZoneNode(targetNode, 0.1385f, 0.24525f, 0.39025f, -1 * 0.2845f, Providers.DataModelProvider.TargetInfos[13]);

                        break;

                    case Providers.ConstantProvider.CINEMA_STREET_TARGET_2:

                        ConfigurateInfoZoneNode(targetNode, 0.2190f, 0.24275f, -1 * 0.325f, 0.2825f, Providers.DataModelProvider.TargetInfos[14]);
                        ConfigurateInfoZoneNode(targetNode, 0.2185f, 0.247125f, -1 * 0.325f, -1 * 0.0025f, Providers.DataModelProvider.TargetInfos[15]);
                        ConfigurateInfoZoneNode(targetNode, 0.2185f, 0.24525f, -1 * 0.325f, -1 * 0.2845f, Providers.DataModelProvider.TargetInfos[16]);

                        ConfigurateInfoZoneNode(targetNode, 0.2190f, 0.24275f, -1 * 0.065f, 0.2825f, Providers.DataModelProvider.TargetInfos[17]);
                        ConfigurateInfoZoneNode(targetNode, 0.2185f, 0.247125f, -1 * 0.065f, -1 * 0.0025f, Providers.DataModelProvider.TargetInfos[18]);
                        ConfigurateInfoZoneNode(targetNode, 0.2185f, 0.24525f, -1 * 0.0675f, -1 * 0.2845f, Providers.DataModelProvider.TargetInfos[19]);

                        ConfigurateInfoZoneNode(targetNode, 0.2190f, 0.24275f, 0.195f, 0.2825f, Providers.DataModelProvider.TargetInfos[20]);
                        ConfigurateInfoZoneNode(targetNode, 0.2185f, 0.247125f, 0.195f, -1 * 0.0025f, Providers.DataModelProvider.TargetInfos[21]);
                        ConfigurateInfoZoneNode(targetNode, 0.2185f, 0.24525f, 0.195f, -1 * 0.2845f, Providers.DataModelProvider.TargetInfos[22]);

                        break;
                }

                targetIdentitficationNodes.Add(targetName, rootNode);
            }

            // Reverse handedness of pose's rotation
            var rotation = poseMatrix.Rotation;

            rotation.Z *= -1;
            rotation.W *= -1;

            var pos = poseMatrix.Column3;

            rootNode.Position = new Vector3(pos.X, pos.Y, -1 * pos.Z); // Reverse handedness of the poses position
            rootNode.Rotation = rotation;
            rootNode.Scale = scale;

            //foreach (var node in calloutNodes)
            //{
            //    RotateNodeRelativeToCamera(node);
            //}
        }

        private void ConfigurateInfoZoneNode(Node parentNode, float widthFactor, float heightFactor, float positionX, float positionY, Models.Data.TargetInfoDataModel targetInfo)
        {
            var glowMaterial = Material.FromColor(Color.Cyan);

            var aspectFactor = widthFactor / heightFactor;

            var infoZoneNode = parentNode.CreateChild();

            infoZoneNode.Position = new Vector3(positionX, positionY, 0.0f);
            infoZoneNode.Scale = new Vector3(widthFactor, heightFactor, 1.0f);

            var infoZoneOverlayComponent = infoZoneNode.CreateComponent<InfoZoneOverlayModel>();

            infoZoneOverlayComponent.TargetInfo = targetInfo;
            infoZoneOverlayComponent.Model = CoreAssets.Models.Box;
            infoZoneOverlayComponent.Material = ResourceCache.GetMaterial("Materials/Overlay.xml", sendEventOnFailure: false);

            var callToActionTextShadownNode = infoZoneNode.CreateChild();

            callToActionTextShadownNode.Position = Vector3.Zero;
            callToActionTextShadownNode.Scale = new Vector3(1.0f, aspectFactor, 1.0f);

            var callToActionTextShadownComponent = callToActionTextShadownNode.CreateComponent<InfoZoneCallToAction3DText>();

            callToActionTextShadownComponent.TargetInfo = targetInfo;
            callToActionTextShadownComponent.Text = "";
            callToActionTextShadownComponent.HorizontalAlignment = Urho.Gui.HorizontalAlignment.Center;
            callToActionTextShadownComponent.VerticalAlignment = Urho.Gui.VerticalAlignment.Center;

            callToActionTextShadownComponent.SetFont(ResourceCache.GetFont("Fonts/materialdesignicons-webfont.ttf"), 54);
            callToActionTextShadownComponent.SetColor(Color.Black);

            var callToActionTextNode = infoZoneNode.CreateChild();

            callToActionTextNode.Position = new Vector3(0.0f, 0.0f, -1.0f);
            callToActionTextNode.Scale = new Vector3(1.0f, aspectFactor, 1.0f);

            var callToActionTextComponent = callToActionTextNode.CreateComponent<InfoZoneCallToAction3DText>();

            callToActionTextComponent.TargetInfo = targetInfo;
            callToActionTextComponent.Text = "";

            callToActionTextComponent.HorizontalAlignment = Urho.Gui.HorizontalAlignment.Center;
            callToActionTextComponent.VerticalAlignment = Urho.Gui.VerticalAlignment.Center;

            callToActionTextComponent.SetFont(ResourceCache.GetFont("Fonts/materialdesignicons-webfont.ttf"), 48);
            callToActionTextComponent.SetColor(Color.Cyan);

            callToActionTextShadownNode.RunActionsAsync(new RepeatForever(new Sequence(new EaseElasticInOut(new ScaleBy(0.5f, 1.25f)), new EaseElasticInOut(new ScaleBy(0.5f, 0.8f)))));
            callToActionTextNode.RunActionsAsync(new RepeatForever(new Sequence(new EaseElasticInOut(new ScaleBy(0.5f, 1.25f)), new EaseElasticInOut(new ScaleBy(0.5f, 0.8f)))));

            var edgeHorizontalSpacing = 0.0175f / aspectFactor;
            var edgeVerticalSpacing = 0.0175f;

            var infoZoneLeftEdgeNode = infoZoneNode.CreateChild();

            infoZoneLeftEdgeNode.Position = new Vector3(-1 * 0.5f - edgeHorizontalSpacing, 0.0f, 1.0f);
            infoZoneLeftEdgeNode.Scale = new Vector3(0.025f, 1.0f, 1.0f);

            var infoZoneLeftEdgeComponent = infoZoneLeftEdgeNode.CreateComponent<StaticModel>();

            infoZoneLeftEdgeComponent.Model = CoreAssets.Models.Box;
            infoZoneLeftEdgeComponent.Material = glowMaterial;

            var infoZoneRightEdgeNode = infoZoneNode.CreateChild();

            infoZoneRightEdgeNode.Position = new Vector3(0.5f + edgeHorizontalSpacing, 0.0f, 1.0f);
            infoZoneRightEdgeNode.Scale = new Vector3(0.025f, 1.0f, 1.0f);

            var infoZoneRightEdgeComponent = infoZoneRightEdgeNode.CreateComponent<StaticModel>();

            infoZoneRightEdgeComponent.Model = CoreAssets.Models.Box;
            infoZoneRightEdgeComponent.Material = glowMaterial;

            var infoZoneTopEdgeNode = infoZoneNode.CreateChild();

            infoZoneTopEdgeNode.Position = new Vector3(0.0f, 0.5f + edgeVerticalSpacing, 1.0f);
            infoZoneTopEdgeNode.Scale = new Vector3(1.0f, 0.025f * aspectFactor, 1.0f);

            var infoZoneTopEdgeComponent = infoZoneTopEdgeNode.CreateComponent<StaticModel>();

            infoZoneTopEdgeComponent.Model = CoreAssets.Models.Box;
            infoZoneTopEdgeComponent.Material = glowMaterial;

            var infoZoneBottomEdgeNode = infoZoneNode.CreateChild();

            infoZoneBottomEdgeNode.Position = new Vector3(0.0f, -1 * 0.5f - edgeVerticalSpacing, 1.0f);
            infoZoneBottomEdgeNode.Scale = new Vector3(1.0f, 0.025f * aspectFactor, 1.0f);

            var infoZoneBottomEdgeComponent = infoZoneBottomEdgeNode.CreateComponent<StaticModel>();

            infoZoneBottomEdgeComponent.Model = CoreAssets.Models.Box;
            infoZoneBottomEdgeComponent.Material = glowMaterial;
        }

        private interface IInfoZoneInterative
        {
            public Models.Data.TargetInfoDataModel TargetInfo { get; }
        }

        private class InfoZoneOverlayModel : StaticModel, IInfoZoneInterative
        {
            public Models.Data.TargetInfoDataModel TargetInfo { get; set; }
        }

        private class InfoZoneCallToAction3DText : Urho.Gui.Text3D, IInfoZoneInterative
        {
            public Models.Data.TargetInfoDataModel TargetInfo { get; set; }
        }

        //private class PlaceFeatureImageSprite : Urho.Urho2D.StaticSprite2D, IPlaceDataBindable
        //{
        //    public Models.Data.PlaceDataModel Place { get; set; }
        //}
    }

    public class MainARPresenterTargetInfoPresentRequestEventArg : System.EventArgs
    {
        public Models.Data.TargetInfoDataModel TargetInfo { get; set; }
    }
}

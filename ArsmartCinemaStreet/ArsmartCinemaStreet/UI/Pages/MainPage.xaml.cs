using Xamarin.Essentials;

namespace MOROPO.CPCC.CinemaStreet.Arsmart.UI.Pages
{
    public partial class MainPage : Xamarin.Forms.ContentPage
    {
        private Env3D.Presenters.MainARPresenter env3DPresenter;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = new Models.Page.MainPageModel();
        }

        private Models.Page.MainPageModel ConcreteBindingContext => BindingContext as Models.Page.MainPageModel;

        protected override void OnAppearing()
        {
            base.OnAppearing();

            CoverImage.Source = Xamarin.Forms.ImageSource.FromResource("MOROPO.CPCC.CinemaStreet.Arsmart.Resources.Image.cover.png");
        }

        protected override void OnDisappearing()
        {
            if (env3DPresenter != null)
            {
                env3DPresenter.TargetInfoPresentRequest -= MainARPresenter_TargetInfoPresentRequested;

                env3DPresenter = null;
            }

            (Content as Xamarin.Forms.Grid).Children.RemoveAt(0);

            CoverImage.Source = null;

            Urho.Forms.UrhoSurface.OnDestroy();

            base.OnDisappearing();
        }

        protected override bool OnBackButtonPressed()
        {
            if (ConcreteBindingContext.TargetInfo == null) return false;

            if (ConcreteBindingContext.TargetAuthor == null)
            {
                ConcreteBindingContext.TargetInfo = null;

                MainScrollView.ScrollToAsync(0, 0, false);
            }
            else
            {
                ConcreteBindingContext.TargetAuthor = null;
                AuthorScrollView.ScrollToAsync(0, 0, false);
            }
             
            return true;
        }

        private void HelpToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new HelpPage());
        }

        private void AboutToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }

        private void MainARPresenter_TargetInfoPresentRequested(object sender, Env3D.Presenters.MainARPresenterTargetInfoPresentRequestEventArg eventArg)
        {
            ConcreteBindingContext.TargetInfo = eventArg.TargetInfo;
        }

        private async System.Threading.Tasks.Task<bool> GetPermissions()
        {
            var status = await Permissions.CheckStatusAsync<Permissions.Camera>();

            if (status == PermissionStatus.Denied && DeviceInfo.Platform == DevicePlatform.iOS)
            {
                // Prompt the user to turn on in settings
                // On iOS once a permission has been denied it may not be requested again from the application
                return false;
            }

            if (Permissions.ShouldShowRationale<Permissions.Camera>())
            {
                // Prompt the user with additional information as to why the permission is needed
            }

            status = await Permissions.RequestAsync<Permissions.Camera>();

            return status == PermissionStatus.Granted;
        }

        private void CoverImage_Success(object sender, FFImageLoading.Forms.CachedImageEvents.SuccessEventArgs e)
        {
            System.Threading.Tasks.Task.Delay(5000).ContinueWith(_ =>
            {
                Dispatcher.BeginInvokeOnMainThread(() =>
                {
                    GetPermissions().ContinueWith(task =>
                    {
                        Dispatcher.BeginInvokeOnMainThread(() =>
                        {
                            if (!task.Result)
                            {
                                DisplayAlert("Aviso", "Es necesario brindar permisos de uso de la cámara a esta aplicación para su correcto funcionamiento.", "Aceptar");
                            }
                            else
                            {
                                if (ConcreteBindingContext.IsBusy) return;

                                ConcreteBindingContext.IsBusy = true;

                                System.Threading.Tasks.Task.Delay(1000).ContinueWith(_ =>
                                {
                                    Dispatcher.BeginInvokeOnMainThread(() =>
                                    {
                                        ConcreteBindingContext.IsBusy = false;

                                        var urhoSurface = new Urho.Forms.UrhoSurface();

                                        var urhoApplicationOptions = new Urho.ApplicationOptions()
                                        {
                                            ResourcePaths = new[] { "UrhoData" },
                                            Orientation = Urho.ApplicationOptions.OrientationType.LandscapeAndPortrait
                                        };

                                        (Content as Xamarin.Forms.Grid).Children.Insert(0, urhoSurface);

                                        urhoSurface.Show<Env3D.Presenters.MainARPresenter>(urhoApplicationOptions).ContinueWith(task =>
                                        {
                                            env3DPresenter = task.Result;

                                            env3DPresenter.TargetInfoPresentRequest += MainARPresenter_TargetInfoPresentRequested;
                                        });
                                    });
                                });
                            }
                        });
                    });
                });
            });                        
        }

        private void AuthorDetail_Button_Clicked(object sender, System.EventArgs e)
        {
            ConcreteBindingContext.TargetAuthor = ConcreteBindingContext.TargetInfo.Author; 
        }

    }
}
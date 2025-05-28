namespace MOROPO.CPCC.CinemaStreet.Arsmart.Models.Page
{
    public class MainPageModel : SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel
    {
        private Data.TargetInfoDataModel targetInfo;

        public Data.TargetInfoDataModel TargetInfo { get => targetInfo; set => SetProperty(ref targetInfo, value); }
    }
}

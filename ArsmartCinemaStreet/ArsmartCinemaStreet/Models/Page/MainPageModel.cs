namespace MOROPO.CPCC.CinemaStreet.Arsmart.Models.Page
{
    public class MainPageModel : SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel
    {
        private Data.TargetInfoDataModel targetInfo;
        private Data.AuthorDataModel targetAuthor;

        public Data.TargetInfoDataModel TargetInfo { get => targetInfo; set => SetProperty(ref targetInfo, value); }

        public Data.AuthorDataModel TargetAuthor { get => targetAuthor; set => SetProperty(ref targetAuthor, value); }

    }
}

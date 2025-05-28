namespace MOROPO.CPCC.CinemaStreet.Arsmart.UI.Converters
{
    public class TargetInfoDataToPosterImageHeightConverter : Xamarin.Forms.IValueConverter
    {
        public Pages.MainPage Page { get; set; }

        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) return null;

            var model = value as Models.Data.TargetInfoDataModel;

            if (model == null) return null;

            return System.Convert.ToDouble(model.PosterHeight) * (Page.Width - 64) / System.Convert.ToDouble(model.PosterWidth);
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}

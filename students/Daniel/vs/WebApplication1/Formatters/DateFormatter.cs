namespace WebApplication1.Formaters
{
    public class DateFormatter
    {
        public string DateToStrng(DateTime dt)
        {
            return dt.ToString("yyyy.MM.dd");
        }
    }
}

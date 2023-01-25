namespace WebApplication3.TimeService
{
    public class DateTimeService : IDateTimeService
    {
        private Guid _id;
        public DateTimeService()
        {
            _id = Guid.NewGuid();
        }

        public DateTime GetNow()
        {
            return DateTime.Now;
        }
    }
}

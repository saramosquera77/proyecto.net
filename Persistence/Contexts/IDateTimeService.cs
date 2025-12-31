namespace Persistence.Contexts
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
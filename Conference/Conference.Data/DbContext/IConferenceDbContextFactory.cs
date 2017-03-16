namespace Conference.Data.DbContext
{
    public interface IConferenceDbContextFactory
    {
        IConferenceDbContext Create();
    }
}

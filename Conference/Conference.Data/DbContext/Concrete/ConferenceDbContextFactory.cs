namespace Conference.Data.DbContext.Concrete
{
    public class ConferenceDbContextFactory : IConferenceDbContextFactory
    {
        public IConferenceDbContext Create()
        {
            return new ConferenceDbContext(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Conferences; Integrated Security=True;");
        }
    }
}

using Conference.Data.Entities;
using System;
using System.Data.Entity;

namespace Conference.Data.DbContext
{
    public interface IConferenceDbContext : IDisposable
    {
        IDbSet<Entities.Conference> Conferences { get; }
        IDbSet<Location> Locations { get; }
        IDbSet<User> Users { get; }

        /// <summary>
        /// Save all changes to the current db context.
        /// </summary>
        /// <returns>The number of affected rows.</returns>
        int SaveChanges();
    }
}

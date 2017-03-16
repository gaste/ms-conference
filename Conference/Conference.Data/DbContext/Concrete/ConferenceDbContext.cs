using System.Data.Entity;
using Conference.Data.Entities;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Conference.Data.DbContext.Concrete
{
    public class ConferenceDbContext : System.Data.Entity.DbContext, IConferenceDbContext
    {
        public ConferenceDbContext() { }

        public ConferenceDbContext(string contextNameOrConnectionString)
            : base(contextNameOrConnectionString)
        { }

        public IDbSet<Entities.Conference> Conferences => Set<Entities.Conference>();
        public IDbSet<Location> Locations => Set<Location>();
        public IDbSet<User> Users => Set<User>();

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var location = modelBuilder.Entity<Location>();
            location.HasKey(l => l.LocationId);
            location.Property(l => l.AddressStreet)
                    .IsRequired()
                    .HasMaxLength(128);
            location.Property(l => l.AddressNumber)
                    .IsRequired()
                    .HasMaxLength(64);
            location.Property(l => l.AddressPostCode)
                    .IsRequired()
                    .HasMaxLength(16);
            location.Property(l => l.AddressCity)
                    .IsRequired()
                    .HasMaxLength(128);
            location.Property(l => l.AddressCountry)
                    .IsRequired()
                    .HasMaxLength(128);
            location.Property(l => l.AddressCoordinatesLongitude)
                    .IsRequired()
                    .HasPrecision(9, 6);
            location.Property(l => l.AddressCoordinatesLatitude)
                    .IsRequired()
                    .HasPrecision(9, 6);
            location.Property(l => l.RoomName)
                    .IsRequired()
                    .HasMaxLength(128);
            location.Property(l => l.Floor)
                    .IsRequired();
            location.Property(l => l.SquareMetersOfAvailableSpace)
                    .IsRequired()
                    .HasPrecision(6, 2);
            location.Property(l => l.AmountOfAvailableSeats)
                    .IsRequired();
            location.Property(l => l.ExpensesPerDay)
                    .IsRequired()
                    .HasPrecision(9, 2);
            location.Property(l => l.CateringCostsPerSeat)
                    .IsRequired()
                    .HasPrecision(9, 2);

            var user = modelBuilder.Entity<User>();
            user.HasKey(u => u.Email);
            user.HasMany(u => u.HoldsConferences)
                .WithRequired(c => c.Lecturer);
            user.HasMany(u => u.EnrolledConferences)
                .WithMany(c => c.Attendees)
                .Map(m => m.ToTable("ConferenceAttendees"));
            user.Property(u => u.Name)
                .HasMaxLength(512)
                .IsRequired();
            user.Property(u => u.FirstName)
                .HasMaxLength(512);
            user.Property(u => u.Email)
                .HasMaxLength(256)
                .IsRequired();
            user.Property(u => u.HashedPassword)
                .HasMaxLength(342)
                .IsRequired();

            var conference = modelBuilder.Entity<Entities.Conference>();
            conference.HasKey(c => c.ConferenceId);
            conference.HasRequired(c => c.Location)
                      .WithMany();
            conference.HasMany(c => c.Attendees)
                      .WithMany()
                      .Map(m => m.ToTable("ConferenceAttendees"));
            conference.HasRequired(c => c.Lecturer)
                      .WithMany();
            conference.Property(c => c.Title)
                      .IsRequired()
                      .HasMaxLength(256)
                      .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                                           new IndexAnnotation(new IndexAttribute("UX_Conference_Title", 1) { IsUnique = true }));
            conference.Property(c => c.Abstract)
                      .IsRequired()
                      .HasMaxLength(4069);
            conference.Property(c => c.StartsAt)
                      .IsRequired();
            conference.Property(c => c.AmountOfLastingDays)
                      .IsRequired();
        }
    }
}

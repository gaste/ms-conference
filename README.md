# Conference System
A conference system for the MS Software Design and Architecture Bootcamp.

Hallo Welt!!!

## Architecture
Three-layered architecture:

* Presentation Layer
* Business Layer
* Data Access Layer

### Data Access Layer
The data access layer is a thin facade over Entity Framework.
The `IConferenceDbContext` provides the `IDbSet`s for accessing the entities, as well as the `SaveChanges` method.
Use the `IConferenceDbContextFactory` to create a new **disposable** `IConferenceDbContext` object:

```
// IConferenceDbContextFactory dbFactory passed e.g. per constructor
using (IConferenceDbContext db = dbFactory.Create())
{
    // query using linq
    User user = db.Users
                  .Where(u => u.Email == @"john@doe.com")
                  .FirstOrDefault();

    // add a new item
    User newUser = new User("Bar", "Foo", "foo@bar.com", "...");
    db.Users.Add(newUser);

    // save all pending changes
    db.SaveChanges();
}
```

* Any modifications to entities in scope of an `IConferenceDbContext` will be persisted when calling `SaveChanges()`.
* Any entities added or deleted to the `IDbSet`s will be persisted/removed when calling `SaveChanges()`.
* Not calling `SaveChanges()` and disposing the `IConferenceDbContext` results in no changes being persisted.
* Only use the entities in the scope of their `IConferenceDbContext`.

#### Update the database schema
To update the database schema or create the initial schema execute the following command from the Package Manager Console in Visual Studio:
```
Update-Database -ConnectionString "Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Conferences; Integrated Security=True;" -ConnectionProviderName "System.Data.SqlClient"
```
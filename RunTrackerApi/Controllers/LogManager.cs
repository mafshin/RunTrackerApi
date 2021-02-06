using RunTrackerApi.Repository;

namespace RunTrackerApi.Controllers
{
    public class LogManager
{
    public LogManager(IRepository repository)
    {
        this.RepositoryId = repository.Id;
    }

    public string RepositoryId {get; set;}
}
}
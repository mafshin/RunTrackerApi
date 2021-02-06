using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RunTrackerApi.Models;
using RunTrackerApi.Repository;

namespace RunTrackerApi.Controllers
{

    [ApiController]
[Route("[controller]")]
public partial class ActivityController : ControllerBase
{
    private  IRepository _repository;
    private LogManager _logManager;

    public ActivityController(IRepository repository, LogManager logManager)
    {
        _repository = repository;
        _logManager = logManager;
    }

    [HttpGet]
    public async Task<IEnumerable<ActivityRecord>> Get()
    {
        return _repository.GetAll();
    }

    [HttpGet("repid")]
    public async Task<string> GetRepositoryId()
    {
        return $"ControllerRepositoryId: {_repository.Id}, LogManagerReposityr: {_logManager.RepositoryId}";
    }

    [HttpGet("{id}")]

    public async Task<ActivityRecord> Get(int id)
    {
       return  _repository.GetActivity(id);
    }

    [HttpDelete("{id}")]
    public async Task<bool> Delete(int id)
    {
        return _repository.DeleteActvity(id);
    }

    [HttpPost]
    public async Task<ActivityRecord> Add(ActivityRecord record)
    {
       return  _repository.AddActivity(record);
    }

    [HttpPut("{id}")]
    public async Task<ActivityRecord> Update(int id, ActivityRecord newRecord)
    {
        return _repository.UpdateActivity(id, newRecord);
    }
}
}
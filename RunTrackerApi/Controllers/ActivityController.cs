using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public partial class ActivityController : ControllerBase
{
    private static DataManager dataManager;

    static ActivityController()
    {
        dataManager = new DataManager();
    }

    [HttpGet]
    public async Task<IEnumerable<ActivityRecord>> Get()
    {
        return dataManager.GetAll();
    }

    [HttpGet("{id}")]

    public async Task<ActivityRecord> Get(int id)
    {
       return  dataManager.GetActivity(id);
    }

    [HttpDelete("{id}")]
    public async Task<bool> Delete(int id)
    {
        return dataManager.DeleteActvity(id);
    }

    [HttpPost]
    public async Task<ActivityRecord> Add(ActivityRecord record)
    {
       return  dataManager.AddActivity(record);
    }

    [HttpPut("{id}")]
    public async Task<ActivityRecord> Update(int id, ActivityRecord newRecord)
    {
        return dataManager.UpdateActivity(id, newRecord);
    }
}
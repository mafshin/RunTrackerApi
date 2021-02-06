using System.Collections.Generic;
using RunTrackerApi.Models;

namespace RunTrackerApi.Repository
{
    public interface IRepository
    {
        string Id {get;}
        IEnumerable<ActivityRecord> GetAll();
        ActivityRecord AddActivity(ActivityRecord record);
        ActivityRecord GetActivity(int id);
        ActivityRecord UpdateActivity(int id, ActivityRecord newRecord);
        bool DeleteActvity(int id);
    }
}
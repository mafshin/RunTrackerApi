using System;
using System.Collections.Generic;
using RunTrackerApi.Models;

namespace RunTrackerApi.Repository
{
    public class SqlRepository : IRepository
    {
        public SqlRepository()
        {
        }

        public string Id {get;} = string.Empty;

        public ActivityRecord AddActivity(ActivityRecord record)
        {
            throw new NotImplementedException();
        }

        public bool DeleteActvity(int id)
        {
            throw new NotImplementedException();
        }

        public ActivityRecord GetActivity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ActivityRecord> GetAll()
        {
            throw new NotImplementedException();
        }

        public ActivityRecord UpdateActivity(int id, ActivityRecord newRecord)
        {
            throw new NotImplementedException();
        }
    }


}
using System;
using System.Collections.Generic;
using System.Linq;

public partial class ActivityController
{
    public class DataManager 
    {
        public List<ActivityRecord> list = new List<ActivityRecord>();
        public IEnumerable<ActivityRecord> GetAll()
        {
            return list;
        }
        public ActivityRecord AddActivity(ActivityRecord record)
        {
            int id = new Random().Next(1, 1000);

            record.Id = id;

            list.Add(record);

            return record;
        }

        public ActivityRecord GetActivity(int id)
        {
            return list.FirstOrDefault(x => x.Id == id);
        }

        public bool DeleteActvity(int id)
        {
            var record = list.FirstOrDefault(x => x.Id == id);

            list.Remove(record);

            return true;
        }

        public ActivityRecord UpdateActivity(int id, ActivityRecord newRecord)
        {
            var record = list.FirstOrDefault(x => x.Id == id);

            record.Date = newRecord.Date;

            return record;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.ApplicationServer.Dal
{
    public class TaskDao:ITaskDao
    {        
        public MilanaTestEntities DBContext { get; set; }

        public TaskDao(MilanaTestEntities milanaTestEntities)
        {
            DBContext = milanaTestEntities;
        }

        public int GetTasksNumber()
        {
            return DBContext.TblTasks != null ? DBContext.TblTasks.ToList().Count() : 0;
        }

        public void DeleteTask(int id)
        {
            var task = DBContext.TblTasks.SingleOrDefault(x => x.Id == id);
            DBContext.TblTasks.Remove(task);
            DBContext.SaveChanges();
            DBContext.Dispose();
        }

        public List<TblTask> GetTasks()
        {
            return DBContext.TblTasks != null ? DBContext.TblTasks.ToList() : new List<TblTask>();
        }
    }
}

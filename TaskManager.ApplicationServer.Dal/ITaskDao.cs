using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.ApplicationServer.Dal
{
    public interface ITaskDao
    {
        int GetTasksNumber();

        void DeleteTask(int id);

        List<TblTask> GetTasks();
    }
}

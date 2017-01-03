using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.ApplicationServer.Dal
{
    public class TaskDao:ITaskDao
    {
        public int GetTasksNumber()
        {
            return 8;
        }
    }
}

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TaskManager.ApplicationServer.Dal;
using TaskManager.ApplicationServer.Models;

namespace TaskManager.ApplicationServer.Controllers
{
    public class TaskController : ApiController
    {
        public ITaskDao TaskDao { get; set; }

        public TaskController(ITaskDao taskDao)
        {
            TaskDao = taskDao;
        }

        // GET: api/Task
        public IEnumerable<TaskModel> Get()
        {
            var list = TaskDao.GetTasks(); 
            List<TaskModel> personViews = Mapper.Map<List<TblTask>, List<TaskModel>>(list);

            //var tasks = new List<TaskModel>();
            //foreach(var task in list)
            //{
            //    tasks.Add(new TaskModel() { Id = task.Id, Description = task.Description, Created = task.Created, Name = task.Name });
            //}

            return personViews;
            //return new List<TaskModel> {
            //    new TaskModel{Created = DateTime.Now, Description = "Mock task 1", Id = 1, Name = "Task 1"},
            //    new TaskModel{Created = DateTime.Now, Description = "Mock task 2", Id = 2, Name = "Task 2"},
            //    new TaskModel{Created = DateTime.Now, Description = "Mock task 3", Id = 3, Name = "Task 3"},
            //    new TaskModel{Created = DateTime.Now, Description = "Mock task 4", Id = 4, Name = "Task 4"},
            //    new TaskModel{Created = DateTime.Now, Description = "Mock task 5", Id = 5, Name = "Task 5"},
            //    new TaskModel{Created = DateTime.Now, Description = "Mock task 6", Id = 6, Name = "Task 6"},
            //    new TaskModel{Created = DateTime.Now, Description = "Mock task 7", Id = 7, Name = "Task 7"},
            //    new TaskModel{Created = DateTime.Now, Description = "Mock task 8", Id = 8, Name = "Task 8"},
            //};
        }

        // GET: api/Task/5
        public TaskModel Get(int id)
        {
            return new TaskModel { Created = DateTime.Now, Description = "Mock task 1", Id = 1, Name = "Task 1" };
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("tasks/totaltasks")]
        public int GetTasksNumber()
        {
            return TaskDao.GetTasksNumber();
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("tasks/removetask")]
        [HttpPost]
        public void DeleteTask(TaskRequest task)
        {
            TaskDao.DeleteTask(task.task);
        }

        public class TaskRequest
        {
            public int task;
        }

        // POST: api/Task
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Task/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Task/5
        public void Delete(int id)
        {
        }
    }
}

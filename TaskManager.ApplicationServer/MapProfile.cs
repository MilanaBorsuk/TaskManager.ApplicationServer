using AutoMapper;
using TaskManager.ApplicationServer.Dal;
using TaskManager.ApplicationServer.Models;

namespace TaskManager.ApplicationServer
{
    internal class MapProfile : AutoMapper.Profile
    {
        protected override void Configure()
        {
            CreateMap<TblTask, TaskModel>();
            CreateMap<TaskModel, TblTask>();
        }       
    }
}
using AutoMapper;
using HIS.Dtos;
using HIS.IRepository;
using HIS.IService;
using HIS.Models;
using HIS.Repository;
using HIS.Service;
using HIS.Share;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace HIS.DependencyInjection
{
    public static class HisDependencyInjection
    {
        public static void AddRepository(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddSingleton<IPatientRepository, DemoRepository>();
        }

        public static void AddService(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddAutoMapper(config =>
            {
                config
                    .CreateMap<PatientDto, PatientModel>()
                    .AfterMap((dto, model) =>
                    {
                        model.Sex = dto.Sex.GetDescription();
                        model.Age = (int)Math.Ceiling((DateTime.Now - dto.BirthDay).TotalDays / 365);
                        model.BirthDay = dto.BirthDay.ToString("yyyy年MM月dd日");
                    });
            }, assemblies:new Assembly[0]);

            serviceDescriptors.AddSingleton<IAuthService, AuthService>();
            serviceDescriptors.AddSingleton<IPatientService, PatientService>();
        }
    }
}

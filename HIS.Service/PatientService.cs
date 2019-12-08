using AutoMapper;
using HIS.Dtos;
using HIS.IRepository;
using HIS.IService;
using HIS.Models;
using System;

namespace HIS.Service
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        private readonly Mapper _mapper;
        public PatientService(IPatientRepository patientRepository, Mapper mapper)
        {
            this._patientRepository = patientRepository;
            this._mapper = mapper;
        }
        public PatientModel GetPatient(string patientNO)
        {
            var patientDto = this._patientRepository.GetPatientInfoByNO(patientNO);
            return this._mapper.Map<PatientDto, PatientModel>(patientDto);
        }
    }
}

using HIS.IController;
using HIS.IService;
using HIS.Models;
using HIS.Service.Abstraction;
using HIS.WebService.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HIS.WebService.Controllers
{
    [ApiController]
    [Route("auth/[controller]")]
    public class PatientController : HisControllerBase, IPatientController
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService patientService)
        {
            this._patientService = patientService;
        }

        [ServiceFilter(typeof(HisAuthAttribute))]
        [HttpPost]
        [Route("GetPatient")]
        public PatientModel GetPatient(PatientModel patient)
        {
            return this._patientService.GetPatient(patient.PaientNO);
        }
    }
}

using BussinnesLayer.Concrete;
using Data.Attribute;
using Data.Repository;
using Data.Request;
using Data.Response;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace Api.Controllers
{
    public class PatientController : ApiController
    {
        PatientServices patientServices = new PatientServices();

        [HttpGet]
        public  PatientListResponse PatientList([FromBody] PatientRequest patientRequest)
        {
          return  patientServices.PatientList(patientRequest);

        }
        
     
    }
}

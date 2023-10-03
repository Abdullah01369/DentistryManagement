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
        PatientRepo patientRepo=new PatientRepo();

        [HttpGet]
        public PatientListResponse PatientList(string UserName,string Password)
        {
           
            PatientRequest request = new PatientRequest();
            request.Yetki=new Yetki();
            request.Yetki.Password = Password;
            request.Yetki.UserName = UserName;
            PatientListResponse response;
            try
            {
                if (request.Yetki.UserName == "admin" && request.Yetki.Password == "123")
                {
                    try
                    {
                        var veri = patientRepo.Listele();

                        var liste = veri.Select(x => new
                        {
                            x.Name,
                            x.Surname,
                            x.Sex,
                            x.Birthdate,
                            x.Mail,
                            x.Phone
                            
                        }).ToList()
                       .Select(x => new Patient()
                       {
                            Name = x.Name,
                            Birthdate = x.Birthdate,
                            Phone = x.Phone,
                            Mail = x.Phone ,
                            Sex = x.Sex
                       }).ToList();


                        
                        return response = new PatientListResponse()
                        {
                              Statu = new Status()
                            {
                                kod = (int)MessageCode.Codes.basarili,
                                mesaj = MessageCode.Codes.basarili.ToString()

                            },
                            Patient = liste


                        };

                    }
                    catch (Exception)
                    {

                        return response = new PatientListResponse()
                        {
                            Statu = new Status()
                            {
                                kod = (int)MessageCode.Codes.listeleme_hata,
                                mesaj = MessageCode.Codes.listeleme_hata.ToString()
                            }
                        };

                    }

                }

                else
                {
                    return response = new PatientListResponse()
                    {
                        Statu = new Status()
                        {
                            kod = (int)MessageCode.Codes.Yetki_Hata,
                            mesaj = MessageCode.Codes.Yetki_Hata.ToString()
                        }
                    };
                }




            }
            catch (Exception)
            {

                return response = new PatientListResponse()
                {
                    Statu = new Status()
                    {
                        kod = (int)MessageCode.Codes.Yetki_Hata,
                        mesaj = MessageCode.Codes.Yetki_Hata.ToString()
                    }
                };
            }

        }
    }
}

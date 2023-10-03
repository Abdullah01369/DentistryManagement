using Data.Attribute;
using Data.Dto;
using Data.Repository;
using Data.Request;
using Data.Response;
using EntityLayer.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinnesLayer.Concrete
{
    public class DoctorService
    {
        DoctorRepo doctorepo = new DoctorRepo();
        
        public DoctorListResponse doctorliste(RequestBase request)
        {
            DoctorListResponse doctorlistresponse = new DoctorListResponse();

            try
            {
                if (request.Yetki.UserName == "admin" && request.Yetki.Password == "123")
                {
                    try
                    {
                        var liste = doctorepo.DoctorList();
                        var list_ = liste.Select(x => new
                        {
                            DoctorName = x.Name,
                            DoctorSurname = x.Surname,
                            DoctorMail = x.Mail,
                            ClinicId = x.clinic.Id,
                            ClinicName = x.clinic.Name,
                            CityName = x.Address.city.Name
                        }).ToList().Select(x => new DoctorListDto()
                        {
                            Name = x.DoctorName,
                            Surname = x.DoctorSurname,
                            Mail = x.DoctorMail,

                            clinic = new ClinicDto()
                            {
                                Id = x.ClinicId,
                                Name = x.ClinicName,
                            },
                            CityName = x.CityName

                        }).ToList();

                        return doctorlistresponse = new DoctorListResponse()
                        {
                            statu = new Status()
                            {
                                kod = (int)MessageCode.Codes.basarili,
                                mesaj = MessageCode.Codes.basarili.ToString()

                            },
                             Doktorlist = list_


                        };

                    }
                    catch (Exception)
                    {

                        return doctorlistresponse = new DoctorListResponse()
                        {
                            statu = new Status()
                            {
                                kod = (int)MessageCode.Codes.basarisiz,
                                mesaj = MessageCode.Codes.listeleme_hata.ToString()

                            },



                        };
                    }

                }
                else
                {
                    return doctorlistresponse = new DoctorListResponse()
                    {
                        statu = new Status()
                        {
                            kod = (int)MessageCode.Codes.Yetki_Hata,
                            mesaj = MessageCode.Codes.Yetki_Hata.ToString()
                        }
                    };
                }
                
            }
            catch
            {
                return doctorlistresponse = new DoctorListResponse()
                {
                    statu = new Status()
                    {
                        kod = (int)MessageCode.Codes.basarisiz,
                        mesaj = MessageCode.Codes.basarisiz.ToString()

                    },
                  


                };
            }
        }


    }
}

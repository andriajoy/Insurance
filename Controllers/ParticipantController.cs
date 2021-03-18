using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceDBfirst.Controllers
{
    public class ParticipantController : Controller
    {
        // GET: Insurance
        public ActionResult AddParticipant()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddParticipant(Participant participant)
        {            
            InsuranceDBContext db = new InsuranceDBContext();
            db.USP_AddParticipants(participant.FirtsName, participant.LastName, participant.MiddleName, participant.DOB, participant.ParticipantTypeNo);
            db.SaveChanges();

            return View();
        }
        public ActionResult UpdateParticipants(Participant participant)
        {
            InsuranceDBContext db = new InsuranceDBContext();
            db.USP_UpdateParticipants(participant.ParticipantNo, participant.FirtsName, participant.LastName, participant.MiddleName, participant.DOB, participant.ParticipantTypeNo);
            db.SaveChanges();

            return View();
        }
        public ActionResult DeleteParticipants(int participantno)
        {
            InsuranceDBContext db = new InsuranceDBContext();
            db.USP_DeleteParticipants(participantno);
            db.SaveChanges();

            return View();
        }
    }
}
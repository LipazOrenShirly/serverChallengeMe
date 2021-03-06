﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using serverChallengeMe.Models;
using serverChallengeMe.Models.DAL;
using System.Web.Http.Cors;

namespace serverChallengeMe.Controllers
{
    [EnableCors("*", "*", "GET, POST, PUT, DELETE")]

    public class AlertController : ApiController
    {
        // GET api/Alert?teacherID_UnRead={teacherID}
        // מחזירה את כמות ההתראות שלא נקראו שיש למורה
        public int getUnReadAlertCount(int teacherID_UnRead)
        {
            Alert alert = new Alert();
            return alert.getUnReadAlertCount(teacherID_UnRead);
        }

        [HttpGet]
        [Route("api/Alert/getTeacherAlerts")]
        // מחזירה את כל ההתראות שיש למורה לפי ההגדרות שלו
        public DataTable getTeacherAlerts(int teacherID)
        {
            Alert alert = new Alert();
            return alert.getTeacherAlerts(teacherID);
        }

        [HttpGet]
        [Route("api/Alert/getTeacherAlertsSearch")]
        // מחזירה את כל ההתראות שיש למורה לפי ההגדרות שלו ולפי החיפוש שלו
        public DataTable getTeacherAlertsSearch(int teacherID, string studentName)
        {
            Alert alert = new Alert();
            return alert.getTeacherAlertsSearch(teacherID, studentName);
        }

        // GET api/<controller>
        public DataTable Get(int studentID)
        {
            Alert alert = new Alert();
            return alert.getNumOfAlertNotReadForStudents(studentID);
        }

        // POST api/Alert
        public int Post(Alert alert)
        {
            Alert a = new Alert();
            return a.postAlert(alert);
        }

        // מעדכן עבור המורה את ההתראה לנקראה
        // PUT api/Alert
        public int Put(int alertID)
        {
            Alert a = new Alert();
            return a.putAlertToRead(alertID);
        }

        // DELETE api/<controller>/5
        public int Delete(int alertID)
        {
            Alert alert = new Alert();
            return alert.deleteAlert(alertID);
        }
    }
}
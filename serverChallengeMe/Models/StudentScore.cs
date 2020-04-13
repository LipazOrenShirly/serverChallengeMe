﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using serverChallengeMe.Models.DAL;

namespace serverChallengeMe.Models
{
    public class StudentScore
    {
        public int StudentID { get; set; }
        public double Social { get; set; }
        public double School { get; set; }
        public double Emotional { get; set; }
        public StudentScore() { }
        public StudentScore(int studentID, double social, double school, double emotional)
        {
            StudentID = studentID;
            Social = social;
            School = school;
            Emotional = emotional;
        }
    }
}
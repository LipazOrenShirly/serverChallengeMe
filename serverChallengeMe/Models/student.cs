﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using serverChallengeMe.Models.DAL;


namespace serverChallengeMe.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int ClassID { get; set; }
        public int TeacherID { get; set; }
        public int AvatarID { get; set; }

        public Student() { }

        public Student(int studentID, string userName, string password, string firstName, string lastName, string phone, int classID, int teacherID, int avatarID)
        {
            StudentID = studentID;
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            ClassID = classID;
            TeacherID = teacherID;
            AvatarID = avatarID;
        }

        public DataTable getStudents(int classID)
        {
            DBservices dBservices = new DBservices();
            return dBservices.getStudents(classID);
            //מחזיר רשימה של כל התלמידים של כיתה
        }

        public DataTable getStudentById(int studentID)
        {
            DBservices dBservices = new DBservices();
            return dBservices.getStudentById(studentID);
        }

        public int getStudentByUserNameAndPassword(string userName, int password)
        {
            DBservices dBservices = new DBservices();
            return dBservices.getStudentByUserNameAndPassword(userName, password);
        }

        public int getStudentByPhone(string phone)
        {
            DBservices dBservices = new DBservices();
            return dBservices.getStudentByPhone(phone);
        }

        public int postStudent(Student student)
        {
            DBservices dbs = new DBservices();
            return dbs.postStudent(student);
        }

        public int putStudent(Student student)
        {
            DBservices dbs = new DBservices();
            return dbs.updateStudentDetails(student);
        }

        public int deleteStudent(int studentID)
        {
            DBservices dbs = new DBservices();
            return dbs.deleteStudent(studentID);
        }
    }
}
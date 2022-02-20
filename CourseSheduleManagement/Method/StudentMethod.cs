using CourseSheduleManagement.DataAccess;
using CourseSheduleManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace CourseSheduleManagement.Method
{
    public class StudentMethod
    {
        StudentDataAccess _studentDataAccess = new StudentDataAccess();

        public DataTable GetStudents()
        {
            DataTable dt = _studentDataAccess.GetStudents();
            return dt;
        }
        public Student GetStudentById(int studentId)
        {
            Student student = new Student();
            DataTable dt = _studentDataAccess.GetStudentById(studentId);
            if (dt.Rows.Count == 1)
            {
                student.StudentId =Convert.ToInt32(dt.Rows[0]["StudentId"].ToString());
                student.FirstName = dt.Rows[0]["FirstName"].ToString();
                student.LastName = dt.Rows[0]["LastName"].ToString();
                student.Line1 = dt.Rows[0]["Line1"].ToString();
                student.Line2 = dt.Rows[0]["Line2"].ToString();
                student.DoB = Convert.ToDateTime(dt.Rows[0]["DoB"].ToString());
                student.Sex = dt.Rows[0]["Sex"].ToString();
                student.NIC = dt.Rows[0]["NIC"].ToString();
                student.Email = dt.Rows[0]["Email"].ToString();
                student.MobileNumber =Convert.ToInt32(dt.Rows[0]["MobileNumber"].ToString());
                student.Telephone =Convert.ToInt32(dt.Rows[0]["Telephone"].ToString());
                student.CourseId =Convert.ToInt32(dt.Rows[0]["CourseId"].ToString());
                student.BatchId =Convert.ToInt32(dt.Rows[0]["BatchId"].ToString());
            }
            return student;
        }
        public void EditStudent(int studentId, string firstName, string lastName, string line1, string line2, DateTime dob, string sex, string nic, string email, int mobileNuber, int telephone, int courseId, int batchId)
        {
            _studentDataAccess.EditStudent(studentId,firstName,lastName,line1,line2,dob,sex,nic,email,mobileNuber,telephone,courseId,batchId);
        }

        public int AddStudent(string firstName, string lastName, string line1, string line2, DateTime dob, string sex, string nic, string email, int courseId, int batchId)
        {
            return _studentDataAccess.AddStudent(firstName, lastName, line1, line2, dob, sex, nic, email, courseId, batchId);
        }

        public void AddStudentMobile(int studentId,int mobileNumber)
        {
             _studentDataAccess.AddStudentMobile(studentId, mobileNumber);
        }

        public void DeleteStudent(int studentId)
        {
            _studentDataAccess.DeleteStudent(studentId);
        }

      
    }


}

using Exercises.Models;
using System;
using System.Collections.Generic;

namespace Exercises.Services
{
    public class StudentServices
    {
        public List<StudentModel> CreateStudentsFromFullNameList(List<string> stundentList)
        {
            List<StudentModel> returnedList = new List<StudentModel>();

            foreach (string student in stundentList)
            {
                string[] fullNameArray = student.Split(' ');
                int lastIndex = fullNameArray.Length - 1;
                string lastName = fullNameArray[lastIndex];

                StudentModel studentToAdd = new StudentModel
                {
                    FirstName = student.Replace(lastName, "").Trim(),
                    LastName = lastName
                };

                returnedList.Add(studentToAdd);
            }

            return returnedList;
        }

        public string GetStudentLastName(StudentModel student)
        {

            try
            {
                if (!student.FullName.Equals(""))
                {
                    string[] fullNameArray = student.FullName.Split(' ');
                    int lastIndex = fullNameArray.Length - 1;
                    return fullNameArray[lastIndex];
                }

                else throw new ArgumentException("No full name was set");
            }
            catch (Exception e)
            {
                throw new ArgumentException("No full name was set");
            }
           
        }

        public string GetStudentFirstName(StudentModel student)
        {
            if (student.LastName == null)
                student.LastName = GetStudentLastName(student);
            student.FirstName = student.FullName.Replace(student.LastName, "").Trim();

            return student.FirstName;
        }
    }
}

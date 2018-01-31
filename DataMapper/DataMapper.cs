using PFEProj.DataModel;
using PFEProj.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PFEProj.DataMapper
{
    public class DataMapper
    {


        public static StudentDTO MapToStudentDTO(Students student)
        {
            return new StudentDTO()
            {
                Id = student.StudentId,
                FirstName = student.StudentFirstname,
                Name = student.StudentName,
                Departement = student.StudentDepartement
            };
        }
    }
}
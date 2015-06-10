using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResetUserPassword.Model;

namespace ResetUserPassword.Model
{
    class Employee : User
    {
        private string academicType;
        private string faculty;
        private string academicDepartment;
        private string speciality;
        private bool isMemberInManagement;
        private string managingStruct;

        public string getAcademicType()
        {
            return this.academicType;
        }

        public void setAcademicType(string aType)
        {
            this.academicType = aType;
        }

        public string getFaculty()
        {
            return this.faculty;
        }

        public void setFaculty(string faculty)
        {
            this.faculty = faculty;
        }

        public string getAcademicDepartment()
        {
            return this.academicDepartment;
        }

        public void setAcademicDepartment(string academicDepartment)
        {
            this.academicDepartment = academicDepartment;
        }

        public string getSpeciality()
        {
            return this.speciality;
        }

        public void setSpeciality(string speciality)
        {
            this.speciality = speciality;
        }

        public bool getIsMemberInManagement()
        {
            return this.isMemberInManagement;
        }

        public void setIsMemberInManagement(bool isMemberInManagement) 
        {
            this.isMemberInManagement = isMemberInManagement;
        }

        public string getManagingStruct()
        {
            return this.managingStruct;
        }

        public void setManagingStruct(string managingStruct)
        {
            this.managingStruct = managingStruct;
        }

        public Employee()
        {
            base.setType(UserType.EMPLOYEE);
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace ResetUserPassword.Tests
{
    [TestFixture]
    class Tests
    {
        static Model.Admin a1 = new Model.Admin();
        Model.Employee u1 = new Model.Employee();

        [TestFixtureSetUp]
        public void init()
        {
            
            Model.Employee u2 = new Model.Employee();

            

            a1.setId(1000);
            a1.setUserName("admin_georgi");
            a1.setFirstName("Georgi");
            a1.setSecondName("Georgiev");
            a1.setLastName("Ivanov");
            a1.setPassword("aaaaaa");

            u1.setId(1001);
            u1.setUserName("ivan11");
            u1.setFirstName("Ivan");
            u1.setSecondName("Ivanov");
            u1.setLastName("Petrov");
            u1.setPassword("123456");
            u1.setFaculty("FKSU");
            u1.setAcademicDepartment("FCC");

            Data.Store.insertUser(a1);
            Data.Store.insertUser(u1);
        }

        [Test]
        public void getUserByUserNameTest()
        {
            Assert.IsNotNull(Data.Store.getUserByUserName("ivan11"));
        }

        [Test]
        public void resetPasswordTest()
        {
            a1.resetPassword(u1, "thisIsNewPassword");
            Assert.AreEqual("thisIsNewPassword", Data.Store.getUserByUserName("ivan11").getPassword());
        }

        [Test]
        public void resetPasswordTest2()
        {
            a1.resetPassword(u1, "123");
            Assert.AreNotEqual("123", Data.Store.getUserByUserName("ivan11").getPassword());
        }

        [Test]
        public void resetPasswordTest3()
        {
            Assert.False(a1.resetPassword(u1, "123"));
        }

        [Test]
        public void getUsersListByFirstAndLastNamesTest()
        {
            Assert.NotNull(a1.getUsersListByFirstAndLastNames("Ivan", "Petrov"));
        }
            
        [Test]  
        public void getAllUsersTest()
        {
            Assert.NotNull(a1.getAllUsers());
        }


    }
}

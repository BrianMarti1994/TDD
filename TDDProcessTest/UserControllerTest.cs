using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDprocess.Controllers;


namespace TDDProcessTest
{
    [TestClass]
    public class UserControllerTest
    {

     

        [TestMethod]
        public void TestGetUser()
        {
            Boolean res = false;
            var UserController = new UserController();

            List<string> lstUsers = UserController.getUser();

            if (lstUsers.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            Assert.IsTrue(res);

        }

    }
}

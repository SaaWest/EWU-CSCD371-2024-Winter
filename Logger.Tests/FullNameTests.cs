using DocuSign.eSign.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Xunit;

namespace Logger.Tests
{
    class FullNameTests
    {
        [TestClass]
        public class FullName_Record_Tests()
        {
            [TestMethod]
            [DataRow("Mike", "Rowe", "Soft")]
            //[DataRow("Michael", "J", "Jordon")]
            public void FullName_Record_Test(string "firstName", string? "middleName", string "lastName")
            {
                FullName fullName = new() { FirstName = firstName, MiddleName = middleName, LastName = lastName };
                Assert.AreEqual(new {fullName.FirstName, fullname.MiddleName, fullname.lastName });

            }
        }

    }
}

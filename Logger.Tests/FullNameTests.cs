//using DocuSign.eSign.Model;
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
            //[DataRow("Michael", "B", "Jordon")]
            public void FullName_Record_NotNull(string firstName, string middleName, string lastName)
            {
                FullName fullName = new FullName(firstName, middleName, lastName);
              
                Assert.Equals(fullName.FirstName, firstName);
                Assert.Equals(fullName.MiddleName, middleName);
                Assert.Equals(fullName.FirstName, lastName);


            }
            [TestMethod]
            [DataRow("Micheal", null, "Jordon")]
            public void FullName_Record_WithNull(string firstName, string middleName, string lastName)
            {
                FullName fullName = new FullName(firstName, middleName, lastName);

                Assert.Equals(fullName.FirstName, firstName);
                Assert.Equals(fullName.MiddleName, middleName);
                Assert.Equals(fullName.FirstName, lastName);

            }
        }

    }
}

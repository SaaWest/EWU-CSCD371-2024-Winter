//using DocuSign.eSign.Model;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Logger.Tests;

public class FullNameTests
{
    //[TestClass]
    public class FullName_Record_Tests()
    {
        [Fact]
        //[DataRow("Mike", "Rowe", "Soft")]
        //[DataRow("Michael", "B", "Jordon")]
        public void FullName_Record_NotNull()
        {
            string firstName = "Mike";
            string middleName = "Rowe";
            string lastName = "Soft";
            FullName fullName = new(firstName, lastName, middleName);

            Assert.Equal("Mike Rowe Soft", fullName.Name);
            //Assert.Equal(middleName, fullName.MiddleName);
            //Assert.Equal(lastName, fullName.LastName);


        }

        [Fact]
        //[DataRow("Micheal", null, "Jordon")]
        public void FullName_Record_WithNullMiddleName()
        {
            string firstName = "Michael";
            string middleName = null!;
            string lastName = "Jordon";

            FullName fullName = new(firstName, lastName, middleName);

            Assert.Equal("Michael Jordon", fullName.Name);
            //Assert.Equal(fullName.MiddleName, middleName);
            //Assert.Equal(fullName.FirstName, lastName);

        }
        [Fact]
        public void FullName_MissingLastName_IsNull()
        {
            string firstName = "Steven";
            Assert.Throws<ArgumentNullException>(() => new FullName(firstName, null!));



        }
        [Fact]
        public void FullName_MissingFirstName_IsNull()
        {
            string lastName = "Smith";
            Assert.Throws<ArgumentNullException>(() => new FullName(null!, lastName));

        }
    }

}

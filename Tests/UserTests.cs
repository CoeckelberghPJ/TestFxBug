using Domain;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class UserTests
    {
        [DataTestMethod]
        [DynamicData(nameof(GetParseUserDatas), DynamicDataSourceType.Method)]
        public void ParseUserDatasTest(User user, string lastName, string firstName)
        {
            //Assert
            user.FirstName.Should().Be(firstName);
            user.LastName.Should().Be(lastName);
        }

        public static IEnumerable<object[]> GetParseUserDatas()
        {
            yield return new object[] {
                User.Create("Doe", "John"),
                "Doe",
                "John"
            };
            yield return new object[] {
                new User("Doe", "Jane"),
                "Doe",
                "Jane "
            };
        }
    }
}

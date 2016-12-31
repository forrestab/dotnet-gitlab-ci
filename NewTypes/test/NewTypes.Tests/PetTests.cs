using NewTypes.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace NewTypes.Tests
{
    public class PetTests
    {
        [Fact]
        public void DogTalkToOwnerTest()
        {
            string expected = "Woof!";
            string actual = new Dog().TalkToOwner();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CatTalkToOwner()
        {
            string expected = "Meow!";
            string actual = new Cat().TalkToOwner();

            Assert.Equal(expected, actual);
        }
    }
}

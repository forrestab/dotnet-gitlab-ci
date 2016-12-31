using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTypes.Pets
{
    public class Dog : IPet
    {
        public string TalkToOwner() => "Woof!";
    }
}

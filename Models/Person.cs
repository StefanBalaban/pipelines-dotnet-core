using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pipelines_dotnet_core.Models
{
    public class Person
    {
        public string Name { get; set; }

        public string IntroduceTo(string name)
        {
            return $"Hi {name}, I'm {Name}";
        }
    }
}

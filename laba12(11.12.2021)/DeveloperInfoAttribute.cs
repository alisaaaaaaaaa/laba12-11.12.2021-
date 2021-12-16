using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12_11._12._2021_
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class DeveloperInfoAttribute:Attribute
    {
        public DeveloperInfoAttribute(string developer)
        {
            this.Developer = developer;
        }
        public DeveloperInfoAttribute(string developer, string date) : this(developer)
        {
            Date = date;
        }
        public string Date { get; set; }
        public string Developer { get; private set; }

    }
}

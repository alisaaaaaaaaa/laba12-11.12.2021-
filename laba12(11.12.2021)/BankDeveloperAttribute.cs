using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12_11._12._2021_
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class BankDeveloperAttribute : Attribute
    {
        public string Developer { get; set; }
        public string Company { get; set; }
        public BankDeveloperAttribute(string developer)
        {
            this.Developer = developer;
        }
        public BankDeveloperAttribute(string developer, string company) : this(developer)
        {
            this.Company = company;

        }
    }
}

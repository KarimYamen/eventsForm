using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventsFormsProject
{
    internal class UserClass
    {
        private string name;
        public UserClass(string u)
        {
            name = u;
        }
        public string Name { get { return name; } }
    }
}

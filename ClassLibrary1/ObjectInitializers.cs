using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class ObjectInitializers
    {
        public DateTime Birthday { get; set; }
        public string Name { get; set; }
        public int Age
        {
            get
            {
                var birthday = DateTime.Now - Birthday;
                return birthday.Days / 365;
            }
        }

        public ObjectInitializers(DateTime birthday)
        {
            Birthday = birthday;
        }
    }
}

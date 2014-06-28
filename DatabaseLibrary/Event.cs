using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLibrary
{
    public class Event
    {
        public String Owner { get; set; }
        public Int32 Id { get; set; }
        public String Desc { get; set; }
        public String LocX { get; set; }
        public String LocY { get; set; }
        public DateTime Date { get; set; }
        public Boolean IsActive { get; set; }
    }
}

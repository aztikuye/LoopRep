using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    public class Shape
    {
        public string Name { get; set; }
        public virtual string Draw()
        {
            return "you are drawing" + Name;
        }

    }
}

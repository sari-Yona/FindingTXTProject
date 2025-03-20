using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT
{
    public class ToraLocation:TanachLocation
    {
        public string Parasha { get; set; }
        public override string ToString()
        {
            return base.ToString()+ ": פרשה "+this.Parasha;
        }
    }
}

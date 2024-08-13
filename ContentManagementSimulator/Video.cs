using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManagementSimulator
{
    public class Video : Content, ITimed
    {
        public int Duration { get; set; }
    }
}

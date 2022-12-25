using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUniti.SystemExtend
{
    public class FRanDom
        : Random
    {
        public FRanDom()
            :base(new Guid().GetHashCode())
        {

        }
    }
}

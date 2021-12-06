using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___Generic_Class___Lukas_Rose_SUT21
{
    public class Check<T>
    {
        public virtual bool ToCheck(T a, T b)
        {
            return (a.Equals(b));
        }
    }
}

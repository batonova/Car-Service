using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OF5KAE
{
    public interface IParser<T>
    {
        T Parse(String[] columns);
    }

    public class WorkParser : IParser<Work>
    {
       public Work Parse(String[] columns)
       {
            var time = Convert.ToUInt16(columns[1]);
            var cost = Convert.ToUInt16(columns[2]);

            return new Work(columns[0], time, cost);
       }
    }
}

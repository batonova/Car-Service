using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OF5KAE
{
    public class Loader<T>
    {
        public static List<T> LoadFile(string filePath, IParser<T> parser)
        {
            var list = new List<T>();
            var enumLines = File.ReadLines(filePath, Encoding.UTF8);

            foreach (var line in enumLines)
            {
                var columns = line.Split(';');
                list.Add(parser.Parse(columns));
            }

            return list;
        }
    }
}

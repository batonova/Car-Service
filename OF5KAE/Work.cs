using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OF5KAE
{
    public class Work
    {
        public string Name         { get; }
        public uint   Time         { get; }
        public uint   MaterialCost { get; }

        public Work(string name, uint time, uint materialCost)
        {
            Name = name;
            Time = time;
            MaterialCost = materialCost;
        }

        public uint GetTimeHours()
        {
            return Time / 60;
        }

        public uint GetTimeMinutes()
        {
            return Time - 60 * (Time / 60);
        }

        public uint GetTimeCost()
        {
            return Time * 15000 / 60;
        }
    }
}

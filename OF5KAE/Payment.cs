using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OF5KAE
{
    public class Payment
    {
        public uint WorksheetNumber { get; set; }
        public uint WorksNumber { get; set; }
        public uint MaterialCost { get; set; }
        public uint ServiceCost { get; set; }
        public uint ServiceTime { get; set; }
        public uint TotalCost { get; set; }

        public Payment(uint worksNumber, uint materialCost, uint serviceCost, uint serviceTime)
        {
            WorksheetNumber = 1;
            WorksNumber = worksNumber;
            MaterialCost = materialCost;
            ServiceCost = serviceCost;
            ServiceTime = serviceTime;
            TotalCost = ServiceCost + MaterialCost;
        }

        public Payment(uint worksheetNumber, uint worksNumber, uint materialCost, uint serviceCost, uint serviceTime)
        {
            WorksheetNumber = worksheetNumber;
            WorksNumber = worksNumber;
            MaterialCost = materialCost;
            ServiceCost = serviceCost;
            ServiceTime = serviceTime;
            TotalCost = ServiceCost + MaterialCost;
        }

        public Payment()
        {
            WorksheetNumber = 0;
            WorksNumber = 0;
            MaterialCost = 0;
            ServiceCost = 0;
            ServiceTime = 0;
            TotalCost = 0;
        }

        public static Payment operator +(Payment p1, Payment p2)
        {
            return new Payment
            (
                p1.WorksheetNumber + p2.WorksheetNumber,
                p1.WorksNumber + p2.WorksNumber,
                p1.MaterialCost + p2.MaterialCost,
                p1.ServiceCost + p2.ServiceCost,
                p1.ServiceTime + p2.ServiceTime
            );
        }
    }
}
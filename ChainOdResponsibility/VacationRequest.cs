using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOdResponsibility
{
    public class VacationRequest
    {
        public Employee? employee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int GetTotalDays()
        {
            return (EndDate - StartDate).Days;
        }
    }
}

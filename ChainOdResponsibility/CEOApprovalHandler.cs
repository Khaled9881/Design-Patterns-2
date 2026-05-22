using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOdResponsibility
{
    public class CEOApprovalHandler : ApprovalHandler
    {
        public override void Process(VacationRequest vacationRequest)
        {
            if (vacationRequest?.employee?.JobTitle == JobTitle.CTO)
            {
                Console.WriteLine("CEO has approve ur vacation");
            }
            else
                Console.WriteLine();
        }
    }
}

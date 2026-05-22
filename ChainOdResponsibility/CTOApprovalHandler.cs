using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOdResponsibility
{
    public class CTOApprovalHandler : ApprovalHandler
    {
        public override void Process(VacationRequest vacationRequest)
        {
            if (vacationRequest?.employee?.JobTitle == JobTitle.TechnicalManager)
            {
                Console.WriteLine("CTO has approve ur vacation");
            }
            else
                CallNext(vacationRequest);
        }
    }
}

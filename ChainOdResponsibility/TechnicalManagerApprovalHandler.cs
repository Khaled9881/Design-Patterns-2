using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOdResponsibility
{
    public class TechnicalManagerApprovalHandler : ApprovalHandler
    {
        public override void Process(VacationRequest vacationRequest)
        {
            if (vacationRequest?.employee?.JobTitle == JobTitle.TeamLeader ||
               (vacationRequest?.employee?.JobTitle == JobTitle.Developer && vacationRequest.GetTotalDays() > 3))
            {
                Console.WriteLine("Technical Manager has approve ur vacation");
            }
            else
                CallNext(vacationRequest);
        }
    }
}

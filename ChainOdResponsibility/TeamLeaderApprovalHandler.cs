using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOdResponsibility
{
    public class TeamLeaderApprovalHandler : ApprovalHandler
    {
        public override void Process(VacationRequest vacationRequest)
        {
            if (vacationRequest?.employee?.JobTitle == JobTitle.Developer &&
                vacationRequest.GetTotalDays() <= 3)
            {
                Console.WriteLine("Team Leader has approve ur vacation");
            }
            else
                CallNext(vacationRequest);
        }
    }
}

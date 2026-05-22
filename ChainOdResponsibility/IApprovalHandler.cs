using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOdResponsibility
{
    public interface IApprovalHandler
    {
        public void Process(VacationRequest vacationRequest);
        public void SetNextHandler(IApprovalHandler next);
    }
}

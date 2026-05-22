using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOdResponsibility
{
    public abstract class ApprovalHandler : IApprovalHandler
    {
        private IApprovalHandler _next;

        public abstract void Process(VacationRequest vacationRequest);

        public void SetNextHandler(IApprovalHandler next)
        {
            _next = next;
        }

        protected void CallNext(VacationRequest vacationRequest)
        {
            if (_next != null)
                _next.Process(vacationRequest);
        }


    }
}

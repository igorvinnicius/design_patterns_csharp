using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.ChainOfResponsibility.Handlers
{
    public interface  IExpenseHandler
    {
		void SetNext(IExpenseHandler next);
		ApprovalResponse Approve(IExpenseReport expenseReport);

    }
}

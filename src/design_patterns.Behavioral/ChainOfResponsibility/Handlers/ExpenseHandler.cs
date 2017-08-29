using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.ChainOfResponsibility.Handlers
{
	public class ExpenseHandler : IExpenseHandler
	{
		private IExpenseHandler _next;
		private readonly IExpenseApprover _approver;


		public ExpenseHandler(IExpenseApprover expenseApprover)
		{
			_approver = expenseApprover;
			_next = EndOfChainExpenseHandler.Instance;
		}

		public ApprovalResponse Approve(IExpenseReport expenseReport)
		{
			var response = _approver.ApproveExpense(expenseReport);

			if (response == ApprovalResponse.BeyondApprovalLimit)
			{
				return _next.Approve(expenseReport);
			}

			return response;
		}

		public void SetNext(IExpenseHandler next)
		{
			_next = next;
		}
	}
}

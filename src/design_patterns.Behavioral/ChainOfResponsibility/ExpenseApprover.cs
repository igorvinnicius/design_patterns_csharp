using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.ChainOfResponsibility
{
	public class ExpenseApprover : IExpenseApprover
	{
		public Employee Employee { get; private set; }

		public ExpenseApprover(Employee employee)
		{
			Employee = employee;
		}

		public ApprovalResponse ApproveExpense(IExpenseReport expenseReport)
		{
			if (Employee.ApprovalLimit < expenseReport.ExpenseAmount)
			{
				return ApprovalResponse.BeyondApprovalLimit;
			}

			return ApprovalResponse.Approved;
		}
	}
}

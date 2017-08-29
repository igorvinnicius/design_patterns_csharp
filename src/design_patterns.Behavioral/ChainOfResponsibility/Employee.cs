using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.ChainOfResponsibility
{
    public class Employee : IExpenseApprover
    {
		public string Name { get; set; }

		public decimal ApprovalLimit { get; set; }

		public Employee(string name, decimal approvalLimit)
		{
			Name = name;
			ApprovalLimit = approvalLimit;
		}

		public ApprovalResponse ApproveExpense(IExpenseReport expenseReport)
		{
			if (ApprovalLimit < expenseReport.ExpenseAmount)
			{
				return ApprovalResponse.BeyondApprovalLimit;
			}

			return ApprovalResponse.Approved;
		}
	}
}

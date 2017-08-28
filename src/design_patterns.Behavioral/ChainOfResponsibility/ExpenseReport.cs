using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.ChainOfResponsibility
{
	public class ExpenseReport : IExpenseReport
	{
		public decimal ExpenseAmount { get ; set; }

		public ExpenseReport(decimal expenseAmount)
		{
			ExpenseAmount = expenseAmount;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.ChainOfResponsibility.Handlers
{
	public class EndOfChainExpenseHandler : IExpenseHandler
	{
		private static readonly EndOfChainExpenseHandler _instance = new EndOfChainExpenseHandler();

		private EndOfChainExpenseHandler() { }

		public static EndOfChainExpenseHandler Instance
		{
			get { return _instance; }
		}


		public ApprovalResponse Approve(IExpenseReport expenseReport)
		{
			return ApprovalResponse.Denied;
		}

		public void SetNext(IExpenseHandler next)
		{
			throw new InvalidOperationException("End of chain!");
		}
	}
}

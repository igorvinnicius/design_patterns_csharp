using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.ChainOfResponsibility
{
    public interface IExpenseReport
    {
		decimal ExpenseAmount { get; set; }
    }
}

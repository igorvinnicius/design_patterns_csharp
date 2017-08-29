using design_patterns.Behavioral.ChainOfResponsibility;
using design_patterns.Behavioral.ChainOfResponsibility.Handlers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace design_patterns.Behavioral.Tests
{
    public class ChainOfResponsibilityTests
    {
		[Fact]
		public void Should_Approve_An_Expense()
		{
			//Arrange
			ExpenseHandler gwen = new ExpenseHandler(new Employee("Gwen Stacy", 45000));
			ExpenseHandler harry = new ExpenseHandler(new Employee("Harry Osborn", 50000));
			ExpenseHandler norman = new ExpenseHandler(new Employee("Norman Osborn", 8000000));
						
			gwen.SetNext(harry);
			harry.SetNext(norman);

			var expenseAmount = 48000;

			IExpenseReport expenseReport = new ExpenseReport(expenseAmount);

			//Act
			var response = gwen.Approve(expenseReport);

			//Assert
			Assert.Equal(ApprovalResponse.Approved, response);

		}

		[Fact]
		public void Should_Deny_An_Expense()
		{
			//Arrange
			ExpenseHandler gwen = new ExpenseHandler(new Employee("Gwen Stacy", 45000));
			ExpenseHandler harry = new ExpenseHandler(new Employee("Harry Osborn", 50000));
			ExpenseHandler norman = new ExpenseHandler(new Employee("Norman Osborn", 8000000));

			gwen.SetNext(harry);
			harry.SetNext(norman);

			var expenseAmount = 9000000;

			IExpenseReport expenseReport = new ExpenseReport(expenseAmount);

			//Act
			var response = harry.Approve(expenseReport);

			//Assert
			Assert.Equal(ApprovalResponse.Denied, response);

		}

	}
}

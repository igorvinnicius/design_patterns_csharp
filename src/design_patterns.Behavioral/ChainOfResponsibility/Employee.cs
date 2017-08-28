using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Behavioral.ChainOfResponsibility
{
    public class Employee
    {
		public string Name { get; set; }

		public decimal ApprovalLimit { get; set; }

		public Employee(string name, decimal approvalLimit)
		{
			Name = name;
			ApprovalLimit = approvalLimit;
		}

	}
}

// See https://aka.ms/new-console-template for more information
using Day5_Assignment;

ExpenseAnalyzer expenseAnalyzer = new ExpenseAnalyzer();
Console.WriteLine("Your account balace : ");
expenseAnalyzer.Balance();
Console.WriteLine("Net balance in each month : ");
expenseAnalyzer.NetBalance();


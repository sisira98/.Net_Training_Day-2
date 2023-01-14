
namespace Day5_Assignment;

public class ExpenseAnalyzer
{

    private readonly List<Statement> _statement = new List<Statement>();
    public ExpenseAnalyzer()
    {
        DateTime date;
        double money;
        string category;
        var logFile = File.ReadAllLines("C:\\Users\\EDSTEM\\source\\Day2\\Day5-Assignment\\TextFile1.txt");
        List<string> logList = new List<string>(logFile);
        foreach (string item in logList)
        {
            string[] list = item.Split(",");

            _statement.Add(new Statement(DateTime.Parse(list[0]), double.Parse(list[1]), list[2]));


        }
        
    }
    public void Balance()
    {
        double totalBalance = 0.0;
        foreach (Statement statement in _statement)
        {
            totalBalance += statement.expense;
        }
        Console.WriteLine(totalBalance);
    }
    public void NetBalance()
    {
        double totalNetBalance = 0.0;
        List<Statement> _statementOfMonth = new List<Statement>();
        for (int i = 0; i < 12; i++)
        {
            foreach (Statement item in _statement)
            {
                if (item.date.Month == i)
                {
                    totalNetBalance += item.expense;
                }
            }
            if (totalNetBalance != 0.0)
            {
                Console.WriteLine($"Net balance of month {i} = {totalNetBalance}");
            }
            totalNetBalance = 0.0;
        }
    }





}


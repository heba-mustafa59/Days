
using System.Security.Cryptography.X509Certificates;
using day5;
using Delegates;
public delegate bool Elligable(Employee employee);
public delegate bool Elligable1(Employee employee, int x);
public delegate double Calculate(float employee, decimal x);
 
// Predicate putput: bool , input: one input 
// Func output: one output, input: from 1 to 16
// Action output: void , input: from one to 16
public class Program
{
    public static void Main(string[] args)
    {

        List<Employee> employees =
        [
            new(){DepId=100,Name="emp1",Salary=1000,Address="Ramallah"},
            new(){DepId=200,Name="emp2",Salary=2000,Address="Nablus"},
            new(){DepId=300,Name="emp3",Salary=3000,Address="Salfit"},
            new(){DepId=400,Name="emp4",Salary=4000,Address="Ramallah"},
            new(){DepId=500,Name="emp5",Salary=5000,Address="Jerico"},
        ];
        #region After Delegate
        // Elligable elligable = new Elligable(checkaddress);
        Elligable elligable = checksalary;
        //Console.WriteLine(elligable(new() { DepId = 100, Name = "emp1", Salary = 1000, Address = "Ramallah" }));
        #endregion

        #region shorter
        Elligable elligable2 = (Employee emp) => { return emp.Salary < 4000; };
        Predicate<Employee> elligable3 = emp1 => emp1.Address == "Salfit" && emp1.Salary < 5000;

        #endregion
        var target = getfilterdemployees(employees, elligable3);
        foreach (Employee employee in target)
        {
            Console.WriteLine(employee);
        }
      //  Calculate mycalc = Getvalue;
        Func<float ,decimal,double> mycalc = Getvalue;
        Func<Employee ,int,double> cc = Getemp;  
    }
    // public static List<Employee> getfilterdemployeesbyaddress(List<Employee> employees)
    // {
    //     List<Employee> result = new List<Employee>();
    //     for (int i = 0; i < employees.Count; i++)
    //     {
    //         if (employees[i].Address =="Salfit")
    //             result.Add(employees[i]);
    //     }
    //     return result;
    // }
    public static double Getvalue(float c, decimal x)
    {
        return (double)(c + (float)x);
    }
     public static double Getemp(Employee c, int x)
    {
        return (double)x;
    }
    public static List<Employee> getfilterdemployees(List<Employee> employees, Predicate<Employee> iselligable)
    {
        List<Employee> result = new List<Employee>();
        for (int i = 0; i < employees.Count; i++)
        {
            if (iselligable(employees[i]))
                result.Add(employees[i]);
        }
        return result;
    }
    public static bool checksalary(Employee emp)
    {
        return emp.Salary < 4000;
    }
    // public static bool checkaddress(Employee emp)
    // {
    //     return emp.Address == "Salfit";
    // }
    // System.Console.WriteLine(GetFirst<String>("s1", "s2"));
    // System.Console.WriteLine(GetFirst<int>(1, 2));
    // ShoppingCart<string> sc = new ShoppingCart<string>();
    // sc.addItem("3");
    // ShoppingCart<int> sc1 = new ShoppingCart<int>();

    // sc1.addItem(5);
    // sc.Displayitem();

    // var x = 5;
    // ShoppingCart<int> sc2 = new();
    // List<int> list = new();

    // var x2 = 5;
    // var sc3 = new ShoppingCart<int>();
    // var list2 = new List<int>();

    // public static int GetFirst(int x, int y)
    // {
    //     return x;
    // }
    // //overload
    // public static string GetFirst(string x, string y)
    // {
    //     return x;
    // }

}
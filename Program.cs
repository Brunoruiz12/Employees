using System.Globalization;

Console.WriteLine("How many employees will be registered ?: ");
int n = int.Parse(Console.ReadLine());

List<Employees> list = new List<Employees>();

for (int i = 0; i <= n; i++)
{
    Console.WriteLine("Emplyoee #" + i + ":");
    Console.Write("id:");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Name:");
    string name = Console.ReadLine();
    Console.Write("Salario:");
    double salario = double.Parse(Console.ReadLine());
    list.Add(new Employees(id, name, salario));
    Console.WriteLine();
}

Console.WriteLine("Enter the employee id that will have salary increase");
int searchId = int.Parse(Console.ReadLine());

Employees emp = list.Find(x => x.Id == searchId);
if(emp != null)
{
    Console.Write("Enter the percentage:");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emp.AumentoSalrio(percentage);
}
else
{
    Console.Write("This id does not exist!");

}
Console.WriteLine();
Console.WriteLine("update list of employees:");
foreach(Employees obj in list)
{
    Console.WriteLine(obj);
}



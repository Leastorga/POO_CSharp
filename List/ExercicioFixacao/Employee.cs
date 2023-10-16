using System.Globalization;

namespace ExercicioFixacao
{
    class Employee
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public double Salary { set; private get; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += (Salary * percentage) / 100.00;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
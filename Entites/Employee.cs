using System.Globalization;
using System;
namespace ExerComparaveis.Entites
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvString)
        {
            string[] vet = csvString.Split(',');
            Name = vet[0];
            Salary = double.Parse(vet[1], CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee.");
            }
            Employee other = obj as Employee; //casting de obj para Employee
            //Pode-se comparar qualquer atributo da classe.
            return Salary.CompareTo(other.Salary);
        }
    }
}

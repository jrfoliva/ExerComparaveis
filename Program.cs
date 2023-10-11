using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using ExerComparaveis.Entites;

namespace ExerComparaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler arquivo, ordenar e exibir a lista ordenada
            string path = @"c:\temp\in.txt";
            /*
            try
            {
                List<string> list = new List<string>();
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                }
                list.Sort();
                foreach (string s in list)
                {
                    Console.WriteLine(s);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
            */

            // Outro problema, ler um arquivo contendo funcionários(nome e salário) no formato .csv
            // Depois ordenar a lista por nome e mostrar o resultado na tela.

            try
            {
                List<Employee> list = new List<Employee>();
                using (StreamReader sr = File.OpenText(path)) 
                {
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                }
                list.Sort(); //Falha ao comparar dois elementos no array
                             //sendo necessário implementar IComparable na classe Employee
                foreach (Employee emp in list)
                {
                    Console.WriteLine(emp);
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
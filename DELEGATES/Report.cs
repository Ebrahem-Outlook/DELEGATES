using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATES
{
    public class Report
    {
        public static void ProssesImployeeSalsee50000(Employee[] employees)
        {
            Console.WriteLine("Employees with 50000 Totalsales::");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var employee in employees)
            {
                if(employee.TotalSales >= 50000)
                {
                    Console.WriteLine($"Id::{employee.Id} , Name::{employee.Name} , TotalSales::{employee.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }

        public static void ProssesImployeeSalsee40000(Employee[] employees)
        {
            Console.WriteLine("Employees with 40000 Totalsales::");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var employee in employees)
            {
                if (employee.TotalSales >= 40000)
                {
                    Console.WriteLine($"Id::{employee.Id} , Name::{employee.Name} , TotalSales::{employee.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }

        public static void ProssesImployeeSalsee30000(Employee[] employees)
        {
            Console.WriteLine("Employees with 30000 Totalsales::");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var employee in employees)
            {
                if (employee.TotalSales >= 30000)
                {
                    Console.WriteLine($"Id::{employee.Id} , Name::{employee.Name} , TotalSales::{employee.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }

        public static void ProssesImployeeSalsee20000(Employee[] employees)
        {
            Console.WriteLine("Employees with 20000 Totalsales::");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var employee in employees)
            {
                if (employee.TotalSales >= 20000)
                {
                    Console.WriteLine($"Id::{employee.Id} , Name::{employee.Name} , TotalSales::{employee.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }

        public static void ProssesImployeeSalsee10000(Employee[] employees)
        {
            Console.WriteLine("Employees with 20000 Totalsales::");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var employee in employees)
            {
                if (employee.TotalSales >= 10000)
                {
                    Console.WriteLine($"Id::{employee.Id} , Name::{employee.Name} , TotalSales::{employee.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}

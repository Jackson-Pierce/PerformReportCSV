using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using PerformReportCSV.Controllers;
using PerformReportCSV.Models;

namespace PerformReportCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformanceReports.Setup();
            string directory = @"C:\Users\hmw\Documents\J.Pierce\JPStarterDesktop\kwreports";
            //PerformanceReports.ImportUnimportedFiles(directory);
            PerformanceReports.ImportUnimportedFiles(directory);           
            // PerformanceReports.Setup();
            //PerformanceReports.ImportUnimportedFiles(@"C:\Users\hmw\Documents\J.Pierce\JPStarterDesktop\kwreports");

        }

        static void Practice031016v1()
        {
            //notes:...
            Console.WriteLine("test");

        }
    }
}


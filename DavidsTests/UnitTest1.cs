using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using PerformReportCSV.Controllers;
using PerformReportCSV.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DavidsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PerformanceReports.Setup();
            using (var db = new LINQtoSQLDataContext())
            {
                Assert.IsTrue(
                    db.KWPerformanceReports.
                        ToList().                        
                        Select(kwp => kwp.filename).                        
                        Distinct().
                        Count() == 1,
                    "setup failed");
                var existinglines = db.KWPerformanceReports.ToList();

                Assert.IsTrue(
                    PerformanceReports.FilesToBeImported(
                        @"C:\Users\hmw\Documents\J.Pierce\JPStarterDesktop\kwreports").Count == 4, 
                    "Fix FilesToBeImported()");

                //your code runs
                PerformanceReports.ImportUnimportedFiles(@"C:\Users\hmw\Documents\J.Pierce\JPStarterDesktop\kwreports");

                Assert.IsTrue(
                    db.KWPerformanceReports.
                        ToList().
                        Except(existinglines).
                        Select(kwp => kwp.filename).
                        Distinct().
                        Count() == 4, 
                    "Fix ImportUnimportedFiles()");               
            }
        }
    }
}

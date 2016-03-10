using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using PerformReportCSV.Models;

namespace PerformReportCSV.Controllers
{
   public class PerformanceReports
    {
        /// <summary>
        /// What does this Method do?
        /// Exports a table as a CSV file.
        /// 
        /// 1. Create a List of strings called reports.
        /// 2. Use the DataContext LINQtoSQL to write statement for the database table.
        /// 3. Create a list of class objects from the database table.
        /// 4. Add typed out string to the list reports.
        /// 5. Iterate through the list keywords one string at a time.
        /// 5a. Create an array variable as a list of strings.
        /// 5b. Add objects to the array as strings.
        /// 6. Add the array to the reports list as a list of strings formatted by ","s.
        /// 7. Write the List reports as a new csv file in the specific path. 
        /// </summary> 
        public static void CSVExporteachloop()
        {
            List<string> reports = new List<string>();
            using (LINQtoSQLDataContext db = new LINQtoSQLDataContext())
            {
                List<KWPerformanceReport> keywords = db.KWPerformanceReports.ToList();
                
                    reports.Add
                    ("channel," +
                    "day," +
                    "campaignid," +
                    "campaign," +
                    "campaignState," +
                    "matchType," +
                    "firstpagecpc," +
                    "qualityscore," +
                    "maxcpc," +
                    "impressions," +
                    "searchimpressionshare," +
                    "clicks," +
                    "avgcpc," +
                    "cost," +
                    "avgposition," +
                    "finalurls," +
                    "importedat," +
                    "filename"
                    );
                
                foreach (KWPerformanceReport keyword in keywords)
                {
                    var arr1 = new List<String>
                      {
                         keyword.channel,
                         keyword.day,
                         keyword.campaignid,
                         keyword.campaign,
                         keyword.campaignState,
                         keyword.matchType,
                         keyword.firstpagecpc,
                         keyword.qualityscore,
                         keyword.maxcpc,
                         keyword.impressions,
                         keyword.searchimpressionshare,
                         keyword.clicks,
                         keyword.avgcpc,
                         keyword.cost,
                         keyword.avgposition,
                         keyword.finalurls,
                         keyword.importedat,
                         keyword.filename
                      };

                    reports.Add(String.Join(",", arr1));
                }

            }
            File.WriteAllLines(@"C:\Users\hmw\Documents\J.Pierce\JPStarterDesktop\NewCSV\foreach", reports);
        }
        public static void CSVExportforloop()
        {
            List<string> reporting = new List<string>();
            using (LINQtoSQLDataContext datab = new LINQtoSQLDataContext())
            {
                List<KWPerformanceReport> keys = datab.KWPerformanceReports.ToList();
                {
                    reporting.Add
                    ("channel," +
                    "day," +
                    "campaignid," +
                    "campaign," +
                    "campaignState," +
                    "matchType," +
                    "firstpagecpc," +
                    "qualityscore," +
                    "maxcpc," +
                    "impressions," +
                    "searchimpressionshare," +
                    "clicks," +
                    "avgcpc," +
                    "cost," +
                    "avgposition," +
                    "finalurls," +
                    "importedat," +
                    "filename"
                    );
                }
                for (int i = 0; i < keys.Count(); i++)
                {
                    KWPerformanceReport keyword = keys[i];


                    var arr1 = new List<String>
                                      {
                                         keyword.channel,
                                         keyword.day,
                                         keyword.campaignid,
                                         keyword.campaign,
                                         keyword.campaignState,
                                         keyword.matchType,
                                         keyword.firstpagecpc,
                                         keyword.qualityscore,
                                         keyword.maxcpc,
                                         keyword.impressions,
                                         keyword.searchimpressionshare,
                                         keyword.clicks,
                                         keyword.avgcpc,
                                         keyword.cost,
                                         keyword.avgposition,
                                         keyword.finalurls,
                                         keyword.importedat,
                                         keyword.filename
                                    };
                    reporting.Add(String.Join(",", arr1));
                }
            }
            File.WriteAllLines(@"C:\Users\hmw\Documents\J.Pierce\JPStarterDesktop\NewCSV\forloop", reporting);
        }
        public static void CSVExportLinq()
        {
            List<string> reports = new List<string>();
            using (LINQtoSQLDataContext db = new LINQtoSQLDataContext())
            {
                List<KWPerformanceReport> keywords = db.KWPerformanceReports.ToList();
                {
                    reports.Add
                    ("channel," +
                    "day," +
                    "campaignid," +
                    "campaign," +
                    "campaignState," +
                    "matchType," +
                    "firstpagecpc," +
                    "qualityscore," +
                    "maxcpc," +
                    "impressions," +
                    "searchimpressionshare," +
                    "clicks," +
                    "avgcpc," +
                    "cost," +
                    "avgposition," +
                    "finalurls," +
                    "importedat," +
                    "filename"
                    );
                };

                var newlines = keywords.
                    Select(keyword =>
                      String.Join(",", new List<String> {
                         keyword.channel,
                         keyword.day,
                         keyword.campaignid,
                         keyword.campaign,
                         keyword.campaignState,
                         keyword.matchType,
                         keyword.firstpagecpc,
                         keyword.qualityscore,
                         keyword.maxcpc,
                         keyword.impressions,
                         keyword.searchimpressionshare,
                         keyword.clicks,
                         keyword.avgcpc,
                         keyword.cost,
                         keyword.avgposition,
                         keyword.finalurls,
                         keyword.importedat,
                         keyword.filename
                    })).ToList();

                reports.AddRange(newlines);
            }//end of using
            File.WriteAllLines(@"C:\Users\hmw\Documents\J.Pierce\JPStarterDesktop\NewCSV\foreach", reports);
        }

        /// <summary>
        /// What is this method trying to do?
        /// Import new data from a file, and insert that data into the table.
        /// 
        /// How will it do this? (list steps in detail)
        /// 1. Pull the string Filename from the main method.
        /// 2. Use the datacontext LINQtoSQL to write statements for a database table.
        /// 3. Create a list of strings to hold the file data
        /// 4. Pull the data from the file 
        /// 5a. Iterate through each string one row at a time (expand on iterate). For each string in list:
        /// 5b. Create a string array and copy the foreach string variable in the array.
        /// 5c. Organize the string array by the character ",".
        /// 5d. Assign objects from the string array to a Class variable.
        /// 5e. Insert the Class variables to KWPerformanceReport class.
        /// </summary>
        public static void CSVImporteachloop(string filename)
        {            
            using (LINQtoSQLDataContext db = new LINQtoSQLDataContext())
            {
                List<string> allLinesText = File.ReadAllLines(filename).ToList();

                foreach (string line in allLinesText)
                {                    
                    string[] info = line.Split(',');                                   

                    KWPerformanceReport keyword = new KWPerformanceReport();
                    keyword.channel = info[0];
                    keyword.day = info[1];
                    keyword.campaignid = info[2];
                    keyword.campaign = info[3];
                    keyword.campaignState = info[4];
                    keyword.adgroupid = info[5];
                    keyword.adGroup = info[6];
                    keyword.adGroupState = info[7];
                    keyword.keywordid = info[8];
                    keyword.keyword = info[9];
                    keyword.matchType = info[10];
                    keyword.firstpagecpc = info[11];
                    keyword.qualityscore = info[12];
                    keyword.maxcpc = info[13];
                    keyword.impressions = info[14];
                    keyword.searchimpressionshare = info[15];
                    keyword.clicks = info[16];
                    keyword.avgcpc = info[17];
                    keyword.cost = info[18];
                    keyword.avgposition = info[19];
                    keyword.finalurls = info[20];
                    keyword.importedat = info[21];
                    keyword.filename = info[22];

                   db.KWPerformanceReports.InsertOnSubmit(keyword);                   
                } // end of foreach loop     
                   db.SubmitChanges();
            }  //end of using statement     
        } 
        /// <summary>
        /// What is this method trying to do?
        /// Import new data from file and sort through the data a certain amount of lines at a time.
        /// 
        /// How will it do this? (List of steps)
        /// 1. Pull the string filename
        /// 2. Use the datacontext LINQtoSQL to write statements for a database table.
        /// 3. Create a list of strings to hold the file data.
        /// 4. Pull the data from the file.
        /// 5. Take the first 100 strings from the file to the list.
        /// 6. Create a integer variable for the size of the batch.
        /// 7. Create a loop to read each line one at a time.
        /// 7a. Set integer i to 0.
        /// 7b. i is less than or equal to the number of lines in the list divided by the batchsize.
        /// 7c. Increment by 1 each loop.
        /// 8. Create a Variable batchitems that equals the list of strings.
        /// 8a. Skip the first string and move on to the next string then add to the list.
        /// 9. Iterate through each string in the list
        /// 9a. Create a string array and copy each string to array.
        /// 9b. Format the array by the character ",".
        /// 10. Create if statement to skip the first string.
        /// 10a. if statement says the first string in the loop is NOT equal to the string "channel".
        /// 11. Create true or false test statement to show the results of the if statement for each iteration.
        /// 12. Assign objects from the string array to a class object.
        /// 12a. Set class column variable importedat to the current date and time.
        /// 12b. Set class column variable filename to the string filename.
        /// 13. Insert the class object to the KWPerformance table.
        /// </summary>
        /// <param name="filename"></param>
        public static void CSVBatching(string filename)
        {
            using (LINQtoSQLDataContext db = new LINQtoSQLDataContext())
            {
                List<string> allLinesText = File.ReadAllLines(filename).
                    //Skip(1).    //Skip one line (Header)
                    Take(100).                   
                    ToList();
                
                int batchsize = 10000;               

                for (int i = 0; i <= allLinesText.Count / batchsize; i++)                
                {
                    // Variable batchitems is equal to the file list
                    // Skip ignores the specified items (i * batchsize) and starts after the last skipped item.
                    // Take will return the specified number of items and ignore the rest of the sequence.
                    var batchitems = allLinesText.Skip(i * batchsize).Take(batchsize).ToList();

                    foreach (string line in batchitems)
                    {
                        string[] info = line.Split(',');

                        //If statement skips the first string in the loop, which is the header line.
                        if (!info[0].Equals("channel")) // If the first string not equal to the string channel
                        {
                            bool test = true;
                            test = !info[0].Equals("channel");                            

                            KWPerformanceReport keyword = new KWPerformanceReport();
                            keyword.channel = info[0];
                            keyword.day = info[1];
                            keyword.campaignid = info[2];
                            keyword.campaign = info[3];
                            keyword.campaignState = info[4];
                            keyword.adgroupid = info[5];
                            keyword.adGroup = info[6];
                            keyword.adGroupState = info[7];
                            keyword.keywordid = info[8];
                            keyword.keyword = info[9];
                            keyword.matchType = info[10];
                            keyword.firstpagecpc = info[11];
                            keyword.qualityscore = info[12];
                            keyword.maxcpc = info[13];
                            keyword.impressions = info[14];
                            keyword.searchimpressionshare = info[15];
                            keyword.clicks = info[16];
                            keyword.avgcpc = info[17];
                            keyword.cost = info[18];
                            keyword.avgposition = info[19];
                            keyword.finalurls = info[20];

                            keyword.importedat = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Get current date and time written to string.
                            //DateTime now = DateTime.Now;
                            //string.Format("{0:d/M/yyyy HH:mm:ss}", now);
                            keyword.filename = filename;


                            db.KWPerformanceReports.InsertOnSubmit(keyword);
                      } // end of if statement
                    } // end of foreach loop 
                    db.SubmitChanges();
                } // end of for loop
            }  //end of using statement     
        }

        /// <summary>
        /// This method will return a list of all files in directory that haven't been loaded into JPStarter.dbo.KWPerformanceReports
        /// 1. Create a list of csv file paths from a folder
        /// 2. Use the LINQtoSQL DataContext to ???
        /// 3. Create a list called keywords from the KWPerformanceReport class
        /// 4. Create a list of csv file paths from a table (fileNames)
        /// 4a. Loop through the list keywords
        /// 4b. Add filename from the table to the list
        /// 5. Create new List to compare the two lists and hold on the differences
        /// 6. return differences
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public static List<String> FilesToBeImported(string directory)
        {
            List<String> directoryfiles = Directory.GetFiles(directory, "*.csv").ToList();

            using (LINQtoSQLDataContext db = new LINQtoSQLDataContext())
            {
                List<KWPerformanceReport> keywords = db.KWPerformanceReports.ToList(); //eager loading
                List<String> importedfiles = new List<string>();
                foreach (KWPerformanceReport keyword in keywords)
                {                    
                    importedfiles.Add(keyword.filename);                                       
                }
                //List<String> fileDifference = directoryfiles.Except(importedfiles).ToList();

                List<String> fileDifference = new List<string>();
                foreach(string directoryfile in directoryfiles)
                {
                    foreach(string importedfile in importedfiles)
                    {
                        if (directoryfile.Equals(importedfile))
                        {

                        }
                        else if(!directoryfile.Equals(importedfile))
                        {
                            fileDifference.Add(importedfile);
                        }
                    }
                }
                
                return fileDifference; //where is this going? It goes to the method that calls this method.
            }            
        }

        /// <summary>
        /// This method will import all files from directory that haven't been imported
        /// hint: use FilesToBeImported() and CSVBatching()
        /// 1. Call the FilesToBeImported method to give me a list of filenames that haven't been imported
        /// 2. Import the files into the table using CSVBatching method on each filename
        /// </summary>
        public static List<String> ImportUnimportedFiles(string directory)
        {
            List<string> filenamesTobeimported = FilesToBeImported(directory).ToList();

            foreach (string filename in filenamesTobeimported)
            {
                CSVBatching(filename);
            }
            return null;
        }
        /// <summary>
        /// This method will set the default filename and truncate the table.
        /// 1. Create string filename which is the path to a file.
        /// 2. Use the LINQtoSQL Datacontext to write statement for the database table
        /// 3. Datacontext execute sql command to clear out the table specified.
        /// 4. The method CSVBatching uses the string filename.
        /// </summary>
        public static void Setup()
        {
            string filename = (@"C:\Users\hmw\Documents\J.Pierce\JPStarterDesktop\kwreports\keywordperformancereport20160201.csv");

            using (LINQtoSQLDataContext dba = new LINQtoSQLDataContext())
            {
                dba.ExecuteCommand("TRUNCATE TABLE KWPerformanceReports");
            }

            PerformanceReports.CSVBatching(filename);
        }
    }

    public class DavidsPerformanceReports
    {
        public static String ImportUnimportedFiles(string directory)
        {
            using (var db = new LINQtoSQLDataContext())
            {

                var all_files = Directory.GetFiles(directory).ToList();

                var imported_files = db.KWPerformanceReports.
                    Select(kwp => kwp.filename).
                    Distinct().
                    ToList();

                var unimported_files = all_files.Except(imported_files).ToList();

                var unimported_lines = unimported_files.
                    SelectMany(unimported_file => File.ReadAllLines(unimported_file)).
                    Where(line => !line.Split(',')[0].Equals("channel")).
                    ToList();

                var new_keywords = unimported_lines.
                    Select(fl => fl.Split(',')).
                    Where(fl => fl.Count() >= 23).
                    Select(fl =>
                        new KWPerformanceReport()
                        {
                            channel = fl[0],
                            day = fl[1],
                            campaignid = fl[2],
                            campaign = fl[3],
                            campaignState = fl[4],
                            adgroupid = fl[5],
                            adGroup = fl[6],
                            adGroupState = fl[7],
                            keywordid = fl[8],
                            keyword = fl[9],
                            matchType = fl[10],
                            firstpagecpc = fl[11],
                            qualityscore = fl[12],
                            maxcpc = fl[13],
                            impressions = fl[14],
                            searchimpressionshare = fl[15],
                            clicks = fl[16],
                            avgcpc = fl[17],
                            cost = fl[18],
                            avgposition = fl[19],
                            finalurls = fl[20],
                            importedat = fl[21],
                            filename = fl[22]
                        }).
                    ToList();

                db.KWPerformanceReports.InsertAllOnSubmit(new_keywords);

                db.SubmitChanges();
            }//end of using

            return null;
        }
    }
} 
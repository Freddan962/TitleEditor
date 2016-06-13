using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TitleEditor
{
    public static class DBCUtil
    {

        static string DBCUtilPath = "lib\\DBCUtil.exe";

        public static string findTitleRow(int titleEntry)
        {
            string row;

            using (System.IO.StreamReader file = new System.IO.StreamReader("CharTitles.dbc.csv"))
            {
                int counter = 0;
                while ((row = file.ReadLine()) != null)
                {
                    if (counter == 0)
                    {
                        counter++;
                        continue;
                    }

                    int currentEntry = int.Parse(getColumnValue(0, row));
                    if (currentEntry == titleEntry)
                    {
                        return row;
                    }
                }

                return null;
            }
        }

        //Zero based
        public static string getColumnValue(int column)
        {
            return getColumnValue(column, lastEntry());
        }

        public static string getColumnValue(int column, string dataString)
        {
            List<string> data = dataString.Split(',').ToList<String>();
            return data[column];
        }

        public static string lastEntry()
        {
            return File.ReadLines("CharTitles.dbc.csv").Last();
        }

        public static void addTitle(string titleEntry)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("CharTitles.dbc.csv", true))
            {
                file.WriteLine(titleEntry);
            }
        }

        public static string formatDBCRow(string row)
        {
            string entry = getColumnValue(0, row).Replace("\"", "");
            string mTitle = getColumnValue(2, row).Replace("\"", "");
            string fTitle = getColumnValue(19, row).Replace("\"", "");

            return entry + "," + mTitle + "," + fTitle;
        }

        public static string formatEntry(string fTitle, string mTitle)
        {
            string entry = String.Format("{0},0,\"{1}\",,,,,,,,,,,,,,,,", nextEntry(), mTitle);
            entry += String.Format("0xFF01FE,\"{0}\",,,,,,,,,,,,,,,,0xFF01FE,{1},", fTitle, nextInGameOrder());

            return entry;
        }

        public static void dbcToCsv()
        {

            if (File.Exists("CharTitles.dbc.csv"))
                File.Delete("CharTitles.dbc.csv");

            executeCommand(DBCUtilPath + " CharTitles.dbc");
        }

        public static void csvToDbc()
        {
            if (File.Exists("CharTitles.dbc"))
                File.Delete("CharTitles.dbc");

            executeCommand(DBCUtilPath + " CharTitles.dbc.csv");
        }


        public static int currEntry()
        {
            return nextEntry() - 1;
        }

        public static int nextEntry()
        {
            return int.Parse(DBCUtil.getColumnValue(0)) + 1;
        }

        public static int nextInGameOrder()
        {
            return int.Parse(DBCUtil.getColumnValue(36)) + 1;
        }

        public static List<String> readRows()
        {
            List<String> rows = new List<String>();

            using (System.IO.StreamReader file = new System.IO.StreamReader("CharTitles.dbc.csv"))
            {
                string row;
                while ((row = file.ReadLine()) != null)
                {
                    rows.Add(row);
                }
            }

            return rows;
        }

        private static void executeCommand(string command)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + command;  // /c carries out the command and then terminates

            process.StartInfo = startInfo;
            process.Start();
        }
    }
}

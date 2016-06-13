using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TitleEditor
{
    public partial class Application : Form
    {
        TitleList titleList;

        public bool load { get; set; } = false;
        public bool add { get; set; } = false;
        public bool delete { get; set; } = false;

        public Application()
        {
            InitializeComponent();
            DBCUtil.dbcToCsv();
            titleList = null;
        }

        public void select(int titleEntry)
        {
            EntryField.Text = Convert.ToString(titleEntry);
            loadTitle();
            updateStatus(String.Format("Selected title with ID {0}", titleEntry));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MTitleField.Enabled = false;
            FTitleField.Enabled = false;
            EntryField.Enabled = false;
        }

        private void updateStatus(string status)
        {
            string time = DateTime.Now.ToString("HH:mm:ss tt");
            statusLabel.Text = time + " " + status;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!add)
            {
                add = true;
                delete = false;
                load = false;

                MTitleField.Enabled = true;
                FTitleField.Enabled = true;
                EntryField.Enabled = false;

                return;
            }

            string fTitle = FTitleField.Text;
            string mTitle = MTitleField.Text;
            string titleRow = DBCUtil.formatEntry(fTitle, mTitle);

            DBCUtil.addTitle(titleRow);
            DBCUtil.csvToDbc();

            if (titleList != null)
                titleList.addOption(DBCUtil.formatDBCRow(titleRow));

            updateAddStatus();
            load = false;
        }

        private void LoadTitleButton_Click(object sender, EventArgs e)
        {
            if (!load && !delete)
            {
                load = true;
                add = false;
                MTitleField.Enabled = false;
                FTitleField.Enabled = false;
                EntryField.Enabled = true;
                return;
            }

            loadTitle();
            updateLoadStatus();
        }

        private void DeleteTitle_Click(object sender, EventArgs e)
        {
            if (!delete && !load)
            {
                delete = true;
                add = false;
                MTitleField.Enabled = false;
                FTitleField.Enabled = false;
                EntryField.Enabled = true;
                return;
            }

            string data = getLine();
            if (data == null) return;

            string tempFile = Path.GetTempFileName();
            List<string> linesToKeep = File.ReadLines("CharTitles.dbc.csv").Where(line => line != data).ToList();
            File.WriteAllLines(tempFile, linesToKeep);
            File.Delete("CharTitles.dbc.csv");
            File.Move(tempFile, "CharTitles.dbc.csv");

            DBCUtil.csvToDbc();

            if (titleList != null)
                titleList.removeOption(DBCUtil.formatDBCRow(data));

            updateDeleteStatus();
        }

        private void loadTitle()
        {
            string data = getLine();
            if (data == null) return;

            MTitleField.Text = DBCUtil.getColumnValue(2, data).Replace("\"", "");
            FTitleField.Text = DBCUtil.getColumnValue(19, data).Replace("\"", "");

            updateLoadStatus();
        }

        private void updateAddStatus()
        {
            EntryField.Text = DBCUtil.currEntry().ToString();
            string change = String.Format("Added title with ID {0}", DBCUtil.currEntry());
            updateStatus(change);
        }

        private void updateDeleteStatus()
        {
            updateStatus("Deleted title with ID " + int.Parse(EntryField.Text));
        }

        private void updateLoadStatus()
        {
            updateStatus("Loaded title with ID " + int.Parse(EntryField.Text));
        }

        private string getLine()
        {
            if (EntryField.Text == string.Empty) return null;
            int targetEntry = int.Parse(EntryField.Text);

            string data = DBCUtil.findTitleRow(targetEntry);

            if (data == null)
            {
                updateStatus(String.Format("Could not find title with entry {0}", targetEntry));
                return null;
            }

            return data;
        }

        private void List_Click(object sender, EventArgs e)
        {
            if (titleList == null) titleList = titleList = new TitleList(this);
            titleList.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitleEditor
{
    public partial class TitleList : Form
    {
        Application application;

        public TitleList(Application app)
        {
            InitializeComponent();
            application = app;
            listView.SelectionMode = SelectionMode.One;
            addOptions();
        }

        public void removeOption(string option)
        {
            listView.Items.Remove(option);
        }

        public void addOption(string option)
        {
            listView.Items.Add(option);
            viewBottomOfList();
        }
        
        private void viewBottomOfList()
        {
            listView.TopIndex = listView.Items.Count - 1;
        }

        private void addOptions()
        {
            List<String> lines = DBCUtil.readRows();

            for (int i = 0; i < lines.Count; i++)
            {
                if (i == 0) continue;

                listView.Items.Add(DBCUtil.formatDBCRow(lines[i]));
            }
        }

        private void removeOptions()
        {
            listView.Items.Remove(listView.Items);
        }

        private void selectTitle()
        {
            string selectedItem = listView.GetItemText(listView.SelectedItem);

            if (selectedItem == string.Empty) return;

            int titleID = int.Parse(DBCUtil.getColumnValue(0, selectedItem));
            application.select(titleID);
            application.delete = true;
        }

        private void button1_Click(object sender, EventArgs e) { selectTitle(); }
        private void listView_SelectedIndexChanged(object sender, EventArgs e) { selectTitle();  }
    }
}

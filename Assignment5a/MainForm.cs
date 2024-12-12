using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5a
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.personDataSet.Person);

        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personDataSet);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            personBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.personDataSet);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            personBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (personBindingSource.Current != null)
            {
                personBindingSource.RemoveCurrent();
                tableAdapterManager.UpdateAll(this.personDataSet);
            }
        }
    }
}

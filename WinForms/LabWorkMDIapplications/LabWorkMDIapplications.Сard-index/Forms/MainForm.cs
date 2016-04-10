using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWorkMDIapplications.Сard_index
{
    public partial class MainForm : Form
    {
        private AllBoksForm allBooksForm;
        private AddAutorForm addAutorform;
        private AddBookForm addBookform;
        private AddPublishingHouseForm addPublishingHouseform;

        public MainForm()
        {
            InitializeComponent();
            addAutorform = new AddAutorForm();
            addPublishingHouseform = new AddPublishingHouseForm();
            addBookform = new AddBookForm();
        }

        private void showAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allBooksForm = new AllBoksForm();
            allBooksForm.MdiParent = this;
            allBooksForm.Show();
        }

        private void addAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAutorform.MdiParent = this;
            addAutorform.FormClosing += (oo, ee) =>
            {
                ee.Cancel = true;
                addAutorform.Visible = false;
            };
            addAutorform.Visible = true;
        }

        private void addPubHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPublishingHouseform.MdiParent = this;
            addPublishingHouseform.FormClosing += (oo, ee) =>
            {
                ee.Cancel = true;
                addPublishingHouseform.Visible = false;
            };
            addPublishingHouseform.Visible = true;
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBookform.MdiParent = this;
            addBookform.FormClosing += (oo, ee) =>
            {
                ee.Cancel = true;
                addBookform.Visible = false;
            };
            addBookform.Visible = true;
        }
    }
}

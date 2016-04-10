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
    public partial class AddAutorForm : Form
    {
       
        public AddAutorForm()
        {
            
            InitializeComponent();
        }

        private void ButtonAddAutor_Click(object sender, EventArgs e)
        {
            if (TextFName.ToString() != "" & TextBoxLName.ToString() != "")
            {
                Facade.DataBase.AddAutor(TextFName.ToString(), TextBoxLName.ToString());
                TextFName.Clear();
                TextBoxLName.Clear();
            }
            else
                MessageBox.Show("Null Ferst Name or Null Last Name", "Error");
        }
    }
}

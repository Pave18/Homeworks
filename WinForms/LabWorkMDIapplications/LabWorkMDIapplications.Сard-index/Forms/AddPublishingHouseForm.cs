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
    public partial class AddPublishingHouseForm : Form
    {
        public AddPublishingHouseForm()
        {
            InitializeComponent();
        }

        private void ButtonAddPubHouse_Click(object sender, EventArgs e)
        {
            if (TextBoxNameHouse.ToString() != "")
            {
                Facade.DataBase.AddPublishingHouse(TextBoxNameHouse.ToString());
                TextBoxNameHouse.Clear();
            }
            else
                MessageBox.Show("Null Name", "Error");

        }
    }
}

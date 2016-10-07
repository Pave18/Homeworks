using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW1
{
    public partial class MainForm1 : System.Web.UI.Page
    {
        public List<string> LProducts = new List<string>() { "Product1", "Product2", "Product3", "Product4" };
        public List<string> LBasket = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            UpdateListBoxs();
        }

        private void UpdateListBoxs()
        {
            ListBoxPoducts.Items.Clear() ;
            ListBoxBasket.Items.Clear();

            foreach (var item in LProducts)
            {
                ListBoxPoducts.Items.Add(item);
            }

            foreach (var item in LBasket)
            {
                ListBoxBasket.Items.Add(item);
            }
        }

        protected void ButtonAllAddBasket_Click(object sender, EventArgs e)
        {

           foreach (ListItem item in ListBoxPoducts.Items)
            {
                LBasket.Add(item.ToString());   
            }
            LProducts.Clear();
            UpdateListBoxs();
        }

        protected void ButtonAddBasket_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in ListBoxPoducts.Items)
            {
                if (item.Selected)
                {
                    LBasket.Add(item.ToString());
                    LProducts.Remove(item.ToString());
                }
            }
            UpdateListBoxs();
        }

        protected void ButtonAllOutBasket_Click(object sender, EventArgs e)
        {

            foreach (ListItem item in ListBoxBasket.Items)
            {
                LProducts.Add(item.ToString());
            }
            LBasket.Clear();
            UpdateListBoxs();
        }

        protected void ButtonOutBasket_Click (object sender, EventArgs e)
        {
            foreach (ListItem item in ListBoxBasket.Items)
            {
                if (item.Selected)
                {
                    LProducts.Add(item.ToString());
                    LBasket.Remove(item.ToString());
                }
            }
            UpdateListBoxs();
        }
    }
}
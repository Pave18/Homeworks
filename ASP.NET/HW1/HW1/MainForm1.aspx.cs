using System;
using System.Web.UI.WebControls;

namespace HW1
{
    public partial class MainForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UpdateListBoxs();
            }
        }

        private void UpdateListBoxs()
        {
            ListBoxPoducts.Items.Clear() ;
            ListBoxBasket.Items.Clear();

            foreach (var item in Lists.LProducts)
            {
                ListBoxPoducts.Items.Add(item);
            }

            foreach (var item in Lists.LBasket)
            {
                ListBoxBasket.Items.Add(item);
            }
        }

        protected void ButtonAllAddBasket_Click(object sender, EventArgs e)
        {

           foreach (ListItem item in ListBoxPoducts.Items)
            {
                Lists.LBasket.Add(item.ToString());   
            }
            Lists.LProducts.Clear();
            UpdateListBoxs();
        }

        protected void ButtonAddBasket_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in ListBoxPoducts.Items)
            {
                if (item.Selected)
                {
                    Lists.LBasket.Add(item.ToString());
                    Lists.LProducts.Remove(item.ToString());
                }
            }
            UpdateListBoxs();
        }

        protected void ButtonAllOutBasket_Click(object sender, EventArgs e)
        {

            foreach (ListItem item in ListBoxBasket.Items)
            {
                Lists.LProducts.Add(item.ToString());
            }
            Lists.LBasket.Clear();
            UpdateListBoxs();
        }

        protected void ButtonOutBasket_Click (object sender, EventArgs e)
        {
            foreach (ListItem item in ListBoxBasket.Items)
            {
                if (item.Selected)
                {
                    Lists.LProducts.Add(item.ToString());
                    Lists.LBasket.Remove(item.ToString());
                }
            }
            UpdateListBoxs();
        }
    }
}
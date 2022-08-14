using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Manufacturing
{
    public partial class UpperEntryForm : Form
    {
        public UpperEntryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void UpperEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = txtArticleName.Text;
            arr[1] = txtColor.Text;
            arr[2] = txtTotalQuantity.Text;
            arr[3] = txtUpperVendor.Text;

            ListViewItem listitems = new ListViewItem(arr);
            listView1.Items.Add(listitems);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 16);
            Font fontsmall = new Font("Arial", 12);
            float fontweight = font.GetHeight();
            int startx = 250;
            int starty = 40;
            int offset = 30;
            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("Shoes Management Store",new Font("Arial",20), new SolidBrush(Color.Black),startx,starty);
            string top = "DATE: " + txtDate.Text.PadRight(1);
            graphics.DrawString(top, fontsmall, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int)fontweight;
            graphics.DrawString("----------------------------------------------------",font,new SolidBrush(Color.Black),200,starty+offset);
            offset = offset + 30;
            graphics.DrawString("Article Name\tColor\tTotal Quantity\tUpper Vendor",fontsmall, new SolidBrush(Color.Black),150,starty+offset);
            offset = offset + 30;

            for(int x = 0;x<listView1.Items.Count;x++)
            {
                graphics.DrawString(listView1.Items[x].SubItems[0].Text+"\t\t"+ listView1.Items[x].SubItems[1].Text+"\t\t"+listView1.Items[x].SubItems[2].Text+"\t\t"+listView1.Items[x].SubItems[3].Text, new Font("Arial", 12), new SolidBrush(Color.Black), 150, starty+offset);
                offset = offset + 20;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //foreach (var c in this.Controls)
            //{
            //    if (c is TextBox)
            //    {
            //        ((TextBox)c).Text = string.Empty;
            //    }
            //}

            txtID.Text = "";
            txtColor.Text = "";
            txtUpperVendor.Text = "";
            txtArticleName.Text = "";
            txtTotalQuantity.Text = "";

            // ===============Empty Data Grid view===================
            int numRows = listView1.Items.Count;
            for (int i = 0; i < numRows; i++)
            {
                try
                {
                    int max = listView1.Items.Count - 1;
                    listView1.Items.Remove(listView1.Items[max]);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("All rows are not to be deleted" + ex, "Data Delete Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

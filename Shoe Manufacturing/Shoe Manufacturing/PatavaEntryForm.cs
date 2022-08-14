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
    public partial class PatavaEntryForm : Form
    {
        public PatavaEntryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PatavaEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string[] arr = new string[6];
            //arr[0] = txtArticleName.Text;
            //arr[1] = txtColor.Text;
            //arr[2] = txtTotalQuantity.Text;
            //arr[3] = txtSupplierName.Text;
            //arr[4] = txtAssign.Text;
            //arr[5] = txtInout.Text;

           // ListViewItem listitems = new ListViewItem(arr);
           // listView1.Items.Add(listitems);
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
            //txtID.Text = "";
            //txtColor.Text = "";
            //txtAssign.Text = "";
            //txtArticleName.Text = "";
            //txtInout.Text = "";
            //txtTotalQuantity.Text = "";
            //txtSupplierName.Text = "";
           

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

        private void btndelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
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
            graphics.DrawString("Company", new Font("Arial", 20), new SolidBrush(Color.Black), startx, starty);
            //string top = "DATE: " + dateTimePicker1.Text.PadRight(1);
           // graphics.DrawString(top, fontsmall, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int)fontweight;
            graphics.DrawString("----------------------------------------------------", font, new SolidBrush(Color.Black), 200, starty + offset);
            offset = offset + 30;
            graphics.DrawString("Article Name\tColor\tTotal Quantity\tSupplier Name\tAssign Or Received\tIn/Out", fontsmall, new SolidBrush(Color.Black), 30, starty + offset);
            offset = offset + 30;

            for (int x = 0; x < listView1.Items.Count; x++)
            {
                graphics.DrawString(listView1.Items[x].SubItems[0].Text + "\t\t" + listView1.Items[x].SubItems[1].Text + "\t\t" + listView1.Items[x].SubItems[2].Text + "\t\t" + listView1.Items[x].SubItems[3].Text + "\t" + listView1.Items[x].SubItems[4].Text + "\t" + listView1.Items[x].SubItems[5].Text, new Font("Arial", 12), new SolidBrush(Color.Black), 30, starty + offset);
                offset = offset + 20;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

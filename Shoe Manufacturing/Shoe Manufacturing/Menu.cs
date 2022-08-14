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
    public partial class btnStockPosition : Form
    {
        public btnStockPosition()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelEntryFormsSub.Visible = false;
            //panelStockPositionSub.Visible = false;
          //  panelRecordsSub.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelEntryFormsSub.Visible == true)
                panelEntryFormsSub.Visible = false;
           // if (panelRecordsSub.Visible == true)
           //     panelRecordsSub.Visible = false;
         //   if (panelStockPositionSub.Visible == true)
          //      panelStockPositionSub.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnEntryForms_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEntryFormsSub);
        }

        private void btnProductionEntry_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductionEntry());
            hideSubMenu();
        }

        private void btnUpperEntry_Click(object sender, EventArgs e)
        {
            openChildForm(new UpperEntryForm());
            hideSubMenu();
        }

        private void btnPatavaEntry_Click(object sender, EventArgs e)
        {
            openChildForm(new PatavaEntryForm());
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          //  showSubMenu(panelStockPositionSub);
        
        }

        private void btnShoesStock_Click(object sender, EventArgs e)
        {
            openChildForm(new ShoesStockForm());
            hideSubMenu();
        }

        private void btnUpperStock_Click(object sender, EventArgs e)
        {
            openChildForm(new UpperStockForm());
            hideSubMenu();
        }

        private void btnPatavaStock_Click(object sender, EventArgs e)
        {
            openChildForm(new PatavaStockForm());
            hideSubMenu();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
         //   showSubMenu(panelRecordsSub);
        }

        private void btnSaleRecord_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form ChildForm )
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnStockPosition_Load(object sender, EventArgs e)
        {

        }

        private void panelRecordsSub_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

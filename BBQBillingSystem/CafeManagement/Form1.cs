using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //test
        }

        private void button3_Click(object sender, EventArgs e)
        { //btnReset
            txtBeef.Text = "0";
            txtElk.Text = "0";
            txtMushroom.Text = "0";
            txtTurkey.Text = "0";
            txtVeggie.Text = "0";
            txtSalmon.Text = "0";
            txtTuna.Text = "0";
            txtShoestring.Text = "0";
            txtBelgian.Text = "0";
            txtStandard.Text = "0";
            txtCrinkle.Text = "0";
            txtSweet.Text = "0";
            txtWaffle.Text = "0";
            txtPotato.Text = "0";
            lblCakeCost.Text = "0";
            lblDrinkCost.Text = "0"; 
            lblSvcCharge.Text = "1.75";
            lblTax.Text = "0";
            lblSubTotal.Text = "0";
            lblTotal.Text = "0";

            chkBeef.Checked = false;
            chkElk.Checked = false;
            chkMushroom.Checked = false;
            chkTurkey.Checked = false;
            chkVeggie.Checked = false;
            chkSalmon.Checked = false;
            chkTuna.Checked = false;
            chkBelgian.Checked = false;
            chkShoestring.Checked = false;
            chkStandard.Checked = false;
            chkCrinkle.Checked = false;
            chkSweet.Checked = false;
            chkWaffle.Checked = false;
            chkPotato.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //btnReceipt
            rtfReceipt.Clear();

           // rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("\t\t" + "Bon" + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            if (double.Parse(txtBeef.Text.ToString()) != 0 )
                rtfReceipt.AppendText("Beef Burger \t\t\t\t" + txtBeef.Text + Environment.NewLine);
            if (double.Parse(txtElk.Text.ToString()) != 0)
                rtfReceipt.AppendText("Elk Burger \t\t\t" + txtElk.Text + Environment.NewLine);
            if (double.Parse(txtMushroom.Text.ToString()) != 0)
                rtfReceipt.AppendText("Mushrooms Burger \t\t\t\t" + txtMushroom.Text + Environment.NewLine);
            if (double.Parse(txtTurkey.Text.ToString()) != 0)
                rtfReceipt.AppendText("Turkey Burger \t\t\t" + txtTurkey.Text + Environment.NewLine);
            if (double.Parse(txtVeggie.Text.ToString()) != 0)
                rtfReceipt.AppendText("Veggie Burger \t\t\t" + txtVeggie.Text + Environment.NewLine);
            if (double.Parse(txtSalmon.Text.ToString()) != 0)
                rtfReceipt.AppendText("Salmon Burger \t\t\t" + txtSalmon.Text + Environment.NewLine);
            if (double.Parse(txtTuna.Text.ToString()) != 0)
                rtfReceipt.AppendText("Tuna Burger \t\t\t" + txtTuna.Text + Environment.NewLine);
            if (double.Parse(txtShoestring.Text.ToString()) != 0)
                rtfReceipt.AppendText("Shoestring Fries \t\t\t" + txtShoestring.Text + Environment.NewLine);
            if (double.Parse(txtBelgian.Text.ToString()) != 0)
                rtfReceipt.AppendText("Belgian Fries \t\t" + txtBelgian.Text + Environment.NewLine);
            if (double.Parse(txtStandard.Text.ToString()) != 0)
                rtfReceipt.AppendText("Standard Fries \t\t" + txtStandard.Text + Environment.NewLine);
            if (double.Parse(txtCrinkle.Text.ToString()) != 0)
                rtfReceipt.AppendText("Crinkle Fries \t\t" + txtCrinkle.Text + Environment.NewLine);
            if (double.Parse(txtSweet.Text.ToString()) != 0)
                rtfReceipt.AppendText("Sweet Fries \t\t" + txtSweet.Text + Environment.NewLine);
            if (double.Parse(txtWaffle.Text.ToString()) != 0)
                rtfReceipt.AppendText("Waffle Fries \t\t" + txtWaffle.Text + Environment.NewLine);
            if (double.Parse(txtPotato.Text.ToString()) != 0)
                rtfReceipt.AppendText("Potato Wedges \t\t\t" + txtPotato.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Service Charge \t\t" + lblSvcCharge.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Tax \t\t\t\t" + lblTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("Sub Total \t\t\t" + lblSubTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("Total Cost \t\t\t" + lblTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTimer.Text + "\t" + lblDate.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        { //btnTotal
            //double lat, mocha, espr, vale, cappu, afri, mTea;
            //double cCake, rValvet, bFor, bCream, lChoco, kChoco, cheese, rain;
            //double tax;
            //tax = 0.45;

            //lat = 1.20; mocha = 1.29; espr = 1.29; vale = 1.45; cappu = 1.70; afri = 1.50; mTea = 1.45; //coffee pries
            //cCake = 1.30; rValvet = 1.20; bFor = 1.30; bCream = 1.90; lChoco = 1.50; kChoco = 1.40; cheese = 1.30; rain = 1.10; //cake prices

            double beef, elk, mush, turkey, veggie, salmon, tuna;
            double shoestring, belgian, standard, crinkle, sweet, waffle, potato;
            double tax;
            tax = 0.95;

            beef = 5.50; elk = 8.00; mush = 6.20; turkey = 7.00; veggie = 5.20; salmon = 7.2; tuna = 5.00;
            shoestring = 4.20; belgian = 3.50; standard = 3.00; crinkle = 3.90; sweet = 4.40; waffle = 5.2; potato = 5.00;

            //Burgers
            double BeefB = Convert.ToDouble(txtBeef.Text);
            double ElkB = Convert.ToDouble(txtElk.Text);
            double MushroomB = Convert.ToDouble(txtMushroom.Text);
            double TurkeyB = Convert.ToDouble(txtTurkey.Text);
            double VeggieB = Convert.ToDouble(txtVeggie.Text);
            double SalmonB = Convert.ToDouble(txtSalmon.Text);
            double TunaB = Convert.ToDouble(txtTuna.Text);
            //Fries
            double ShoestringF = Convert.ToDouble(txtShoestring.Text);
            double BelgianF = Convert.ToDouble(txtBelgian.Text);
            double StandardF = Convert.ToDouble(txtStandard.Text);
            double CrinkleF = Convert.ToDouble(txtCrinkle.Text);
            double SweetF = Convert.ToDouble(txtSweet.Text);
            double WaffleF = Convert.ToDouble(txtWaffle.Text);
            double PotatoF = Convert.ToDouble(txtPotato.Text);

            Cafe eat_in_cafe = new Cafe(BeefB, ElkB, MushroomB, TurkeyB, VeggieB, SalmonB, TunaB,
                ShoestringF, BelgianF, StandardF, CrinkleF, SweetF, WaffleF, PotatoF);

            double drinkCosts = (BeefB * beef) + (ElkB * elk) + (MushroomB * mush) + (TurkeyB * turkey) + (VeggieB * veggie) + (SalmonB * salmon) + (TunaB * tuna);
            lblDrinkCost.Text = Convert.ToString(drinkCosts);
            double cakeCosts = (ShoestringF * shoestring) + (BelgianF * belgian) + (StandardF * standard) + (CrinkleF * crinkle) + (SweetF * sweet) + (WaffleF * waffle) + (PotatoF * potato);
            lblCakeCost.Text = Convert.ToString(cakeCosts);

            double svcCharge = Convert.ToDouble(lblSvcCharge.Text);

            lblSubTotal.Text = Convert.ToString(cakeCosts + drinkCosts + svcCharge);
            lblTax.Text = Convert.ToString(((cakeCosts + drinkCosts + svcCharge) * tax) / 100);
            double totalAftTax = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(cakeCosts + drinkCosts + svcCharge + totalAftTax);

            lblDrinkCost.Text = String.Format("{0:C}", drinkCosts);
            lblCakeCost.Text = String.Format("{0:C}", cakeCosts);
            lblSvcCharge.Text = String.Format("{0:C}", svcCharge);
            lblSubTotal.Text = String.Format("{0:C}", (cakeCosts + drinkCosts + svcCharge));
            lblTax.Text = String.Format("{0:C}", totalAftTax);
            lblTotal.Text = String.Format("{0:C}", (cakeCosts + drinkCosts + svcCharge + totalAftTax));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this code will save text files
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";


            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
            double BeefB = Convert.ToDouble(txtBeef.Text);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();


            txtBeef.Text = "0";
            txtElk.Text = "0";
            txtMushroom.Text = "0";
            txtTurkey.Text = "0";
            txtVeggie.Text = "0";
            txtSalmon.Text = "0";
            txtTuna.Text = "0";
            txtShoestring.Text = "0";
            txtBelgian.Text = "0";
            txtStandard.Text = "0";
            txtCrinkle.Text = "0";
            txtSweet.Text = "0";
            txtWaffle.Text = "0";
            txtPotato.Text = "0";
            lblCakeCost.Text = "0";
            lblDrinkCost.Text = "0";
            lblSvcCharge.Text = "1.75";
            lblSubTotal.Text = "0";
            lblTax.Text = "0";
            lblTotal.Text = "0";

            txtBeef.Enabled = false;
            txtElk.Enabled = false; ;
            txtMushroom.Enabled = false;
            txtTurkey.Enabled = false;
            txtVeggie.Enabled = false;
            txtSalmon.Enabled = false;
            txtTuna.Enabled = false;
            txtShoestring.Enabled = false;
            txtBelgian.Enabled = false;
            txtStandard.Enabled = false;
            txtCrinkle.Enabled = false;
            txtSweet.Enabled = false;
            txtWaffle.Enabled = false;
            txtPotato.Enabled = false;

            chkBeef.Checked = false;
            chkElk.Checked = false;
            chkMushroom.Checked = false;
            chkTurkey.Checked = false;
            chkVeggie.Checked = false;
            chkSalmon.Checked = false;
            chkTuna.Checked = false;
            chkBelgian.Checked = false;
            chkShoestring.Checked = false;
            chkStandard.Checked = false;
            chkCrinkle.Checked = false;
            chkSweet.Checked = false;
            chkWaffle.Checked = false;
            chkPotato.Checked = false;

            rtfReceipt.Clear();

        }

        private void chkBeef_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBeef.Checked==true)
            {
                txtBeef.Enabled = true;
            }
            else
            {
                txtBeef.Enabled = false;
                txtBeef.Text = "0";
            }
        }    

        private void txtBeef_Click(object sender, EventArgs e)
        {
            txtBeef.Text = "";
            txtBeef.Focus();
        }

        private void chkElk_CheckedChanged(object sender, EventArgs e)
        {
            if (chkElk.Checked == true)
            {
               txtElk.Enabled = true;
            }
            else
            {
                txtElk.Enabled = false;
                txtElk.Text = "0";
            }
        }

        private void txtElk_Click(object sender, EventArgs e)
        {
            txtElk.Text = "";
            txtElk.Focus();
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMushroom.Checked == true)
            {
                txtMushroom.Enabled = true;
            }
            else
            {
                txtMushroom.Enabled = false;
                txtMushroom.Text = "0";
            }
        }

        private void txtMushroom_Click(object sender, EventArgs e)
        {
            txtMushroom.Text = "";
            txtMushroom.Focus();
        }

        private void chkTurkey_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTurkey.Checked == true)
            {
                txtTurkey.Enabled = true;
            }
            else
            {
                txtTurkey.Enabled = false;
                txtTurkey.Text = "0";
            }
        }

        private void txtTurkey_Click(object sender, EventArgs e)
        {
            txtTurkey.Text = "";
            txtTurkey.Focus();
        }

        private void chkVeggie_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVeggie.Checked == true)
            {
                txtVeggie.Enabled = true;
            }
            else
            {
                txtVeggie.Enabled = false;
                txtVeggie.Text = "0";
            }
        }

        private void txtVeggie_Click(object sender, EventArgs e)
        {
            txtVeggie.Text = "";
            txtVeggie.Focus();
        }

        private void chkSalmon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSalmon.Checked == true)
            {
                txtSalmon.Enabled = true;
            }
            else
            {
                txtSalmon.Enabled = false;
                txtSalmon.Text = "0";
            }
        }

           private void txtSalmon_Click(object sender, EventArgs e)
        {
            txtSalmon.Text = "";
            txtSalmon.Focus();
        }

        private void chkTuna_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTuna.Checked == true)
            {
                txtTuna.Enabled = true;
            }
            else
            {
                txtTuna.Enabled = false;
                txtTuna.Text = "0";
            }
        }

        private void txtTuna_Click(object sender, EventArgs e)
        {
            txtTuna.Text = "";
            txtTuna.Focus();
        }

        

        private void chkShoestring_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShoestring.Checked == true)
            {
                txtShoestring.Enabled = true;
            }
            else
            {
                txtShoestring.Enabled = false;
                txtShoestring.Text = "0";
            }
        }

        private void txtShoestring_Click(object sender, EventArgs e)
        {
            txtShoestring.Text = "";
            txtShoestring.Focus();
        }

        private void chkBelgian_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBelgian.Checked == true)
            {
                txtBelgian.Enabled = true;
            }
            else
            {
                txtBelgian.Enabled = false;
                txtBelgian.Text = "0";
            }
        }

        private void txtBelgian_Click(object sender, EventArgs e)
        {
            txtBelgian.Text = "";
            txtBelgian.Focus();
        }


        private void chkStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStandard.Checked == true)
            {
                txtStandard.Enabled = true;
            }
            else
            {
                txtStandard.Enabled = false;
                txtStandard.Text = "0";
            }
        }

        private void txtStandard_Click(object sender, EventArgs e)
        {
            txtStandard.Text = "";
            txtStandard.Focus();
        }

        private void chkCrinkle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCrinkle.Checked == true)
            {
                txtCrinkle.Enabled = true;
            }
            else
            {
                txtCrinkle.Enabled = false;
                txtCrinkle.Text = "0";
            }
        }

        private void txtCrinkle_Click(object sender, EventArgs e)
        {
            txtCrinkle.Text = "";
            txtCrinkle.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSweet.Checked == true)
            {
               txtSweet.Enabled = true;
            }
            else
            {
                txtSweet.Enabled = false;
                txtSweet.Text = "0";
            }
        }

        private void txtSweet_Click(object sender, EventArgs e)
        {
            txtSweet.Text = "";
            txtSweet.Focus();
        }

        private void chkWaffle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWaffle.Checked == true)
            {
                txtWaffle.Enabled = true;
            }
            else
            {
                txtWaffle.Enabled = false;
                txtWaffle.Text = "0";
            }
        }


        private void txtKillburnChoco_Click(object sender, EventArgs e)
        {
            txtWaffle.Text = "";
            txtWaffle.Focus();
        }

        private void chkPotato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPotato.Checked == true)
            {
                txtPotato.Enabled = true;
            }
            else
            {
                txtPotato.Enabled = false;
                txtPotato.Text = "0";
            }
        }


        private void txtPotato_Click(object sender, EventArgs e)
        {
            txtPotato.Text = "";
            txtPotato.Focus();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will open text files
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will save text files
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            
            
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }
    }
}

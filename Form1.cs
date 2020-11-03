using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTORY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to exit", "Object Oriented Inheritances", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iExit==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void ResetTextBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Child cost_of_items = new Child();
            double iTax, iSubtotal, iTotal;

            cost_of_items.Apple = cost_of_items.pApple * Double.Parse(txtApple.Text);
            cost_of_items.Banana = cost_of_items.pBanana * Double.Parse(txtBanana.Text);
            cost_of_items.Cherry = cost_of_items.pCherry * Double.Parse(txtCherry.Text);
            cost_of_items.Grape = cost_of_items.pGrape * Double.Parse(txtGrape.Text);
            cost_of_items.Mango = cost_of_items.pMango * Double.Parse(txtMango.Text);
            cost_of_items.Orange = cost_of_items.pOrange * Double.Parse(txtOrange.Text);

            cost_of_items.Syrah = cost_of_items.pSyrah * Double.Parse(txtSyrah.Text);
            cost_of_items.Merlot = cost_of_items.pMerlot * Double.Parse(txtMerlot.Text);
            cost_of_items.Riesling = cost_of_items.pRiesling * Double.Parse(txtRiesling.Text);
            cost_of_items.Pinot = cost_of_items.pPinot * Double.Parse(txtPinot.Text);
            cost_of_items.Chardonnay = cost_of_items.pChardonnay * Double.Parse(txtChardonnay.Text);
            cost_of_items.Sauvignon = cost_of_items.pSauvignon * Double.Parse(txtSauvignon.Text);

            cost_of_items.MilkShake = cost_of_items.pMilkShake * Double.Parse(txtVanillaMilkShake.Text);
            cost_of_items.VanillaCone = cost_of_items.pVanillaCone * Double.Parse(txtVanillaCone.Text);
            cost_of_items.ClasVanilla = cost_of_items.pClasVanilla * Double.Parse(txtClassicVanilla.Text);
            cost_of_items.VanMilkShake = cost_of_items.pVanMilkShake * Double.Parse(txtVanillaMilkShake.Text);
            cost_of_items.ChocMilkShake = cost_of_items.pChocMilkShake * Double.Parse(txtChocolateMilk.Text);
            cost_of_items.StrawMilkShake = cost_of_items.pStrawMilkShake * Double.Parse(txtStrawberryMilk.Text);

            iSubtotal = cost_of_items.GetAmount();
            iTax = iSubtotal*0.15;
            iTotal = iTax + iSubtotal;

            string Tax = string.Format( "{0:C}", iTax);
            txtTax.Text = Convert.ToString(iTax);
            string Subtotal = string.Format( "{0:C}", iSubtotal);
            txtSubtotal.Text = Convert.ToString(iSubtotal);

            string Total = string.Format( "{0:C}",iTotal);
            txtTotal.Text = Convert.ToString(iTotal);

            string Fruit = string.Format("{0:C}",cost_of_items.itemscost1);
            txtFruits.Text = Convert.ToString(Fruit);

            string Wine = string.Format("{0:C}", cost_of_items.itemscost2);
            txtWine.Text = Convert.ToString(Wine);

            string IceCream = string.Format("{0:C}", cost_of_items.itemscost3);
            txtIceCream.Text = Convert.ToString(IceCream);


        }

        private void OnClick(object sender, EventArgs e)
        {
            TextBox b = sender as TextBox;
            b.Text = "";
            b.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtVanillaMilkShake_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChocolateMilk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChardonnay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSyrah_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSauvignon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRiesling_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMerlot_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClassicVanilla_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrange_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMango_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStrawberryMilk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCherry_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBanana_TextChanged(object sender, EventArgs e)
        {

        }

        private void Numbers_Only(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!char.IsDigit(ch)&&ch!=8)
            {
                e.Handled = true;
            }
        }
    }
}

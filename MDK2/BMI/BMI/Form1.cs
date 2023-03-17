using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class woman : Form
    {
        public woman()
        {
            InitializeComponent();
        }

        float index;
        float rost, ves;

        private void man_Click(object sender, EventArgs e)
        {
            pic_man.BorderStyle = BorderStyle.FixedSingle;
            pic_man.BackColor = Color.LightGray;

            pic_wom.BorderStyle = BorderStyle.None;
            pic_wom.BackColor = Color.WhiteSmoke;
        }

        private void pic_womClick(object sender, EventArgs e)
        {
            pic_wom.BorderStyle = BorderStyle.FixedSingle;
            pic_wom.BackColor = Color.LightGray;

            pic_man.BorderStyle = BorderStyle.None;
            pic_man.BackColor = Color.WhiteSmoke;
        }

        private void SCHET(object sender, EventArgs e)
        {
            rost = float.Parse(rost_v.Text);
            ves = float.Parse(ves_v.Text);
            rost /= 100;
            index = ves / (rost * rost);
            cof.Text = index.ToString("N");
            trackBar1.Value = (int)index;

            it1.Visible = false;
            it2.Visible = false;
            it3.Visible = false;
            it4.Visible = false;


            if (index < 18.5)
            {
                it1.Visible = true;
            }

            if (index >= 18.5 && index <= 24.9)
            {
                it2.Visible = true;
            }


            if (index >= 25 && index < 29.9)
            {
                it3.Visible = true;
            }


            if (index >= 30)
            {
                it4.Visible = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void it3_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            rost_v.Text = null;
            ves_v.Text = null;
            cof.Text = null;


            pic_man.BorderStyle= BorderStyle.None;
            pic_man.BackColor = Color.White;
            pic_wom.BorderStyle = BorderStyle.None;
            pic_wom.BackColor = Color.White;

            it1.Visible = false;
            it2.Visible = false;
            it3.Visible = false;
            it4.Visible = true;

            trackBar1.Value = 0;
        }
    }
}

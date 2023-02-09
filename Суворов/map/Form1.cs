using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void luj_Click(object sender, EventArgs e)
        {
            drinks.Visible = true;
            label_drink.Visible = true;


            energy.Visible = true;
            label_energy.Visible = true;


            information.Visible = true;
            label_info.Visible = true;


            medisime.Visible = true;
            label_medisine.Visible = true;


            toilet.Visible = true;
            label_toilet.Visible = true;


            Lokat.Text = "МКЦ Лужники";
        }

        private void luj2_Click(object sender, MouseEventArgs e)
        {
            drinks.Visible = false;
            energy.Visible = false;
            information.Visible = false;
            medisime.Visible = false;
            toilet.Visible = false;
            Lokat.Text = "";

            label_toilet.Visible = false;
            label_medisine.Visible = false;
            label_energy.Visible = false;
            label_drink.Visible = false;
            label_info.Visible = false;


        }

        private void two_Click(object sender, EventArgs e)
        {

            energy.Visible = true;
            energy.Location = new Point(697, 83);
            label_energy.Visible = true;
            label_energy.Location = new Point(773, 83);



            medisime.Visible = true;
            medisime.Location = new Point(697, 156);
            label_medisine.Visible = true;
            label_medisine.Location = new Point(775, 175);

            Lokat.Text = "Новодевичей монастрырь";
        }

        private void two2_Click(object sender, MouseEventArgs e)
        {
            drinks.Visible = false;
            energy.Visible = false;
            information.Visible = false;
            medisime.Visible = false;
            toilet.Visible = false;
            Lokat.Text = "";

            label_toilet.Visible = false;
            label_medisine.Visible = false;
            label_energy.Visible = false;
            label_drink.Visible = false;
            label_info.Visible = false;

        }

        private void three_Click(object sender, EventArgs e)
        {
            drinks.Visible = true;
            label_drink.Visible = true;


            information.Visible = true;
            information.Location = new Point(697, 156);
            label_info.Visible = true;
            label_info.Location = new Point(775, 175);


            toilet.Visible = true;
            toilet.Location = new Point(697, 235);
            label_toilet.Visible = true;
            label_toilet.Location = new Point(773, 245);

            Lokat.Text = "Метро Киевская";
        }

        private void three2(object sender, MouseEventArgs e)
        {
            drinks.Visible = false;
            energy.Visible = false;
            information.Visible = false;
            medisime.Visible = false;
            toilet.Visible = false;
            Lokat.Text = "";

            label_toilet.Visible = false;
            label_medisine.Visible = false;
            label_energy.Visible = false;
            label_drink.Visible = false;
            label_info.Visible = false;
        }

        private void four_Click(object sender, EventArgs e)
        {

            energy.Visible = true;
            energy.Location = new Point(697, 83);
            label_energy.Visible = true;
            label_energy.Location = new Point(773, 83);


            information.Visible = true;
            information.Location = new Point(697, 156);
            label_info.Visible = true;
            label_info.Location = new Point(775, 175);


            medisime.Visible = true;
            medisime.Location = new Point(697, 235);
            label_medisine.Visible = true;
            label_medisine.Location = new Point(773, 245);


            Lokat.Text = "МИД";
        }

        private void four2_click(object sender, MouseEventArgs e)
        {
            drinks.Visible = false;
            energy.Visible = false;
            information.Visible = false;
            medisime.Visible = false;
            toilet.Visible = false;
            Lokat.Text = "";

            label_toilet.Visible = false;
            label_medisine.Visible = false;
            label_energy.Visible = false;
            label_drink.Visible = false;
            label_info.Visible = false;
        }

        private void park_Click(object sender, EventArgs e)
        {
            drinks.Visible = true;
            label_drink.Visible = true;
            information.Visible = true;
            information.Location = new Point(697, 156);
            label_info.Visible = true;
            label_info.Location = new Point(775, 175);


            Lokat.Text = "Парк Горького";
        }

        private void park2_click(object sender, MouseEventArgs e)
        {
            drinks.Visible = false;
            energy.Visible = false;
            information.Visible = false;
            medisime.Visible = false;
            toilet.Visible = false;
            Lokat.Text = "";

            label_toilet.Visible = false;
            label_medisine.Visible = false;
            label_energy.Visible = false;
            label_drink.Visible = false;
            label_info.Visible = false;
        }

        private void ran_Click(object sender, EventArgs e)
        {
            drinks.Visible = true;
            label_drink.Visible = true;


            energy.Visible = true;
            label_energy.Visible = true;


            information.Visible = true;
            label_info.Visible = true;


            medisime.Visible = true;
            label_medisine.Visible = true;


            toilet.Visible = true;
            label_toilet.Visible = true;

            Lokat.Text = "РАН";
        }

        private void ran2_Click(object sender, MouseEventArgs e)
        {
            drinks.Visible = false;
            energy.Visible = false;
            information.Visible = false;
            medisime.Visible = false;
            toilet.Visible = false;
            Lokat.Text = "";

            label_toilet.Visible = false;
            label_medisine.Visible = false;
            label_energy.Visible = false;
            label_drink.Visible = false;
            label_info.Visible = false;
        }

        private void metro_Click(object sender, EventArgs e)
        {
            drinks.Visible = true;
            label_drink.Visible = true;



            medisime.Visible = true;
            medisime.Location = new Point(697, 156);
            label_medisine.Visible = true;
            label_medisine.Location = new Point(775, 175);


            toilet.Visible = true;
            toilet.Location = new Point(697, 235);
            label_toilet.Visible = true;
            label_toilet.Location = new Point(773, 245);


            Lokat.Text = "Метро Воробьёвы горы";
        }

        private void metro2(object sender, MouseEventArgs e)
        {
            drinks.Visible = false;
            energy.Visible = false;
            information.Visible = false;
            medisime.Visible = false;
            toilet.Visible = false;
            Lokat.Text = "";

            label_toilet.Visible = false;
            label_medisine.Visible = false;
            label_energy.Visible = false;
            label_drink.Visible = false;
            label_info.Visible = false;
        }

        private void stad_Click(object sender, EventArgs e)
        {
            drinks.Visible = true;
            label_drink.Visible = true;


            information.Visible = true;
            information.Location = new Point(697, 156);
            label_info.Visible = true;
            label_info.Location = new Point(775, 175);


            medisime.Visible = true;
            medisime.Location = new Point(697, 235);
            label_medisine.Visible = true;
            label_medisine.Location = new Point(773, 245);


            toilet.Visible = true;
            toilet.Location = new Point(697, 312);
            label_toilet.Visible = true;
            label_toilet.Location = new Point(775, 321);


            Lokat.Text = "Стадион Лужники";
        }

        private void stad2_Click(object sender, MouseEventArgs e)
        {
            drinks.Visible = false;
            energy.Visible = false;
            information.Visible = false;
            medisime.Visible = false;
            toilet.Visible = false;
            Lokat.Text = "";

            label_toilet.Visible = false;
            label_medisine.Visible = false;
            label_energy.Visible = false;
            label_drink.Visible = false;
            label_info.Visible = false;
        }

        private void star_one_Click(object sender, EventArgs e)
        {
            label_drink.Visible = true;
            label_drink.Text = "Samba Full Marathon";
            Lokat.Text = "Race start";
        }

        private void start1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label_drink.Visible = false;
            label_drink.Text = "Напитки";
            Lokat.Text = "";
        }

        private void start_two_Click(object sender, EventArgs e)
        {
            label_drink.Visible = true;
            label_drink.Text = "Jongo Half Marathon";
            Lokat.Text = "Race statr";
        }

        private void start_two_Claick(object sender, MouseEventArgs e)
        {
            label_drink.Visible = false;
            label_drink.Text = "Напитки";
            Lokat.Text = "";
        }

        private void start_three_click(object sender, EventArgs e)
        {
            label_drink.Visible = true;
            label_drink.Text = "Capoeira 5km fun Run";
            Lokat.Text = "Race statr";
        }

        private void start_three_Click(object sender, MouseEventArgs e)
        {
            label_drink.Visible = false;
            label_drink.Text = "Напитки";
            Lokat.Text = "";
        }
    }
}

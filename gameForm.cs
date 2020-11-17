using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Raulette
{
    public partial class gameForm : Form
    {
        ClassGame Class_obj = new ClassGame();
        public gameForm()
        {
            InitializeComponent();
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            //code to show image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Russian_Raulette.Resources.load.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            image_display.Image = bmp_Object;

            //code to play sound

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Russian_Raulette.Properties.Resources.Load1);

            Sound_Object.Play();

            Class_obj.load();
            spin_button.Enabled = true;
            load_button.Enabled = false;
        }

        private void spin_button_Click(object sender, EventArgs e)
        {
            //code to show image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Russian_Raulette.Resources.Spin.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            image_display.Image = bmp_Object;

            //code to play sound for spin gun chamber

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Properties.Resources.Spin1);

            Sound_Object.Play();

            MessageBox.Show(Class_obj.spin().ToString());

            spin_button.Enabled = false;
            shoot_button.Enabled = true;
            shootaway_button.Enabled = true;
        }

        private void shoot_button_Click(object sender, EventArgs e)
        {
            //code to show image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Russian_Raulette.Resources.load.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            image_display.Image = bmp_Object;

            //code for shoot bullet

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Properties.Resources.shoot);

            Sound_Object.Play();

            if (Class_obj.shoot() == 0)
            {
                MessageBox.Show("Good luck for next time");
            }
            else
            {
                MessageBox.Show("Bullets are finished");
            }
        }

        private void shootaway_button_Click(object sender, EventArgs e)
        {
            //code to show image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Russian_Raulette.Resources.Shootaway.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            image_display.Image = bmp_Object;

            //code to play sound 

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Properties.Resources.shoot);

            Sound_Object.Play();

            if (Class_obj.chance < 2)
            {
                if (Class_obj.shoot() == 0)
                {
                    MessageBox.Show("You WIN");
                    shoot_button.Enabled = false;
                    shootaway_button.Enabled = false;
                }
                else
                {
                    Class_obj.chance++;
                    if (Class_obj.chance == 2)
                    {
                        MessageBox.Show("Good luck for next time");
                        shoot_button.Enabled = false;
                        shootaway_button.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Bullets are finished");
                    }
                }
            }
        }

        //coding of play again game

        private void playagain_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //coding of exit game again

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

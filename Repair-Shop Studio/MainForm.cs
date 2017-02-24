using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Repair_Shop_Studio.Classes;

namespace Repair_Shop_Studio
{
    public partial class main : Form
    {
        
        public main()
        {
            InitializeComponent();
            
        }

        private void rtb_note_TextChanged(object sender, EventArgs e)
        {
           
            Properties.Settings.Default.NoteText = rtb_note.Text;
            Properties.Settings.Default.Save();
                
        }

        private void main_Load(object sender, EventArgs e)
        {
            StartUp startUp = new StartUp();
            startUp.ShowDialog();
            Login login = new Login();
            DialogResult dr =  login.ShowDialog();
            if (dr == DialogResult.Cancel)this.Close();
            else if (dr == DialogResult.OK)
            {
                GeneralPerposeClass.Entered_User    = login._user;
                GeneralPerposeClass.Enrered_User_ID = login._ID;
                
            }
            RTC.Start();
            this.Text = "سیستم متمرکز مدیریت تعمیرگاه        ***کاربر : " + GeneralPerposeClass.Entered_User;
            lbl_user.Text = "      " + GeneralPerposeClass.Entered_User;
            rtb_note.Text = Properties.Settings.Default.NoteText;
        }

        private void rtb_note_KeyPress(object sender, KeyPressEventArgs e)
        {
           // if (e.KeyChar == (char)Keys.Enter)
           // {
           //     rtb_note.Text += "\n-";
           //   
           // }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از خروج اطمینان دارید؟", "خروج",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_exit_MouseDown(object sender, MouseEventArgs e)
        {
            //btn_exit.Text = System.AppDomain.CurrentDomain.BaseDirectory;
          // btn_exit.Image = System.Drawing.Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory+"\\Resources\\ball.ico");
        }

        private void RTC_Tick(object sender, EventArgs e)
        {
            lbl_hour.Text = "      " + GeneralPerposeClass.getHour();
            lbl_date.Text = "    " + GeneralPerposeClass.getDate();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void lbl_about1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
        }

        private void btn_connection_Click(object sender, EventArgs e)
        {
            if (GeneralPerposeClass.checkConnection()==true)
            {
                MessageBox.Show("اتصال با موفقیقیت انجام شد");
            }
            else
            {
                MessageBox.Show("خطا 21.");
            }
        }
    }
}

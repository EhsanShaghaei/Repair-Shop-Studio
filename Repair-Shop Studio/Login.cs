using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Repair_Shop_Studio
{
    public partial class Login : Form
    {
       // public string logged_user { get; } = "ناشناخته";
        public int _ID;
        public string _user;
        public Login()
        {
            InitializeComponent();
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            
         
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"Select *from Users where Username = N'"
                                    +tb_user.Text+ "'  AND Password = N'"
                                    +tb_pass.Text+"'"; 
                                    
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("کاربر "+tb_user.Text+"خوش آمدید!","ورود",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    _ID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                    _user = dt.Rows[0]["Username"].ToString();
                    if (_user == tb_user.Text)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                        
                    }
                    
                   // Repair_Shop_Studio.Classes.GeneralPerposeClass.userbar = tb_user.Text;
                  //  this.Close();
                    
                }
                else
                {
                    MessageBox.Show( "خطا در اتصال!ورودی های خود را چک کنید!", "خطا", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    tb_pass.Text = tb_user.Text = String.Empty;
                    //foreach (Control item in Controls)
                    //{
                    //    if ()
                    //    {
                    //        item.Text = String.Empty;
                    //    }
                        
                    //}
                    tb_user.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                MessageBox.Show("خطا در اتصال به دیتابیس", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_pass.Text = tb_user.Text = String.Empty;
                tb_user.Focus();
                // throw;
            }
            //try
            //{
            //    SqlConnection cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            //    cn.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = "Select Username from Users Where ( Password = '"+
            //        tb_pass.Text+"') AND ( Username = '"+
            //        tb_user.Text+"' )";
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    if (dt.Rows.Count >0)
            //    {
            //        MessageBox.Show("hello");
            //       // Repair_Shop_Studio.Classes.GeneralPerposeClass.userbar=
                        
                    
            //    }
            //    else
            //    {
            //        MessageBox.Show("bye");
            //    }



            //}
            //catch (Exception)
            //{

            //    throw;
            //}
           
        }
    }
}

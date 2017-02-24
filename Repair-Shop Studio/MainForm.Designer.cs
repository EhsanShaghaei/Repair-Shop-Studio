namespace Repair_Shop_Studio
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_about1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_note = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RTC = new System.Windows.Forms.Timer(this.components);
            this.NI = new System.Windows.Forms.NotifyIcon(this.components);
            this.ni_bal = new System.Windows.Forms.NotifyIcon(this.components);
            this.label_about = new System.Windows.Forms.Label();
            this.lbl_hour = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Label();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_connection = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_store = new System.Windows.Forms.Button();
            this.btn_stuff = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.58242F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.41758F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(767, 468);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_about1);
            this.groupBox3.Controls.Add(this.label_about);
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Controls.Add(this.btn_exit);
            this.groupBox3.Location = new System.Drawing.Point(16, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 399);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "وضعیت";
            // 
            // lbl_about1
            // 
            this.lbl_about1.AutoSize = true;
            this.lbl_about1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_about1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_about1.Location = new System.Drawing.Point(65, 358);
            this.lbl_about1.Name = "lbl_about1";
            this.lbl_about1.Size = new System.Drawing.Size(36, 13);
            this.lbl_about1.TabIndex = 0;
            this.lbl_about1.Text = "درباره";
            this.lbl_about1.Click += new System.EventHandler(this.lbl_about1_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_hour, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_date, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_user, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 35);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(102, 168);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_report);
            this.groupBox1.Controls.Add(this.btn_connection);
            this.groupBox1.Controls.Add(this.btn_setting);
            this.groupBox1.Controls.Add(this.btn_store);
            this.groupBox1.Controls.Add(this.btn_stuff);
            this.groupBox1.Controls.Add(this.btn_customer);
            this.groupBox1.Location = new System.Drawing.Point(659, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "کنترل";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(136, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 399);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اعلانات";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(516, 385);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "آماده تحویل";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "در انتظار تعمیر";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(502, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "گزارش دستگاه های تحویل داده شده امروز";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(502, 353);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "یادداشت ها";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.rtb_note, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(499, 352);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // rtb_note
            // 
            this.rtb_note.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtb_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_note.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.rtb_note.Location = new System.Drawing.Point(3, 3);
            this.rtb_note.Name = "rtb_note";
            this.rtb_note.Size = new System.Drawing.Size(493, 344);
            this.rtb_note.TabIndex = 0;
            this.rtb_note.Text = "";
            this.rtb_note.TextChanged += new System.EventHandler(this.rtb_note_TextChanged);
            this.rtb_note.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtb_note_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // RTC
            // 
            this.RTC.Interval = 1000;
            this.RTC.Tick += new System.EventHandler(this.RTC_Tick);
            // 
            // NI
            // 
            this.NI.Text = "سیستم مدیریت متمرکز تعمیرگاه";
            this.NI.Visible = true;
            // 
            // ni_bal
            // 
            this.ni_bal.Icon = ((System.Drawing.Icon)(resources.GetObject("ni_bal.Icon")));
            this.ni_bal.Text = "سیستم مدیریت تعمیرگاه";
            this.ni_bal.Visible = true;
            // 
            // label_about
            // 
            this.label_about.AutoSize = true;
            this.label_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_about.Image = global::Repair_Shop_Studio.Properties.Resources.ball_yellow;
            this.label_about.Location = new System.Drawing.Point(59, 334);
            this.label_about.Name = "label_about";
            this.label_about.Size = new System.Drawing.Size(49, 60);
            this.label_about.TabIndex = 3;
            this.label_about.Text = "              \r\n\r\n\r\n\r\n";
            this.label_about.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_hour
            // 
            this.lbl_hour.AutoSize = true;
            this.lbl_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hour.Image = global::Repair_Shop_Studio.Properties.Resources.history1;
            this.lbl_hour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_hour.Location = new System.Drawing.Point(7, 0);
            this.lbl_hour.Name = "lbl_hour";
            this.lbl_hour.Size = new System.Drawing.Size(92, 17);
            this.lbl_hour.TabIndex = 1;
            this.lbl_hour.Text = "      hh:mm:ss";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Image = global::Repair_Shop_Studio.Properties.Resources.calendar;
            this.lbl_date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_date.Location = new System.Drawing.Point(7, 24);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(92, 17);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "      hh/mm/ss";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Image = global::Repair_Shop_Studio.Properties.Resources.adim1;
            this.lbl_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_user.Location = new System.Drawing.Point(39, 51);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(60, 17);
            this.lbl_user.TabIndex = 3;
            this.lbl_user.Text = "      user";
            // 
            // btn_exit
            // 
            this.btn_exit.AutoSize = true;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Image = global::Repair_Shop_Studio.Properties.Resources.delete;
            this.btn_exit.Location = new System.Drawing.Point(8, 341);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(50, 44);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "   ";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_exit_MouseDown);
            // 
            // btn_report
            // 
            this.btn_report.Image = global::Repair_Shop_Studio.Properties.Resources.chart;
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.Location = new System.Drawing.Point(5, 151);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(96, 52);
            this.btn_report.TabIndex = 6;
            this.btn_report.Text = "      گزارش";
            this.btn_report.UseVisualStyleBackColor = true;
            // 
            // btn_connection
            // 
            this.btn_connection.Image = global::Repair_Shop_Studio.Properties.Resources.web_connect;
            this.btn_connection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_connection.Location = new System.Drawing.Point(4, 325);
            this.btn_connection.Name = "btn_connection";
            this.btn_connection.Size = new System.Drawing.Size(96, 52);
            this.btn_connection.TabIndex = 5;
            this.btn_connection.Text = "            اتصال به         دیتابیس";
            this.btn_connection.UseVisualStyleBackColor = true;
            this.btn_connection.Click += new System.EventHandler(this.btn_connection_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Image = global::Repair_Shop_Studio.Properties.Resources.applications;
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Location = new System.Drawing.Point(4, 267);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(96, 52);
            this.btn_setting.TabIndex = 4;
            this.btn_setting.Text = "      تنظیمات";
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_store
            // 
            this.btn_store.Image = global::Repair_Shop_Studio.Properties.Resources.objects;
            this.btn_store.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_store.Location = new System.Drawing.Point(4, 209);
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(96, 52);
            this.btn_store.TabIndex = 3;
            this.btn_store.Text = "      انبار";
            this.btn_store.UseVisualStyleBackColor = true;
            // 
            // btn_stuff
            // 
            this.btn_stuff.Image = global::Repair_Shop_Studio.Properties.Resources.config;
            this.btn_stuff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stuff.Location = new System.Drawing.Point(4, 93);
            this.btn_stuff.Name = "btn_stuff";
            this.btn_stuff.Size = new System.Drawing.Size(96, 52);
            this.btn_stuff.TabIndex = 2;
            this.btn_stuff.Text = "      تعمیرکاران";
            this.btn_stuff.UseVisualStyleBackColor = true;
            // 
            // btn_customer
            // 
            this.btn_customer.Image = global::Repair_Shop_Studio.Properties.Resources.users;
            this.btn_customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customer.Location = new System.Drawing.Point(5, 35);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(96, 52);
            this.btn_customer.TabIndex = 1;
            this.btn_customer.Text = "      مشتریان";
            this.btn_customer.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(784, 474);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "سیستم متمرکز مدیریت تعمیرگاه";
            this.Load += new System.EventHandler(this.main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RichTextBox rtb_note;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label btn_exit;
        private System.Windows.Forms.Button btn_store;
        private System.Windows.Forms.Button btn_stuff;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Label lbl_hour;
        private System.Windows.Forms.Button btn_connection;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Timer RTC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Label label_about;
        private System.Windows.Forms.Label lbl_about1;
        private System.Windows.Forms.NotifyIcon NI;
        private System.Windows.Forms.NotifyIcon ni_bal;
    }
}


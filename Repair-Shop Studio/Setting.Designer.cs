namespace Repair_Shop_Studio
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.btn_locations = new System.Windows.Forms.Button();
            this.btn_models = new System.Windows.Forms.Button();
            this.btn_DeviceBrands = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_locations
            // 
            this.btn_locations.Image = global::Repair_Shop_Studio.Properties.Resources.upload;
            this.btn_locations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_locations.Location = new System.Drawing.Point(12, 146);
            this.btn_locations.Name = "btn_locations";
            this.btn_locations.Size = new System.Drawing.Size(160, 52);
            this.btn_locations.TabIndex = 2;
            this.btn_locations.Text = "مناطق پیشفرض";
            this.btn_locations.UseVisualStyleBackColor = true;
            // 
            // btn_models
            // 
            this.btn_models.Image = global::Repair_Shop_Studio.Properties.Resources.adreess_book;
            this.btn_models.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_models.Location = new System.Drawing.Point(12, 88);
            this.btn_models.Name = "btn_models";
            this.btn_models.Size = new System.Drawing.Size(160, 52);
            this.btn_models.TabIndex = 1;
            this.btn_models.Text = "مدل ها";
            this.btn_models.UseVisualStyleBackColor = true;
            // 
            // btn_DeviceBrands
            // 
            this.btn_DeviceBrands.Image = global::Repair_Shop_Studio.Properties.Resources.shopping_cart_full;
            this.btn_DeviceBrands.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeviceBrands.Location = new System.Drawing.Point(12, 30);
            this.btn_DeviceBrands.MaximumSize = new System.Drawing.Size(160, 52);
            this.btn_DeviceBrands.MinimumSize = new System.Drawing.Size(160, 52);
            this.btn_DeviceBrands.Name = "btn_DeviceBrands";
            this.btn_DeviceBrands.Size = new System.Drawing.Size(160, 52);
            this.btn_DeviceBrands.TabIndex = 0;
            this.btn_DeviceBrands.Text = "برندها";
            this.btn_DeviceBrands.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(183, 209);
            this.Controls.Add(this.btn_locations);
            this.Controls.Add(this.btn_models);
            this.Controls.Add(this.btn_DeviceBrands);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تنظیمات";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DeviceBrands;
        private System.Windows.Forms.Button btn_models;
        private System.Windows.Forms.Button btn_locations;
    }
}
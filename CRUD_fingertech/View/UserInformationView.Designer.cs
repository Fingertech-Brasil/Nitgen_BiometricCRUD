﻿namespace CRUD_User.View
{
    partial class UserInformationView
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
            tb_name = new TextBox();
            tx_name = new Label();
            SuspendLayout();
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(55, 75);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(237, 27);
            tb_name.TabIndex = 0;
            tb_name.TextAlign = HorizontalAlignment.Center;
            // 
            // tx_name
            // 
            tx_name.AutoSize = true;
            tx_name.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tx_name.Location = new Point(64, 60);
            tx_name.Name = "tx_name";
            tx_name.Size = new Size(62, 25);
            tx_name.TabIndex = 1;
            tx_name.Text = "Name";
            // 
            // UserInformationView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 159);
            Controls.Add(tx_name);
            Controls.Add(tb_name);
            Name = "UserInformationView";
            Text = "User Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_name;
        private Label tx_name;
    }
}
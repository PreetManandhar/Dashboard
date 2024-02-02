namespace frmDashboard
{
    partial class Ip4Validator
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
            this.label2 = new System.Windows.Forms.Label();
            this.exit_botton = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.validate_botton = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Today :";
            // 
            // exit_botton
            // 
            this.exit_botton.Location = new System.Drawing.Point(501, 288);
            this.exit_botton.Name = "exit_botton";
            this.exit_botton.Size = new System.Drawing.Size(187, 40);
            this.exit_botton.TabIndex = 4;
            this.exit_botton.Text = "Exit";
            this.exit_botton.UseVisualStyleBackColor = true;
            this.exit_botton.Click += new System.EventHandler(this.exit_botton_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(288, 288);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(187, 40);
            this.reset_button.TabIndex = 3;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // validate_botton
            // 
            this.validate_botton.Location = new System.Drawing.Point(62, 288);
            this.validate_botton.Name = "validate_botton";
            this.validate_botton.Size = new System.Drawing.Size(187, 40);
            this.validate_botton.TabIndex = 2;
            this.validate_botton.Text = "Validate IP";
            this.validate_botton.UseVisualStyleBackColor = true;
            this.validate_botton.Click += new System.EventHandler(this.validate_botton_Click);
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(288, 229);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(343, 22);
            this.textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Enter IP address: ";
            // 
            // Ip4Validator
            // 
            this.ClientSize = new System.Drawing.Size(735, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit_botton);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.validate_botton);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.label1);
            this.Name = "Ip4Validator";
            this.Text = "Ip4-Validator";
            this.Load += new System.EventHandler(this.Ip4Validator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit_botton;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button validate_botton;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label label1;
    }
}
namespace Local_Computer_Information
{
    partial class Form1
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
            this.LoggedinLBL = new System.Windows.Forms.Label();
            this.LoggedinTB = new System.Windows.Forms.TextBox();
            this.ComputerNameTB = new System.Windows.Forms.TextBox();
            this.ComputerNameLBL = new System.Windows.Forms.Label();
            this.ComputerSerialTB = new System.Windows.Forms.TextBox();
            this.CSerialNumberLBL = new System.Windows.Forms.Label();
            this.ComputerModelTB = new System.Windows.Forms.TextBox();
            this.ComputerModelLBL = new System.Windows.Forms.Label();
            this.TimeRebootTB = new System.Windows.Forms.TextBox();
            this.TimeRebootLBL = new System.Windows.Forms.Label();
            this.RebootReqTB = new System.Windows.Forms.TextBox();
            this.RebootReqLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoggedinLBL
            // 
            this.LoggedinLBL.AutoSize = true;
            this.LoggedinLBL.Location = new System.Drawing.Point(13, 13);
            this.LoggedinLBL.Name = "LoggedinLBL";
            this.LoggedinLBL.Size = new System.Drawing.Size(77, 13);
            this.LoggedinLBL.TabIndex = 0;
            this.LoggedinLBL.Text = "Logged in user";
            // 
            // LoggedinTB
            // 
            this.LoggedinTB.Location = new System.Drawing.Point(16, 29);
            this.LoggedinTB.Name = "LoggedinTB";
            this.LoggedinTB.ReadOnly = true;
            this.LoggedinTB.Size = new System.Drawing.Size(100, 20);
            this.LoggedinTB.TabIndex = 1;
            // 
            // ComputerNameTB
            // 
            this.ComputerNameTB.Location = new System.Drawing.Point(132, 29);
            this.ComputerNameTB.Name = "ComputerNameTB";
            this.ComputerNameTB.ReadOnly = true;
            this.ComputerNameTB.Size = new System.Drawing.Size(100, 20);
            this.ComputerNameTB.TabIndex = 3;
            // 
            // ComputerNameLBL
            // 
            this.ComputerNameLBL.AutoSize = true;
            this.ComputerNameLBL.Location = new System.Drawing.Point(129, 13);
            this.ComputerNameLBL.Name = "ComputerNameLBL";
            this.ComputerNameLBL.Size = new System.Drawing.Size(83, 13);
            this.ComputerNameLBL.TabIndex = 2;
            this.ComputerNameLBL.Text = "Computer Name";
            // 
            // ComputerSerialTB
            // 
            this.ComputerSerialTB.Location = new System.Drawing.Point(248, 29);
            this.ComputerSerialTB.Name = "ComputerSerialTB";
            this.ComputerSerialTB.ReadOnly = true;
            this.ComputerSerialTB.Size = new System.Drawing.Size(100, 20);
            this.ComputerSerialTB.TabIndex = 5;
            // 
            // CSerialNumberLBL
            // 
            this.CSerialNumberLBL.AutoSize = true;
            this.CSerialNumberLBL.Location = new System.Drawing.Point(245, 13);
            this.CSerialNumberLBL.Name = "CSerialNumberLBL";
            this.CSerialNumberLBL.Size = new System.Drawing.Size(91, 13);
            this.CSerialNumberLBL.TabIndex = 4;
            this.CSerialNumberLBL.Text = "Computer Serial #";
            // 
            // ComputerModelTB
            // 
            this.ComputerModelTB.Location = new System.Drawing.Point(364, 29);
            this.ComputerModelTB.Name = "ComputerModelTB";
            this.ComputerModelTB.ReadOnly = true;
            this.ComputerModelTB.Size = new System.Drawing.Size(100, 20);
            this.ComputerModelTB.TabIndex = 7;
            // 
            // ComputerModelLBL
            // 
            this.ComputerModelLBL.AutoSize = true;
            this.ComputerModelLBL.Location = new System.Drawing.Point(361, 13);
            this.ComputerModelLBL.Name = "ComputerModelLBL";
            this.ComputerModelLBL.Size = new System.Drawing.Size(84, 13);
            this.ComputerModelLBL.TabIndex = 6;
            this.ComputerModelLBL.Text = "Computer Model";
            // 
            // TimeRebootTB
            // 
            this.TimeRebootTB.Location = new System.Drawing.Point(16, 78);
            this.TimeRebootTB.Name = "TimeRebootTB";
            this.TimeRebootTB.ReadOnly = true;
            this.TimeRebootTB.Size = new System.Drawing.Size(216, 20);
            this.TimeRebootTB.TabIndex = 9;
            // 
            // TimeRebootLBL
            // 
            this.TimeRebootLBL.AutoSize = true;
            this.TimeRebootLBL.Location = new System.Drawing.Point(13, 62);
            this.TimeRebootLBL.Name = "TimeRebootLBL";
            this.TimeRebootLBL.Size = new System.Drawing.Size(110, 13);
            this.TimeRebootLBL.TabIndex = 8;
            this.TimeRebootLBL.Text = "Time since last reboot";
            // 
            // RebootReqTB
            // 
            this.RebootReqTB.Location = new System.Drawing.Point(248, 78);
            this.RebootReqTB.Name = "RebootReqTB";
            this.RebootReqTB.ReadOnly = true;
            this.RebootReqTB.Size = new System.Drawing.Size(100, 20);
            this.RebootReqTB.TabIndex = 11;
            // 
            // RebootReqLBL
            // 
            this.RebootReqLBL.AutoSize = true;
            this.RebootReqLBL.Location = new System.Drawing.Point(245, 62);
            this.RebootReqLBL.Name = "RebootReqLBL";
            this.RebootReqLBL.Size = new System.Drawing.Size(88, 13);
            this.RebootReqLBL.TabIndex = 10;
            this.RebootReqLBL.Text = "Reboot Required";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RebootReqTB);
            this.Controls.Add(this.RebootReqLBL);
            this.Controls.Add(this.TimeRebootTB);
            this.Controls.Add(this.TimeRebootLBL);
            this.Controls.Add(this.ComputerModelTB);
            this.Controls.Add(this.ComputerModelLBL);
            this.Controls.Add(this.ComputerSerialTB);
            this.Controls.Add(this.CSerialNumberLBL);
            this.Controls.Add(this.ComputerNameTB);
            this.Controls.Add(this.ComputerNameLBL);
            this.Controls.Add(this.LoggedinTB);
            this.Controls.Add(this.LoggedinLBL);
            this.Name = "Form1";
            this.Text = "Local Computer Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoggedinLBL;
        private System.Windows.Forms.TextBox LoggedinTB;
        private System.Windows.Forms.TextBox ComputerNameTB;
        private System.Windows.Forms.Label ComputerNameLBL;
        private System.Windows.Forms.TextBox ComputerSerialTB;
        private System.Windows.Forms.Label CSerialNumberLBL;
        private System.Windows.Forms.TextBox ComputerModelTB;
        private System.Windows.Forms.Label ComputerModelLBL;
        private System.Windows.Forms.TextBox TimeRebootTB;
        private System.Windows.Forms.Label TimeRebootLBL;
        private System.Windows.Forms.TextBox RebootReqTB;
        private System.Windows.Forms.Label RebootReqLBL;
    }
}


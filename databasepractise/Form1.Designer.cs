namespace databasepractise
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblConnect = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnName = new System.Windows.Forms.Button();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 107);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(191, 61);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.Location = new System.Drawing.Point(74, 39);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(61, 13);
            this.lblConnect.TabIndex = 1;
            this.lblConnect.Text = "Connection";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(489, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label1";
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(447, 107);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(133, 61);
            this.btnName.TabIndex = 3;
            this.btnName.Text = "Get Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(360, 281);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(141, 20);
            this.txtUpdateName.TabIndex = 4;
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.Location = new System.Drawing.Point(348, 319);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(166, 72);
            this.btnUpdateName.TabIndex = 5;
            this.btnUpdateName.Text = "Update Name";
            this.btnUpdateName.UseVisualStyleBackColor = true;
            this.btnUpdateName.Click += new System.EventHandler(this.btnUpdateName_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(83, 281);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(130, 20);
            this.txtInsert.TabIndex = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(77, 319);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(136, 31);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.btnUpdateName);
            this.Controls.Add(this.txtUpdateName);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblConnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Button btnUpdateName;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Button btnInsert;
    }
}


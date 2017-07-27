namespace WindowsFormsApplication
{
    partial class carga
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
            this.button1 = new System.Windows.Forms.Button();
            this.IDtextBox1 = new System.Windows.Forms.TextBox();
            this.RZtextBox2 = new System.Windows.Forms.TextBox();
            this.CUITtextBox3 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.rz = new System.Windows.Forms.Label();
            this.cuit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDtextBox1
            // 
            this.IDtextBox1.Location = new System.Drawing.Point(118, 55);
            this.IDtextBox1.Name = "IDtextBox1";
            this.IDtextBox1.Size = new System.Drawing.Size(100, 20);
            this.IDtextBox1.TabIndex = 1;
            // 
            // RZtextBox2
            // 
            this.RZtextBox2.Location = new System.Drawing.Point(118, 107);
            this.RZtextBox2.Name = "RZtextBox2";
            this.RZtextBox2.Size = new System.Drawing.Size(100, 20);
            this.RZtextBox2.TabIndex = 2;
            // 
            // CUITtextBox3
            // 
            this.CUITtextBox3.Location = new System.Drawing.Point(118, 162);
            this.CUITtextBox3.Name = "CUITtextBox3";
            this.CUITtextBox3.Size = new System.Drawing.Size(100, 20);
            this.CUITtextBox3.TabIndex = 3;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(76, 62);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 4;
            this.id.Text = "id";
            this.id.Click += new System.EventHandler(this.label1_Click);
            // 
            // rz
            // 
            this.rz.AutoSize = true;
            this.rz.Location = new System.Drawing.Point(28, 114);
            this.rz.Name = "rz";
            this.rz.Size = new System.Drawing.Size(63, 13);
            this.rz.TabIndex = 5;
            this.rz.Text = "razon social";
            // 
            // cuit
            // 
            this.cuit.AutoSize = true;
            this.cuit.Location = new System.Drawing.Point(56, 169);
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(24, 13);
            this.cuit.TabIndex = 6;
            this.cuit.Text = "cuit";
            // 
            // carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cuit);
            this.Controls.Add(this.rz);
            this.Controls.Add(this.id);
            this.Controls.Add(this.CUITtextBox3);
            this.Controls.Add(this.RZtextBox2);
            this.Controls.Add(this.IDtextBox1);
            this.Controls.Add(this.button1);
            this.Name = "carga";
            this.Text = "carga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IDtextBox1;
        private System.Windows.Forms.TextBox RZtextBox2;
        private System.Windows.Forms.TextBox CUITtextBox3;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label rz;
        private System.Windows.Forms.Label cuit;
    }
}
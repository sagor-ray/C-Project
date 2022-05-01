namespace ConnectionProject
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
            this.addb = new System.Windows.Forms.Button();
            this.clearb = new System.Windows.Forms.Button();
            this.namel = new System.Windows.Forms.Label();
            this.idl = new System.Windows.Forms.Label();
            this.namet = new System.Windows.Forms.TextBox();
            this.idt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addb
            // 
            this.addb.Location = new System.Drawing.Point(194, 162);
            this.addb.Name = "addb";
            this.addb.Size = new System.Drawing.Size(55, 27);
            this.addb.TabIndex = 0;
            this.addb.Text = "ADD";
            this.addb.UseVisualStyleBackColor = true;
            this.addb.Click += new System.EventHandler(this.addb_Click);
            // 
            // clearb
            // 
            this.clearb.Location = new System.Drawing.Point(104, 162);
            this.clearb.Name = "clearb";
            this.clearb.Size = new System.Drawing.Size(64, 27);
            this.clearb.TabIndex = 1;
            this.clearb.Text = "Clear";
            this.clearb.UseVisualStyleBackColor = true;
            this.clearb.Click += new System.EventHandler(this.clearb_Click);
            // 
            // namel
            // 
            this.namel.AutoSize = true;
            this.namel.Location = new System.Drawing.Point(38, 34);
            this.namel.Name = "namel";
            this.namel.Size = new System.Drawing.Size(35, 13);
            this.namel.TabIndex = 2;
            this.namel.Text = "Name";
            // 
            // idl
            // 
            this.idl.AutoSize = true;
            this.idl.Location = new System.Drawing.Point(38, 72);
            this.idl.Name = "idl";
            this.idl.Size = new System.Drawing.Size(18, 13);
            this.idl.TabIndex = 3;
            this.idl.Text = "ID";
            // 
            // namet
            // 
            this.namet.Location = new System.Drawing.Point(104, 34);
            this.namet.Name = "namet";
            this.namet.Size = new System.Drawing.Size(145, 20);
            this.namet.TabIndex = 4;
            // 
            // idt
            // 
            this.idt.Location = new System.Drawing.Point(104, 72);
            this.idt.Name = "idt";
            this.idt.Size = new System.Drawing.Size(145, 20);
            this.idt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.idt);
            this.Controls.Add(this.namet);
            this.Controls.Add(this.idl);
            this.Controls.Add(this.namel);
            this.Controls.Add(this.clearb);
            this.Controls.Add(this.addb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addb;
        private System.Windows.Forms.Button clearb;
        private System.Windows.Forms.Label namel;
        private System.Windows.Forms.Label idl;
        private System.Windows.Forms.TextBox namet;
        private System.Windows.Forms.TextBox idt;
    }
}


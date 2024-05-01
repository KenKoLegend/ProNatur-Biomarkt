namespace ProNatur_Biomarkt_GmbH.BillScreenWindows
{
    partial class BillScreenWindowCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillScreenWindowCreate));
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxCreateVorname = new System.Windows.Forms.TextBox();
            this.textboxCreateRID = new System.Windows.Forms.TextBox();
            this.textboxCreatePreis = new System.Windows.Forms.TextBox();
            this.richtextboxCreateInhalt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(185, 326);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(119, 28);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Hinzufügen";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("SamsungOneUILatin 500C", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "RechnungsID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("SamsungOneUILatin 500C", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vorname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("SamsungOneUILatin 500C", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(30, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Inhalt :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("SamsungOneUILatin 500C", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(35, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preis :";
            // 
            // textboxCreateVorname
            // 
            this.textboxCreateVorname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxCreateVorname.Location = new System.Drawing.Point(89, 50);
            this.textboxCreateVorname.Name = "textboxCreateVorname";
            this.textboxCreateVorname.Size = new System.Drawing.Size(100, 20);
            this.textboxCreateVorname.TabIndex = 6;
            // 
            // textboxCreateRID
            // 
            this.textboxCreateRID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textboxCreateRID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxCreateRID.Enabled = false;
            this.textboxCreateRID.Location = new System.Drawing.Point(222, 10);
            this.textboxCreateRID.Name = "textboxCreateRID";
            this.textboxCreateRID.ReadOnly = true;
            this.textboxCreateRID.Size = new System.Drawing.Size(82, 20);
            this.textboxCreateRID.TabIndex = 7;
            // 
            // textboxCreatePreis
            // 
            this.textboxCreatePreis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxCreatePreis.Location = new System.Drawing.Point(89, 85);
            this.textboxCreatePreis.Name = "textboxCreatePreis";
            this.textboxCreatePreis.Size = new System.Drawing.Size(100, 20);
            this.textboxCreatePreis.TabIndex = 8;
            // 
            // richtextboxCreateInhalt
            // 
            this.richtextboxCreateInhalt.Location = new System.Drawing.Point(13, 146);
            this.richtextboxCreateInhalt.Name = "richtextboxCreateInhalt";
            this.richtextboxCreateInhalt.Size = new System.Drawing.Size(291, 164);
            this.richtextboxCreateInhalt.TabIndex = 9;
            this.richtextboxCreateInhalt.Text = "";
            // 
            // BillScreenWindowCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(316, 366);
            this.Controls.Add(this.richtextboxCreateInhalt);
            this.Controls.Add(this.textboxCreatePreis);
            this.Controls.Add(this.textboxCreateRID);
            this.Controls.Add(this.textboxCreateVorname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillScreenWindowCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxCreateVorname;
        private System.Windows.Forms.TextBox textboxCreateRID;
        private System.Windows.Forms.TextBox textboxCreatePreis;
        private System.Windows.Forms.RichTextBox richtextboxCreateInhalt;
    }
}
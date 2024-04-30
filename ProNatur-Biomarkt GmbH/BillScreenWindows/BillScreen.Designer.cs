namespace ProNatur_Biomarkt_GmbH
{
    partial class BillScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillScreen));
            this.label2 = new System.Windows.Forms.Label();
            this.billingDGV = new System.Windows.Forms.DataGridView();
            this.btnBillScreenCreate = new System.Windows.Forms.Button();
            this.btnBillScreenEdit = new System.Windows.Forms.Button();
            this.btnBillScreenDelete = new System.Windows.Forms.Button();
            this.btnBillScreenBack = new System.Windows.Forms.Button();
            this.btnBillScreenShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billingDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SamsungOneUILatin 500C", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rechnungen : ";
            // 
            // billingDGV
            // 
            this.billingDGV.AllowUserToAddRows = false;
            this.billingDGV.AllowUserToDeleteRows = false;
            this.billingDGV.AllowUserToResizeColumns = false;
            this.billingDGV.AllowUserToResizeRows = false;
            this.billingDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billingDGV.BackgroundColor = System.Drawing.Color.LightGray;
            this.billingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.billingDGV.Location = new System.Drawing.Point(12, 140);
            this.billingDGV.MultiSelect = false;
            this.billingDGV.Name = "billingDGV";
            this.billingDGV.RowHeadersVisible = false;
            this.billingDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.billingDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.billingDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.billingDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.billingDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.billingDGV.RowTemplate.ReadOnly = true;
            this.billingDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.billingDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billingDGV.Size = new System.Drawing.Size(613, 239);
            this.billingDGV.TabIndex = 2;
            this.billingDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billingDGV_CellClick);
            // 
            // btnBillScreenCreate
            // 
            this.btnBillScreenCreate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBillScreenCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillScreenCreate.Location = new System.Drawing.Point(349, 111);
            this.btnBillScreenCreate.Name = "btnBillScreenCreate";
            this.btnBillScreenCreate.Size = new System.Drawing.Size(88, 23);
            this.btnBillScreenCreate.TabIndex = 3;
            this.btnBillScreenCreate.Text = "Erstellen";
            this.btnBillScreenCreate.UseVisualStyleBackColor = false;
            this.btnBillScreenCreate.Click += new System.EventHandler(this.btnBillScreenCreate_Click);
            // 
            // btnBillScreenEdit
            // 
            this.btnBillScreenEdit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBillScreenEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillScreenEdit.Location = new System.Drawing.Point(443, 111);
            this.btnBillScreenEdit.Name = "btnBillScreenEdit";
            this.btnBillScreenEdit.Size = new System.Drawing.Size(88, 23);
            this.btnBillScreenEdit.TabIndex = 4;
            this.btnBillScreenEdit.Text = "Editieren";
            this.btnBillScreenEdit.UseVisualStyleBackColor = false;
            this.btnBillScreenEdit.Click += new System.EventHandler(this.btnBillScreenEdit_Click);
            // 
            // btnBillScreenDelete
            // 
            this.btnBillScreenDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBillScreenDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillScreenDelete.Location = new System.Drawing.Point(537, 111);
            this.btnBillScreenDelete.Name = "btnBillScreenDelete";
            this.btnBillScreenDelete.Size = new System.Drawing.Size(88, 23);
            this.btnBillScreenDelete.TabIndex = 5;
            this.btnBillScreenDelete.Text = "Löschen";
            this.btnBillScreenDelete.UseVisualStyleBackColor = false;
            this.btnBillScreenDelete.Click += new System.EventHandler(this.btnBillScreenDelete_Click);
            // 
            // btnBillScreenBack
            // 
            this.btnBillScreenBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBillScreenBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillScreenBack.Location = new System.Drawing.Point(12, 12);
            this.btnBillScreenBack.Name = "btnBillScreenBack";
            this.btnBillScreenBack.Size = new System.Drawing.Size(88, 23);
            this.btnBillScreenBack.TabIndex = 6;
            this.btnBillScreenBack.Text = "Zurück";
            this.btnBillScreenBack.UseVisualStyleBackColor = false;
            this.btnBillScreenBack.Click += new System.EventHandler(this.btnBillScreenBack_Click);
            // 
            // btnBillScreenShow
            // 
            this.btnBillScreenShow.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBillScreenShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillScreenShow.Location = new System.Drawing.Point(255, 111);
            this.btnBillScreenShow.Name = "btnBillScreenShow";
            this.btnBillScreenShow.Size = new System.Drawing.Size(88, 23);
            this.btnBillScreenShow.TabIndex = 7;
            this.btnBillScreenShow.Text = "Anzeigen";
            this.btnBillScreenShow.UseVisualStyleBackColor = false;
            this.btnBillScreenShow.Click += new System.EventHandler(this.btnBillScreenShow_Click);
            // 
            // BillScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(637, 391);
            this.Controls.Add(this.btnBillScreenShow);
            this.Controls.Add(this.btnBillScreenBack);
            this.Controls.Add(this.btnBillScreenDelete);
            this.Controls.Add(this.btnBillScreenEdit);
            this.Controls.Add(this.btnBillScreenCreate);
            this.Controls.Add(this.billingDGV);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillScreen";
            ((System.ComponentModel.ISupportInitialize)(this.billingDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView billingDGV;
        private System.Windows.Forms.Button btnBillScreenCreate;
        private System.Windows.Forms.Button btnBillScreenEdit;
        private System.Windows.Forms.Button btnBillScreenDelete;
        private System.Windows.Forms.Button btnBillScreenBack;
        private System.Windows.Forms.Button btnBillScreenShow;
    }
}
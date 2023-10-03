namespace HesapMakinesi
{
    partial class HistoryForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgHistory = new System.Windows.Forms.DataGridView();
            this.btnSellect = new System.Windows.Forms.Button();
            this.tbFindId = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(849, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 574);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(20, 549);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(202, 43);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Geçmişi Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgHistory
            // 
            this.dgHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistory.Location = new System.Drawing.Point(20, 69);
            this.dgHistory.Name = "dgHistory";
            this.dgHistory.RowHeadersWidth = 62;
            this.dgHistory.RowTemplate.Height = 28;
            this.dgHistory.Size = new System.Drawing.Size(820, 472);
            this.dgHistory.TabIndex = 4;
            // 
            // btnSellect
            // 
            this.btnSellect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSellect.Location = new System.Drawing.Point(638, 549);
            this.btnSellect.Name = "btnSellect";
            this.btnSellect.Size = new System.Drawing.Size(202, 43);
            this.btnSellect.TabIndex = 5;
            this.btnSellect.Text = "Seçilen Geçmişi Sil";
            this.btnSellect.UseVisualStyleBackColor = false;
            this.btnSellect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tbFindId
            // 
            this.tbFindId.Location = new System.Drawing.Point(256, 555);
            this.tbFindId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFindId.Name = "tbFindId";
            this.tbFindId.Size = new System.Drawing.Size(148, 26);
            this.tbFindId.TabIndex = 6;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFind.Location = new System.Drawing.Point(429, 548);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(202, 43);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Bul";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRefresh.Location = new System.Drawing.Point(20, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(820, 43);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(993, 605);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbFindId);
            this.Controls.Add(this.btnSellect);
            this.Controls.Add(this.dgHistory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgHistory;
        private System.Windows.Forms.Button btnSellect;
        private System.Windows.Forms.TextBox tbFindId;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnRefresh;
    }
}
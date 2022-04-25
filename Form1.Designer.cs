namespace W08_Praktikum_Kei
{
    partial class formPertandingan
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
            this.cBoxTimHome = new System.Windows.Forms.ComboBox();
            this.cBoxTimAway = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblManagerHome = new System.Windows.Forms.Label();
            this.lblCaptainHome = new System.Windows.Forms.Label();
            this.lblManagerAway = new System.Windows.Forms.Label();
            this.lblCaptainAway = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.dtgMatch = new System.Windows.Forms.DataGridView();
            this.lbSkor = new System.Windows.Forms.Label();
            this.lbTanggal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxTimHome
            // 
            this.cBoxTimHome.FormattingEnabled = true;
            this.cBoxTimHome.Location = new System.Drawing.Point(25, 12);
            this.cBoxTimHome.Name = "cBoxTimHome";
            this.cBoxTimHome.Size = new System.Drawing.Size(246, 24);
            this.cBoxTimHome.TabIndex = 0;
            this.cBoxTimHome.SelectedIndexChanged += new System.EventHandler(this.cBoxTimHome_SelectedIndexChanged);
            // 
            // cBoxTimAway
            // 
            this.cBoxTimAway.FormattingEnabled = true;
            this.cBoxTimAway.Location = new System.Drawing.Point(368, 12);
            this.cBoxTimAway.Name = "cBoxTimAway";
            this.cBoxTimAway.Size = new System.Drawing.Size(253, 24);
            this.cBoxTimAway.TabIndex = 1;
            this.cBoxTimAway.SelectedIndexChanged += new System.EventHandler(this.cBoxTimAway_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manager :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Captain :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Manager :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Captain :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Stadium :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Capacity :";
            // 
            // lblManagerHome
            // 
            this.lblManagerHome.AutoSize = true;
            this.lblManagerHome.Location = new System.Drawing.Point(124, 81);
            this.lblManagerHome.Name = "lblManagerHome";
            this.lblManagerHome.Size = new System.Drawing.Size(16, 16);
            this.lblManagerHome.TabIndex = 9;
            this.lblManagerHome.Text = "...";
            // 
            // lblCaptainHome
            // 
            this.lblCaptainHome.AutoSize = true;
            this.lblCaptainHome.Location = new System.Drawing.Point(124, 110);
            this.lblCaptainHome.Name = "lblCaptainHome";
            this.lblCaptainHome.Size = new System.Drawing.Size(16, 16);
            this.lblCaptainHome.TabIndex = 10;
            this.lblCaptainHome.Text = "...";
            // 
            // lblManagerAway
            // 
            this.lblManagerAway.AutoSize = true;
            this.lblManagerAway.Location = new System.Drawing.Point(454, 81);
            this.lblManagerAway.Name = "lblManagerAway";
            this.lblManagerAway.Size = new System.Drawing.Size(16, 16);
            this.lblManagerAway.TabIndex = 11;
            this.lblManagerAway.Text = "...";
            // 
            // lblCaptainAway
            // 
            this.lblCaptainAway.AutoSize = true;
            this.lblCaptainAway.Location = new System.Drawing.Point(454, 110);
            this.lblCaptainAway.Name = "lblCaptainAway";
            this.lblCaptainAway.Size = new System.Drawing.Size(16, 16);
            this.lblCaptainAway.TabIndex = 12;
            this.lblCaptainAway.Text = "...";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(299, 192);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(16, 16);
            this.lblStadium.TabIndex = 13;
            this.lblStadium.Text = "...";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(299, 220);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(16, 16);
            this.lblCapacity.TabIndex = 14;
            this.lblCapacity.Text = "...";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(225, 253);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dtgMatch
            // 
            this.dtgMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMatch.Location = new System.Drawing.Point(25, 347);
            this.dtgMatch.Name = "dtgMatch";
            this.dtgMatch.RowHeadersWidth = 51;
            this.dtgMatch.RowTemplate.Height = 24;
            this.dtgMatch.Size = new System.Drawing.Size(654, 202);
            this.dtgMatch.TabIndex = 16;
            // 
            // lbSkor
            // 
            this.lbSkor.AutoSize = true;
            this.lbSkor.Location = new System.Drawing.Point(295, 318);
            this.lbSkor.Name = "lbSkor";
            this.lbSkor.Size = new System.Drawing.Size(16, 16);
            this.lbSkor.TabIndex = 20;
            this.lbSkor.Text = "...";
            // 
            // lbTanggal
            // 
            this.lbTanggal.AutoSize = true;
            this.lbTanggal.Location = new System.Drawing.Point(295, 290);
            this.lbTanggal.Name = "lbTanggal";
            this.lbTanggal.Size = new System.Drawing.Size(16, 16);
            this.lbTanggal.TabIndex = 19;
            this.lbTanggal.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Skor :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(222, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tanggal :";
            // 
            // formPertandingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 556);
            this.Controls.Add(this.lbSkor);
            this.Controls.Add(this.lbTanggal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtgMatch);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lblCaptainAway);
            this.Controls.Add(this.lblManagerAway);
            this.Controls.Add(this.lblCaptainHome);
            this.Controls.Add(this.lblManagerHome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxTimAway);
            this.Controls.Add(this.cBoxTimHome);
            this.Name = "formPertandingan";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.formPertandingan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxTimHome;
        private System.Windows.Forms.ComboBox cBoxTimAway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblManagerHome;
        private System.Windows.Forms.Label lblCaptainHome;
        private System.Windows.Forms.Label lblManagerAway;
        private System.Windows.Forms.Label lblCaptainAway;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridView dtgMatch;
        private System.Windows.Forms.Label lbSkor;
        private System.Windows.Forms.Label lbTanggal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}


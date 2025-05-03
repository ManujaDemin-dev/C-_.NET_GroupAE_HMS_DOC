namespace TrustWell_Hospital_Doctor
{
    partial class Dashbord1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cuiPanel1.SuspendLayout();
            this.cuiPanel2.SuspendLayout();
            this.cuiPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(32, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of completed appointments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(225, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 49);
            this.label4.TabIndex = 1;
            this.label4.Text = "5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name,
            this.mobile});
            this.dataGridView1.Location = new System.Drawing.Point(30, 312);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1983, 716);
            this.dataGridView1.TabIndex = 2;
            // 
            // number
            // 
            this.number.HeaderText = "Number";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Patient Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // mobile
            // 
            this.mobile.HeaderText = "Mobile Number";
            this.mobile.MinimumWidth = 6;
            this.mobile.Name = "mobile";
            this.mobile.Width = 125;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.cuiLabel1);
            this.cuiPanel1.Controls.Add(this.label7);
            this.cuiPanel1.Location = new System.Drawing.Point(41, 17);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.SystemColors.ControlLight;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.SystemColors.ControlLight;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(13);
            this.cuiPanel1.Size = new System.Drawing.Size(581, 171);
            this.cuiPanel1.TabIndex = 3;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel1.Content = "You\\ can\\ choose\\ a\\ patient\\ here\\ to\\ enter\\ into\\ their\\ details\\.";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cuiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel1.Location = new System.Drawing.Point(34, 80);
            this.cuiLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(542, 72);
            this.cuiLabel1.TabIndex = 11;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.label7.Location = new System.Drawing.Point(26, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(587, 58);
            this.label7.TabIndex = 10;
            this.label7.Text = "DASHBOARD";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.Controls.Add(this.label4);
            this.cuiPanel2.Controls.Add(this.label3);
            this.cuiPanel2.Location = new System.Drawing.Point(666, 17);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(13);
            this.cuiPanel2.Size = new System.Drawing.Size(489, 171);
            this.cuiPanel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(25, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pick the patient here";
            // 
            // cuiPanel3
            // 
            this.cuiPanel3.Controls.Add(this.label2);
            this.cuiPanel3.Controls.Add(this.label5);
            this.cuiPanel3.Location = new System.Drawing.Point(1203, 17);
            this.cuiPanel3.Name = "cuiPanel3";
            this.cuiPanel3.OutlineThickness = 1F;
            this.cuiPanel3.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.cuiPanel3.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.cuiPanel3.Rounding = new System.Windows.Forms.Padding(13);
            this.cuiPanel3.Size = new System.Drawing.Size(489, 171);
            this.cuiPanel3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(225, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "12";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(41, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(420, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Number of upcoming appointments";
            // 
            // Dashbord1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cuiPanel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cuiPanel2);
            this.Controls.Add(this.cuiPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashbord1";
            this.Size = new System.Drawing.Size(1810, 850);
            this.Load += new System.EventHandler(this.Dashbord1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel2.ResumeLayout(false);
            this.cuiPanel2.PerformLayout();
            this.cuiPanel3.ResumeLayout(false);
            this.cuiPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

namespace TrustWell_Hospital_Doctor
{
    partial class addRecord
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.diagnosis = new Guna.UI.WinForms.GunaTextBox();
            this.observations = new System.Windows.Forms.TextBox();
            this.treatments = new System.Windows.Forms.TextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(47, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "Enter new medical record details here.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label3.Location = new System.Drawing.Point(47, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Diagnosis:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label6.Location = new System.Drawing.Point(47, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Observations:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label7.Location = new System.Drawing.Point(640, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 50;
            this.label7.Text = "Treatments:";
            // 
            // diagnosis
            // 
            this.diagnosis.BaseColor = System.Drawing.Color.White;
            this.diagnosis.BorderColor = System.Drawing.Color.Transparent;
            this.diagnosis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.diagnosis.FocusedBaseColor = System.Drawing.Color.White;
            this.diagnosis.FocusedBorderColor = System.Drawing.SystemColors.Highlight;
            this.diagnosis.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.diagnosis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.diagnosis.Location = new System.Drawing.Point(179, 69);
            this.diagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diagnosis.Multiline = true;
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.PasswordChar = '\0';
            this.diagnosis.SelectedText = "";
            this.diagnosis.Size = new System.Drawing.Size(1010, 108);
            this.diagnosis.TabIndex = 57;
            // 
            // observations
            // 
            this.observations.BackColor = System.Drawing.Color.White;
            this.observations.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.observations.Location = new System.Drawing.Point(52, 264);
            this.observations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.observations.Multiline = true;
            this.observations.Name = "observations";
            this.observations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observations.Size = new System.Drawing.Size(561, 295);
            this.observations.TabIndex = 60;
            // 
            // treatments
            // 
            this.treatments.BackColor = System.Drawing.Color.White;
            this.treatments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.treatments.Location = new System.Drawing.Point(645, 264);
            this.treatments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.treatments.Multiline = true;
            this.treatments.Name = "treatments";
            this.treatments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.treatments.Size = new System.Drawing.Size(557, 295);
            this.treatments.TabIndex = 61;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(66, 594);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(150)))), ((int)(((byte)(234)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(150)))), ((int)(((byte)(234)))));
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(150)))), ((int)(((byte)(234)))));
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(174, 43);
            this.gunaButton1.TabIndex = 65;
            this.gunaButton1.Text = "Submit";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // addRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 675);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.treatments);
            this.Controls.Add(this.observations);
            this.Controls.Add(this.diagnosis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addRecord";
            this.Text = "addRecord";
            this.Load += new System.EventHandler(this.addRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox diagnosis;
        private System.Windows.Forms.TextBox observations;
        private System.Windows.Forms.TextBox treatments;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}
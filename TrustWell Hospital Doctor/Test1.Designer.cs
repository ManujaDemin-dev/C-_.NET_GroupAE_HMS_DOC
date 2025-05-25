namespace TrustWell_Hospital_Doctor
{
    partial class Test1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.cuiButton3 = new CuoreUI.Controls.cuiButton();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.cuiButton4 = new CuoreUI.Controls.cuiButton();
            this.cuiButton5 = new CuoreUI.Controls.cuiButton();
            this.gunaNumeric1 = new Guna.UI.WinForms.GunaNumeric();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.LargeCheckerBoard;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineWidth = 5;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(3, 101);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1337, 479);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.SteelBlue;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(33, 46);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(398, 35);
            this.gunaComboBox1.TabIndex = 8;
            // 
            // cuiButton1
            // 
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.Content = "Select Test";
            this.cuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cuiButton1.ForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(200)))), ((int)(((byte)(246)))));
            this.cuiButton1.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton1.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Image = null;
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Location = new System.Drawing.Point(445, 44);
            this.cuiButton1.Margin = new System.Windows.Forms.Padding(0);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(183)))));
            this.cuiButton1.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton1.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.OutlineThickness = 0F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton1.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton1.Size = new System.Drawing.Size(132, 36);
            this.cuiButton1.TabIndex = 9;
            this.cuiButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cuiButton1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(39, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select a Test and Filter by using year.";
            // 
            // cuiButton2
            // 
            this.cuiButton2.CheckButton = false;
            this.cuiButton2.Checked = false;
            this.cuiButton2.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cuiButton2.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cuiButton2.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton2.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton2.Content = "Add Test Value";
            this.cuiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cuiButton2.ForeColor = System.Drawing.Color.White;
            this.cuiButton2.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cuiButton2.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton2.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton2.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.Image = null;
            this.cuiButton2.ImageAutoCenter = true;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.Location = new System.Drawing.Point(1163, 3);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cuiButton2.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton2.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton2.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.OutlineThickness = 1F;
            this.cuiButton2.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton2.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton2.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton2.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton2.Size = new System.Drawing.Size(177, 40);
            this.cuiButton2.TabIndex = 11;
            this.cuiButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton2.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cuiButton2_MouseClick);
            // 
            // cuiButton3
            // 
            this.cuiButton3.CheckButton = false;
            this.cuiButton3.Checked = false;
            this.cuiButton3.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton3.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton3.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton3.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton3.Content = "Data Table";
            this.cuiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cuiButton3.ForeColor = System.Drawing.Color.Black;
            this.cuiButton3.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(162)))));
            this.cuiButton3.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton3.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton3.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.Image = null;
            this.cuiButton3.ImageAutoCenter = true;
            this.cuiButton3.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton3.Location = new System.Drawing.Point(599, 44);
            this.cuiButton3.Name = "cuiButton3";
            this.cuiButton3.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(200)))), ((int)(((byte)(246)))));
            this.cuiButton3.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton3.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton3.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.OutlineThickness = 1F;
            this.cuiButton3.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton3.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton3.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton3.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton3.Size = new System.Drawing.Size(129, 36);
            this.cuiButton3.TabIndex = 13;
            this.cuiButton3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton3.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cuiButton3_MouseClick);
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gunaDataGridView1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(309, 86);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(372, 462);
            this.gunaDataGridView1.TabIndex = 14;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cuiButton4
            // 
            this.cuiButton4.CheckButton = false;
            this.cuiButton4.Checked = false;
            this.cuiButton4.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton4.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton4.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton4.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton4.Content = "Filter";
            this.cuiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cuiButton4.ForeColor = System.Drawing.Color.White;
            this.cuiButton4.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(200)))), ((int)(((byte)(246)))));
            this.cuiButton4.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton4.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton4.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton4.Image = null;
            this.cuiButton4.ImageAutoCenter = true;
            this.cuiButton4.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton4.Location = new System.Drawing.Point(946, 45);
            this.cuiButton4.Name = "cuiButton4";
            this.cuiButton4.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(183)))));
            this.cuiButton4.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton4.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton4.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton4.OutlineThickness = 1F;
            this.cuiButton4.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton4.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton4.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton4.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton4.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton4.Size = new System.Drawing.Size(107, 35);
            this.cuiButton4.TabIndex = 15;
            this.cuiButton4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton4.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cuiButton4_MouseClick);
            // 
            // cuiButton5
            // 
            this.cuiButton5.CheckButton = false;
            this.cuiButton5.Checked = false;
            this.cuiButton5.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton5.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton5.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton5.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton5.Content = "Clear";
            this.cuiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cuiButton5.ForeColor = System.Drawing.Color.Black;
            this.cuiButton5.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(200)))), ((int)(((byte)(246)))));
            this.cuiButton5.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton5.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton5.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton5.Image = null;
            this.cuiButton5.ImageAutoCenter = true;
            this.cuiButton5.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton5.Location = new System.Drawing.Point(1059, 44);
            this.cuiButton5.Name = "cuiButton5";
            this.cuiButton5.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(162)))));
            this.cuiButton5.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton5.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton5.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton5.OutlineThickness = 1F;
            this.cuiButton5.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton5.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton5.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton5.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton5.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton5.Size = new System.Drawing.Size(91, 36);
            this.cuiButton5.TabIndex = 16;
            this.cuiButton5.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton5.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cuiButton5_MouseClick);
            // 
            // gunaNumeric1
            // 
            this.gunaNumeric1.BaseColor = System.Drawing.Color.White;
            this.gunaNumeric1.BorderColor = System.Drawing.Color.Silver;
            this.gunaNumeric1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaNumeric1.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumeric1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaNumeric1.ForeColor = System.Drawing.Color.Black;
            this.gunaNumeric1.Location = new System.Drawing.Point(766, 46);
            this.gunaNumeric1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaNumeric1.Maximum = ((long)(9999));
            this.gunaNumeric1.Minimum = ((long)(0));
            this.gunaNumeric1.Name = "gunaNumeric1";
            this.gunaNumeric1.Size = new System.Drawing.Size(143, 30);
            this.gunaNumeric1.TabIndex = 17;
            this.gunaNumeric1.Text = "gunaNumeric1";
            this.gunaNumeric1.Value = ((long)(0));
            // 
            // Test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaNumeric1);
            this.Controls.Add(this.cuiButton5);
            this.Controls.Add(this.cuiButton4);
            this.Controls.Add(this.cuiButton3);
            this.Controls.Add(this.cuiButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cuiButton1);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.gunaDataGridView1);
            this.Name = "Test1";
            this.Size = new System.Drawing.Size(1350, 583);
            this.Load += new System.EventHandler(this.Test1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private System.Windows.Forms.Label label1;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private CuoreUI.Controls.cuiButton cuiButton4;
        private CuoreUI.Controls.cuiButton cuiButton5;
        private Guna.UI.WinForms.GunaNumeric gunaNumeric1;
    }
}

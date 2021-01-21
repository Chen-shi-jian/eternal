namespace Eternal
{
    partial class Form_Love
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Love));
            this.trackBar_Range = new System.Windows.Forms.TrackBar();
            this.panel_Draw = new System.Windows.Forms.Panel();
            this.label_R = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_BackgroundColor = new System.Windows.Forms.Button();
            this.button_Foreground = new System.Windows.Forms.Button();
            this.panel_information = new System.Windows.Forms.Panel();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_PenWd = new System.Windows.Forms.ComboBox();
            this.button_DropOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Range)).BeginInit();
            this.panel_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar_Range
            // 
            this.trackBar_Range.AutoSize = false;
            this.trackBar_Range.BackColor = System.Drawing.Color.White;
            this.trackBar_Range.LargeChange = 1;
            this.trackBar_Range.Location = new System.Drawing.Point(409, 52);
            this.trackBar_Range.Maximum = 150000;
            this.trackBar_Range.Name = "trackBar_Range";
            this.trackBar_Range.Size = new System.Drawing.Size(30, 20);
            this.trackBar_Range.TabIndex = 0;
            this.trackBar_Range.TickFrequency = 150;
            this.trackBar_Range.ValueChanged += new System.EventHandler(this.trackBar_Range_ValueChanged);
            // 
            // panel_Draw
            // 
            this.panel_Draw.BackColor = System.Drawing.Color.White;
            this.panel_Draw.Location = new System.Drawing.Point(13, 78);
            this.panel_Draw.Name = "panel_Draw";
            this.panel_Draw.Size = new System.Drawing.Size(487, 214);
            this.panel_Draw.TabIndex = 1;
            this.panel_Draw.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Draw_Paint);
            // 
            // label_R
            // 
            this.label_R.AutoSize = true;
            this.label_R.Location = new System.Drawing.Point(3, 3);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(17, 12);
            this.label_R.TabIndex = 4;
            this.label_R.Text = "R:";
            // 
            // button_BackgroundColor
            // 
            this.button_BackgroundColor.BackColor = System.Drawing.Color.Transparent;
            this.button_BackgroundColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_BackgroundColor.FlatAppearance.BorderSize = 0;
            this.button_BackgroundColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_BackgroundColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_BackgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BackgroundColor.Location = new System.Drawing.Point(115, -1);
            this.button_BackgroundColor.Name = "button_BackgroundColor";
            this.button_BackgroundColor.Size = new System.Drawing.Size(52, 20);
            this.button_BackgroundColor.TabIndex = 5;
            this.button_BackgroundColor.Text = "背景色";
            this.button_BackgroundColor.UseVisualStyleBackColor = false;
            this.button_BackgroundColor.Click += new System.EventHandler(this.button_BackgroundColor_Click);
            // 
            // button_Foreground
            // 
            this.button_Foreground.BackColor = System.Drawing.Color.Transparent;
            this.button_Foreground.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Foreground.FlatAppearance.BorderSize = 0;
            this.button_Foreground.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_Foreground.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_Foreground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Foreground.Location = new System.Drawing.Point(57, -1);
            this.button_Foreground.Name = "button_Foreground";
            this.button_Foreground.Size = new System.Drawing.Size(52, 20);
            this.button_Foreground.TabIndex = 6;
            this.button_Foreground.Text = "前景色";
            this.button_Foreground.UseVisualStyleBackColor = false;
            this.button_Foreground.Click += new System.EventHandler(this.button_Foreground_Click);
            // 
            // panel_information
            // 
            this.panel_information.BackColor = System.Drawing.Color.White;
            this.panel_information.Controls.Add(this.button_Reset);
            this.panel_information.Controls.Add(this.label1);
            this.panel_information.Controls.Add(this.comboBox_PenWd);
            this.panel_information.Controls.Add(this.button_BackgroundColor);
            this.panel_information.Controls.Add(this.label_R);
            this.panel_information.Controls.Add(this.button_Foreground);
            this.panel_information.Location = new System.Drawing.Point(200, 18);
            this.panel_information.Name = "panel_information";
            this.panel_information.Size = new System.Drawing.Size(300, 20);
            this.panel_information.TabIndex = 7;
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.Transparent;
            this.button_Reset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Reset.FlatAppearance.BorderSize = 0;
            this.button_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reset.Location = new System.Drawing.Point(248, 0);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(52, 22);
            this.button_Reset.TabIndex = 9;
            this.button_Reset.Text = "重置";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "笔宽：";
            // 
            // comboBox_PenWd
            // 
            this.comboBox_PenWd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PenWd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_PenWd.FormattingEnabled = true;
            this.comboBox_PenWd.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_PenWd.Location = new System.Drawing.Point(209, 0);
            this.comboBox_PenWd.Name = "comboBox_PenWd";
            this.comboBox_PenWd.Size = new System.Drawing.Size(35, 20);
            this.comboBox_PenWd.TabIndex = 7;
            this.comboBox_PenWd.SelectedIndexChanged += new System.EventHandler(this.comboBox_PenWd_SelectedIndexChanged);
            // 
            // button_DropOut
            // 
            this.button_DropOut.BackColor = System.Drawing.Color.Transparent;
            this.button_DropOut.FlatAppearance.BorderSize = 0;
            this.button_DropOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_DropOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DropOut.ForeColor = System.Drawing.Color.Red;
            this.button_DropOut.Location = new System.Drawing.Point(40, 21);
            this.button_DropOut.Name = "button_DropOut";
            this.button_DropOut.Size = new System.Drawing.Size(52, 20);
            this.button_DropOut.TabIndex = 8;
            this.button_DropOut.Text = "退出";
            this.button_DropOut.UseVisualStyleBackColor = false;
            this.button_DropOut.Visible = false;
            this.button_DropOut.Click += new System.EventHandler(this.button_DropOut_Click);
            // 
            // Form_Love
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 353);
            this.Controls.Add(this.button_DropOut);
            this.Controls.Add(this.panel_information);
            this.Controls.Add(this.trackBar_Range);
            this.Controls.Add(this.panel_Draw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Love";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eternal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Love_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Range)).EndInit();
            this.panel_information.ResumeLayout(false);
            this.panel_information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar_Range;
        private System.Windows.Forms.Panel panel_Draw;
        private System.Windows.Forms.Label label_R;
        public System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_BackgroundColor;
        private System.Windows.Forms.Button button_Foreground;
        private System.Windows.Forms.Panel panel_information;
        private System.Windows.Forms.ComboBox comboBox_PenWd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_DropOut;
    }
}

namespace CayleyTree
{
    partial class CayleyTree
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_draw = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_SelectColor = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_length = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_per1 = new System.Windows.Forms.TextBox();
            this.label_per1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_per2 = new System.Windows.Forms.TextBox();
            this.label_per2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_th1 = new System.Windows.Forms.TextBox();
            this.label_th1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox_th2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelPrint = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_draw
            // 
            this.button_draw.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_draw.Location = new System.Drawing.Point(0, 0);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(81, 50);
            this.button_draw.TabIndex = 0;
            this.button_draw.Text = "draw";
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
            // 
            // button_SelectColor
            // 
            this.button_SelectColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_SelectColor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_SelectColor.Location = new System.Drawing.Point(0, 448);
            this.button_SelectColor.Name = "button_SelectColor";
            this.button_SelectColor.Size = new System.Drawing.Size(136, 50);
            this.button_SelectColor.TabIndex = 1;
            this.button_SelectColor.Text = "Select Color";
            this.button_SelectColor.UseVisualStyleBackColor = true;
            this.button_SelectColor.Click += new System.EventHandler(this.button_SelectColor_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 27);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar1.Maximum = 16;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(220, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickFrequency = 2;
            this.trackBar1.Value = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.Location = new System.Drawing.Point(6, 6);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(60, 20);
            this.label_length.TabIndex = 5;
            this.label_length.Text = "length:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "depth";
            // 
            // textBox_length
            // 
            this.textBox_length.Location = new System.Drawing.Point(73, 6);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(147, 27);
            this.textBox_length.TabIndex = 7;
            this.textBox_length.Text = "100";
            this.textBox_length.TextChanged += new System.EventHandler(this.textBox_length_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_length);
            this.panel1.Controls.Add(this.label_length);
            this.panel1.Location = new System.Drawing.Point(3, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 38);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_per1);
            this.panel2.Controls.Add(this.label_per1);
            this.panel2.Location = new System.Drawing.Point(3, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 38);
            this.panel2.TabIndex = 9;
            // 
            // textBox_per1
            // 
            this.textBox_per1.Location = new System.Drawing.Point(73, 6);
            this.textBox_per1.Name = "textBox_per1";
            this.textBox_per1.Size = new System.Drawing.Size(147, 27);
            this.textBox_per1.TabIndex = 7;
            this.textBox_per1.Text = "0.6";
            this.textBox_per1.TextChanged += new System.EventHandler(this.textBox_per1_TextChanged);
            // 
            // label_per1
            // 
            this.label_per1.AutoSize = true;
            this.label_per1.Location = new System.Drawing.Point(6, 6);
            this.label_per1.Name = "label_per1";
            this.label_per1.Size = new System.Drawing.Size(48, 20);
            this.label_per1.TabIndex = 5;
            this.label_per1.Text = "perR:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_per2);
            this.panel3.Controls.Add(this.label_per2);
            this.panel3.Location = new System.Drawing.Point(3, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 38);
            this.panel3.TabIndex = 9;
            // 
            // textBox_per2
            // 
            this.textBox_per2.Location = new System.Drawing.Point(73, 6);
            this.textBox_per2.Name = "textBox_per2";
            this.textBox_per2.Size = new System.Drawing.Size(147, 27);
            this.textBox_per2.TabIndex = 7;
            this.textBox_per2.Text = "0.7";
            this.textBox_per2.TextChanged += new System.EventHandler(this.textBox_per2_TextChanged);
            // 
            // label_per2
            // 
            this.label_per2.AutoSize = true;
            this.label_per2.Location = new System.Drawing.Point(6, 6);
            this.label_per2.Name = "label_per2";
            this.label_per2.Size = new System.Drawing.Size(46, 20);
            this.label_per2.TabIndex = 5;
            this.label_per2.Text = "perL:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox_th1);
            this.panel4.Controls.Add(this.label_th1);
            this.panel4.Location = new System.Drawing.Point(3, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 38);
            this.panel4.TabIndex = 9;
            // 
            // textBox_th1
            // 
            this.textBox_th1.Location = new System.Drawing.Point(73, 6);
            this.textBox_th1.Name = "textBox_th1";
            this.textBox_th1.Size = new System.Drawing.Size(147, 27);
            this.textBox_th1.TabIndex = 7;
            this.textBox_th1.Text = "30";
            this.textBox_th1.TextChanged += new System.EventHandler(this.textBox_th1_TextChanged);
            // 
            // label_th1
            // 
            this.label_th1.AutoSize = true;
            this.label_th1.Location = new System.Drawing.Point(6, 6);
            this.label_th1.Name = "label_th1";
            this.label_th1.Size = new System.Drawing.Size(38, 20);
            this.label_th1.TabIndex = 5;
            this.label_th1.Text = "thR:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox_th2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 158);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 38);
            this.panel5.TabIndex = 9;
            // 
            // textBox_th2
            // 
            this.textBox_th2.Location = new System.Drawing.Point(73, 6);
            this.textBox_th2.Name = "textBox_th2";
            this.textBox_th2.Size = new System.Drawing.Size(147, 27);
            this.textBox_th2.TabIndex = 7;
            this.textBox_th2.Text = "20";
            this.textBox_th2.TextChanged += new System.EventHandler(this.textBox_th2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "thL:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(247, 343);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // PanelPrint
            // 
            this.PanelPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPrint.AutoScroll = true;
            this.PanelPrint.AutoSize = true;
            this.PanelPrint.BackColor = System.Drawing.SystemColors.Window;
            this.PanelPrint.Location = new System.Drawing.Point(244, 0);
            this.PanelPrint.Name = "PanelPrint";
            this.PanelPrint.Size = new System.Drawing.Size(669, 498);
            this.PanelPrint.TabIndex = 11;
            // 
            // CayleyTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(913, 498);
            this.Controls.Add(this.PanelPrint);
            this.Controls.Add(this.button_SelectColor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button_draw);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CayleyTree";
            this.Text = "CayleyTree";
            this.Load += new System.EventHandler(this.CayleyTree_Load);
            this.SizeChanged += new System.EventHandler(this.CaleyTree_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_draw;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_SelectColor;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label_length;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_per1;
        private System.Windows.Forms.Label label_per1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_per2;
        private System.Windows.Forms.Label label_per2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_th1;
        private System.Windows.Forms.Label label_th1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox_th2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel PanelPrint;
    }
}


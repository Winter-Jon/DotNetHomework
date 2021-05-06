
namespace OrderForm
{
    partial class Form3
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
            this.textBox_GoodPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_GoodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_GoodNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_GoodPrice
            // 
            this.textBox_GoodPrice.Location = new System.Drawing.Point(186, 164);
            this.textBox_GoodPrice.Name = "textBox_GoodPrice";
            this.textBox_GoodPrice.Size = new System.Drawing.Size(220, 27);
            this.textBox_GoodPrice.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "商品单价：";
            // 
            // textBox_GoodName
            // 
            this.textBox_GoodName.Location = new System.Drawing.Point(184, 76);
            this.textBox_GoodName.Name = "textBox_GoodName";
            this.textBox_GoodName.Size = new System.Drawing.Size(220, 27);
            this.textBox_GoodName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "商品名：";
            // 
            // text_GoodNo
            // 
            this.text_GoodNo.Location = new System.Drawing.Point(184, 256);
            this.text_GoodNo.Name = "text_GoodNo";
            this.text_GoodNo.Size = new System.Drawing.Size(220, 27);
            this.text_GoodNo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "商品数量：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_GoodNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_GoodPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_GoodName);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_GoodPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_GoodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_GoodNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
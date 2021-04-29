
namespace OrderForm
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource_Order = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column2_GoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_GoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_GoodNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_GoodTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOrderDetailAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOrderDetailDel = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1_OrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1_OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOrderAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOrderDel = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource_OrderDetail = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip2Cell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2CellChange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2DelRow = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1Cell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1CellChange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1DelRow = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Order)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_OrderDetail)).BeginInit();
            this.contextMenuStrip2Cell.SuspendLayout();
            this.contextMenuStrip1Cell.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox_search);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 60);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "订单号",
            "客户名",
            "金额等于",
            "金额大于",
            "金额小于"});
            this.comboBox1.Location = new System.Drawing.Point(136, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(255, 17);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(125, 27);
            this.textBox_search.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(41, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(63, 36);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "查询";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 392);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2_GoodName,
            this.Column2_GoodPrice,
            this.Column2_GoodNum,
            this.Column2_GoodTotalPrice});
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView2.Location = new System.Drawing.Point(299, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(554, 392);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Column2_GoodName
            // 
            this.Column2_GoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2_GoodName.HeaderText = "商品名";
            this.Column2_GoodName.MinimumWidth = 6;
            this.Column2_GoodName.Name = "Column2_GoodName";
            this.Column2_GoodName.ReadOnly = true;
            // 
            // Column2_GoodPrice
            // 
            this.Column2_GoodPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2_GoodPrice.HeaderText = "商品单价";
            this.Column2_GoodPrice.MinimumWidth = 6;
            this.Column2_GoodPrice.Name = "Column2_GoodPrice";
            this.Column2_GoodPrice.ReadOnly = true;
            // 
            // Column2_GoodNum
            // 
            this.Column2_GoodNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2_GoodNum.HeaderText = "商品数量";
            this.Column2_GoodNum.MinimumWidth = 6;
            this.Column2_GoodNum.Name = "Column2_GoodNum";
            this.Column2_GoodNum.ReadOnly = true;
            // 
            // Column2_GoodTotalPrice
            // 
            this.Column2_GoodTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2_GoodTotalPrice.HeaderText = "商品总价";
            this.Column2_GoodTotalPrice.MinimumWidth = 6;
            this.Column2_GoodTotalPrice.Name = "Column2_GoodTotalPrice";
            this.Column2_GoodTotalPrice.ReadOnly = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOrderDetailAdd,
            this.toolStripMenuItemOrderDetailDel});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(169, 52);
            // 
            // toolStripMenuItemOrderDetailAdd
            // 
            this.toolStripMenuItemOrderDetailAdd.Name = "toolStripMenuItemOrderDetailAdd";
            this.toolStripMenuItemOrderDetailAdd.Size = new System.Drawing.Size(168, 24);
            this.toolStripMenuItemOrderDetailAdd.Text = "添加订单明细";
            // 
            // toolStripMenuItemOrderDetailDel
            // 
            this.toolStripMenuItemOrderDetailDel.Name = "toolStripMenuItemOrderDetailDel";
            this.toolStripMenuItemOrderDetailDel.Size = new System.Drawing.Size(168, 24);
            this.toolStripMenuItemOrderDetailDel.Text = "删除订单明细";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1_OrderNum,
            this.Column1_Customer,
            this.Column1_OrderPrice});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(303, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1_OrderNum
            // 
            this.Column1_OrderNum.HeaderText = "订单号";
            this.Column1_OrderNum.MinimumWidth = 6;
            this.Column1_OrderNum.Name = "Column1_OrderNum";
            this.Column1_OrderNum.ReadOnly = true;
            this.Column1_OrderNum.Width = 83;
            // 
            // Column1_Customer
            // 
            this.Column1_Customer.HeaderText = "客户名";
            this.Column1_Customer.MinimumWidth = 6;
            this.Column1_Customer.Name = "Column1_Customer";
            this.Column1_Customer.ReadOnly = true;
            this.Column1_Customer.Width = 83;
            // 
            // Column1_OrderPrice
            // 
            this.Column1_OrderPrice.HeaderText = "总金额";
            this.Column1_OrderPrice.MinimumWidth = 6;
            this.Column1_OrderPrice.Name = "Column1_OrderPrice";
            this.Column1_OrderPrice.ReadOnly = true;
            this.Column1_OrderPrice.Width = 83;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOrderAdd,
            this.toolStripMenuItemOrderDel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 52);
            // 
            // toolStripMenuItemOrderAdd
            // 
            this.toolStripMenuItemOrderAdd.Name = "toolStripMenuItemOrderAdd";
            this.toolStripMenuItemOrderAdd.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItemOrderAdd.Text = "添加订单";
            // 
            // toolStripMenuItemOrderDel
            // 
            this.toolStripMenuItemOrderDel.Name = "toolStripMenuItemOrderDel";
            this.toolStripMenuItemOrderDel.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItemOrderDel.Text = "删除订单";
            // 
            // contextMenuStrip2Cell
            // 
            this.contextMenuStrip2Cell.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2Cell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2CellChange,
            this.toolStripMenuItem2DelRow});
            this.contextMenuStrip2Cell.Name = "contextMenuStrip2";
            this.contextMenuStrip2Cell.Size = new System.Drawing.Size(139, 52);
            // 
            // toolStripMenuItem2CellChange
            // 
            this.toolStripMenuItem2CellChange.Name = "toolStripMenuItem2CellChange";
            this.toolStripMenuItem2CellChange.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItem2CellChange.Text = "修改单元";
            // 
            // toolStripMenuItem2DelRow
            // 
            this.toolStripMenuItem2DelRow.Name = "toolStripMenuItem2DelRow";
            this.toolStripMenuItem2DelRow.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItem2DelRow.Text = "删除行";
            // 
            // contextMenuStrip1Cell
            // 
            this.contextMenuStrip1Cell.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1Cell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1CellChange,
            this.toolStripMenuItem1DelRow});
            this.contextMenuStrip1Cell.Name = "contextMenuStrip2";
            this.contextMenuStrip1Cell.Size = new System.Drawing.Size(139, 52);
            // 
            // toolStripMenuItem1CellChange
            // 
            this.toolStripMenuItem1CellChange.Name = "toolStripMenuItem1CellChange";
            this.toolStripMenuItem1CellChange.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItem1CellChange.Text = "修改单元";
            // 
            // toolStripMenuItem1DelRow
            // 
            this.toolStripMenuItem1DelRow.Name = "toolStripMenuItem1DelRow";
            this.toolStripMenuItem1DelRow.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItem1DelRow.Text = "删除行";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrderForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Order)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_OrderDetail)).EndInit();
            this.contextMenuStrip2Cell.ResumeLayout(false);
            this.contextMenuStrip1Cell.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.BindingSource bindingSource_Order;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource_OrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_OrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2_GoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2_GoodPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2_GoodNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2_GoodTotalPrice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2Cell;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2DelRow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2CellChange;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1Cell;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1CellChange;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1DelRow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOrderAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOrderDel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOrderDetailAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOrderDetailDel;
    }
}


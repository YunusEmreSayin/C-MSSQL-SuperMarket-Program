
namespace SuperMarket
{
    partial class MainFrm
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
            this.components = new System.ComponentModel.Container();
            this.GridCustomer = new System.Windows.Forms.DataGridView();
            this.GridOrder = new System.Windows.Forms.DataGridView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnOrderTimeframe = new System.Windows.Forms.Button();
            this.btnOrderbyCustomer = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BsOrder = new System.Windows.Forms.BindingSource(this.components);
            this.customerIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gsmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BsCustomer = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCustomer
            // 
            this.GridCustomer.AutoGenerateColumns = false;
            this.GridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn1,
            this.cNameDataGridViewTextBoxColumn,
            this.cSurnameDataGridViewTextBoxColumn,
            this.gsmDataGridViewTextBoxColumn});
            this.GridCustomer.DataSource = this.BsCustomer;
            this.GridCustomer.Location = new System.Drawing.Point(12, 23);
            this.GridCustomer.Name = "GridCustomer";
            this.GridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCustomer.Size = new System.Drawing.Size(505, 150);
            this.GridCustomer.TabIndex = 0;
            // 
            // GridOrder
            // 
            this.GridOrder.AutoGenerateColumns = false;
            this.GridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderNoteDataGridViewTextBoxColumn});
            this.GridOrder.DataSource = this.BsOrder;
            this.GridOrder.Location = new System.Drawing.Point(12, 202);
            this.GridOrder.Name = "GridOrder";
            this.GridOrder.Size = new System.Drawing.Size(505, 150);
            this.GridOrder.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(523, 23);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(99, 53);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnOrderTimeframe
            // 
            this.btnOrderTimeframe.Location = new System.Drawing.Point(523, 115);
            this.btnOrderTimeframe.Name = "btnOrderTimeframe";
            this.btnOrderTimeframe.Size = new System.Drawing.Size(99, 58);
            this.btnOrderTimeframe.TabIndex = 1;
            this.btnOrderTimeframe.Text = "View Orders By Selected Timeframe";
            this.btnOrderTimeframe.UseVisualStyleBackColor = true;
            this.btnOrderTimeframe.Click += new System.EventHandler(this.btnOrderTimeframe_Click);
            // 
            // btnOrderbyCustomer
            // 
            this.btnOrderbyCustomer.Location = new System.Drawing.Point(628, 115);
            this.btnOrderbyCustomer.Name = "btnOrderbyCustomer";
            this.btnOrderbyCustomer.Size = new System.Drawing.Size(95, 58);
            this.btnOrderbyCustomer.TabIndex = 1;
            this.btnOrderbyCustomer.Text = "View Selected Customer\'s Orders";
            this.btnOrderbyCustomer.UseVisualStyleBackColor = true;
            this.btnOrderbyCustomer.Click += new System.EventHandler(this.btnOrderbyCustomer_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(628, 23);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(95, 53);
            this.btnCreateOrder.TabIndex = 1;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Order Date";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // orderNoteDataGridViewTextBoxColumn
            // 
            this.orderNoteDataGridViewTextBoxColumn.DataPropertyName = "OrderNote";
            this.orderNoteDataGridViewTextBoxColumn.HeaderText = "Order Note";
            this.orderNoteDataGridViewTextBoxColumn.Name = "orderNoteDataGridViewTextBoxColumn";
            // 
            // BsOrder
            // 
            this.BsOrder.DataSource = typeof(SuperMarket.Order);
            // 
            // customerIdDataGridViewTextBoxColumn1
            // 
            this.customerIdDataGridViewTextBoxColumn1.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn1.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn1.Name = "customerIdDataGridViewTextBoxColumn1";
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "CName";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            // 
            // cSurnameDataGridViewTextBoxColumn
            // 
            this.cSurnameDataGridViewTextBoxColumn.DataPropertyName = "CSurname";
            this.cSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.cSurnameDataGridViewTextBoxColumn.Name = "cSurnameDataGridViewTextBoxColumn";
            // 
            // gsmDataGridViewTextBoxColumn
            // 
            this.gsmDataGridViewTextBoxColumn.DataPropertyName = "Gsm";
            this.gsmDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.gsmDataGridViewTextBoxColumn.Name = "gsmDataGridViewTextBoxColumn";
            // 
            // BsCustomer
            // 
            this.BsCustomer.DataSource = typeof(SuperMarket.Customer);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 364);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnOrderbyCustomer);
            this.Controls.Add(this.btnOrderTimeframe);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.GridOrder);
            this.Controls.Add(this.GridCustomer);
            this.Name = "MainFrm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource BsCustomer;
        private System.Windows.Forms.BindingSource BsOrder;
        private System.Windows.Forms.DataGridView GridCustomer;
        private System.Windows.Forms.DataGridView GridOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gsmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnOrderTimeframe;
        private System.Windows.Forms.Button btnOrderbyCustomer;
        private System.Windows.Forms.Button btnCreateOrder;
    }
}


namespace Views
{
    partial class frmProduct
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
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            lblTitle = new Label();
            groupBox1 = new GroupBox();
            dgvProduct = new DataGridView();
            txtTitle = new TextBox();
            txtUnitPrice = new NumericUpDown();
            txtQuantity = new NumericUpDown();
            lblQuantity = new Label();
            lblUnitPrice = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 26);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(116, 330);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 26);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(229, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 26);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(348, 330);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 26);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(24, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(45, 18);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Title :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvProduct);
            groupBox1.Location = new Point(448, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 390);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "List";
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.BackgroundColor = Color.DarkSeaGreen;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(6, 17);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(316, 367);
            dgvProduct.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(24, 54);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(341, 26);
            txtTitle.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = Color.White;
            txtUnitPrice.Location = new Point(116, 131);
            txtUnitPrice.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(249, 26);
            txtUnitPrice.TabIndex = 7;
            txtUnitPrice.ThousandsSeparator = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(116, 224);
            txtQuantity.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(249, 26);
            txtQuantity.TabIndex = 8;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(24, 226);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(73, 18);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quantity :";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(28, 131);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(78, 18);
            lblUnitPrice.TabIndex = 10;
            lblUnitPrice.Text = "Unit Price :";
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 405);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtTitle);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Product";
            Load += frmProduct_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Label lblTitle;
        private GroupBox groupBox1;
        private TextBox txtTitle;
        private NumericUpDown txtUnitPrice;
        private NumericUpDown txtQuantity;
        private Label lblQuantity;
        private Label lblUnitPrice;
        private DataGridView dgvProduct;
    }
}
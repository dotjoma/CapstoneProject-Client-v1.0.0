namespace client.Forms.ProductManagement
{
    partial class AddProduct
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            pbImage = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cboSubCategory = new ComboBox();
            cboCategory = new ComboBox();
            txtName = new TextBox();
            cboUnit = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            btnUploadImage = new Button();
            cbIsActive = new CheckBox();
            txtPrice = new TextBox();
            checkBox1 = new CheckBox();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblHeader = new Label();
            label3 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            pbKnowMore = new PictureBox();
            cbUseSystemBackground = new CheckBox();
            panel3 = new Panel();
            btnRemoveIngredients = new Button();
            dgvIngredients = new DataGridView();
            ingredient = new DataGridViewTextBoxColumn();
            btnManageIngredients = new Button();
            label1 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            pnlHeader.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbKnowMore).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Location = new Point(436, 94);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(180, 140);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 12;
            pbImage.TabStop = false;
            pbImage.Click += pbImage_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(25, 181);
            label7.Name = "label7";
            label7.Size = new Size(116, 21);
            label7.TabIndex = 24;
            label7.Text = "Sub-Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(25, 139);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 23;
            label6.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(25, 225);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 22;
            label5.Text = "Unit:";
            // 
            // cboSubCategory
            // 
            cboSubCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSubCategory.Font = new Font("Segoe UI", 12F);
            cboSubCategory.FormattingEnabled = true;
            cboSubCategory.Location = new Point(171, 177);
            cboSubCategory.Name = "cboSubCategory";
            cboSubCategory.Size = new Size(242, 29);
            cboSubCategory.TabIndex = 13;
            cboSubCategory.SelectedIndexChanged += cboSubCategory_SelectedIndexChanged;
            // 
            // cboCategory
            // 
            cboCategory.BackColor = Color.FromArgb(232, 232, 232);
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Segoe UI", 12F);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(171, 136);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(242, 29);
            cboCategory.TabIndex = 14;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(232, 232, 232);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(171, 94);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter menu name";
            txtName.Size = new Size(242, 33);
            txtName.TabIndex = 18;
            txtName.TabStop = false;
            // 
            // cboUnit
            // 
            cboUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboUnit.FormattingEnabled = true;
            cboUnit.Location = new Point(171, 223);
            cboUnit.Name = "cboUnit";
            cboUnit.Size = new Size(242, 29);
            cboUnit.TabIndex = 15;
            cboUnit.SelectedIndexChanged += cboUnit_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(25, 265);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 17;
            label4.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 99);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 16;
            label2.Text = "Menu Name:";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.FromArgb(161, 136, 127);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 110, 99);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(337, 557);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(156, 37);
            btnCancel.TabIndex = 23;
            btnCancel.TabStop = false;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseEnter += btnCancel_MouseEnter;
            btnCancel.MouseLeave += btnCancel_MouseLeave;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.FromArgb(141, 110, 99);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 76, 65);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(499, 557);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 37);
            btnSave.TabIndex = 22;
            btnSave.TabStop = false;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.MouseEnter += btnSave_MouseEnter;
            btnSave.MouseLeave += btnSave_MouseLeave;
            // 
            // btnUploadImage
            // 
            btnUploadImage.FlatStyle = FlatStyle.Popup;
            btnUploadImage.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadImage.Location = new Point(424, 185);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(180, 33);
            btnUploadImage.TabIndex = 28;
            btnUploadImage.Text = "UPLOAD IMAGE";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.BackColor = Color.White;
            cbIsActive.Checked = true;
            cbIsActive.CheckState = CheckState.Checked;
            cbIsActive.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIsActive.Location = new Point(171, 307);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(79, 24);
            cbIsActive.TabIndex = 29;
            cbIsActive.Text = "isActive";
            cbIsActive.UseVisualStyleBackColor = false;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(232, 232, 232);
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(171, 261);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "0.00";
            txtPrice.Size = new Size(242, 33);
            txtPrice.TabIndex = 30;
            txtPrice.TabStop = false;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(256, 307);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(115, 24);
            checkBox1.TabIndex = 31;
            checkBox1.Text = "Discountable";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(121, 85, 72);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(label3);
            pnlHeader.Controls.Add(label8);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(647, 34);
            pnlHeader.TabIndex = 64;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(322, 21);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "ELICIAS GARDEN FOOD PARK - Add Menu";
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Left;
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.FromArgb(121, 85, 72);
            lblHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(12, -26);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(241, 21);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "View Batches - Chicken  Breast";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(121, 85, 72);
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, -61);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 1;
            label3.Text = "Add New Batch";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(121, 85, 72);
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, -93);
            label8.Name = "label8";
            label8.Size = new Size(358, 25);
            label8.TabIndex = 0;
            label8.Text = "Inventory Management - Add New Item";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pbKnowMore);
            panel2.Controls.Add(cbUseSystemBackground);
            panel2.Controls.Add(btnUploadImage);
            panel2.Location = new Point(12, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(623, 262);
            panel2.TabIndex = 65;
            // 
            // pbKnowMore
            // 
            pbKnowMore.Image = Properties.Resources.question_mark_24;
            pbKnowMore.Location = new Point(585, 160);
            pbKnowMore.Name = "pbKnowMore";
            pbKnowMore.Size = new Size(19, 17);
            pbKnowMore.SizeMode = PictureBoxSizeMode.StretchImage;
            pbKnowMore.TabIndex = 83;
            pbKnowMore.TabStop = false;
            // 
            // cbUseSystemBackground
            // 
            cbUseSystemBackground.AutoSize = true;
            cbUseSystemBackground.BackColor = Color.White;
            cbUseSystemBackground.Font = new Font("Segoe UI", 8F);
            cbUseSystemBackground.Location = new Point(424, 160);
            cbUseSystemBackground.Name = "cbUseSystemBackground";
            cbUseSystemBackground.Size = new Size(151, 17);
            cbUseSystemBackground.TabIndex = 32;
            cbUseSystemBackground.Text = "Use default background";
            cbUseSystemBackground.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnRemoveIngredients);
            panel3.Controls.Add(dgvIngredients);
            panel3.Controls.Add(btnManageIngredients);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(12, 352);
            panel3.Name = "panel3";
            panel3.Size = new Size(623, 200);
            panel3.TabIndex = 66;
            // 
            // btnRemoveIngredients
            // 
            btnRemoveIngredients.BackColor = Color.FromArgb(244, 67, 54);
            btnRemoveIngredients.FlatAppearance.BorderSize = 0;
            btnRemoveIngredients.FlatStyle = FlatStyle.Flat;
            btnRemoveIngredients.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveIngredients.ForeColor = Color.White;
            btnRemoveIngredients.Location = new Point(193, 28);
            btnRemoveIngredients.Name = "btnRemoveIngredients";
            btnRemoveIngredients.Size = new Size(154, 30);
            btnRemoveIngredients.TabIndex = 82;
            btnRemoveIngredients.Text = "REMOVE INGREDIENTS";
            btnRemoveIngredients.UseVisualStyleBackColor = false;
            btnRemoveIngredients.Click += btnRemoveIngredients_Click;
            // 
            // dgvIngredients
            // 
            dgvIngredients.AllowUserToAddRows = false;
            dgvIngredients.AllowUserToDeleteRows = false;
            dgvIngredients.AllowUserToResizeColumns = false;
            dgvIngredients.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgvIngredients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvIngredients.Anchor = AnchorStyles.Top;
            dgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredients.BackgroundColor = Color.White;
            dgvIngredients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(204, 204, 204);
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(204, 204, 204);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvIngredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvIngredients.ColumnHeadersHeight = 25;
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvIngredients.Columns.AddRange(new DataGridViewColumn[] { ingredient });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 8.5F);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvIngredients.DefaultCellStyle = dataGridViewCellStyle9;
            dgvIngredients.Enabled = false;
            dgvIngredients.EnableHeadersVisualStyles = false;
            dgvIngredients.GridColor = Color.White;
            dgvIngredients.Location = new Point(13, 64);
            dgvIngredients.MultiSelect = false;
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.ReadOnly = true;
            dgvIngredients.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(214, 192, 179);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvIngredients.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvIngredients.RowHeadersVisible = false;
            dgvIngredients.RowHeadersWidth = 51;
            dgvIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredients.Size = new Size(597, 125);
            dgvIngredients.TabIndex = 81;
            dgvIngredients.TabStop = false;
            // 
            // ingredient
            // 
            ingredient.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ingredient.DefaultCellStyle = dataGridViewCellStyle8;
            ingredient.FillWeight = 115.0222F;
            ingredient.HeaderText = "Ingredients Summary";
            ingredient.MinimumWidth = 270;
            ingredient.Name = "ingredient";
            ingredient.ReadOnly = true;
            // 
            // btnManageIngredients
            // 
            btnManageIngredients.BackColor = Color.FromArgb(76, 175, 80);
            btnManageIngredients.FlatAppearance.BorderSize = 0;
            btnManageIngredients.FlatStyle = FlatStyle.Flat;
            btnManageIngredients.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageIngredients.ForeColor = Color.White;
            btnManageIngredients.Location = new Point(13, 28);
            btnManageIngredients.Name = "btnManageIngredients";
            btnManageIngredients.Size = new Size(174, 30);
            btnManageIngredients.TabIndex = 18;
            btnManageIngredients.Text = "MANAGE INGREDIENTS";
            btnManageIngredients.UseVisualStyleBackColor = false;
            btnManageIngredients.Click += btnManageIngredients_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 4);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 17;
            label1.Text = "Recipe";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(121, 85, 72);
            label9.Location = new Point(232, 40);
            label9.Name = "label9";
            label9.Size = new Size(183, 30);
            label9.TabIndex = 71;
            label9.Text = "ADD MENU ITEM";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 232, 232);
            ClientSize = new Size(647, 599);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(panel3);
            Controls.Add(label9);
            Controls.Add(pnlHeader);
            Controls.Add(checkBox1);
            Controls.Add(txtPrice);
            Controls.Add(cbIsActive);
            Controls.Add(pbImage);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cboSubCategory);
            Controls.Add(cboCategory);
            Controls.Add(txtName);
            Controls.Add(cboUnit);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ELICIAS GARDEN FOOD PARK";
            Activated += AddProduct_Activated;
            Load += AddProduct_Load;
            KeyDown += AddProduct_KeyDown;
            KeyPress += AddProduct_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbKnowMore).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cboSubCategory;
        private ComboBox cboCategory;
        private TextBox txtName;
        private ComboBox cboUnit;
        private Label label4;
        private Label label2;
        private Button btnSave;
        private Button btnCancel;
        private Button btnUploadImage;
        private CheckBox cbIsActive;
        private TextBox txtPrice;
        private CheckBox checkBox1;
        private Panel pnlHeader;
        private Label lblHeader;
        private Label label3;
        private Label label8;
        private Label lblTitle;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button btnManageIngredients;
        private Label label9;
        private DataGridView dgvIngredients;
        private DataGridViewTextBoxColumn ingredient;
        private Button btnRemoveIngredients;
        private CheckBox cbUseSystemBackground;
        private PictureBox pbKnowMore;
    }
}
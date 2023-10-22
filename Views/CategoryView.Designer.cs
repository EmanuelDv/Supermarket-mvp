namespace Supermarket_mvp.Views
{
    partial class CategoryView
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
            PanelProduct = new Panel();
            pictureBox1 = new PictureBox();
            lblcategories = new Label();
            tabControl1 = new TabControl();
            tabPageCategoryList = new TabPage();
            BtnSearch2 = new Button();
            BtnCloseCat = new Button();
            BtnDeleteCat = new Button();
            BtnEditCat = new Button();
            BtnNewCat = new Button();
            DgCategory = new DataGridView();
            TxtSearchCat = new TextBox();
            Lbl1 = new Label();
            tabPageCategoryDetail = new TabPage();
            BtnCancelCat = new Button();
            BtnSaveCat = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TxtObserCat = new TextBox();
            TxtCategoryName = new TextBox();
            TxtCategoryId = new TextBox();
            PanelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).BeginInit();
            tabPageCategoryDetail.SuspendLayout();
            SuspendLayout();
            // 
            // PanelProduct
            // 
            PanelProduct.Controls.Add(pictureBox1);
            PanelProduct.Controls.Add(lblcategories);
            PanelProduct.Dock = DockStyle.Top;
            PanelProduct.Location = new Point(0, 0);
            PanelProduct.Name = "PanelProduct";
            PanelProduct.Size = new Size(870, 100);
            PanelProduct.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.supermarketBackG;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblcategories
            // 
            lblcategories.AutoSize = true;
            lblcategories.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblcategories.Location = new Point(151, 33);
            lblcategories.Name = "lblcategories";
            lblcategories.Size = new Size(155, 37);
            lblcategories.TabIndex = 0;
            lblcategories.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoryList);
            tabControl1.Controls.Add(tabPageCategoryDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(870, 486);
            tabControl1.TabIndex = 3;
            // 
            // tabPageCategoryList
            // 
            tabPageCategoryList.Controls.Add(BtnSearch2);
            tabPageCategoryList.Controls.Add(BtnCloseCat);
            tabPageCategoryList.Controls.Add(BtnDeleteCat);
            tabPageCategoryList.Controls.Add(BtnEditCat);
            tabPageCategoryList.Controls.Add(BtnNewCat);
            tabPageCategoryList.Controls.Add(DgCategory);
            tabPageCategoryList.Controls.Add(TxtSearchCat);
            tabPageCategoryList.Controls.Add(Lbl1);
            tabPageCategoryList.Location = new Point(4, 24);
            tabPageCategoryList.Name = "tabPageCategoryList";
            tabPageCategoryList.Padding = new Padding(3);
            tabPageCategoryList.Size = new Size(862, 458);
            tabPageCategoryList.TabIndex = 0;
            tabPageCategoryList.Text = "Category List";
            tabPageCategoryList.UseVisualStyleBackColor = true;
            tabPageCategoryList.Click += tabPageCategoryList_Click;
            // 
            // BtnSearch2
            // 
            BtnSearch2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch2.Image = Properties.Resources.search_small;
            BtnSearch2.Location = new Point(419, 45);
            BtnSearch2.Name = "BtnSearch2";
            BtnSearch2.Size = new Size(53, 43);
            BtnSearch2.TabIndex = 17;
            BtnSearch2.UseVisualStyleBackColor = true;
            BtnSearch2.Click += BtnSearch2_Click;
            // 
            // BtnCloseCat
            // 
            BtnCloseCat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCloseCat.Image = Properties.Resources.cerrar;
            BtnCloseCat.Location = new Point(637, 356);
            BtnCloseCat.Name = "BtnCloseCat";
            BtnCloseCat.Size = new Size(196, 62);
            BtnCloseCat.TabIndex = 16;
            BtnCloseCat.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteCat
            // 
            BtnDeleteCat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteCat.Image = Properties.Resources.delete;
            BtnDeleteCat.Location = new Point(637, 269);
            BtnDeleteCat.Name = "BtnDeleteCat";
            BtnDeleteCat.Size = new Size(196, 62);
            BtnDeleteCat.TabIndex = 15;
            BtnDeleteCat.UseVisualStyleBackColor = true;
            // 
            // BtnEditCat
            // 
            BtnEditCat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditCat.Image = Properties.Resources.edit;
            BtnEditCat.Location = new Point(637, 184);
            BtnEditCat.Name = "BtnEditCat";
            BtnEditCat.Size = new Size(196, 62);
            BtnEditCat.TabIndex = 14;
            BtnEditCat.UseVisualStyleBackColor = true;
            // 
            // BtnNewCat
            // 
            BtnNewCat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNewCat.Image = Properties.Resources._new;
            BtnNewCat.Location = new Point(637, 94);
            BtnNewCat.Name = "BtnNewCat";
            BtnNewCat.Size = new Size(196, 62);
            BtnNewCat.TabIndex = 13;
            BtnNewCat.UseVisualStyleBackColor = true;
            // 
            // DgCategory
            // 
            DgCategory.AllowUserToAddRows = false;
            DgCategory.AllowUserToDeleteRows = false;
            DgCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategory.Location = new Point(27, 94);
            DgCategory.Name = "DgCategory";
            DgCategory.ReadOnly = true;
            DgCategory.RowHeadersWidth = 51;
            DgCategory.RowTemplate.Height = 25;
            DgCategory.Size = new Size(570, 327);
            DgCategory.TabIndex = 3;
            // 
            // TxtSearchCat
            // 
            TxtSearchCat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearchCat.Location = new Point(27, 57);
            TxtSearchCat.Name = "TxtSearchCat";
            TxtSearchCat.PlaceholderText = "Data to search";
            TxtSearchCat.Size = new Size(386, 23);
            TxtSearchCat.TabIndex = 1;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(27, 23);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(101, 15);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Search Categories";
            // 
            // tabPageCategoryDetail
            // 
            tabPageCategoryDetail.Controls.Add(BtnCancelCat);
            tabPageCategoryDetail.Controls.Add(BtnSaveCat);
            tabPageCategoryDetail.Controls.Add(label4);
            tabPageCategoryDetail.Controls.Add(label3);
            tabPageCategoryDetail.Controls.Add(label2);
            tabPageCategoryDetail.Controls.Add(TxtObserCat);
            tabPageCategoryDetail.Controls.Add(TxtCategoryName);
            tabPageCategoryDetail.Controls.Add(TxtCategoryId);
            tabPageCategoryDetail.Location = new Point(4, 24);
            tabPageCategoryDetail.Name = "tabPageCategoryDetail";
            tabPageCategoryDetail.Padding = new Padding(3);
            tabPageCategoryDetail.Size = new Size(862, 458);
            tabPageCategoryDetail.TabIndex = 1;
            tabPageCategoryDetail.Text = "Category Detail";
            tabPageCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancelCat
            // 
            BtnCancelCat.Image = Properties.Resources.cancel;
            BtnCancelCat.Location = new Point(179, 287);
            BtnCancelCat.Name = "BtnCancelCat";
            BtnCancelCat.Size = new Size(98, 88);
            BtnCancelCat.TabIndex = 7;
            BtnCancelCat.UseVisualStyleBackColor = true;
            // 
            // BtnSaveCat
            // 
            BtnSaveCat.Image = Properties.Resources.save;
            BtnSaveCat.Location = new Point(20, 287);
            BtnSaveCat.Name = "BtnSaveCat";
            BtnSaveCat.Size = new Size(99, 88);
            BtnSaveCat.TabIndex = 6;
            BtnSaveCat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 144);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 5;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 83);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 4;
            label3.Text = "Category Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 26);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Category Id";
            // 
            // TxtObserCat
            // 
            TxtObserCat.Location = new Point(20, 164);
            TxtObserCat.Multiline = true;
            TxtObserCat.Name = "TxtObserCat";
            TxtObserCat.PlaceholderText = "Description";
            TxtObserCat.Size = new Size(362, 81);
            TxtObserCat.TabIndex = 2;
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.Location = new Point(20, 101);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.PlaceholderText = "Description";
            TxtCategoryName.Size = new Size(362, 23);
            TxtCategoryName.TabIndex = 1;
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Location = new Point(20, 41);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.ReadOnly = true;
            TxtCategoryId.Size = new Size(191, 23);
            TxtCategoryId.TabIndex = 0;
            TxtCategoryId.Text = "0";
            TxtCategoryId.TextAlign = HorizontalAlignment.Right;
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 586);
            Controls.Add(tabControl1);
            Controls.Add(PanelProduct);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CategoryView";
            Text = "CategoryView";
            PanelProduct.ResumeLayout(false);
            PanelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategoryList.ResumeLayout(false);
            tabPageCategoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).EndInit();
            tabPageCategoryDetail.ResumeLayout(false);
            tabPageCategoryDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelProduct;
        private PictureBox pictureBox1;
        private Label lblcategories;
        private TabControl tabControl1;
        private TabPage tabPageCategoryList;

        private DataGridView DgCategory;



        private TextBox TxtSearchCat;
        private Label Lbl1;
        private TabPage tabPageCategoryDetail;
        private Button BtnCancelCat;
        private Button BtnSaveCat;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TxtObserCat;
        private TextBox TxtCategoryName;
        private TextBox TxtCategoryId;
        private Button BtnCloseCat;
        private Button BtnDeleteCat;
        private Button BtnEditCat;
        private Button BtnNewCat;
        private Button BtnSearch2;
    }
}
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
            BtnCloseCat = new Button();
            BtnDeleteCat = new Button();
            BtnEditCat = new Button();
            BtnNewCat = new Button();
            BtnCloseProd = new Button();
            BtnDeleteProd = new Button();
            DgCategory = new DataGridView();
            BtnEditProd = new Button();
            BtnNewProd = new Button();
            BtnSearchProd = new Button();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            TxtSearchCat = new TextBox();
            Lbl1 = new Label();
            tabPageCategoryDetail = new TabPage();
            BtnCancelCat = new Button();
            BtnSaveCat = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TxtDesCat = new TextBox();
            TxtCategoryName = new TextBox();
            TxtCategory = new TextBox();
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
            PanelProduct.Margin = new Padding(3, 4, 3, 4);
            PanelProduct.Name = "PanelProduct";
            PanelProduct.Size = new Size(994, 133);
            PanelProduct.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.supermarketBackG;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblcategories
            // 
            lblcategories.AutoSize = true;
            lblcategories.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblcategories.Location = new Point(173, 44);
            lblcategories.Name = "lblcategories";
            lblcategories.Size = new Size(189, 46);
            lblcategories.TabIndex = 0;
            lblcategories.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoryList);
            tabControl1.Controls.Add(tabPageCategoryDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 133);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(994, 649);
            tabControl1.TabIndex = 3;
            // 
            // tabPageCategoryList
            // 
            tabPageCategoryList.Controls.Add(BtnCloseCat);
            tabPageCategoryList.Controls.Add(BtnDeleteCat);
            tabPageCategoryList.Controls.Add(BtnEditCat);
            tabPageCategoryList.Controls.Add(BtnNewCat);
            tabPageCategoryList.Controls.Add(BtnCloseProd);
            tabPageCategoryList.Controls.Add(BtnDeleteProd);
            tabPageCategoryList.Controls.Add(DgCategory);
            tabPageCategoryList.Controls.Add(BtnEditProd);
            tabPageCategoryList.Controls.Add(BtnNewProd);
            tabPageCategoryList.Controls.Add(BtnSearchProd);
            tabPageCategoryList.Controls.Add(BtnClose);
            tabPageCategoryList.Controls.Add(BtnDelete);
            tabPageCategoryList.Controls.Add(BtnEdit);
            tabPageCategoryList.Controls.Add(BtnNew);
            tabPageCategoryList.Controls.Add(BtnSearch);
            tabPageCategoryList.Controls.Add(TxtSearchCat);
            tabPageCategoryList.Controls.Add(Lbl1);
            tabPageCategoryList.Location = new Point(4, 29);
            tabPageCategoryList.Margin = new Padding(3, 4, 3, 4);
            tabPageCategoryList.Name = "tabPageCategoryList";
            tabPageCategoryList.Padding = new Padding(3, 4, 3, 4);
            tabPageCategoryList.Size = new Size(986, 616);
            tabPageCategoryList.TabIndex = 0;
            tabPageCategoryList.Text = "Category List";
            tabPageCategoryList.UseVisualStyleBackColor = true;
            // 
            // BtnCloseCat
            // 
            BtnCloseCat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCloseCat.Image = Properties.Resources.cerrar;
            BtnCloseCat.Location = new Point(728, 475);
            BtnCloseCat.Margin = new Padding(3, 4, 3, 4);
            BtnCloseCat.Name = "BtnCloseCat";
            BtnCloseCat.Size = new Size(224, 83);
            BtnCloseCat.TabIndex = 16;
            BtnCloseCat.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteCat
            // 
            BtnDeleteCat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteCat.Image = Properties.Resources.delete;
            BtnDeleteCat.Location = new Point(728, 359);
            BtnDeleteCat.Margin = new Padding(3, 4, 3, 4);
            BtnDeleteCat.Name = "BtnDeleteCat";
            BtnDeleteCat.Size = new Size(224, 83);
            BtnDeleteCat.TabIndex = 15;
            BtnDeleteCat.UseVisualStyleBackColor = true;
            // 
            // BtnEditCat
            // 
            BtnEditCat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditCat.Image = Properties.Resources.edit;
            BtnEditCat.Location = new Point(728, 245);
            BtnEditCat.Margin = new Padding(3, 4, 3, 4);
            BtnEditCat.Name = "BtnEditCat";
            BtnEditCat.Size = new Size(224, 83);
            BtnEditCat.TabIndex = 14;
            BtnEditCat.UseVisualStyleBackColor = true;
            // 
            // BtnNewCat
            // 
            BtnNewCat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNewCat.Image = Properties.Resources._new;
            BtnNewCat.Location = new Point(728, 125);
            BtnNewCat.Margin = new Padding(3, 4, 3, 4);
            BtnNewCat.Name = "BtnNewCat";
            BtnNewCat.Size = new Size(224, 83);
            BtnNewCat.TabIndex = 13;
            BtnNewCat.UseVisualStyleBackColor = true;
            // 
            // BtnCloseProd
            // 
            BtnCloseProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCloseProd.Image = Properties.Resources.cerrar;
            BtnCloseProd.Location = new Point(1647, 464);
            BtnCloseProd.Margin = new Padding(3, 4, 3, 4);
            BtnCloseProd.Name = "BtnCloseProd";
            BtnCloseProd.Size = new Size(224, 83);
            BtnCloseProd.TabIndex = 12;
            BtnCloseProd.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteProd
            // 
            BtnDeleteProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteProd.Image = Properties.Resources.delete;
            BtnDeleteProd.Location = new Point(1647, 359);
            BtnDeleteProd.Margin = new Padding(3, 4, 3, 4);
            BtnDeleteProd.Name = "BtnDeleteProd";
            BtnDeleteProd.Size = new Size(224, 83);
            BtnDeleteProd.TabIndex = 11;
            BtnDeleteProd.UseVisualStyleBackColor = true;
            // 
            // DgCategory
            // 
            DgCategory.AllowUserToAddRows = false;
            DgCategory.AllowUserToDeleteRows = false;
            DgCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategory.Location = new Point(31, 125);
            DgCategory.Margin = new Padding(3, 4, 3, 4);
            DgCategory.Name = "DgCategory";
            DgCategory.ReadOnly = true;
            DgCategory.RowHeadersWidth = 51;
            DgCategory.RowTemplate.Height = 25;
            DgCategory.Size = new Size(651, 437);
            DgCategory.TabIndex = 3;
            // 
            // BtnEditProd
            // 
            BtnEditProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditProd.Image = Properties.Resources.edit;
            BtnEditProd.Location = new Point(1647, 252);
            BtnEditProd.Margin = new Padding(3, 4, 3, 4);
            BtnEditProd.Name = "BtnEditProd";
            BtnEditProd.Size = new Size(224, 83);
            BtnEditProd.TabIndex = 10;
            BtnEditProd.UseVisualStyleBackColor = true;
            // 
            // BtnNewProd
            // 
            BtnNewProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNewProd.Image = Properties.Resources._new;
            BtnNewProd.Location = new Point(1647, 136);
            BtnNewProd.Margin = new Padding(3, 4, 3, 4);
            BtnNewProd.Name = "BtnNewProd";
            BtnNewProd.Size = new Size(224, 83);
            BtnNewProd.TabIndex = 9;
            BtnNewProd.UseVisualStyleBackColor = true;
            // 
            // BtnSearchProd
            // 
            BtnSearchProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchProd.Image = Properties.Resources.search_small;
            BtnSearchProd.Location = new Point(1349, 46);
            BtnSearchProd.Margin = new Padding(3, 4, 3, 4);
            BtnSearchProd.Name = "BtnSearchProd";
            BtnSearchProd.Size = new Size(55, 57);
            BtnSearchProd.TabIndex = 8;
            BtnSearchProd.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(2348, 469);
            BtnClose.Margin = new Padding(3, 4, 3, 4);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(224, 83);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(2348, 365);
            BtnDelete.Margin = new Padding(3, 4, 3, 4);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(224, 83);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(2348, 251);
            BtnEdit.Margin = new Padding(3, 4, 3, 4);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(224, 83);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(2348, 133);
            BtnNew.Margin = new Padding(3, 4, 3, 4);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(224, 83);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(2286, 49);
            BtnSearch.Margin = new Padding(3, 4, 3, 4);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(55, 57);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearchCat
            // 
            TxtSearchCat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearchCat.Location = new Point(31, 76);
            TxtSearchCat.Margin = new Padding(3, 4, 3, 4);
            TxtSearchCat.Name = "TxtSearchCat";
            TxtSearchCat.PlaceholderText = "Data to search";
            TxtSearchCat.Size = new Size(440, 27);
            TxtSearchCat.TabIndex = 1;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(31, 31);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(128, 20);
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
            tabPageCategoryDetail.Controls.Add(TxtDesCat);
            tabPageCategoryDetail.Controls.Add(TxtCategoryName);
            tabPageCategoryDetail.Controls.Add(TxtCategory);
            tabPageCategoryDetail.Location = new Point(4, 29);
            tabPageCategoryDetail.Margin = new Padding(3, 4, 3, 4);
            tabPageCategoryDetail.Name = "tabPageCategoryDetail";
            tabPageCategoryDetail.Padding = new Padding(3, 4, 3, 4);
            tabPageCategoryDetail.Size = new Size(986, 616);
            tabPageCategoryDetail.TabIndex = 1;
            tabPageCategoryDetail.Text = "Category Detail";
            tabPageCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancelCat
            // 
            BtnCancelCat.Image = Properties.Resources.cancel;
            BtnCancelCat.Location = new Point(205, 383);
            BtnCancelCat.Margin = new Padding(3, 4, 3, 4);
            BtnCancelCat.Name = "BtnCancelCat";
            BtnCancelCat.Size = new Size(112, 118);
            BtnCancelCat.TabIndex = 7;
            BtnCancelCat.UseVisualStyleBackColor = true;
            // 
            // BtnSaveCat
            // 
            BtnSaveCat.Image = Properties.Resources.save;
            BtnSaveCat.Location = new Point(23, 383);
            BtnSaveCat.Margin = new Padding(3, 4, 3, 4);
            BtnSaveCat.Name = "BtnSaveCat";
            BtnSaveCat.Size = new Size(113, 118);
            BtnSaveCat.TabIndex = 6;
            BtnSaveCat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 192);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 5;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 111);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 4;
            label3.Text = "Category Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 34);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Category Id";
            // 
            // TxtDesCat
            // 
            TxtDesCat.Location = new Point(23, 218);
            TxtDesCat.Margin = new Padding(3, 4, 3, 4);
            TxtDesCat.Multiline = true;
            TxtDesCat.Name = "TxtDesCat";
            TxtDesCat.PlaceholderText = "Description";
            TxtDesCat.Size = new Size(413, 107);
            TxtDesCat.TabIndex = 2;
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.Location = new Point(23, 135);
            TxtCategoryName.Margin = new Padding(3, 4, 3, 4);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.PlaceholderText = "Description";
            TxtCategoryName.Size = new Size(413, 27);
            TxtCategoryName.TabIndex = 1;
            // 
            // TxtCategory
            // 
            TxtCategory.Location = new Point(23, 55);
            TxtCategory.Margin = new Padding(3, 4, 3, 4);
            TxtCategory.Name = "TxtCategory";
            TxtCategory.ReadOnly = true;
            TxtCategory.Size = new Size(218, 27);
            TxtCategory.TabIndex = 0;
            TxtCategory.Text = "0";
            TxtCategory.TextAlign = HorizontalAlignment.Right;
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 782);
            Controls.Add(tabControl1);
            Controls.Add(PanelProduct);
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
        private Button BtnCloseProd;
        private Button BtnDeleteProd;
        private DataGridView DgCategory;
        private Button BtnEditProd;
        private Button BtnNewProd;
        private Button BtnSearchProd;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private TextBox TxtSearchCat;
        private Label Lbl1;
        private TabPage tabPageCategoryDetail;
        private Button BtnCancelCat;
        private Button BtnSaveCat;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TxtDesCat;
        private TextBox TxtCategoryName;
        private TextBox TxtCategory;
        private Button BtnCloseCat;
        private Button BtnDeleteCat;
        private Button BtnEditCat;
        private Button BtnNewCat;
    }
}
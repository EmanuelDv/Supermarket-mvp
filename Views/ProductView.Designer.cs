namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            lblProducts = new Label();
            tabControl1 = new TabControl();
            tabPageProductsList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProducts = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            Lbl1 = new Label();
            tabPageProductsDetail = new TabPage();
            BtnCancelProd = new Button();
            BtnSaveProd = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPriceProd = new TextBox();
            TxtProductsName = new TextBox();
            TxtProductsId = new TextBox();
            BtnSearchProd = new Button();
            BtnNewProd = new Button();
            BtnEditProd = new Button();
            BtnDeleteProd = new Button();
            BtnCloseProd = new Button();
            lblprice = new Label();
            TxtStockPro = new TextBox();
            label1 = new Label();
            TxtCatId = new TextBox();
            PanelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            tabPageProductsDetail.SuspendLayout();
            SuspendLayout();
            // 
            // PanelProduct
            // 
            PanelProduct.Controls.Add(pictureBox1);
            PanelProduct.Controls.Add(lblProducts);
            PanelProduct.Dock = DockStyle.Top;
            PanelProduct.Location = new Point(0, 0);
            PanelProduct.Margin = new Padding(3, 4, 3, 4);
            PanelProduct.Name = "PanelProduct";
            PanelProduct.Size = new Size(1104, 133);
            PanelProduct.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblProducts.Location = new Point(173, 44);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(162, 46);
            lblProducts.TabIndex = 0;
            lblProducts.Text = "Products";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductsList);
            tabControl1.Controls.Add(tabPageProductsDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 133);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1104, 609);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProductsList
            // 
            tabPageProductsList.Controls.Add(BtnCloseProd);
            tabPageProductsList.Controls.Add(BtnDeleteProd);
            tabPageProductsList.Controls.Add(BtnEditProd);
            tabPageProductsList.Controls.Add(BtnNewProd);
            tabPageProductsList.Controls.Add(BtnSearchProd);
            tabPageProductsList.Controls.Add(BtnClose);
            tabPageProductsList.Controls.Add(BtnDelete);
            tabPageProductsList.Controls.Add(DgProducts);
            tabPageProductsList.Controls.Add(BtnEdit);
            tabPageProductsList.Controls.Add(BtnNew);
            tabPageProductsList.Controls.Add(BtnSearch);
            tabPageProductsList.Controls.Add(TxtSearch);
            tabPageProductsList.Controls.Add(Lbl1);
            tabPageProductsList.Location = new Point(4, 29);
            tabPageProductsList.Margin = new Padding(3, 4, 3, 4);
            tabPageProductsList.Name = "tabPageProductsList";
            tabPageProductsList.Padding = new Padding(3, 4, 3, 4);
            tabPageProductsList.Size = new Size(1096, 576);
            tabPageProductsList.TabIndex = 0;
            tabPageProductsList.Text = "Products List";
            tabPageProductsList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(1565, 465);
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
            BtnDelete.Location = new Point(1565, 361);
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
            BtnEdit.Location = new Point(1565, 247);
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
            BtnNew.Location = new Point(1565, 129);
            BtnNew.Margin = new Padding(3, 4, 3, 4);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(224, 83);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(28, 156);
            DgProducts.Margin = new Padding(3, 4, 3, 4);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.RowHeadersWidth = 51;
            DgProducts.RowTemplate.Height = 25;
            DgProducts.Size = new Size(766, 411);
            DgProducts.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(1503, 45);
            BtnSearch.Margin = new Padding(3, 4, 3, 4);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(55, 57);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(28, 72);
            TxtSearch.Margin = new Padding(3, 4, 3, 4);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(532, 27);
            TxtSearch.TabIndex = 1;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(28, 27);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(108, 20);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Search Product";
            // 
            // tabPageProductsDetail
            // 
            tabPageProductsDetail.Controls.Add(label1);
            tabPageProductsDetail.Controls.Add(TxtCatId);
            tabPageProductsDetail.Controls.Add(lblprice);
            tabPageProductsDetail.Controls.Add(TxtStockPro);
            tabPageProductsDetail.Controls.Add(BtnCancelProd);
            tabPageProductsDetail.Controls.Add(BtnSaveProd);
            tabPageProductsDetail.Controls.Add(label4);
            tabPageProductsDetail.Controls.Add(label3);
            tabPageProductsDetail.Controls.Add(label2);
            tabPageProductsDetail.Controls.Add(txtPriceProd);
            tabPageProductsDetail.Controls.Add(TxtProductsName);
            tabPageProductsDetail.Controls.Add(TxtProductsId);
            tabPageProductsDetail.Location = new Point(4, 29);
            tabPageProductsDetail.Margin = new Padding(3, 4, 3, 4);
            tabPageProductsDetail.Name = "tabPageProductsDetail";
            tabPageProductsDetail.Padding = new Padding(3, 4, 3, 4);
            tabPageProductsDetail.Size = new Size(1096, 576);
            tabPageProductsDetail.TabIndex = 1;
            tabPageProductsDetail.Text = "Products Detail";
            tabPageProductsDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancelProd
            // 
            BtnCancelProd.Image = Properties.Resources.cancel;
            BtnCancelProd.Location = new Point(205, 383);
            BtnCancelProd.Margin = new Padding(3, 4, 3, 4);
            BtnCancelProd.Name = "BtnCancelProd";
            BtnCancelProd.Size = new Size(112, 118);
            BtnCancelProd.TabIndex = 7;
            BtnCancelProd.UseVisualStyleBackColor = true;
            // 
            // BtnSaveProd
            // 
            BtnSaveProd.Image = Properties.Resources.save;
            BtnSaveProd.Location = new Point(23, 383);
            BtnSaveProd.Margin = new Padding(3, 4, 3, 4);
            BtnSaveProd.Name = "BtnSaveProd";
            BtnSaveProd.Size = new Size(113, 118);
            BtnSaveProd.TabIndex = 6;
            BtnSaveProd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 165);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 5;
            label4.Text = "Product Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 100);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 4;
            label3.Text = "Products Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 35);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Products Id";
            // 
            // txtPriceProd
            // 
            txtPriceProd.Location = new Point(23, 189);
            txtPriceProd.Margin = new Padding(3, 4, 3, 4);
            txtPriceProd.Name = "txtPriceProd";
            txtPriceProd.PlaceholderText = "Product Price";
            txtPriceProd.Size = new Size(413, 27);
            txtPriceProd.TabIndex = 2;
            // 
            // TxtProductsName
            // 
            TxtProductsName.Location = new Point(23, 124);
            TxtProductsName.Margin = new Padding(3, 4, 3, 4);
            TxtProductsName.Name = "TxtProductsName";
            TxtProductsName.PlaceholderText = "Products Name";
            TxtProductsName.Size = new Size(413, 27);
            TxtProductsName.TabIndex = 1;
            // 
            // TxtProductsId
            // 
            TxtProductsId.Location = new Point(23, 55);
            TxtProductsId.Margin = new Padding(3, 4, 3, 4);
            TxtProductsId.Name = "TxtProductsId";
            TxtProductsId.ReadOnly = true;
            TxtProductsId.Size = new Size(218, 27);
            TxtProductsId.TabIndex = 0;
            TxtProductsId.Text = "0";
            TxtProductsId.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnSearchProd
            // 
            BtnSearchProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchProd.Image = Properties.Resources.search_small;
            BtnSearchProd.Location = new Point(566, 42);
            BtnSearchProd.Margin = new Padding(3, 4, 3, 4);
            BtnSearchProd.Name = "BtnSearchProd";
            BtnSearchProd.Size = new Size(55, 57);
            BtnSearchProd.TabIndex = 8;
            BtnSearchProd.UseVisualStyleBackColor = true;
            // 
            // BtnNewProd
            // 
            BtnNewProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNewProd.Image = Properties.Resources._new;
            BtnNewProd.Location = new Point(864, 132);
            BtnNewProd.Margin = new Padding(3, 4, 3, 4);
            BtnNewProd.Name = "BtnNewProd";
            BtnNewProd.Size = new Size(224, 83);
            BtnNewProd.TabIndex = 9;
            BtnNewProd.UseVisualStyleBackColor = true;
            // 
            // BtnEditProd
            // 
            BtnEditProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditProd.Image = Properties.Resources.edit;
            BtnEditProd.Location = new Point(864, 248);
            BtnEditProd.Margin = new Padding(3, 4, 3, 4);
            BtnEditProd.Name = "BtnEditProd";
            BtnEditProd.Size = new Size(224, 83);
            BtnEditProd.TabIndex = 10;
            BtnEditProd.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteProd
            // 
            BtnDeleteProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteProd.Image = Properties.Resources.delete;
            BtnDeleteProd.Location = new Point(864, 355);
            BtnDeleteProd.Margin = new Padding(3, 4, 3, 4);
            BtnDeleteProd.Name = "BtnDeleteProd";
            BtnDeleteProd.Size = new Size(224, 83);
            BtnDeleteProd.TabIndex = 11;
            BtnDeleteProd.UseVisualStyleBackColor = true;
            // 
            // BtnCloseProd
            // 
            BtnCloseProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCloseProd.Image = Properties.Resources.cerrar;
            BtnCloseProd.Location = new Point(864, 460);
            BtnCloseProd.Margin = new Padding(3, 4, 3, 4);
            BtnCloseProd.Name = "BtnCloseProd";
            BtnCloseProd.Size = new Size(224, 83);
            BtnCloseProd.TabIndex = 12;
            BtnCloseProd.UseVisualStyleBackColor = true;
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Location = new Point(26, 226);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(45, 20);
            lblprice.TabIndex = 9;
            lblprice.Text = "Stock";
            // 
            // TxtStockPro
            // 
            TxtStockPro.Location = new Point(23, 250);
            TxtStockPro.Margin = new Padding(3, 4, 3, 4);
            TxtStockPro.Name = "TxtStockPro";
            TxtStockPro.PlaceholderText = "Stock Proucts";
            TxtStockPro.Size = new Size(413, 27);
            TxtStockPro.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 286);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 11;
            label1.Text = "Category_Id";
            // 
            // TxtCatId
            // 
            TxtCatId.Location = new Point(23, 310);
            TxtCatId.Margin = new Padding(3, 4, 3, 4);
            TxtCatId.Name = "TxtCatId";
            TxtCatId.PlaceholderText = "Category id";
            TxtCatId.Size = new Size(413, 27);
            TxtCatId.TabIndex = 10;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 742);
            Controls.Add(tabControl1);
            Controls.Add(PanelProduct);
            Name = "ProductView";
            Text = "Product Management";
            PanelProduct.ResumeLayout(false);
            PanelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductsList.ResumeLayout(false);
            tabPageProductsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            tabPageProductsDetail.ResumeLayout(false);
            tabPageProductsDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelProduct;
        private PictureBox pictureBox1;
        private Label lblProducts;
        private TabControl tabControl1;
        private TabPage tabPageProductsList;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProducts;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label Lbl1;
        private TabPage tabPageProductsDetail;
        private Button BtnCancelProd;
        private Button BtnSaveProd;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPriceProd;
        private TextBox TxtProductsName;
        private TextBox TxtProductsId;
        private Button BtnSearchProd;
        private Button BtnNewProd;
        private Button BtnEditProd;
        private Button BtnDeleteProd;
        private Button BtnCloseProd;
        private Label lblprice;
        private TextBox TxtStockPro;
        private Label label1;
        private TextBox TxtCatId;
    }
}
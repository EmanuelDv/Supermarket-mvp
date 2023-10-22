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
            BtnCloseProd = new Button();
            BtnDeleteProd = new Button();
            BtnEditProd = new Button();
            BtnNewProd = new Button();
            BtnSearchProd = new Button();
            BtnClose = new Button();
            BtnDelete = new Button();
            DgProducts = new DataGridView();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            TxtSearchProd = new TextBox();
            Lbl1 = new Label();
            tabPageProductsDetail = new TabPage();
            label1 = new Label();
            TxtCatId = new TextBox();
            lblprice = new Label();
            TxtStockPro = new TextBox();
            BtnCancelProd = new Button();
            BtnSaveProd = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TxtPriceProdu = new TextBox();
            TxtProductsName = new TextBox();
            TxtProductsId = new TextBox();
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
            PanelProduct.Name = "PanelProduct";
            PanelProduct.Size = new Size(966, 100);
            PanelProduct.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblProducts.Location = new Point(151, 33);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(131, 37);
            lblProducts.TabIndex = 0;
            lblProducts.Text = "Products";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductsList);
            tabControl1.Controls.Add(tabPageProductsDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(966, 456);
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
            tabPageProductsList.Controls.Add(TxtSearchProd);
            tabPageProductsList.Controls.Add(Lbl1);
            tabPageProductsList.Location = new Point(4, 24);
            tabPageProductsList.Name = "tabPageProductsList";
            tabPageProductsList.Padding = new Padding(3);
            tabPageProductsList.Size = new Size(958, 428);
            tabPageProductsList.TabIndex = 0;
            tabPageProductsList.Text = "Products List";
            tabPageProductsList.UseVisualStyleBackColor = true;
            // 
            // BtnCloseProd
            // 
            BtnCloseProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCloseProd.Image = Properties.Resources.cerrar;
            BtnCloseProd.Location = new Point(756, 345);
            BtnCloseProd.Name = "BtnCloseProd";
            BtnCloseProd.Size = new Size(196, 62);
            BtnCloseProd.TabIndex = 12;
            BtnCloseProd.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteProd
            // 
            BtnDeleteProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteProd.Image = Properties.Resources.delete;
            BtnDeleteProd.Location = new Point(756, 266);
            BtnDeleteProd.Name = "BtnDeleteProd";
            BtnDeleteProd.Size = new Size(196, 62);
            BtnDeleteProd.TabIndex = 11;
            BtnDeleteProd.UseVisualStyleBackColor = true;
            // 
            // BtnEditProd
            // 
            BtnEditProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditProd.Image = Properties.Resources.edit;
            BtnEditProd.Location = new Point(756, 186);
            BtnEditProd.Name = "BtnEditProd";
            BtnEditProd.Size = new Size(196, 62);
            BtnEditProd.TabIndex = 10;
            BtnEditProd.UseVisualStyleBackColor = true;
            // 
            // BtnNewProd
            // 
            BtnNewProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNewProd.Image = Properties.Resources._new;
            BtnNewProd.Location = new Point(756, 99);
            BtnNewProd.Name = "BtnNewProd";
            BtnNewProd.Size = new Size(196, 62);
            BtnNewProd.TabIndex = 9;
            BtnNewProd.UseVisualStyleBackColor = true;
            // 
            // BtnSearchProd
            // 
            BtnSearchProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchProd.Image = Properties.Resources.search_small;
            BtnSearchProd.Location = new Point(495, 32);
            BtnSearchProd.Name = "BtnSearchProd";
            BtnSearchProd.Size = new Size(48, 43);
            BtnSearchProd.TabIndex = 8;
            BtnSearchProd.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(1369, 349);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(196, 62);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(1369, 271);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(196, 62);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(24, 117);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.RowHeadersWidth = 51;
            DgProducts.RowTemplate.Height = 25;
            DgProducts.Size = new Size(670, 307);
            DgProducts.TabIndex = 3;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(1369, 185);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(196, 62);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(1369, 97);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(196, 62);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(1315, 34);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(48, 43);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearchProd
            // 
            TxtSearchProd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearchProd.Location = new Point(24, 54);
            TxtSearchProd.Name = "TxtSearchProd";
            TxtSearchProd.PlaceholderText = "Data to search";
            TxtSearchProd.Size = new Size(466, 23);
            TxtSearchProd.TabIndex = 1;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(24, 20);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(87, 15);
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
            tabPageProductsDetail.Controls.Add(TxtPriceProdu);
            tabPageProductsDetail.Controls.Add(TxtProductsName);
            tabPageProductsDetail.Controls.Add(TxtProductsId);
            tabPageProductsDetail.Location = new Point(4, 24);
            tabPageProductsDetail.Name = "tabPageProductsDetail";
            tabPageProductsDetail.Padding = new Padding(3);
            tabPageProductsDetail.Size = new Size(958, 428);
            tabPageProductsDetail.TabIndex = 1;
            tabPageProductsDetail.Text = "Products Detail";
            tabPageProductsDetail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 214);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 11;
            label1.Text = "Category_Id";
            // 
            // TxtCatId
            // 
            TxtCatId.Location = new Point(20, 232);
            TxtCatId.Name = "TxtCatId";
            TxtCatId.PlaceholderText = "Category id";
            TxtCatId.Size = new Size(362, 23);
            TxtCatId.TabIndex = 10;
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Location = new Point(23, 170);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(36, 15);
            lblprice.TabIndex = 9;
            lblprice.Text = "Stock";
            // 
            // TxtStockPro
            // 
            TxtStockPro.Location = new Point(20, 188);
            TxtStockPro.Name = "TxtStockPro";
            TxtStockPro.PlaceholderText = "Stock Proucts";
            TxtStockPro.Size = new Size(362, 23);
            TxtStockPro.TabIndex = 8;
            // 
            // BtnCancelProd
            // 
            BtnCancelProd.Image = Properties.Resources.cancel;
            BtnCancelProd.Location = new Point(179, 287);
            BtnCancelProd.Name = "BtnCancelProd";
            BtnCancelProd.Size = new Size(98, 88);
            BtnCancelProd.TabIndex = 7;
            BtnCancelProd.UseVisualStyleBackColor = true;
            // 
            // BtnSaveProd
            // 
            BtnSaveProd.Image = Properties.Resources.save;
            BtnSaveProd.Location = new Point(20, 287);
            BtnSaveProd.Name = "BtnSaveProd";
            BtnSaveProd.Size = new Size(99, 88);
            BtnSaveProd.TabIndex = 6;
            BtnSaveProd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 124);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 5;
            label4.Text = "Product Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 75);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 4;
            label3.Text = "Products Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 26);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Products Id";
            // 
            // TxtPriceProdu
            // 
            TxtPriceProdu.Location = new Point(20, 142);
            TxtPriceProdu.Name = "TxtPriceProdu";
            TxtPriceProdu.PlaceholderText = "Product Price";
            TxtPriceProdu.Size = new Size(362, 23);
            TxtPriceProdu.TabIndex = 2;
            // 
            // TxtProductsName
            // 
            TxtProductsName.Location = new Point(20, 93);
            TxtProductsName.Name = "TxtProductsName";
            TxtProductsName.PlaceholderText = "Products Name";
            TxtProductsName.Size = new Size(362, 23);
            TxtProductsName.TabIndex = 1;
            // 
            // TxtProductsId
            // 
            TxtProductsId.Location = new Point(20, 41);
            TxtProductsId.Name = "TxtProductsId";
            TxtProductsId.ReadOnly = true;
            TxtProductsId.Size = new Size(191, 23);
            TxtProductsId.TabIndex = 0;
            TxtProductsId.Text = "0";
            TxtProductsId.TextAlign = HorizontalAlignment.Right;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 556);
            Controls.Add(tabControl1);
            Controls.Add(PanelProduct);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox TxtSearchProd;
        private Label Lbl1;
        private TabPage tabPageProductsDetail;
        private Button BtnCancelProd;
        private Button BtnSaveProd;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TxtPriceProdu;
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
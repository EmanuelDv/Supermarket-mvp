namespace Supermarket_mvp.Views
{
    partial class ProvidersView
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
            lblProviders = new Label();
            tabControl1 = new TabControl();
            tabPageProvidersList = new TabPage();
            BtnCloseProd = new Button();
            BtnDeleteProd = new Button();
            BtnEditProd = new Button();
            BtnNewProd = new Button();
            BtnSearchProd = new Button();
            BtnClose = new Button();
            BtnDelete = new Button();
            DgProviders = new DataGridView();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            TxtSearchProv = new TextBox();
            Lbl1 = new Label();
            tabPageProvidersDetail = new TabPage();
            lblprice = new Label();
            TxtObservationProv = new TextBox();
            BtnCancelProv = new Button();
            BtnSaveProv = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TxtPhoneProv = new TextBox();
            TxtProvidersName = new TextBox();
            TxtProvidersId = new TextBox();
            BtnSearchProv = new Button();
            BtnNewProv = new Button();
            BtnEditProv = new Button();
            BtnDeleteProv = new Button();
            BtnCloseProv = new Button();
            PanelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProvidersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
            tabPageProvidersDetail.SuspendLayout();
            SuspendLayout();
            // 
            // PanelProduct
            // 
            PanelProduct.Controls.Add(pictureBox1);
            PanelProduct.Controls.Add(lblProviders);
            PanelProduct.Dock = DockStyle.Top;
            PanelProduct.Location = new Point(0, 0);
            PanelProduct.Margin = new Padding(3, 4, 3, 4);
            PanelProduct.Name = "PanelProduct";
            PanelProduct.Size = new Size(1137, 133);
            PanelProduct.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblProviders
            // 
            lblProviders.AutoSize = true;
            lblProviders.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblProviders.Location = new Point(173, 44);
            lblProviders.Name = "lblProviders";
            lblProviders.Size = new Size(172, 46);
            lblProviders.TabIndex = 0;
            lblProviders.Text = "Providers";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProvidersList);
            tabControl1.Controls.Add(tabPageProvidersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 133);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1137, 604);
            tabControl1.TabIndex = 3;
            // 
            // tabPageProvidersList
            // 
            tabPageProvidersList.Controls.Add(BtnCloseProv);
            tabPageProvidersList.Controls.Add(BtnDeleteProv);
            tabPageProvidersList.Controls.Add(BtnEditProv);
            tabPageProvidersList.Controls.Add(BtnNewProv);
            tabPageProvidersList.Controls.Add(BtnSearchProv);
            tabPageProvidersList.Controls.Add(BtnCloseProd);
            tabPageProvidersList.Controls.Add(BtnDeleteProd);
            tabPageProvidersList.Controls.Add(DgProviders);
            tabPageProvidersList.Controls.Add(BtnEditProd);
            tabPageProvidersList.Controls.Add(BtnNewProd);
            tabPageProvidersList.Controls.Add(BtnSearchProd);
            tabPageProvidersList.Controls.Add(BtnClose);
            tabPageProvidersList.Controls.Add(BtnDelete);
            tabPageProvidersList.Controls.Add(BtnEdit);
            tabPageProvidersList.Controls.Add(BtnNew);
            tabPageProvidersList.Controls.Add(BtnSearch);
            tabPageProvidersList.Controls.Add(TxtSearchProv);
            tabPageProvidersList.Controls.Add(Lbl1);
            tabPageProvidersList.Location = new Point(4, 29);
            tabPageProvidersList.Margin = new Padding(3, 4, 3, 4);
            tabPageProvidersList.Name = "tabPageProvidersList";
            tabPageProvidersList.Padding = new Padding(3, 4, 3, 4);
            tabPageProvidersList.Size = new Size(1129, 571);
            tabPageProvidersList.TabIndex = 0;
            tabPageProvidersList.Text = "Providers List";
            tabPageProvidersList.UseVisualStyleBackColor = true;
            // 
            // BtnCloseProd
            // 
            BtnCloseProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCloseProd.Image = Properties.Resources.cerrar;
            BtnCloseProd.Location = new Point(1790, 464);
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
            BtnDeleteProd.Location = new Point(1790, 359);
            BtnDeleteProd.Margin = new Padding(3, 4, 3, 4);
            BtnDeleteProd.Name = "BtnDeleteProd";
            BtnDeleteProd.Size = new Size(224, 83);
            BtnDeleteProd.TabIndex = 11;
            BtnDeleteProd.UseVisualStyleBackColor = true;
            // 
            // BtnEditProd
            // 
            BtnEditProd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditProd.Image = Properties.Resources.edit;
            BtnEditProd.Location = new Point(1790, 252);
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
            BtnNewProd.Location = new Point(1790, 136);
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
            BtnSearchProd.Location = new Point(1492, 46);
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
            BtnClose.Location = new Point(2491, 469);
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
            BtnDelete.Location = new Point(2491, 365);
            BtnDelete.Margin = new Padding(3, 4, 3, 4);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(224, 83);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // DgProviders
            // 
            DgProviders.AllowUserToAddRows = false;
            DgProviders.AllowUserToDeleteRows = false;
            DgProviders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Location = new Point(31, 124);
            DgProviders.Margin = new Padding(3, 4, 3, 4);
            DgProviders.Name = "DgProviders";
            DgProviders.ReadOnly = true;
            DgProviders.RowHeadersWidth = 51;
            DgProviders.RowTemplate.Height = 25;
            DgProviders.Size = new Size(746, 423);
            DgProviders.TabIndex = 3;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(2491, 251);
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
            BtnNew.Location = new Point(2491, 133);
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
            BtnSearch.Location = new Point(2429, 49);
            BtnSearch.Margin = new Padding(3, 4, 3, 4);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(55, 57);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearchProv
            // 
            TxtSearchProv.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearchProv.Location = new Point(31, 76);
            TxtSearchProv.Margin = new Padding(3, 4, 3, 4);
            TxtSearchProv.Name = "TxtSearchProv";
            TxtSearchProv.PlaceholderText = "Data to search";
            TxtSearchProv.Size = new Size(521, 27);
            TxtSearchProv.TabIndex = 1;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(31, 31);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(118, 20);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Search Providers";
            // 
            // tabPageProvidersDetail
            // 
            tabPageProvidersDetail.Controls.Add(lblprice);
            tabPageProvidersDetail.Controls.Add(TxtObservationProv);
            tabPageProvidersDetail.Controls.Add(BtnCancelProv);
            tabPageProvidersDetail.Controls.Add(BtnSaveProv);
            tabPageProvidersDetail.Controls.Add(label4);
            tabPageProvidersDetail.Controls.Add(label3);
            tabPageProvidersDetail.Controls.Add(label2);
            tabPageProvidersDetail.Controls.Add(TxtPhoneProv);
            tabPageProvidersDetail.Controls.Add(TxtProvidersName);
            tabPageProvidersDetail.Controls.Add(TxtProvidersId);
            tabPageProvidersDetail.Location = new Point(4, 29);
            tabPageProvidersDetail.Margin = new Padding(3, 4, 3, 4);
            tabPageProvidersDetail.Name = "tabPageProvidersDetail";
            tabPageProvidersDetail.Padding = new Padding(3, 4, 3, 4);
            tabPageProvidersDetail.Size = new Size(1129, 571);
            tabPageProvidersDetail.TabIndex = 1;
            tabPageProvidersDetail.Text = "Providers Detail";
            tabPageProvidersDetail.UseVisualStyleBackColor = true;
            tabPageProvidersDetail.Click += tabPageProvidersDetail_Click;
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Location = new Point(29, 230);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(89, 20);
            lblprice.TabIndex = 9;
            lblprice.Text = "Observation";
            // 
            // TxtObservationProv
            // 
            TxtObservationProv.Location = new Point(23, 250);
            TxtObservationProv.Margin = new Padding(3, 4, 3, 4);
            TxtObservationProv.Multiline = true;
            TxtObservationProv.Name = "TxtObservationProv";
            TxtObservationProv.PlaceholderText = "Direction";
            TxtObservationProv.Size = new Size(413, 102);
            TxtObservationProv.TabIndex = 8;
            // 
            // BtnCancelProv
            // 
            BtnCancelProv.Image = Properties.Resources.cancel;
            BtnCancelProv.Location = new Point(205, 383);
            BtnCancelProv.Margin = new Padding(3, 4, 3, 4);
            BtnCancelProv.Name = "BtnCancelProv";
            BtnCancelProv.Size = new Size(112, 118);
            BtnCancelProv.TabIndex = 7;
            BtnCancelProv.UseVisualStyleBackColor = true;
            // 
            // BtnSaveProv
            // 
            BtnSaveProv.Image = Properties.Resources.save;
            BtnSaveProv.Location = new Point(23, 383);
            BtnSaveProv.Margin = new Padding(3, 4, 3, 4);
            BtnSaveProv.Name = "BtnSaveProv";
            BtnSaveProv.Size = new Size(113, 118);
            BtnSaveProv.TabIndex = 6;
            BtnSaveProv.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 169);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 103);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 4;
            label3.Text = "Providers Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 35);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 3;
            label2.Text = "Providers Nit";
            // 
            // TxtPhoneProv
            // 
            TxtPhoneProv.Location = new Point(23, 189);
            TxtPhoneProv.Margin = new Padding(3, 4, 3, 4);
            TxtPhoneProv.Name = "TxtPhoneProv";
            TxtPhoneProv.PlaceholderText = "Phone";
            TxtPhoneProv.Size = new Size(413, 27);
            TxtPhoneProv.TabIndex = 2;
            // 
            // TxtProvidersName
            // 
            TxtProvidersName.Location = new Point(23, 124);
            TxtProvidersName.Margin = new Padding(3, 4, 3, 4);
            TxtProvidersName.Name = "TxtProvidersName";
            TxtProvidersName.PlaceholderText = "Products Name";
            TxtProvidersName.Size = new Size(413, 27);
            TxtProvidersName.TabIndex = 1;
            // 
            // TxtProvidersId
            // 
            TxtProvidersId.Location = new Point(23, 55);
            TxtProvidersId.Margin = new Padding(3, 4, 3, 4);
            TxtProvidersId.Name = "TxtProvidersId";
            TxtProvidersId.ReadOnly = true;
            TxtProvidersId.Size = new Size(218, 27);
            TxtProvidersId.TabIndex = 0;
            TxtProvidersId.Text = "0";
            TxtProvidersId.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnSearchProv
            // 
            BtnSearchProv.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchProv.Image = Properties.Resources.search_small;
            BtnSearchProv.Location = new Point(558, 46);
            BtnSearchProv.Margin = new Padding(3, 4, 3, 4);
            BtnSearchProv.Name = "BtnSearchProv";
            BtnSearchProv.Size = new Size(55, 57);
            BtnSearchProv.TabIndex = 13;
            BtnSearchProv.UseVisualStyleBackColor = true;
            // 
            // BtnNewProv
            // 
            BtnNewProv.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNewProv.Image = Properties.Resources._new;
            BtnNewProv.Location = new Point(839, 124);
            BtnNewProv.Margin = new Padding(3, 4, 3, 4);
            BtnNewProv.Name = "BtnNewProv";
            BtnNewProv.Size = new Size(224, 83);
            BtnNewProv.TabIndex = 14;
            BtnNewProv.UseVisualStyleBackColor = true;
            // 
            // BtnEditProv
            // 
            BtnEditProv.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditProv.Image = Properties.Resources.edit;
            BtnEditProv.Location = new Point(839, 237);
            BtnEditProv.Margin = new Padding(3, 4, 3, 4);
            BtnEditProv.Name = "BtnEditProv";
            BtnEditProv.Size = new Size(224, 83);
            BtnEditProv.TabIndex = 15;
            BtnEditProv.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteProv
            // 
            BtnDeleteProv.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteProv.Image = Properties.Resources.delete;
            BtnDeleteProv.Location = new Point(839, 353);
            BtnDeleteProv.Margin = new Padding(3, 4, 3, 4);
            BtnDeleteProv.Name = "BtnDeleteProv";
            BtnDeleteProv.Size = new Size(224, 83);
            BtnDeleteProv.TabIndex = 16;
            BtnDeleteProv.UseVisualStyleBackColor = true;
            // 
            // BtnCloseProv
            // 
            BtnCloseProv.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCloseProv.Image = Properties.Resources.cerrar;
            BtnCloseProv.Location = new Point(839, 456);
            BtnCloseProv.Margin = new Padding(3, 4, 3, 4);
            BtnCloseProv.Name = "BtnCloseProv";
            BtnCloseProv.Size = new Size(224, 83);
            BtnCloseProv.TabIndex = 17;
            BtnCloseProv.UseVisualStyleBackColor = true;
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 737);
            Controls.Add(tabControl1);
            Controls.Add(PanelProduct);
            Name = "ProvidersView";
            Text = "Providers Management";
            PanelProduct.ResumeLayout(false);
            PanelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProvidersList.ResumeLayout(false);
            tabPageProvidersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
            tabPageProvidersDetail.ResumeLayout(false);
            tabPageProvidersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelProduct;
        private PictureBox pictureBox1;
        private Label lblProviders;
        private TabControl tabControl1;
        private TabPage tabPageProvidersList;
        private Button BtnCloseProd;
        private Button BtnDeleteProd;
        private DataGridView DgProviders;
        private Button BtnEditProd;
        private Button BtnNewProd;
        private Button BtnSearchProd;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private TextBox TxtSearchProv;
        private Label Lbl1;
        private TabPage tabPageProvidersDetail;
        private Label lblprice;
        private TextBox TxtObservationProv;
        private Button BtnCancelProv;
        private Button BtnSaveProv;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TxtPhoneProv;
        private TextBox TxtProvidersName;
        private TextBox TxtProvidersId;
        private Button BtnSearchProv;
        private Button BtnNewProv;
        private Button BtnEditProv;
        private Button BtnDeleteProv;
        private Button BtnCloseProv;
    }
}
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
            BtnCloseProv = new Button();
            BtnDeleteProv = new Button();
            BtnEditProv = new Button();
            BtnNewProv = new Button();
            BtnSearchProv = new Button();
            
            DgProviders = new DataGridView();
           
            TxtSearchProv = new TextBox();
            Lbl1 = new Label();
            tabPageProvidersDetail = new TabPage();
            lblprice = new Label();
            TxtObservationProv = new TextBox();
            BtnCancelProv = new Button();
            BtnSaveProv = new Button();
            label3 = new Label();
            label2 = new Label();
            TxtProvidersName = new TextBox();
            TxtProvidersId = new TextBox();
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
            PanelProduct.Name = "PanelProduct";
            PanelProduct.Size = new Size(995, 100);
            PanelProduct.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblProviders
            // 
            lblProviders.AutoSize = true;
            lblProviders.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblProviders.Location = new Point(151, 33);
            lblProviders.Name = "lblProviders";
            lblProviders.Size = new Size(140, 37);
            lblProviders.TabIndex = 0;
            lblProviders.Text = "Providers";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProvidersList);
            tabControl1.Controls.Add(tabPageProvidersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(995, 453);
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
            tabPageProvidersList.Location = new Point(4, 24);
            tabPageProvidersList.Name = "tabPageProvidersList";
            tabPageProvidersList.Padding = new Padding(3);
            tabPageProvidersList.Size = new Size(987, 425);
            tabPageProvidersList.TabIndex = 0;
            tabPageProvidersList.Text = "Providers List";
            tabPageProvidersList.UseVisualStyleBackColor = true;
            // 
            // BtnCloseProv
            // 
            BtnCloseProv.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCloseProv.Image = Properties.Resources.cerrar;
            BtnCloseProv.Location = new Point(734, 342);
            BtnCloseProv.Name = "BtnCloseProv";
            BtnCloseProv.Size = new Size(196, 62);
            BtnCloseProv.TabIndex = 17;
            BtnCloseProv.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteProv
            // 
            BtnDeleteProv.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteProv.Image = Properties.Resources.delete;
            BtnDeleteProv.Location = new Point(734, 265);
            BtnDeleteProv.Name = "BtnDeleteProv";
            BtnDeleteProv.Size = new Size(196, 62);
            BtnDeleteProv.TabIndex = 16;
            BtnDeleteProv.UseVisualStyleBackColor = true;
            // 
            // BtnEditProv
            // 
            BtnEditProv.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditProv.Image = Properties.Resources.edit;
            BtnEditProv.Location = new Point(734, 178);
            BtnEditProv.Name = "BtnEditProv";
            BtnEditProv.Size = new Size(196, 62);
            BtnEditProv.TabIndex = 15;
            BtnEditProv.UseVisualStyleBackColor = true;
            // 
            // BtnNewProv
            // 
            BtnNewProv.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNewProv.Image = Properties.Resources._new;
            BtnNewProv.Location = new Point(734, 93);
            BtnNewProv.Name = "BtnNewProv";
            BtnNewProv.Size = new Size(196, 62);
            BtnNewProv.TabIndex = 14;
            BtnNewProv.UseVisualStyleBackColor = true;
            // 
            // BtnSearchProv
            // 
            BtnSearchProv.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchProv.Image = Properties.Resources.search_small;
            BtnSearchProv.Location = new Point(488, 34);
            BtnSearchProv.Name = "BtnSearchProv";
            BtnSearchProv.Size = new Size(48, 43);
            BtnSearchProv.TabIndex = 13;
            BtnSearchProv.UseVisualStyleBackColor = true;
            // 
            // BtnCloseProd
            // 
           
            // 
            // BtnDeleteProd
            // 
            
            // 
            // DgProviders
            // 
            DgProviders.AllowUserToAddRows = false;
            DgProviders.AllowUserToDeleteRows = false;
            DgProviders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Location = new Point(27, 93);
            DgProviders.Name = "DgProviders";
            DgProviders.ReadOnly = true;
            DgProviders.RowHeadersWidth = 51;
            DgProviders.RowTemplate.Height = 25;
            DgProviders.Size = new Size(653, 317);
            DgProviders.TabIndex = 3;
            // 
            // BtnEditProd
            // 
          
            // 
            // BtnNewProd
            // 
            
            // 
            // BtnSearchProd
            // 
            
            // 
            // BtnClose
            // 
           
            
            // 
            // BtnEdit
            // 
            
            // 
            // BtnSearch
     
            // TxtSearchProv
            // 
            TxtSearchProv.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearchProv.Location = new Point(27, 57);
            TxtSearchProv.Name = "TxtSearchProv";
            TxtSearchProv.PlaceholderText = "Data to search";
            TxtSearchProv.Size = new Size(456, 23);
            TxtSearchProv.TabIndex = 1;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(27, 23);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(94, 15);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Search Providers";
            // 
            // tabPageProvidersDetail
            // 
            tabPageProvidersDetail.Controls.Add(lblprice);
            tabPageProvidersDetail.Controls.Add(TxtObservationProv);
            tabPageProvidersDetail.Controls.Add(BtnCancelProv);
            tabPageProvidersDetail.Controls.Add(BtnSaveProv);
            tabPageProvidersDetail.Controls.Add(label3);
            tabPageProvidersDetail.Controls.Add(label2);
            tabPageProvidersDetail.Controls.Add(TxtProvidersName);
            tabPageProvidersDetail.Controls.Add(TxtProvidersId);
            tabPageProvidersDetail.Location = new Point(4, 24);
            tabPageProvidersDetail.Name = "tabPageProvidersDetail";
            tabPageProvidersDetail.Padding = new Padding(3);
            tabPageProvidersDetail.Size = new Size(987, 425);
            tabPageProvidersDetail.TabIndex = 1;
            tabPageProvidersDetail.Text = "Providers Detail";
            tabPageProvidersDetail.UseVisualStyleBackColor = true;
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Location = new Point(25, 140);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(71, 15);
            lblprice.TabIndex = 9;
            lblprice.Text = "Observation";
            // 
            // TxtObservationProv
            // 
            TxtObservationProv.Location = new Point(20, 156);
            TxtObservationProv.Multiline = true;
            TxtObservationProv.Name = "TxtObservationProv";
            TxtObservationProv.PlaceholderText = "Observacion";
            TxtObservationProv.Size = new Size(362, 78);
            TxtObservationProv.TabIndex = 8;
            // 
            // BtnCancelProv
            // 
            BtnCancelProv.Image = Properties.Resources.cancel;
            BtnCancelProv.Location = new Point(179, 287);
            BtnCancelProv.Name = "BtnCancelProv";
            BtnCancelProv.Size = new Size(98, 88);
            BtnCancelProv.TabIndex = 7;
            BtnCancelProv.UseVisualStyleBackColor = true;
            // 
            // BtnSaveProv
            // 
            BtnSaveProv.Image = Properties.Resources.save;
            BtnSaveProv.Location = new Point(20, 287);
            BtnSaveProv.Name = "BtnSaveProv";
            BtnSaveProv.Size = new Size(99, 88);
            BtnSaveProv.TabIndex = 6;
            BtnSaveProv.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 77);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 4;
            label3.Text = "Providers Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 26);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Providers Nit";
            // 
            // TxtProvidersName
            // 
            TxtProvidersName.Location = new Point(20, 93);
            TxtProvidersName.Name = "TxtProvidersName";
            TxtProvidersName.PlaceholderText = "Products Name";
            TxtProvidersName.Size = new Size(362, 23);
            TxtProvidersName.TabIndex = 1;
            // 
            // TxtProvidersId
            // 
            TxtProvidersId.Location = new Point(20, 41);
            TxtProvidersId.Name = "TxtProvidersId";
            TxtProvidersId.ReadOnly = true;
            TxtProvidersId.Size = new Size(191, 23);
            TxtProvidersId.TabIndex = 0;
            TxtProvidersId.Text = "0";
            TxtProvidersId.TextAlign = HorizontalAlignment.Right;
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 553);
            Controls.Add(tabControl1);
            Controls.Add(PanelProduct);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label3;
        private Label label2;
        private TextBox TxtProvidersName;
        private TextBox TxtProvidersId;
        private Button BtnSearchProv;
        private Button BtnNewProv;
        private Button BtnEditProv;
        private Button BtnDeleteProv;
        private Button BtnCloseProv;
    }
}
namespace Shelton_BookDB
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            CheckoutTab = new TabPage();
            label5 = new Label();
            label4 = new Label();
            CustomerGrid = new DataGridView();
            BookGrid = new DataGridView();
            groupBox1 = new GroupBox();
            RefreshBTN = new Button();
            COBtn = new Button();
            DTOut = new DateTimePicker();
            label2 = new Label();
            CustTXT = new TextBox();
            label3 = new Label();
            BookTXT = new TextBox();
            label1 = new Label();
            SearchTab = new TabPage();
            label13 = new Label();
            ResetBtn = new Button();
            SearchBtn = new Button();
            groupBox2 = new GroupBox();
            ISBNRB = new RadioButton();
            SubjectRB = new RadioButton();
            BookRB = new RadioButton();
            SearchBar = new TextBox();
            label6 = new Label();
            CataGrid = new DataGridView();
            CheckTab = new TabPage();
            label10 = new Label();
            CheckInGrid = new DataGridView();
            groupBox3 = new GroupBox();
            CheckRe = new Button();
            CheckInBtn = new Button();
            DTIn = new DateTimePicker();
            label7 = new Label();
            CustomerInTXT = new TextBox();
            label8 = new Label();
            BookInTXT = new TextBox();
            label9 = new Label();
            CustomerTab = new TabPage();
            HistoryGrid = new DataGridView();
            label12 = new Label();
            label11 = new Label();
            ItemGrid = new DataGridView();
            groupBox4 = new GroupBox();
            CustPGrid = new DataGridView();
            UNKBtn = new Button();
            UNKtxt = new TextBox();
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            bindingSource3 = new BindingSource(components);
            bindingSource4 = new BindingSource(components);
            tabControl1.SuspendLayout();
            CheckoutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookGrid).BeginInit();
            groupBox1.SuspendLayout();
            SearchTab.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CataGrid).BeginInit();
            CheckTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CheckInGrid).BeginInit();
            groupBox3.SuspendLayout();
            CustomerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HistoryGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemGrid).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustPGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource4).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(CheckoutTab);
            tabControl1.Controls.Add(SearchTab);
            tabControl1.Controls.Add(CheckTab);
            tabControl1.Controls.Add(CustomerTab);
            tabControl1.Location = new Point(1, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(857, 560);
            tabControl1.TabIndex = 0;
            // 
            // CheckoutTab
            // 
            CheckoutTab.BackColor = Color.LightGray;
            CheckoutTab.Controls.Add(label5);
            CheckoutTab.Controls.Add(label4);
            CheckoutTab.Controls.Add(CustomerGrid);
            CheckoutTab.Controls.Add(BookGrid);
            CheckoutTab.Controls.Add(groupBox1);
            CheckoutTab.ForeColor = SystemColors.ActiveCaptionText;
            CheckoutTab.Location = new Point(4, 29);
            CheckoutTab.Name = "CheckoutTab";
            CheckoutTab.Padding = new Padding(3);
            CheckoutTab.Size = new Size(849, 527);
            CheckoutTab.TabIndex = 0;
            CheckoutTab.Text = "Checkout";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(424, 23);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 4;
            label5.Text = "Choose Customer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(17, 23);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 3;
            label4.Text = "Chooes Avliable Book:";
            // 
            // CustomerGrid
            // 
            CustomerGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerGrid.GridColor = SystemColors.ActiveCaptionText;
            CustomerGrid.Location = new Point(424, 46);
            CustomerGrid.Name = "CustomerGrid";
            CustomerGrid.RowHeadersWidth = 51;
            CustomerGrid.RowTemplate.Height = 29;
            CustomerGrid.Size = new Size(407, 291);
            CustomerGrid.TabIndex = 2;
            CustomerGrid.CellContentClick += CustomerGrid_CellContentClick;
            // 
            // BookGrid
            // 
            BookGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookGrid.GridColor = SystemColors.ActiveCaptionText;
            BookGrid.Location = new Point(17, 46);
            BookGrid.Name = "BookGrid";
            BookGrid.RowHeadersWidth = 51;
            BookGrid.RowTemplate.Height = 29;
            BookGrid.Size = new Size(389, 291);
            BookGrid.TabIndex = 1;
            BookGrid.CellContentClick += BookGrid_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(RefreshBTN);
            groupBox1.Controls.Add(COBtn);
            groupBox1.Controls.Add(DTOut);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(CustTXT);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(BookTXT);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(138, 355);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(550, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Confirm Check Out Information:";
            // 
            // RefreshBTN
            // 
            RefreshBTN.BackColor = SystemColors.ActiveCaption;
            RefreshBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RefreshBTN.Location = new Point(412, 93);
            RefreshBTN.Name = "RefreshBTN";
            RefreshBTN.Size = new Size(118, 43);
            RefreshBTN.TabIndex = 8;
            RefreshBTN.Text = "Refresh";
            RefreshBTN.UseVisualStyleBackColor = false;
            RefreshBTN.Click += RefreshBTN_Click;
            // 
            // COBtn
            // 
            COBtn.BackColor = SystemColors.ActiveCaption;
            COBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            COBtn.Location = new Point(412, 33);
            COBtn.Name = "COBtn";
            COBtn.Size = new Size(118, 43);
            COBtn.TabIndex = 7;
            COBtn.Text = "Check Out";
            COBtn.UseVisualStyleBackColor = false;
            COBtn.Click += COBtn_Click;
            // 
            // DTOut
            // 
            DTOut.Location = new Point(117, 106);
            DTOut.Name = "DTOut";
            DTOut.Size = new Size(270, 30);
            DTOut.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(21, 106);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 3;
            label2.Text = "Due Date:";
            // 
            // CustTXT
            // 
            CustTXT.Location = new Point(117, 69);
            CustTXT.Name = "CustTXT";
            CustTXT.ReadOnly = true;
            CustTXT.Size = new Size(270, 30);
            CustTXT.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(18, 69);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 5;
            label3.Text = "Customer:";
            // 
            // BookTXT
            // 
            BookTXT.Location = new Point(117, 33);
            BookTXT.Name = "BookTXT";
            BookTXT.ReadOnly = true;
            BookTXT.Size = new Size(270, 30);
            BookTXT.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(54, 33);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 1;
            label1.Text = "Book:";
            // 
            // SearchTab
            // 
            SearchTab.BackColor = Color.LightGray;
            SearchTab.Controls.Add(label13);
            SearchTab.Controls.Add(ResetBtn);
            SearchTab.Controls.Add(SearchBtn);
            SearchTab.Controls.Add(groupBox2);
            SearchTab.Controls.Add(label6);
            SearchTab.Controls.Add(CataGrid);
            SearchTab.Location = new Point(4, 29);
            SearchTab.Name = "SearchTab";
            SearchTab.Padding = new Padding(3);
            SearchTab.Size = new Size(849, 527);
            SearchTab.TabIndex = 1;
            SearchTab.Text = "Search Catalog";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(224, 26);
            label13.Name = "label13";
            label13.Size = new Size(357, 20);
            label13.TabIndex = 9;
            label13.Text = "(Double click on a book to view author information) ";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = SystemColors.ActiveBorder;
            ResetBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResetBtn.Location = new Point(689, 458);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(118, 43);
            ResetBtn.TabIndex = 8;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = SystemColors.ActiveCaption;
            SearchBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBtn.Location = new Point(689, 382);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(118, 43);
            SearchBtn.TabIndex = 7;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(ISBNRB);
            groupBox2.Controls.Add(SubjectRB);
            groupBox2.Controls.Add(BookRB);
            groupBox2.Controls.Add(SearchBar);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(148, 359);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(505, 162);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choose Search Criteria:";
            // 
            // ISBNRB
            // 
            ISBNRB.AutoSize = true;
            ISBNRB.Location = new Point(44, 115);
            ISBNRB.Name = "ISBNRB";
            ISBNRB.Size = new Size(70, 27);
            ISBNRB.TabIndex = 8;
            ISBNRB.TabStop = true;
            ISBNRB.Text = "ISBN";
            ISBNRB.UseVisualStyleBackColor = true;
            // 
            // SubjectRB
            // 
            SubjectRB.AutoSize = true;
            SubjectRB.Location = new Point(44, 72);
            SubjectRB.Name = "SubjectRB";
            SubjectRB.Size = new Size(137, 27);
            SubjectRB.TabIndex = 7;
            SubjectRB.TabStop = true;
            SubjectRB.Text = "Book Subject";
            SubjectRB.UseVisualStyleBackColor = true;
            // 
            // BookRB
            // 
            BookRB.AutoSize = true;
            BookRB.Location = new Point(44, 33);
            BookRB.Name = "BookRB";
            BookRB.Size = new Size(113, 27);
            BookRB.TabIndex = 6;
            BookRB.TabStop = true;
            BookRB.Text = "Book Title";
            BookRB.UseVisualStyleBackColor = true;
            // 
            // SearchBar
            // 
            SearchBar.Location = new Point(208, 69);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(270, 30);
            SearchBar.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(6, 18);
            label6.Name = "label6";
            label6.Size = new Size(166, 28);
            label6.TabIndex = 5;
            label6.Text = "Book Catalouge:";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // CataGrid
            // 
            CataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CataGrid.Location = new Point(6, 49);
            CataGrid.Name = "CataGrid";
            CataGrid.RowHeadersWidth = 51;
            CataGrid.RowTemplate.Height = 29;
            CataGrid.Size = new Size(833, 291);
            CataGrid.TabIndex = 4;
            CataGrid.CellDoubleClick += CataGrid_CellDoubleClick;
            // 
            // CheckTab
            // 
            CheckTab.BackColor = Color.LightGray;
            CheckTab.Controls.Add(label10);
            CheckTab.Controls.Add(CheckInGrid);
            CheckTab.Controls.Add(groupBox3);
            CheckTab.Location = new Point(4, 29);
            CheckTab.Name = "CheckTab";
            CheckTab.Size = new Size(849, 527);
            CheckTab.TabIndex = 2;
            CheckTab.Text = "Check-In";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(7, 22);
            label10.Name = "label10";
            label10.Size = new Size(189, 20);
            label10.TabIndex = 5;
            label10.Text = "Select a Book for Checkin:";
            // 
            // CheckInGrid
            // 
            CheckInGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CheckInGrid.Location = new Point(7, 45);
            CheckInGrid.Name = "CheckInGrid";
            CheckInGrid.RowHeadersWidth = 51;
            CheckInGrid.RowTemplate.Height = 29;
            CheckInGrid.Size = new Size(833, 291);
            CheckInGrid.TabIndex = 4;
            CheckInGrid.CellContentClick += CheckInGrid_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Silver;
            groupBox3.Controls.Add(CheckRe);
            groupBox3.Controls.Add(CheckInBtn);
            groupBox3.Controls.Add(DTIn);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(CustomerInTXT);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(BookInTXT);
            groupBox3.Controls.Add(label9);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.ActiveCaptionText;
            groupBox3.Location = new Point(134, 355);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(550, 162);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Confirm Check In Information:";
            // 
            // CheckRe
            // 
            CheckRe.BackColor = SystemColors.ActiveCaption;
            CheckRe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CheckRe.Location = new Point(409, 94);
            CheckRe.Name = "CheckRe";
            CheckRe.Size = new Size(118, 43);
            CheckRe.TabIndex = 9;
            CheckRe.Text = "Refresh";
            CheckRe.UseVisualStyleBackColor = false;
            CheckRe.Click += CheckRe_Click;
            // 
            // CheckInBtn
            // 
            CheckInBtn.BackColor = SystemColors.ActiveCaption;
            CheckInBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CheckInBtn.Location = new Point(409, 33);
            CheckInBtn.Name = "CheckInBtn";
            CheckInBtn.Size = new Size(118, 43);
            CheckInBtn.TabIndex = 7;
            CheckInBtn.Text = "Check In";
            CheckInBtn.UseVisualStyleBackColor = false;
            CheckInBtn.Click += CheckInBtn_Click;
            // 
            // DTIn
            // 
            DTIn.Enabled = false;
            DTIn.Location = new Point(117, 106);
            DTIn.Name = "DTIn";
            DTIn.Size = new Size(270, 30);
            DTIn.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(21, 106);
            label7.Name = "label7";
            label7.Size = new Size(90, 23);
            label7.TabIndex = 3;
            label7.Text = "Due Date:";
            // 
            // CustomerInTXT
            // 
            CustomerInTXT.Location = new Point(117, 69);
            CustomerInTXT.Name = "CustomerInTXT";
            CustomerInTXT.ReadOnly = true;
            CustomerInTXT.Size = new Size(270, 30);
            CustomerInTXT.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(18, 69);
            label8.Name = "label8";
            label8.Size = new Size(93, 23);
            label8.TabIndex = 5;
            label8.Text = "Customer:";
            // 
            // BookInTXT
            // 
            BookInTXT.Location = new Point(117, 33);
            BookInTXT.Name = "BookInTXT";
            BookInTXT.ReadOnly = true;
            BookInTXT.Size = new Size(270, 30);
            BookInTXT.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(54, 33);
            label9.Name = "label9";
            label9.Size = new Size(57, 23);
            label9.TabIndex = 1;
            label9.Text = "Book:";
            // 
            // CustomerTab
            // 
            CustomerTab.BackColor = Color.LightGray;
            CustomerTab.Controls.Add(HistoryGrid);
            CustomerTab.Controls.Add(label12);
            CustomerTab.Controls.Add(label11);
            CustomerTab.Controls.Add(ItemGrid);
            CustomerTab.Controls.Add(groupBox4);
            CustomerTab.Location = new Point(4, 29);
            CustomerTab.Name = "CustomerTab";
            CustomerTab.Size = new Size(849, 527);
            CustomerTab.TabIndex = 3;
            CustomerTab.Text = "Customer Profile";
            // 
            // HistoryGrid
            // 
            HistoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoryGrid.Location = new Point(63, 356);
            HistoryGrid.Name = "HistoryGrid";
            HistoryGrid.RowHeadersWidth = 51;
            HistoryGrid.RowTemplate.Height = 29;
            HistoryGrid.Size = new Size(777, 161);
            HistoryGrid.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(0, 356);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 6;
            label12.Text = "History:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(443, 65);
            label11.Name = "label11";
            label11.Size = new Size(247, 23);
            label11.TabIndex = 5;
            label11.Text = "Items Currently Checked Out:";
            // 
            // ItemGrid
            // 
            ItemGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemGrid.Location = new Point(443, 91);
            ItemGrid.Name = "ItemGrid";
            ItemGrid.RowHeadersWidth = 51;
            ItemGrid.RowTemplate.Height = 29;
            ItemGrid.Size = new Size(397, 246);
            ItemGrid.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Silver;
            groupBox4.Controls.Add(CustPGrid);
            groupBox4.Controls.Add(UNKBtn);
            groupBox4.Controls.Add(UNKtxt);
            groupBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(7, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(419, 317);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Choose a Customer:";
            // 
            // CustPGrid
            // 
            CustPGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustPGrid.Location = new Point(6, 65);
            CustPGrid.Name = "CustPGrid";
            CustPGrid.RowHeadersWidth = 51;
            CustPGrid.RowTemplate.Height = 29;
            CustPGrid.Size = new Size(407, 246);
            CustPGrid.TabIndex = 3;
            CustPGrid.CellClick += CustPGrid_CellClick;
            // 
            // UNKBtn
            // 
            UNKBtn.BackColor = Color.CadetBlue;
            UNKBtn.Location = new Point(177, 29);
            UNKBtn.Name = "UNKBtn";
            UNKBtn.Size = new Size(36, 30);
            UNKBtn.TabIndex = 1;
            UNKBtn.Text = "<";
            UNKBtn.UseVisualStyleBackColor = false;
            UNKBtn.Click += UNKBtn_Click;
            // 
            // UNKtxt
            // 
            UNKtxt.Location = new Point(219, 29);
            UNKtxt.Name = "UNKtxt";
            UNKtxt.ReadOnly = true;
            UNKtxt.Size = new Size(194, 30);
            UNKtxt.TabIndex = 2;
            // 
            // bindingSource1
            // 
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 562);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            CheckoutTab.ResumeLayout(false);
            CheckoutTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            SearchTab.ResumeLayout(false);
            SearchTab.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CataGrid).EndInit();
            CheckTab.ResumeLayout(false);
            CheckTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CheckInGrid).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            CustomerTab.ResumeLayout(false);
            CustomerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HistoryGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemGrid).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustPGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage CheckoutTab;
        private GroupBox groupBox1;
        private TabPage SearchTab;
        private TabPage CheckTab;
        private TabPage CustomerTab;
        private TextBox BookTXT;
        private Label label1;
        private Label label4;
        private DataGridView CustomerGrid;
        private DataGridView BookGrid;
        private Button COBtn;
        private DateTimePicker DTOut;
        private Label label2;
        private TextBox CustTXT;
        private Label label3;
        private Label label5;
        private Button ResetBtn;
        private Button SearchBtn;
        private GroupBox groupBox2;
        private RadioButton ISBNRB;
        private RadioButton SubjectRB;
        private RadioButton BookRB;
        private TextBox SearchBar;
        private Label label6;
        private DataGridView CataGrid;
        private Label label10;
        private DataGridView CheckInGrid;
        private GroupBox groupBox3;
        private Button CheckInBtn;
        private DateTimePicker DTIn;
        private Label label7;
        private TextBox CustomerInTXT;
        private Label label8;
        private TextBox BookInTXT;
        private Label label9;
        private Button UNKBtn;
        private GroupBox groupBox4;
        private TextBox UNKtxt;
        private DataGridView HistoryGrid;
        private Label label12;
        private Label label11;
        private DataGridView ItemGrid;
        private DataGridView CustPGrid;
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
        private Label label13;
        private BindingSource bindingSource3;
        private Button RefreshBTN;
        private Button CheckRe;
        private BindingSource bindingSource4;
    }
}
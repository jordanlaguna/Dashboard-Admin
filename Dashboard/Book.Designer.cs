namespace Dashboard
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtAuthor = new TextBox();
            pictureBox1 = new PictureBox();
            txtTitle = new TextBox();
            pictureBox5 = new PictureBox();
            txtCode = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            btnAdd = new Button();
            panel5 = new Panel();
            pictureBox6 = new PictureBox();
            btnEdit = new Button();
            panel6 = new Panel();
            pictureBox7 = new PictureBox();
            btnDelete = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel7 = new Panel();
            tableBooks = new DataGridView();
            ColumnCode = new DataGridViewTextBoxColumn();
            ColumnTitle = new DataGridViewTextBoxColumn();
            ColumnAuthor = new DataGridViewTextBoxColumn();
            ColumnEditorial = new DataGridViewTextBoxColumn();
            ColumnAvailable = new DataGridViewTextBoxColumn();
            ColumnYear = new DataGridViewTextBoxColumn();
            pictureBox8 = new PictureBox();
            txtSearch = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1193, 40);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.89608F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.10392F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 40);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1193, 221);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtAuthor);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(txtTitle);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(txtCode);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 211);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(223, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(353, 11);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // txtAuthor
            // 
            txtAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAuthor.BackColor = Color.SeaShell;
            txtAuthor.BorderStyle = BorderStyle.None;
            txtAuthor.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAuthor.ForeColor = Color.Black;
            txtAuthor.Location = new Point(223, 143);
            txtAuthor.Multiline = true;
            txtAuthor.Name = "txtAuthor";
            txtAuthor.PlaceholderText = "Digite el autor del libro";
            txtAuthor.Size = new Size(353, 33);
            txtAuthor.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(223, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 11);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.BackColor = Color.SeaShell;
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.ForeColor = Color.Black;
            txtTitle.Location = new Point(223, 84);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Digite el título del libro";
            txtTitle.Size = new Size(353, 33);
            txtTitle.TabIndex = 4;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(223, 57);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(353, 11);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // txtCode
            // 
            txtCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCode.BackColor = Color.SeaShell;
            txtCode.BorderStyle = BorderStyle.None;
            txtCode.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode.ForeColor = Color.Black;
            txtCode.Location = new Point(223, 26);
            txtCode.Multiline = true;
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "Digite el código del libro";
            txtCode.Size = new Size(353, 33);
            txtCode.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 146);
            label3.Name = "label3";
            label3.Size = new Size(214, 38);
            label3.TabIndex = 2;
            label3.Text = "Digite el autor:";
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 84);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(214, 38);
            label2.TabIndex = 1;
            label2.Text = "Digite el título:";
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 25);
            label1.Name = "label1";
            label1.Size = new Size(214, 38);
            label1.TabIndex = 0;
            label1.Text = "Digite el código:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaShell;
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(633, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(555, 211);
            panel3.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(107, 148);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.No;
            dateTimePicker1.Size = new Size(356, 37);
            dateTimePicker1.TabIndex = 12;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 115);
            label5.Name = "label5";
            label5.Size = new Size(549, 38);
            label5.TabIndex = 11;
            label5.Text = "Año de lanzamiento:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(109, 97);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(354, 11);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 25);
            label4.Name = "label4";
            label4.Size = new Size(549, 38);
            label4.TabIndex = 9;
            label4.Text = "Digite el editorial:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.SeaShell;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(109, 66);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite el editorial del libro";
            textBox1.Size = new Size(354, 33);
            textBox1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(panel4, 0, 0);
            tableLayoutPanel2.Controls.Add(panel5, 1, 0);
            tableLayoutPanel2.Controls.Add(panel6, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 261);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1193, 149);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(btnAdd);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(391, 143);
            panel4.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top;
            pictureBox4.BackColor = Color.FromArgb(0, 84, 92);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(118, 59);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(0, 84, 92);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnAdd.FlatAppearance.BorderSize = 30;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(98, 45);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(230, 59);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(btnEdit);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(400, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(391, 143);
            panel5.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top;
            pictureBox6.BackColor = Color.FromArgb(0, 84, 92);
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(121, 57);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(0, 84, 92);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnEdit.FlatAppearance.BorderSize = 30;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(100, 45);
            btnEdit.Margin = new Padding(0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(230, 59);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox7);
            panel6.Controls.Add(btnDelete);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(797, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(393, 143);
            panel6.TabIndex = 2;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top;
            pictureBox7.BackColor = Color.FromArgb(0, 84, 92);
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(105, 57);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(35, 35);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(0, 84, 92);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnDelete.FlatAppearance.BorderSize = 30;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(87, 43);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(230, 61);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel7, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 410);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1193, 450);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(tableBooks);
            panel7.Controls.Add(pictureBox8);
            panel7.Controls.Add(txtSearch);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(1187, 444);
            panel7.TabIndex = 1;
            // 
            // tableBooks
            // 
            tableBooks.AllowUserToAddRows = false;
            tableBooks.AllowUserToDeleteRows = false;
            tableBooks.AllowUserToResizeColumns = false;
            tableBooks.AllowUserToResizeRows = false;
            tableBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableBooks.BackgroundColor = Color.FromArgb(0, 84, 92);
            tableBooks.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SeaShell;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tableBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tableBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableBooks.Columns.AddRange(new DataGridViewColumn[] { ColumnCode, ColumnTitle, ColumnAuthor, ColumnEditorial, ColumnAvailable, ColumnYear });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 84, 92);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tableBooks.DefaultCellStyle = dataGridViewCellStyle2;
            tableBooks.GridColor = Color.FromArgb(0, 84, 92);
            tableBooks.Location = new Point(9, 101);
            tableBooks.Margin = new Padding(0);
            tableBooks.MultiSelect = false;
            tableBooks.Name = "tableBooks";
            tableBooks.ReadOnly = true;
            tableBooks.RowHeadersVisible = false;
            tableBooks.RowHeadersWidth = 62;
            tableBooks.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tableBooks.RowTemplate.Height = 33;
            tableBooks.Size = new Size(1170, 343);
            tableBooks.TabIndex = 2;
            // 
            // ColumnCode
            // 
            ColumnCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCode.DataPropertyName = "isbn";
            ColumnCode.HeaderText = "Código";
            ColumnCode.MinimumWidth = 8;
            ColumnCode.Name = "ColumnCode";
            ColumnCode.ReadOnly = true;
            // 
            // ColumnTitle
            // 
            ColumnTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnTitle.DataPropertyName = "title";
            ColumnTitle.HeaderText = "Título";
            ColumnTitle.MinimumWidth = 8;
            ColumnTitle.Name = "ColumnTitle";
            ColumnTitle.ReadOnly = true;
            // 
            // ColumnAuthor
            // 
            ColumnAuthor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnAuthor.DataPropertyName = "authorBook";
            ColumnAuthor.HeaderText = "Autor";
            ColumnAuthor.MinimumWidth = 8;
            ColumnAuthor.Name = "ColumnAuthor";
            ColumnAuthor.ReadOnly = true;
            // 
            // ColumnEditorial
            // 
            ColumnEditorial.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnEditorial.DataPropertyName = "editorial";
            ColumnEditorial.HeaderText = "Editorial";
            ColumnEditorial.MinimumWidth = 8;
            ColumnEditorial.Name = "ColumnEditorial";
            ColumnEditorial.ReadOnly = true;
            // 
            // ColumnAvailable
            // 
            ColumnAvailable.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnAvailable.DataPropertyName = "available";
            ColumnAvailable.HeaderText = "Disponible";
            ColumnAvailable.MinimumWidth = 8;
            ColumnAvailable.Name = "ColumnAvailable";
            ColumnAvailable.ReadOnly = true;
            // 
            // ColumnYear
            // 
            ColumnYear.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnYear.DataPropertyName = "releaseDate";
            ColumnYear.HeaderText = "Año";
            ColumnYear.MinimumWidth = 8;
            ColumnYear.Name = "ColumnYear";
            ColumnYear.ReadOnly = true;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(357, 52);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(45, 46);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(9, 52);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Buscar";
            txtSearch.Size = new Size(345, 46);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += Search;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1193, 860);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Book";
            Text = "Book";
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label label1;
        private TextBox txtCode;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private TextBox txtAuthor;
        private PictureBox pictureBox1;
        private TextBox txtTitle;
        private Panel panel3;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label4;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button btnAdd;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private Button btnEdit;
        private PictureBox pictureBox7;
        private Button btnDelete;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel7;
        private DataGridView tableBooks;
        private PictureBox pictureBox8;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn ColumnCode;
        private DataGridViewTextBoxColumn ColumnTitle;
        private DataGridViewTextBoxColumn ColumnAuthor;
        private DataGridViewTextBoxColumn ColumnEditorial;
        private DataGridViewTextBoxColumn ColumnAvailable;
        private DataGridViewTextBoxColumn ColumnYear;
    }
}
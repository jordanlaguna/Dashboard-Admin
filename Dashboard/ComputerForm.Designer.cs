namespace Dashboard
{
    partial class ComputerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerForm));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox5 = new TextBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            pictureBox3 = new PictureBox();
            btnAdd = new Button();
            pictureBox6 = new PictureBox();
            btnEdit = new Button();
            pictureBox7 = new PictureBox();
            btnDelete = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel9 = new Panel();
            pictureBox8 = new PictureBox();
            txtSearch = new TextBox();
            tableLaptops = new DataGridView();
            ColumnCodigo = new DataGridViewTextBoxColumn();
            ColumnTrademark = new DataGridViewTextBoxColumn();
            ColumnUbication = new DataGridViewTextBoxColumn();
            ColumnAvailable = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableLaptops).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1193, 75);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(40, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 35);
            comboBox1.TabIndex = 43;
            comboBox1.Text = "Seleccione";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 31);
            label4.Name = "label4";
            label4.Size = new Size(287, 38);
            label4.TabIndex = 41;
            label4.Text = "Seleccione:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.SeaShell;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(15, 72);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ingrese la ubicación";
            textBox2.Size = new Size(261, 33);
            textBox2.TabIndex = 37;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(261, 15);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 31);
            label3.Name = "label3";
            label3.Size = new Size(287, 38);
            label3.TabIndex = 38;
            label3.Text = "Ubicación:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.SeaShell;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(15, 72);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese la marca";
            textBox1.Size = new Size(261, 33);
            textBox1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 31);
            label2.Name = "label2";
            label2.Size = new Size(287, 38);
            label2.TabIndex = 35;
            label2.Text = "Digite la marca:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.BackColor = Color.SeaShell;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(12, 72);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Ingrese el código";
            textBox5.Size = new Size(261, 33);
            textBox5.TabIndex = 31;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 100);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(261, 15);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 33;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 31);
            label1.Name = "label1";
            label1.Size = new Size(287, 38);
            label1.TabIndex = 32;
            label1.Text = "Código:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 2, 0);
            tableLayoutPanel1.Controls.Add(panel5, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 75);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1193, 184);
            tableLayoutPanel1.TabIndex = 44;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 0);
            panel2.Margin = new Padding(5, 0, 0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 184);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaShell;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(298, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(298, 184);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SeaShell;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(textBox2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(596, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(298, 184);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SeaShell;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(comboBox1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(894, 0);
            panel5.Margin = new Padding(0, 0, 5, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(294, 184);
            panel5.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(panel6, 0, 0);
            tableLayoutPanel2.Controls.Add(panel7, 1, 0);
            tableLayoutPanel2.Controls.Add(panel8, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 259);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1193, 119);
            tableLayoutPanel2.TabIndex = 45;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(btnAdd);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(397, 119);
            panel6.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox6);
            panel7.Controls.Add(btnEdit);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(397, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(397, 119);
            panel7.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox7);
            panel8.Controls.Add(btnDelete);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(794, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(399, 119);
            panel8.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.BackColor = Color.FromArgb(0, 84, 92);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(102, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 47;
            pictureBox3.TabStop = false;
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
            btnAdd.Location = new Point(79, 34);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(230, 59);
            btnAdd.TabIndex = 46;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top;
            pictureBox6.BackColor = Color.FromArgb(0, 84, 92);
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(114, 47);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 48;
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
            btnEdit.Location = new Point(87, 34);
            btnEdit.Margin = new Padding(0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(230, 59);
            btnEdit.TabIndex = 49;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top;
            pictureBox7.BackColor = Color.FromArgb(0, 84, 92);
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(123, 47);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(35, 35);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 50;
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
            btnDelete.Location = new Point(103, 34);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(230, 59);
            btnDelete.TabIndex = 51;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel9, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 378);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1193, 464);
            tableLayoutPanel3.TabIndex = 46;
            // 
            // panel9
            // 
            panel9.Controls.Add(tableLaptops);
            panel9.Controls.Add(pictureBox8);
            panel9.Controls.Add(txtSearch);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1193, 464);
            panel9.TabIndex = 0;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(353, 61);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(45, 46);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 3;
            pictureBox8.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(5, 61);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Buscar";
            txtSearch.Size = new Size(345, 46);
            txtSearch.TabIndex = 2;
            // 
            // tableLaptops
            // 
            tableLaptops.AllowUserToAddRows = false;
            tableLaptops.AllowUserToDeleteRows = false;
            tableLaptops.AllowUserToResizeColumns = false;
            tableLaptops.AllowUserToResizeRows = false;
            tableLaptops.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLaptops.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableLaptops.BackgroundColor = Color.FromArgb(0, 84, 92);
            tableLaptops.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SeaShell;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tableLaptops.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tableLaptops.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLaptops.Columns.AddRange(new DataGridViewColumn[] { ColumnCodigo, ColumnTrademark, ColumnUbication, ColumnAvailable });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 84, 92);
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            tableLaptops.DefaultCellStyle = dataGridViewCellStyle4;
            tableLaptops.GridColor = Color.FromArgb(0, 84, 92);
            tableLaptops.Location = new Point(9, 110);
            tableLaptops.Margin = new Padding(0);
            tableLaptops.MultiSelect = false;
            tableLaptops.Name = "tableLaptops";
            tableLaptops.ReadOnly = true;
            tableLaptops.RowHeadersVisible = false;
            tableLaptops.RowHeadersWidth = 62;
            tableLaptops.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tableLaptops.RowTemplate.Height = 33;
            tableLaptops.Size = new Size(1170, 354);
            tableLaptops.TabIndex = 4;
            // 
            // ColumnCodigo
            // 
            ColumnCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCodigo.DataPropertyName = "code";
            ColumnCodigo.HeaderText = "Código";
            ColumnCodigo.MinimumWidth = 8;
            ColumnCodigo.Name = "ColumnCodigo";
            ColumnCodigo.ReadOnly = true;
            // 
            // ColumnTrademark
            // 
            ColumnTrademark.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnTrademark.DataPropertyName = "trademark";
            ColumnTrademark.HeaderText = "Marca";
            ColumnTrademark.MinimumWidth = 8;
            ColumnTrademark.Name = "ColumnTrademark";
            ColumnTrademark.ReadOnly = true;
            // 
            // ColumnUbication
            // 
            ColumnUbication.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnUbication.DataPropertyName = "ubication";
            ColumnUbication.HeaderText = "Ubicación";
            ColumnUbication.MinimumWidth = 8;
            ColumnUbication.Name = "ColumnUbication";
            ColumnUbication.ReadOnly = true;
            // 
            // ColumnAvailable
            // 
            ColumnAvailable.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnAvailable.DataPropertyName = "available";
            ColumnAvailable.HeaderText = "Disponibilidad";
            ColumnAvailable.MinimumWidth = 8;
            ColumnAvailable.Name = "ColumnAvailable";
            ColumnAvailable.ReadOnly = true;
            // 
            // ComputerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1193, 846);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ComputerForm";
            Text = "ComputerForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableLaptops).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox5;
        private PictureBox pictureBox4;
        private Label label1;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private Label label3;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private PictureBox pictureBox3;
        private Button btnAdd;
        private PictureBox pictureBox6;
        private Button btnEdit;
        private PictureBox pictureBox7;
        private Button btnDelete;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel9;
        private PictureBox pictureBox8;
        private TextBox txtSearch;
        private DataGridView tableLaptops;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnTrademark;
        private DataGridViewTextBoxColumn ColumnUbication;
        private DataGridViewTextBoxColumn ColumnAvailable;
    }
}
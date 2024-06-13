namespace DemoExam
{
    partial class workOrder
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
            listClients = new Label();
            searchTextBox = new TextBox();
            buttonAscending = new RadioButton();
            dataGridView1 = new DataGridView();
            filterButton = new Button();
            sortListBox = new ListBox();
            clientCombo = new ComboBox();
            searchString = new Label();
            showAllButton = new Button();
            searchButton = new Button();
            buttonDescending = new RadioButton();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listClients
            // 
            listClients.AutoSize = true;
            listClients.Location = new Point(12, 28);
            listClients.Name = "listClients";
            listClients.Size = new Size(108, 15);
            listClients.TabIndex = 0;
            listClients.Text = "Выберите клиента";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(158, 67);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(121, 23);
            searchTextBox.TabIndex = 1;
            // 
            // buttonAscending
            // 
            buttonAscending.AutoSize = true;
            buttonAscending.Checked = true;
            buttonAscending.Location = new Point(140, 38);
            buttonAscending.Name = "buttonAscending";
            buttonAscending.Size = new Size(116, 19);
            buttonAscending.TabIndex = 2;
            buttonAscending.TabStop = true;
            buttonAscending.Text = "По возрастанию";
            buttonAscending.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.IndianRed;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(985, 259);
            dataGridView1.TabIndex = 3;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(285, 24);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(95, 23);
            filterButton.TabIndex = 4;
            filterButton.Text = "Фильтровать";
            filterButton.UseVisualStyleBackColor = true;
            // 
            // sortListBox
            // 
            sortListBox.FormattingEnabled = true;
            sortListBox.ItemHeight = 15;
            sortListBox.Items.AddRange(new object[] { "Клиент", "Дата заказа", "Статус" });
            sortListBox.Location = new Point(6, 22);
            sortListBox.Name = "sortListBox";
            sortListBox.Size = new Size(120, 94);
            sortListBox.TabIndex = 5;
            // 
            // clientCombo
            // 
            clientCombo.FormattingEnabled = true;
            clientCombo.Location = new Point(158, 25);
            clientCombo.Name = "clientCombo";
            clientCombo.Size = new Size(121, 23);
            clientCombo.TabIndex = 6;
            // 
            // searchString
            // 
            searchString.AutoSize = true;
            searchString.Location = new Point(12, 70);
            searchString.Name = "searchString";
            searchString.Size = new Size(132, 15);
            searchString.TabIndex = 7;
            searchString.Text = "Введите строку поиска";
            // 
            // showAllButton
            // 
            showAllButton.Location = new Point(386, 24);
            showAllButton.Name = "showAllButton";
            showAllButton.Size = new Size(97, 23);
            showAllButton.TabIndex = 8;
            showAllButton.Text = "Показать все";
            showAllButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(285, 67);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(95, 23);
            searchButton.TabIndex = 9;
            searchButton.Text = "Найти";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // buttonDescending
            // 
            buttonDescending.AutoSize = true;
            buttonDescending.Location = new Point(140, 63);
            buttonDescending.Name = "buttonDescending";
            buttonDescending.Size = new Size(102, 19);
            buttonDescending.TabIndex = 11;
            buttonDescending.Text = "По убыванию";
            buttonDescending.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAscending);
            groupBox1.Controls.Add(buttonDescending);
            groupBox1.Controls.Add(sortListBox);
            groupBox1.Location = new Point(507, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 145);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите поле для сортировки";
            // 
            // workOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 482);
            Controls.Add(groupBox1);
            Controls.Add(searchButton);
            Controls.Add(showAllButton);
            Controls.Add(searchString);
            Controls.Add(clientCombo);
            Controls.Add(filterButton);
            Controls.Add(dataGridView1);
            Controls.Add(searchTextBox);
            Controls.Add(listClients);
            MinimumSize = new Size(640, 480);
            Name = "workOrder";
            Text = "Работа с заказами";
            Load += workOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label listClients;
        private TextBox searchTextBox;
        private RadioButton buttonAscending;
        private DataGridView dataGridView1;
        private Button filterButton;
        private ListBox sortListBox;
        private ComboBox clientCombo;
        private Label searchString;
        private Button showAllButton;
        private Button searchButton;
        private RadioButton buttonDescending;
        private GroupBox groupBox1;
    }
}

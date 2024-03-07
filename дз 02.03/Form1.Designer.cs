namespace дз_02._03
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Цена");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("О горках");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Время работы");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Техника безопасности");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Противопоказания");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Горки", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Цена");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("О бассейнах");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Время работы");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Техника безопасности");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Техника безопасности");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Бассейны", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Список кафе");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Меню");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Отзывы");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Расположение");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Правила посещения");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Кафе", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Аквапарк", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode12,
            treeNode18});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.Загрузить = new System.Windows.Forms.Button();
            this.Показать = new System.Windows.Forms.Button();
            this.Закрыть = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Сереализация = new System.Windows.Forms.Button();
            this.Десереализация = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(-12, 119);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Цена";
            treeNode1.Text = "Цена";
            treeNode2.Name = "О горках";
            treeNode2.Text = "О горках";
            treeNode3.Name = "Время работы";
            treeNode3.Text = "Время работы";
            treeNode4.Name = "Техника безопасности";
            treeNode4.Text = "Техника безопасности";
            treeNode5.Name = "Противопоказания";
            treeNode5.Text = "Противопоказания";
            treeNode6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            treeNode6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            treeNode6.Name = "Горки";
            treeNode6.Text = "Горки";
            treeNode7.Name = "Цена";
            treeNode7.Text = "Цена";
            treeNode8.Name = "О бассейнах";
            treeNode8.Text = "О бассейнах";
            treeNode9.Name = "Время работы";
            treeNode9.Text = "Время работы";
            treeNode10.Name = "Техника безопасности";
            treeNode10.Text = "Техника безопасности";
            treeNode11.Name = "Противопоказания";
            treeNode11.Text = "Техника безопасности";
            treeNode12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            treeNode12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            treeNode12.Name = "Бассейны";
            treeNode12.Text = "Бассейны";
            treeNode13.Name = "Список кафе";
            treeNode13.Text = "Список кафе";
            treeNode14.Name = "Меню";
            treeNode14.Text = "Меню";
            treeNode15.Name = "Отзывы";
            treeNode15.Text = "Отзывы";
            treeNode16.Name = "Расположение";
            treeNode16.Text = "Расположение";
            treeNode17.Name = "Правила посещения";
            treeNode17.Text = "Правила посещения";
            treeNode18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            treeNode18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            treeNode18.Name = "Кафе";
            treeNode18.Text = "Кафе";
            treeNode19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            treeNode19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            treeNode19.Name = "Аквапарк";
            treeNode19.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode19.Text = "Аквапарк";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode19});
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(800, 331);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(240, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(560, 450);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // Загрузить
            // 
            this.Загрузить.Location = new System.Drawing.Point(240, 0);
            this.Загрузить.Name = "Загрузить";
            this.Загрузить.Size = new System.Drawing.Size(143, 62);
            this.Загрузить.TabIndex = 5;
            this.Загрузить.Text = "Загрузить";
            this.Загрузить.UseVisualStyleBackColor = true;
            this.Загрузить.Click += new System.EventHandler(this.button1_Click);
            // 
            // Показать
            // 
            this.Показать.Location = new System.Drawing.Point(379, 0);
            this.Показать.Name = "Показать";
            this.Показать.Size = new System.Drawing.Size(144, 62);
            this.Показать.TabIndex = 6;
            this.Показать.Text = "Показать";
            this.Показать.UseVisualStyleBackColor = true;
            // 
            // Закрыть
            // 
            this.Закрыть.Location = new System.Drawing.Point(517, 0);
            this.Закрыть.Name = "Закрыть";
            this.Закрыть.Size = new System.Drawing.Size(131, 62);
            this.Закрыть.TabIndex = 7;
            this.Закрыть.Text = "Закрыть";
            this.Закрыть.UseVisualStyleBackColor = true;
            this.Закрыть.Click += new System.EventHandler(this.Закрыть_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AccessibleName = "";
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(241, 163);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.05505F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.94495F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 218);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // Сереализация
            // 
            this.Сереализация.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Сереализация.Location = new System.Drawing.Point(465, 387);
            this.Сереализация.Name = "Сереализация";
            this.Сереализация.Size = new System.Drawing.Size(152, 51);
            this.Сереализация.TabIndex = 10;
            this.Сереализация.Text = "Сереализация";
            this.Сереализация.UseVisualStyleBackColor = false;
            // 
            // Десереализация
            // 
            this.Десереализация.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Десереализация.Location = new System.Drawing.Point(635, 387);
            this.Десереализация.Name = "Десереализация";
            this.Десереализация.Size = new System.Drawing.Size(151, 50);
            this.Десереализация.TabIndex = 11;
            this.Десереализация.Text = "Десереализация";
            this.Десереализация.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Десереализация);
            this.Controls.Add(this.Сереализация);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Закрыть);
            this.Controls.Add(this.Показать);
            this.Controls.Add(this.Загрузить);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button Загрузить;
        private System.Windows.Forms.Button Показать;
        private System.Windows.Forms.Button Закрыть;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Сереализация;
        private System.Windows.Forms.Button Десереализация;
    }
}


namespace OOPDraw
{
    partial class OOPDrawForm
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
            this.DrawButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.numericUpDownRemoveShape = new System.Windows.Forms.NumericUpDown();
            this.comboBoxAdd = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DrawBox = new System.Windows.Forms.PictureBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.trackBarDrawings = new System.Windows.Forms.TrackBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonChooseFontColor = new System.Windows.Forms.Button();
            this.buttonRandomFontColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoveShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrawings)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawButton
            // 
            this.DrawButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrawButton.Location = new System.Drawing.Point(12, 418);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(130, 50);
            this.DrawButton.TabIndex = 1;
            this.DrawButton.Text = "Прорисовка";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(148, 418);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(130, 50);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Стереть";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Name
            // 
            this.Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(714, 528);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(158, 24);
            this.Name.TabIndex = 3;
            this.Name.Text = "Олексейчук М.В.";
            // 
            // numericUpDownRemoveShape
            // 
            this.numericUpDownRemoveShape.AccessibleDescription = "azaz";
            this.numericUpDownRemoveShape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownRemoveShape.Location = new System.Drawing.Point(148, 475);
            this.numericUpDownRemoveShape.Name = "numericUpDownRemoveShape";
            this.numericUpDownRemoveShape.Size = new System.Drawing.Size(130, 20);
            this.numericUpDownRemoveShape.TabIndex = 4;
            this.numericUpDownRemoveShape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownRemoveShape.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBoxAdd
            // 
            this.comboBoxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxAdd.FormattingEnabled = true;
            this.comboBoxAdd.Items.AddRange(new object[] {
            "Точка",
            "Линия",
            "Прямоугольник",
            "Круг",
            "Эллипс"});
            this.comboBoxAdd.Location = new System.Drawing.Point(12, 474);
            this.comboBoxAdd.Name = "comboBoxAdd";
            this.comboBoxAdd.Size = new System.Drawing.Size(130, 21);
            this.comboBoxAdd.TabIndex = 5;
            this.comboBoxAdd.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdd_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrawBox
            // 
            this.DrawBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawBox.BackColor = System.Drawing.Color.White;
            this.DrawBox.Location = new System.Drawing.Point(12, 12);
            this.DrawBox.Name = "DrawBox";
            this.DrawBox.Size = new System.Drawing.Size(860, 400);
            this.DrawBox.TabIndex = 0;
            this.DrawBox.TabStop = false;
            this.DrawBox.Click += new System.EventHandler(this.DrawBox_Click);
            this.DrawBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBox_Paint);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Location = new System.Drawing.Point(148, 501);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(130, 23);
            this.buttonRemove.TabIndex = 10;
            this.buttonRemove.Text = "Убрать";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // trackBarDrawings
            // 
            this.trackBarDrawings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarDrawings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trackBarDrawings.LargeChange = 1;
            this.trackBarDrawings.Location = new System.Drawing.Point(0, 528);
            this.trackBarDrawings.Maximum = 50;
            this.trackBarDrawings.Name = "trackBarDrawings";
            this.trackBarDrawings.Size = new System.Drawing.Size(708, 45);
            this.trackBarDrawings.TabIndex = 11;
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.ShowHelp = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRandomFontColor);
            this.groupBox1.Controls.Add(this.buttonChooseFontColor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(284, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 106);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цвет фона";
            // 
            // buttonChooseFontColor
            // 
            this.buttonChooseFontColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChooseFontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChooseFontColor.Location = new System.Drawing.Point(6, 21);
            this.buttonChooseFontColor.Name = "buttonChooseFontColor";
            this.buttonChooseFontColor.Size = new System.Drawing.Size(96, 33);
            this.buttonChooseFontColor.TabIndex = 13;
            this.buttonChooseFontColor.Text = "Выбор";
            this.buttonChooseFontColor.UseVisualStyleBackColor = true;
            this.buttonChooseFontColor.Click += new System.EventHandler(this.buttonChooseFontColor_Click);
            // 
            // buttonRandomFontColor
            // 
            this.buttonRandomFontColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRandomFontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRandomFontColor.Location = new System.Drawing.Point(6, 60);
            this.buttonRandomFontColor.Name = "buttonRandomFontColor";
            this.buttonRandomFontColor.Size = new System.Drawing.Size(96, 33);
            this.buttonRandomFontColor.TabIndex = 14;
            this.buttonRandomFontColor.Text = "Случайно";
            this.buttonRandomFontColor.UseVisualStyleBackColor = true;
            this.buttonRandomFontColor.Click += new System.EventHandler(this.button3_Click);
            // 
            // OOPDrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBarDrawings);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxAdd);
            this.Controls.Add(this.numericUpDownRemoveShape);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.DrawBox);
            this.MaximumSize = new System.Drawing.Size(1800, 1024);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Text = "OOPDraw";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoveShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrawings)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.NumericUpDown numericUpDownRemoveShape;
        private System.Windows.Forms.ComboBox comboBoxAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox DrawBox;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TrackBar trackBarDrawings;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRandomFontColor;
        private System.Windows.Forms.Button buttonChooseFontColor;
    }
}


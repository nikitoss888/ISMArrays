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
            this.numericUpDownNumOfShape = new System.Windows.Forms.NumericUpDown();
            this.comboBoxAdd = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DrawBox = new System.Windows.Forms.PictureBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.trackBarDrawings = new System.Windows.Forms.TrackBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRandomFontColor = new System.Windows.Forms.Button();
            this.buttonChooseFontColor = new System.Windows.Forms.Button();
            this.buttonChangeColorOfDrawings = new System.Windows.Forms.Button();
            this.checkBoxColorOfShapes = new System.Windows.Forms.CheckBox();
            this.labelNumOfShape = new System.Windows.Forms.Label();
            this.labelChangeCoordinates = new System.Windows.Forms.Label();
            this.textBoxChangeX = new System.Windows.Forms.TextBox();
            this.textBoxChangeY = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.buttonMoveTheNumber = new System.Windows.Forms.Button();
            this.buttonMoveAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfShape)).BeginInit();
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
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(664, 465);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(130, 60);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Стереть всё";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Name
            // 
            this.Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(636, 528);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(158, 24);
            this.Name.TabIndex = 3;
            this.Name.Text = "Олексейчук М.В.";
            // 
            // numericUpDownNumOfShape
            // 
            this.numericUpDownNumOfShape.AccessibleDescription = "azaz";
            this.numericUpDownNumOfShape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownNumOfShape.Location = new System.Drawing.Point(424, 437);
            this.numericUpDownNumOfShape.Name = "numericUpDownNumOfShape";
            this.numericUpDownNumOfShape.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownNumOfShape.TabIndex = 4;
            this.numericUpDownNumOfShape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownNumOfShape.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
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
            this.DrawBox.Location = new System.Drawing.Point(0, 0);
            this.DrawBox.Name = "DrawBox";
            this.DrawBox.Size = new System.Drawing.Size(807, 412);
            this.DrawBox.TabIndex = 0;
            this.DrawBox.TabStop = false;
            this.DrawBox.Click += new System.EventHandler(this.DrawBox_Click);
            this.DrawBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBox_Paint);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Location = new System.Drawing.Point(414, 465);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(115, 23);
            this.buttonRemove.TabIndex = 10;
            this.buttonRemove.Text = "Стереть по номеру";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // trackBarDrawings
            // 
            this.trackBarDrawings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarDrawings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trackBarDrawings.LargeChange = 1;
            this.trackBarDrawings.Location = new System.Drawing.Point(0, 528);
            this.trackBarDrawings.Maximum = 50;
            this.trackBarDrawings.Name = "trackBarDrawings";
            this.trackBarDrawings.Size = new System.Drawing.Size(630, 45);
            this.trackBarDrawings.TabIndex = 11;
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.buttonRandomFontColor);
            this.groupBox1.Controls.Add(this.buttonChooseFontColor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(145, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 106);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цвет фона";
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
            // buttonChangeColorOfDrawings
            // 
            this.buttonChangeColorOfDrawings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChangeColorOfDrawings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeColorOfDrawings.Location = new System.Drawing.Point(259, 442);
            this.buttonChangeColorOfDrawings.Name = "buttonChangeColorOfDrawings";
            this.buttonChangeColorOfDrawings.Size = new System.Drawing.Size(111, 29);
            this.buttonChangeColorOfDrawings.TabIndex = 13;
            this.buttonChangeColorOfDrawings.Text = "Выбор цвета";
            this.buttonChangeColorOfDrawings.UseVisualStyleBackColor = true;
            this.buttonChangeColorOfDrawings.Visible = false;
            this.buttonChangeColorOfDrawings.Click += new System.EventHandler(this.buttonChangeColorOfDrawings_Click);
            // 
            // checkBoxColorOfShapes
            // 
            this.checkBoxColorOfShapes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxColorOfShapes.AutoSize = true;
            this.checkBoxColorOfShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxColorOfShapes.Location = new System.Drawing.Point(259, 418);
            this.checkBoxColorOfShapes.Name = "checkBoxColorOfShapes";
            this.checkBoxColorOfShapes.Size = new System.Drawing.Size(159, 20);
            this.checkBoxColorOfShapes.TabIndex = 15;
            this.checkBoxColorOfShapes.Text = "Свой цвет рисунков";
            this.checkBoxColorOfShapes.UseVisualStyleBackColor = true;
            this.checkBoxColorOfShapes.CheckedChanged += new System.EventHandler(this.checkBoxColorOfShapes_CheckedChanged);
            // 
            // labelNumOfShape
            // 
            this.labelNumOfShape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNumOfShape.AutoSize = true;
            this.labelNumOfShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumOfShape.Location = new System.Drawing.Point(421, 418);
            this.labelNumOfShape.Name = "labelNumOfShape";
            this.labelNumOfShape.Size = new System.Drawing.Size(108, 16);
            this.labelNumOfShape.TabIndex = 16;
            this.labelNumOfShape.Text = "Номер рисунка";
            // 
            // labelChangeCoordinates
            // 
            this.labelChangeCoordinates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelChangeCoordinates.AutoSize = true;
            this.labelChangeCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChangeCoordinates.Location = new System.Drawing.Point(535, 418);
            this.labelChangeCoordinates.Name = "labelChangeCoordinates";
            this.labelChangeCoordinates.Size = new System.Drawing.Size(179, 16);
            this.labelChangeCoordinates.TabIndex = 17;
            this.labelChangeCoordinates.Text = "Сместить по координатам";
            // 
            // textBoxChangeX
            // 
            this.textBoxChangeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxChangeX.Location = new System.Drawing.Point(560, 436);
            this.textBoxChangeX.Name = "textBoxChangeX";
            this.textBoxChangeX.Size = new System.Drawing.Size(40, 20);
            this.textBoxChangeX.TabIndex = 18;
            this.textBoxChangeX.Text = "0";
            this.textBoxChangeX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxChangeY
            // 
            this.textBoxChangeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxChangeY.Location = new System.Drawing.Point(632, 435);
            this.textBoxChangeY.Name = "textBoxChangeY";
            this.textBoxChangeY.Size = new System.Drawing.Size(40, 20);
            this.textBoxChangeY.TabIndex = 19;
            this.textBoxChangeY.Text = "0";
            this.textBoxChangeY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX
            // 
            this.labelX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(535, 437);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(28, 16);
            this.labelX.TabIndex = 20;
            this.labelX.Text = "ΔX:";
            // 
            // labelY
            // 
            this.labelY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(606, 437);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(29, 16);
            this.labelY.TabIndex = 21;
            this.labelY.Text = "ΔY:";
            // 
            // buttonMoveTheNumber
            // 
            this.buttonMoveTheNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMoveTheNumber.Location = new System.Drawing.Point(538, 465);
            this.buttonMoveTheNumber.Name = "buttonMoveTheNumber";
            this.buttonMoveTheNumber.Size = new System.Drawing.Size(122, 23);
            this.buttonMoveTheNumber.TabIndex = 22;
            this.buttonMoveTheNumber.Text = "Сместить по номеру";
            this.buttonMoveTheNumber.UseVisualStyleBackColor = true;
            this.buttonMoveTheNumber.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonMoveAll
            // 
            this.buttonMoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMoveAll.Location = new System.Drawing.Point(538, 490);
            this.buttonMoveAll.Name = "buttonMoveAll";
            this.buttonMoveAll.Size = new System.Drawing.Size(122, 23);
            this.buttonMoveAll.TabIndex = 23;
            this.buttonMoveAll.Text = "Сместить всё";
            this.buttonMoveAll.UseVisualStyleBackColor = true;
            this.buttonMoveAll.Click += new System.EventHandler(this.buttonMoveAll_Click);
            // 
            // OOPDrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(806, 561);
            this.Controls.Add(this.buttonMoveAll);
            this.Controls.Add(this.buttonMoveTheNumber);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxChangeY);
            this.Controls.Add(this.textBoxChangeX);
            this.Controls.Add(this.labelChangeCoordinates);
            this.Controls.Add(this.labelNumOfShape);
            this.Controls.Add(this.checkBoxColorOfShapes);
            this.Controls.Add(this.buttonChangeColorOfDrawings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBarDrawings);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxAdd);
            this.Controls.Add(this.numericUpDownNumOfShape);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.DrawBox);
            this.MaximumSize = new System.Drawing.Size(1800, 1024);
            this.MinimumSize = new System.Drawing.Size(822, 600);
            this.Text = "OOPDraw";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfShape)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDownNumOfShape;
        private System.Windows.Forms.ComboBox comboBoxAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox DrawBox;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TrackBar trackBarDrawings;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRandomFontColor;
        private System.Windows.Forms.Button buttonChooseFontColor;
        private System.Windows.Forms.Button buttonChangeColorOfDrawings;
        private System.Windows.Forms.CheckBox checkBoxColorOfShapes;
        private System.Windows.Forms.Label labelNumOfShape;
        private System.Windows.Forms.Label labelChangeCoordinates;
        private System.Windows.Forms.TextBox textBoxChangeX;
        private System.Windows.Forms.TextBox textBoxChangeY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button buttonMoveTheNumber;
        private System.Windows.Forms.Button buttonMoveAll;
    }
}


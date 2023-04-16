
namespace FCMApp.Views.Controls
{
    partial class algStep3Control
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(algStep3Control));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vectorTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.iterTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ComboBoxActivationFunction = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.ComboBoxInferenceEquation = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.nextButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.labelVector = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxActivationFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInferenceEquation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Шаг 3. Выбор параметров для алгоритма обучения НКК\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Вектор активации\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Количество итераций\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Функция активации\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Уравнение вывода\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vectorTextBox
            // 
            this.vectorTextBox.Location = new System.Drawing.Point(306, 86);
            this.vectorTextBox.Name = "vectorTextBox";
            this.vectorTextBox.Size = new System.Drawing.Size(371, 39);
            this.vectorTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.vectorTextBox.StateCommon.Border.Rounding = 20;
            this.vectorTextBox.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.vectorTextBox.StateNormal.Border.Rounding = 20;
            this.vectorTextBox.TabIndex = 21;
            this.vectorTextBox.Enter += new System.EventHandler(this.vectorTextBox_Enter);
            // 
            // iterTextBox
            // 
            this.iterTextBox.Location = new System.Drawing.Point(306, 214);
            this.iterTextBox.Name = "iterTextBox";
            this.iterTextBox.Size = new System.Drawing.Size(371, 39);
            this.iterTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.iterTextBox.StateCommon.Border.Rounding = 20;
            this.iterTextBox.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.iterTextBox.StateNormal.Border.Rounding = 20;
            this.iterTextBox.TabIndex = 22;
            // 
            // ComboBoxActivationFunction
            // 
            this.ComboBoxActivationFunction.DropDownWidth = 379;
            this.ComboBoxActivationFunction.Items.AddRange(new object[] {
            "бивалентная",
            "тривалентная",
            "сигмоидальная",
            "гиперболический тангенс"});
            this.ComboBoxActivationFunction.Location = new System.Drawing.Point(306, 285);
            this.ComboBoxActivationFunction.Name = "ComboBoxActivationFunction";
            this.ComboBoxActivationFunction.Size = new System.Drawing.Size(371, 37);
            this.ComboBoxActivationFunction.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComboBoxActivationFunction.StateCommon.ComboBox.Border.Rounding = 20;
            this.ComboBoxActivationFunction.TabIndex = 27;
            // 
            // ComboBoxInferenceEquation
            // 
            this.ComboBoxInferenceEquation.DropDownWidth = 379;
            this.ComboBoxInferenceEquation.Items.AddRange(new object[] {
            "схема вывода Коско",
            "модифицированная схема вывода Коско",
            "масштабированный вывод"});
            this.ComboBoxInferenceEquation.Location = new System.Drawing.Point(306, 348);
            this.ComboBoxInferenceEquation.Name = "ComboBoxInferenceEquation";
            this.ComboBoxInferenceEquation.Size = new System.Drawing.Size(371, 37);
            this.ComboBoxInferenceEquation.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComboBoxInferenceEquation.StateCommon.ComboBox.Border.Rounding = 20;
            this.ComboBoxInferenceEquation.TabIndex = 28;
            // 
            // nextButton
            // 
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Location = new System.Drawing.Point(376, 422);
            this.nextButton.Name = "nextButton";
            this.nextButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.nextButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.nextButton.OverrideDefault.Back.ColorAngle = 45F;
            this.nextButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.nextButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.nextButton.OverrideDefault.Border.ColorAngle = 45F;
            this.nextButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nextButton.OverrideDefault.Border.Rounding = 20;
            this.nextButton.OverrideDefault.Border.Width = 1;
            this.nextButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.nextButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.nextButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F);
            this.nextButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.nextButton.Size = new System.Drawing.Size(301, 61);
            this.nextButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.nextButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.nextButton.StateCommon.Back.ColorAngle = 45F;
            this.nextButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.nextButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.nextButton.StateCommon.Border.ColorAngle = 45F;
            this.nextButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nextButton.StateCommon.Border.Rounding = 20;
            this.nextButton.StateCommon.Border.Width = 1;
            this.nextButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.nextButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.nextButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.nextButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.nextButton.StatePressed.Back.ColorAngle = 135F;
            this.nextButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.nextButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.nextButton.StatePressed.Border.ColorAngle = 135F;
            this.nextButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextButton.StatePressed.Border.Rounding = 20;
            this.nextButton.StatePressed.Border.Width = 1;
            this.nextButton.StatePressed.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F);
            this.nextButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.nextButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.nextButton.StateTracking.Back.ColorAngle = 45F;
            this.nextButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.nextButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.nextButton.StateTracking.Border.ColorAngle = 45F;
            this.nextButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nextButton.StateTracking.Border.Rounding = 20;
            this.nextButton.StateTracking.Border.Width = 1;
            this.nextButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.nextButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.nextButton.StateTracking.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F);
            this.nextButton.TabIndex = 29;
            this.nextButton.Values.Text = "Перейти на следующий шаг";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // labelVector
            // 
            this.labelVector.AutoSize = true;
            this.labelVector.BackColor = System.Drawing.Color.White;
            this.labelVector.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVector.Location = new System.Drawing.Point(29, 152);
            this.labelVector.Name = "labelVector";
            this.labelVector.Size = new System.Drawing.Size(551, 20);
            this.labelVector.TabIndex = 30;
            this.labelVector.Text = "Введите вектор в формате 1,1,0,1... по количеству выбранных факторов";
            this.labelVector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(666, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // algStep3Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelVector);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.ComboBoxInferenceEquation);
            this.Controls.Add(this.ComboBoxActivationFunction);
            this.Controls.Add(this.iterTextBox);
            this.Controls.Add(this.vectorTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "algStep3Control";
            this.Size = new System.Drawing.Size(729, 518);
            this.Load += new System.EventHandler(this.algStep3Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxActivationFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInferenceEquation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox vectorTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox iterTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ComboBoxActivationFunction;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ComboBoxInferenceEquation;
        private ComponentFactory.Krypton.Toolkit.KryptonButton nextButton;
        private System.Windows.Forms.Label labelVector;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

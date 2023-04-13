
namespace FCMApp.Views.Controls
{
    partial class algStep2Control
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNameOfFactor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelParameters = new System.Windows.Forms.Label();
            this.parametersTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.domainTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nextFactorButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.nextButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ComboBoxMF = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.mfComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxMF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Шаг 2. Описание факторов успеха\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Название фактора\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNameOfFactor
            // 
            this.labelNameOfFactor.BackColor = System.Drawing.Color.White;
            this.labelNameOfFactor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameOfFactor.Location = new System.Drawing.Point(249, 71);
            this.labelNameOfFactor.Name = "labelNameOfFactor";
            this.labelNameOfFactor.Size = new System.Drawing.Size(424, 56);
            this.labelNameOfFactor.TabIndex = 13;
            this.labelNameOfFactor.Text = "Название фактора\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Функция принадлежности\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Параметры функции";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelParameters
            // 
            this.labelParameters.BackColor = System.Drawing.Color.White;
            this.labelParameters.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParameters.Location = new System.Drawing.Point(241, 262);
            this.labelParameters.Name = "labelParameters";
            this.labelParameters.Size = new System.Drawing.Size(432, 53);
            this.labelParameters.TabIndex = 17;
            this.labelParameters.Text = "Выберите функцию принадлежности";
            // 
            // parametersTextBox
            // 
            this.parametersTextBox.Location = new System.Drawing.Point(33, 323);
            this.parametersTextBox.Name = "parametersTextBox";
            this.parametersTextBox.Size = new System.Drawing.Size(640, 39);
            this.parametersTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.parametersTextBox.StateCommon.Border.Rounding = 20;
            this.parametersTextBox.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.parametersTextBox.StateNormal.Border.Rounding = 20;
            this.parametersTextBox.TabIndex = 18;
            this.parametersTextBox.Enter += new System.EventHandler(this.parametersTextBox_Enter);
            this.parametersTextBox.Leave += new System.EventHandler(this.parametersTextBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(29, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(356, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Домен (область определения функции)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // domainTextBox
            // 
            this.domainTextBox.Location = new System.Drawing.Point(416, 199);
            this.domainTextBox.Name = "domainTextBox";
            this.domainTextBox.Size = new System.Drawing.Size(257, 39);
            this.domainTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.domainTextBox.StateCommon.Border.Rounding = 20;
            this.domainTextBox.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.domainTextBox.StateNormal.Border.Rounding = 20;
            this.domainTextBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(29, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Метод дефаззификации\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextFactorButton
            // 
            this.nextFactorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextFactorButton.Location = new System.Drawing.Point(33, 444);
            this.nextFactorButton.Name = "nextFactorButton";
            this.nextFactorButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.nextFactorButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.nextFactorButton.OverrideDefault.Back.ColorAngle = 45F;
            this.nextFactorButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.nextFactorButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.nextFactorButton.OverrideDefault.Border.ColorAngle = 45F;
            this.nextFactorButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextFactorButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nextFactorButton.OverrideDefault.Border.Rounding = 20;
            this.nextFactorButton.OverrideDefault.Border.Width = 1;
            this.nextFactorButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.nextFactorButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.nextFactorButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F);
            this.nextFactorButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.nextFactorButton.Size = new System.Drawing.Size(255, 61);
            this.nextFactorButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.nextFactorButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.nextFactorButton.StateCommon.Back.ColorAngle = 45F;
            this.nextFactorButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.nextFactorButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.nextFactorButton.StateCommon.Border.ColorAngle = 45F;
            this.nextFactorButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextFactorButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nextFactorButton.StateCommon.Border.Rounding = 20;
            this.nextFactorButton.StateCommon.Border.Width = 1;
            this.nextFactorButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.nextFactorButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.nextFactorButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextFactorButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.nextFactorButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.nextFactorButton.StatePressed.Back.ColorAngle = 135F;
            this.nextFactorButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.nextFactorButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.nextFactorButton.StatePressed.Border.ColorAngle = 135F;
            this.nextFactorButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextFactorButton.StatePressed.Border.Rounding = 20;
            this.nextFactorButton.StatePressed.Border.Width = 1;
            this.nextFactorButton.StatePressed.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F);
            this.nextFactorButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.nextFactorButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.nextFactorButton.StateTracking.Back.ColorAngle = 45F;
            this.nextFactorButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.nextFactorButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.nextFactorButton.StateTracking.Border.ColorAngle = 45F;
            this.nextFactorButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextFactorButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nextFactorButton.StateTracking.Border.Rounding = 20;
            this.nextFactorButton.StateTracking.Border.Width = 1;
            this.nextFactorButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.nextFactorButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.nextFactorButton.StateTracking.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F);
            this.nextFactorButton.TabIndex = 23;
            this.nextFactorButton.Values.Text = "Следующий фактор";
            this.nextFactorButton.Click += new System.EventHandler(this.nextFactorButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Location = new System.Drawing.Point(372, 444);
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
            this.nextButton.TabIndex = 24;
            this.nextButton.Values.Text = "Перейти на следующий шаг";
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // ComboBoxMF
            // 
            this.ComboBoxMF.DropDownWidth = 379;
            this.ComboBoxMF.Items.AddRange(new object[] {
            "треугольная",
            "трапециевидная",
            "квадратичная S-сплайн",
            "квадратичная Z-сплайн",
            "экспоненциальная (гауссова)",
            "колоколообразная"});
            this.ComboBoxMF.Location = new System.Drawing.Point(282, 132);
            this.ComboBoxMF.Name = "ComboBoxMF";
            this.ComboBoxMF.Size = new System.Drawing.Size(391, 37);
            this.ComboBoxMF.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComboBoxMF.StateCommon.ComboBox.Border.Rounding = 20;
            this.ComboBoxMF.TabIndex = 26;
            this.ComboBoxMF.SelectedValueChanged += new System.EventHandler(this.ComboBoxMF_SelectedValueChanged);
            // 
            // mfComboBox
            // 
            this.mfComboBox.DropDownWidth = 379;
            this.mfComboBox.Items.AddRange(new object[] {
            "метод среднего максимумам (Middle of Maxima)",
            "метод центра тяжести (Center of Gravity)"});
            this.mfComboBox.Location = new System.Drawing.Point(282, 377);
            this.mfComboBox.Name = "mfComboBox";
            this.mfComboBox.Size = new System.Drawing.Size(391, 37);
            this.mfComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mfComboBox.StateCommon.ComboBox.Border.Rounding = 20;
            this.mfComboBox.TabIndex = 27;
            // 
            // algStep2Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mfComboBox);
            this.Controls.Add(this.ComboBoxMF);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.nextFactorButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.domainTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.parametersTextBox);
            this.Controls.Add(this.labelParameters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNameOfFactor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "algStep2Control";
            this.Size = new System.Drawing.Size(729, 518);
            this.Load += new System.EventHandler(this.algStep2Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxMF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNameOfFactor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelParameters;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox parametersTextBox;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox domainTextBox;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonButton nextFactorButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton nextButton;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ComboBoxMF;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox mfComboBox;
    }
}

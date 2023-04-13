
namespace FCMApp.Views.Controls
{
    partial class successFactorsLibControl
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.listFactorsView = new System.Windows.Forms.DataGridView();
            this.sfLoadButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addFactorButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.successFactorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nAMEFACTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONFACTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listFactorsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.successFactorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Факторы успеха IT-проекта";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listFactorsView
            // 
            this.listFactorsView.AllowUserToAddRows = false;
            this.listFactorsView.AllowUserToDeleteRows = false;
            this.listFactorsView.AutoGenerateColumns = false;
            this.listFactorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listFactorsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEFACTORDataGridViewTextBoxColumn,
            this.dESCRIPTIONFACTORDataGridViewTextBoxColumn});
            this.listFactorsView.DataSource = this.successFactorsBindingSource;
            this.listFactorsView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listFactorsView.Location = new System.Drawing.Point(0, 204);
            this.listFactorsView.Name = "listFactorsView";
            this.listFactorsView.ReadOnly = true;
            this.listFactorsView.RowHeadersWidth = 51;
            this.listFactorsView.RowTemplate.Height = 24;
            this.listFactorsView.Size = new System.Drawing.Size(729, 314);
            this.listFactorsView.TabIndex = 10;
            // 
            // sfLoadButton
            // 
            this.sfLoadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sfLoadButton.Location = new System.Drawing.Point(33, 64);
            this.sfLoadButton.Name = "sfLoadButton";
            this.sfLoadButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.sfLoadButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.sfLoadButton.OverrideDefault.Back.ColorAngle = 45F;
            this.sfLoadButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.sfLoadButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.sfLoadButton.OverrideDefault.Border.ColorAngle = 45F;
            this.sfLoadButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sfLoadButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.sfLoadButton.OverrideDefault.Border.Rounding = 20;
            this.sfLoadButton.OverrideDefault.Border.Width = 1;
            this.sfLoadButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.sfLoadButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.sfLoadButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F);
            this.sfLoadButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.sfLoadButton.Size = new System.Drawing.Size(247, 61);
            this.sfLoadButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.sfLoadButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.sfLoadButton.StateCommon.Back.ColorAngle = 45F;
            this.sfLoadButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.sfLoadButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.sfLoadButton.StateCommon.Border.ColorAngle = 45F;
            this.sfLoadButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sfLoadButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.sfLoadButton.StateCommon.Border.Rounding = 20;
            this.sfLoadButton.StateCommon.Border.Width = 1;
            this.sfLoadButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.sfLoadButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.sfLoadButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfLoadButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.sfLoadButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.sfLoadButton.StatePressed.Back.ColorAngle = 135F;
            this.sfLoadButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.sfLoadButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.sfLoadButton.StatePressed.Border.ColorAngle = 135F;
            this.sfLoadButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sfLoadButton.StatePressed.Border.Rounding = 20;
            this.sfLoadButton.StatePressed.Border.Width = 1;
            this.sfLoadButton.StatePressed.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F);
            this.sfLoadButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.sfLoadButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.sfLoadButton.StateTracking.Back.ColorAngle = 45F;
            this.sfLoadButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.sfLoadButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.sfLoadButton.StateTracking.Border.ColorAngle = 45F;
            this.sfLoadButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sfLoadButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.sfLoadButton.StateTracking.Border.Rounding = 20;
            this.sfLoadButton.StateTracking.Border.Width = 1;
            this.sfLoadButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.sfLoadButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.sfLoadButton.StateTracking.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F);
            this.sfLoadButton.TabIndex = 11;
            this.sfLoadButton.Values.Text = "Загрузить факторы";
            this.sfLoadButton.Click += new System.EventHandler(this.sfLoadButton_Click);
            // 
            // addFactorButton
            // 
            this.addFactorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFactorButton.Location = new System.Drawing.Point(318, 64);
            this.addFactorButton.Name = "addFactorButton";
            this.addFactorButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.addFactorButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.addFactorButton.OverrideDefault.Back.ColorAngle = 45F;
            this.addFactorButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.addFactorButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.addFactorButton.OverrideDefault.Border.ColorAngle = 45F;
            this.addFactorButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addFactorButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.addFactorButton.OverrideDefault.Border.Rounding = 20;
            this.addFactorButton.OverrideDefault.Border.Width = 1;
            this.addFactorButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.addFactorButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.addFactorButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F);
            this.addFactorButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.addFactorButton.Size = new System.Drawing.Size(255, 61);
            this.addFactorButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.addFactorButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.addFactorButton.StateCommon.Back.ColorAngle = 45F;
            this.addFactorButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.addFactorButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.addFactorButton.StateCommon.Border.ColorAngle = 45F;
            this.addFactorButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addFactorButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.addFactorButton.StateCommon.Border.Rounding = 20;
            this.addFactorButton.StateCommon.Border.Width = 1;
            this.addFactorButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.addFactorButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.addFactorButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFactorButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.addFactorButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.addFactorButton.StatePressed.Back.ColorAngle = 135F;
            this.addFactorButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.addFactorButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.addFactorButton.StatePressed.Border.ColorAngle = 135F;
            this.addFactorButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addFactorButton.StatePressed.Border.Rounding = 20;
            this.addFactorButton.StatePressed.Border.Width = 1;
            this.addFactorButton.StatePressed.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F);
            this.addFactorButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.addFactorButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.addFactorButton.StateTracking.Back.ColorAngle = 45F;
            this.addFactorButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.addFactorButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.addFactorButton.StateTracking.Border.ColorAngle = 45F;
            this.addFactorButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addFactorButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.addFactorButton.StateTracking.Border.Rounding = 20;
            this.addFactorButton.StateTracking.Border.Width = 1;
            this.addFactorButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.addFactorButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.addFactorButton.StateTracking.Content.ShortText.Font = new System.Drawing.Font("HSE Sans", 10.2F);
            this.addFactorButton.TabIndex = 12;
            this.addFactorButton.Values.Text = "Добавить фактор";
            this.addFactorButton.Click += new System.EventHandler(this.addFactorButton_Click);
            // 
            // successFactorsBindingSource
            // 
            this.successFactorsBindingSource.DataSource = typeof(FCMApp.Models.Library.successFactors);
            // 
            // nAMEFACTORDataGridViewTextBoxColumn
            // 
            this.nAMEFACTORDataGridViewTextBoxColumn.DataPropertyName = "NAME_FACTOR";
            this.nAMEFACTORDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nAMEFACTORDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nAMEFACTORDataGridViewTextBoxColumn.Name = "nAMEFACTORDataGridViewTextBoxColumn";
            this.nAMEFACTORDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAMEFACTORDataGridViewTextBoxColumn.Width = 200;
            // 
            // dESCRIPTIONFACTORDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONFACTORDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION_FACTOR";
            this.dESCRIPTIONFACTORDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.dESCRIPTIONFACTORDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dESCRIPTIONFACTORDataGridViewTextBoxColumn.Name = "dESCRIPTIONFACTORDataGridViewTextBoxColumn";
            this.dESCRIPTIONFACTORDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRIPTIONFACTORDataGridViewTextBoxColumn.Width = 300;
            // 
            // successFactorsLibControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addFactorButton);
            this.Controls.Add(this.sfLoadButton);
            this.Controls.Add(this.listFactorsView);
            this.Controls.Add(this.label1);
            this.Name = "successFactorsLibControl";
            this.Size = new System.Drawing.Size(729, 518);
            ((System.ComponentModel.ISupportInitialize)(this.listFactorsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.successFactorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listFactorsView;
        private ComponentFactory.Krypton.Toolkit.KryptonButton sfLoadButton;
        private System.Windows.Forms.BindingSource successFactorsBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addFactorButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEFACTORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONFACTORDataGridViewTextBoxColumn;
    }
}

namespace registry
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
            this.BtnCreateKey = new System.Windows.Forms.Button();
            this.TxtKeyName = new System.Windows.Forms.TextBox();
            this.KeyName = new System.Windows.Forms.Label();
            this.ValueName = new System.Windows.Forms.Label();
            this.TxtValueName = new System.Windows.Forms.TextBox();
            this.keyValue = new System.Windows.Forms.Label();
            this.TxtKeyValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDeleteKeyName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnReadValues = new System.Windows.Forms.Button();
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.LbxKeys = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnCreateKey
            // 
            this.BtnCreateKey.Location = new System.Drawing.Point(268, 154);
            this.BtnCreateKey.Name = "BtnCreateKey";
            this.BtnCreateKey.Size = new System.Drawing.Size(98, 40);
            this.BtnCreateKey.TabIndex = 0;
            this.BtnCreateKey.Text = "Create Key";
            this.BtnCreateKey.UseVisualStyleBackColor = true;
            this.BtnCreateKey.Click += new System.EventHandler(this.BtnCreateKey_Click);
            // 
            // TxtKeyName
            // 
            this.TxtKeyName.Location = new System.Drawing.Point(188, 64);
            this.TxtKeyName.Name = "TxtKeyName";
            this.TxtKeyName.Size = new System.Drawing.Size(178, 20);
            this.TxtKeyName.TabIndex = 1;
            // 
            // KeyName
            // 
            this.KeyName.AutoSize = true;
            this.KeyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyName.Location = new System.Drawing.Point(67, 60);
            this.KeyName.Name = "KeyName";
            this.KeyName.Size = new System.Drawing.Size(98, 24);
            this.KeyName.TabIndex = 2;
            this.KeyName.Text = "Key Name";
            // 
            // ValueName
            // 
            this.ValueName.AutoSize = true;
            this.ValueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueName.Location = new System.Drawing.Point(67, 87);
            this.ValueName.Name = "ValueName";
            this.ValueName.Size = new System.Drawing.Size(115, 24);
            this.ValueName.TabIndex = 4;
            this.ValueName.Text = "Value Name";
            // 
            // TxtValueName
            // 
            this.TxtValueName.Location = new System.Drawing.Point(188, 91);
            this.TxtValueName.Name = "TxtValueName";
            this.TxtValueName.Size = new System.Drawing.Size(178, 20);
            this.TxtValueName.TabIndex = 3;
            // 
            // keyValue
            // 
            this.keyValue.AutoSize = true;
            this.keyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyValue.Location = new System.Drawing.Point(67, 114);
            this.keyValue.Name = "keyValue";
            this.keyValue.Size = new System.Drawing.Size(96, 24);
            this.keyValue.TabIndex = 6;
            this.keyValue.Text = "Key Value";
            // 
            // TxtKeyValue
            // 
            this.TxtKeyValue.Location = new System.Drawing.Point(188, 118);
            this.TxtKeyValue.Name = "TxtKeyValue";
            this.TxtKeyValue.Size = new System.Drawing.Size(178, 20);
            this.TxtKeyValue.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(184, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Create Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(184, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Delete Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(67, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Key Name";
            // 
            // TxtDeleteKeyName
            // 
            this.TxtDeleteKeyName.Location = new System.Drawing.Point(188, 249);
            this.TxtDeleteKeyName.Name = "TxtDeleteKeyName";
            this.TxtDeleteKeyName.Size = new System.Drawing.Size(178, 20);
            this.TxtDeleteKeyName.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Delete Key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnReadValues
            // 
            this.BtnReadValues.Location = new System.Drawing.Point(691, 302);
            this.BtnReadValues.Name = "BtnReadValues";
            this.BtnReadValues.Size = new System.Drawing.Size(75, 23);
            this.BtnReadValues.TabIndex = 13;
            this.BtnReadValues.Text = "Read Values";
            this.BtnReadValues.UseVisualStyleBackColor = true;
            this.BtnReadValues.Click += new System.EventHandler(this.BtnReadValues_Click);
            // 
            // TxtInfo
            // 
            this.TxtInfo.Location = new System.Drawing.Point(450, 165);
            this.TxtInfo.Multiline = true;
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.ReadOnly = true;
            this.TxtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtInfo.Size = new System.Drawing.Size(316, 124);
            this.TxtInfo.TabIndex = 14;
            // 
            // LbxKeys
            // 
            this.LbxKeys.FormattingEnabled = true;
            this.LbxKeys.Location = new System.Drawing.Point(450, 64);
            this.LbxKeys.Name = "LbxKeys";
            this.LbxKeys.Size = new System.Drawing.Size(316, 82);
            this.LbxKeys.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbxKeys);
            this.Controls.Add(this.TxtInfo);
            this.Controls.Add(this.BtnReadValues);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDeleteKeyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyValue);
            this.Controls.Add(this.TxtKeyValue);
            this.Controls.Add(this.ValueName);
            this.Controls.Add(this.TxtValueName);
            this.Controls.Add(this.KeyName);
            this.Controls.Add(this.TxtKeyName);
            this.Controls.Add(this.BtnCreateKey);
            this.Name = "Form1";
            this.Text = "RegEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateKey;
        private System.Windows.Forms.TextBox TxtKeyName;
        private System.Windows.Forms.Label KeyName;
        private System.Windows.Forms.Label ValueName;
        private System.Windows.Forms.TextBox TxtValueName;
        private System.Windows.Forms.Label keyValue;
        private System.Windows.Forms.TextBox TxtKeyValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDeleteKeyName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnReadValues;
        private System.Windows.Forms.TextBox TxtInfo;
        private System.Windows.Forms.ListBox LbxKeys;
    }
}


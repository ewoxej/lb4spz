namespace LB4SPZ
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
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_content = new System.Windows.Forms.RichTextBox();
            this.btn_exch = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text_path = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(526, 14);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(607, 14);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File content";
            // 
            // text_content
            // 
            this.text_content.Enabled = false;
            this.text_content.Location = new System.Drawing.Point(12, 137);
            this.text_content.Name = "text_content";
            this.text_content.Size = new System.Drawing.Size(759, 169);
            this.text_content.TabIndex = 4;
            this.text_content.Text = "";
            // 
            // btn_exch
            // 
            this.btn_exch.Enabled = false;
            this.btn_exch.Location = new System.Drawing.Point(12, 52);
            this.btn_exch.Name = "btn_exch";
            this.btn_exch.Size = new System.Drawing.Size(143, 31);
            this.btn_exch.TabIndex = 5;
            this.btn_exch.Text = "Exchange";
            this.btn_exch.UseVisualStyleBackColor = true;
            this.btn_exch.Click += new System.EventHandler(this.btn_exch_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(688, 14);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "File path:";
            // 
            // text_path
            // 
            this.text_path.Enabled = false;
            this.text_path.Location = new System.Drawing.Point(80, 16);
            this.text_path.Name = "text_path";
            this.text_path.Size = new System.Drawing.Size(440, 20);
            this.text_path.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.text_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exch);
            this.Controls.Add(this.text_content);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_new);
            this.Name = "Form1";
            this.Text = "Laba4SPZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox text_content;
        private System.Windows.Forms.Button btn_exch;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_path;
    }
}


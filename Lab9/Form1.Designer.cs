
namespace Lab9
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Имя = new System.Windows.Forms.ListBox();
            this.Фамилия = new System.Windows.Forms.ListBox();
            this.Возраст = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(132, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(585, 319);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Имя
            // 
            this.Имя.FormattingEnabled = true;
            this.Имя.ItemHeight = 16;
            this.Имя.Location = new System.Drawing.Point(132, 13);
            this.Имя.Name = "Имя";
            this.Имя.Size = new System.Drawing.Size(152, 36);
            this.Имя.TabIndex = 1;
            this.Имя.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Фамилия
            // 
            this.Фамилия.FormattingEnabled = true;
            this.Фамилия.ItemHeight = 16;
            this.Фамилия.Location = new System.Drawing.Point(303, 12);
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Size = new System.Drawing.Size(188, 36);
            this.Фамилия.TabIndex = 2;
            // 
            // Возраст
            // 
            this.Возраст.FormattingEnabled = true;
            this.Возраст.ItemHeight = 16;
            this.Возраст.Location = new System.Drawing.Point(522, 13);
            this.Возраст.Name = "Возраст";
            this.Возраст.Size = new System.Drawing.Size(195, 36);
            this.Возраст.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Возраст);
            this.Controls.Add(this.Фамилия);
            this.Controls.Add(this.Имя);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox Имя;
        private System.Windows.Forms.ListBox Фамилия;
        private System.Windows.Forms.ListBox Возраст;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}


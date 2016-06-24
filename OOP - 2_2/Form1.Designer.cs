namespace OOP___2_2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_result_x2 = new System.Windows.Forms.TextBox();
            this.txt_result_x1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_do = new System.Windows.Forms.Button();
            this.rb_Method = new System.Windows.Forms.RadioButton();
            this.rv_Event = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_c);
            this.groupBox1.Controls.Add(this.txt_b);
            this.groupBox1.Controls.Add(this.txt_a);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "c = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "b = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "a = ";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(51, 74);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(100, 20);
            this.txt_c.TabIndex = 2;
            this.txt_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(51, 48);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 20);
            this.txt_b.TabIndex = 1;
            this.txt_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(51, 22);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(100, 20);
            this.txt_a.TabIndex = 0;
            this.txt_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_result_x2);
            this.groupBox2.Controls.Add(this.txt_result_x1);
            this.groupBox2.Location = new System.Drawing.Point(192, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "x2 = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "x1 = ";
            // 
            // txt_result_x2
            // 
            this.txt_result_x2.BackColor = System.Drawing.SystemColors.Window;
            this.txt_result_x2.Location = new System.Drawing.Point(51, 65);
            this.txt_result_x2.Name = "txt_result_x2";
            this.txt_result_x2.ReadOnly = true;
            this.txt_result_x2.Size = new System.Drawing.Size(100, 20);
            this.txt_result_x2.TabIndex = 1;
            // 
            // txt_result_x1
            // 
            this.txt_result_x1.BackColor = System.Drawing.SystemColors.Window;
            this.txt_result_x1.Location = new System.Drawing.Point(51, 26);
            this.txt_result_x1.Name = "txt_result_x1";
            this.txt_result_x1.ReadOnly = true;
            this.txt_result_x1.Size = new System.Drawing.Size(100, 20);
            this.txt_result_x1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btn_new);
            this.groupBox3.Controls.Add(this.btn_close);
            this.groupBox3.Controls.Add(this.btn_do);
            this.groupBox3.Controls.Add(this.rb_Method);
            this.groupBox3.Controls.Add(this.rv_Event);
            this.groupBox3.Location = new System.Drawing.Point(17, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление";
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_new.Location = new System.Drawing.Point(175, 57);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 5;
            this.btn_new.Text = "Новое";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_close.Location = new System.Drawing.Point(257, 19);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 61);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Завершить";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_do
            // 
            this.btn_do.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_do.Location = new System.Drawing.Point(175, 19);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(75, 23);
            this.btn_do.TabIndex = 3;
            this.btn_do.Text = "Вычислить";
            this.btn_do.UseVisualStyleBackColor = false;
            this.btn_do.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_Method
            // 
            this.rb_Method.AutoSize = true;
            this.rb_Method.BackColor = System.Drawing.Color.Transparent;
            this.rb_Method.Location = new System.Drawing.Point(17, 57);
            this.rb_Method.Name = "rb_Method";
            this.rb_Method.Size = new System.Drawing.Size(57, 17);
            this.rb_Method.TabIndex = 1;
            this.rb_Method.TabStop = true;
            this.rb_Method.Text = "Метод";
            this.rb_Method.UseVisualStyleBackColor = false;
            // 
            // rv_Event
            // 
            this.rv_Event.AutoSize = true;
            this.rv_Event.BackColor = System.Drawing.Color.Transparent;
            this.rv_Event.Checked = true;
            this.rv_Event.Location = new System.Drawing.Point(17, 25);
            this.rv_Event.Name = "rv_Event";
            this.rv_Event.Size = new System.Drawing.Size(69, 17);
            this.rv_Event.TabIndex = 0;
            this.rv_Event.TabStop = true;
            this.rv_Event.Text = "Событие";
            this.rv_Event.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(364, 232);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Решение квадратных уравнений";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_result_x2;
        private System.Windows.Forms.TextBox txt_result_x1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_do;
        private System.Windows.Forms.RadioButton rb_Method;
        private System.Windows.Forms.RadioButton rv_Event;
    }
}


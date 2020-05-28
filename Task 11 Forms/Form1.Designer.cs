namespace Task_11_Forms
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
            this.Task = new System.Windows.Forms.GroupBox();
            this.print = new System.Windows.Forms.Label();
            this.information = new System.Windows.Forms.Label();
            this.remore = new System.Windows.Forms.Label();
            this.v3 = new System.Windows.Forms.Label();
            this.v2 = new System.Windows.Forms.Label();
            this.t_or_f = new System.Windows.Forms.Label();
            this.v1 = new System.Windows.Forms.Label();
            this.Botton = new System.Windows.Forms.Button();
            this.Task.SuspendLayout();
            this.SuspendLayout();
            // 
            // Task
            // 
            this.Task.BackColor = System.Drawing.Color.White;
            this.Task.Controls.Add(this.print);
            this.Task.Controls.Add(this.information);
            this.Task.Controls.Add(this.remore);
            this.Task.Controls.Add(this.v3);
            this.Task.Controls.Add(this.v2);
            this.Task.Controls.Add(this.t_or_f);
            this.Task.Controls.Add(this.v1);
            this.Task.Location = new System.Drawing.Point(79, 67);
            this.Task.Margin = new System.Windows.Forms.Padding(2);
            this.Task.Name = "Task";
            this.Task.Padding = new System.Windows.Forms.Padding(2);
            this.Task.Size = new System.Drawing.Size(445, 347);
            this.Task.TabIndex = 9;
            this.Task.TabStop = false;
            // 
            // print
            // 
            this.print.AutoSize = true;
            this.print.Location = new System.Drawing.Point(4, 191);
            this.print.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(0, 13);
            this.print.TabIndex = 10;
            // 
            // information
            // 
            this.information.AutoSize = true;
            this.information.Location = new System.Drawing.Point(4, 28);
            this.information.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(0, 13);
            this.information.TabIndex = 9;
            // 
            // remore
            // 
            this.remore.AutoSize = true;
            this.remore.Location = new System.Drawing.Point(4, 276);
            this.remore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.remore.Name = "remore";
            this.remore.Size = new System.Drawing.Size(0, 13);
            this.remore.TabIndex = 7;
            // 
            // v3
            // 
            this.v3.AutoSize = true;
            this.v3.Location = new System.Drawing.Point(13, 258);
            this.v3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(428, 13);
            this.v3.TabIndex = 6;
            this.v3.Text = "УДАЛЕНИЕ ИЗ ТЕКСТА ФРАГМЕНТОВ, СООТВЕТСТВУЮЩИХ ШАБЛОНУ ПОЛЯ:";
            // 
            // v2
            // 
            this.v2.AutoSize = true;
            this.v2.Location = new System.Drawing.Point(40, 178);
            this.v2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(340, 13);
            this.v2.TabIndex = 4;
            this.v2.Text = "ФРАГМЕНТЫ ТЕКСТА, СООТВЕТСТВУЮЩИЕ ШАБЛОНУ ПОЛЯ:";
            // 
            // t_or_f
            // 
            this.t_or_f.AutoSize = true;
            this.t_or_f.Location = new System.Drawing.Point(4, 146);
            this.t_or_f.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.t_or_f.Name = "t_or_f";
            this.t_or_f.Size = new System.Drawing.Size(0, 13);
            this.t_or_f.TabIndex = 3;
            // 
            // v1
            // 
            this.v1.AutoSize = true;
            this.v1.Location = new System.Drawing.Point(13, 116);
            this.v1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(419, 13);
            this.v1.TabIndex = 2;
            this.v1.Text = "СОДЕРЖИТ ЛИ ТЕКСТ ФРАГМЕНТЫ, СООТВЕТСТВУЮЩИЕ ШАБЛОНУ ПОЛЯ:";
            // 
            // Botton
            // 
            this.Botton.BackColor = System.Drawing.Color.White;
            this.Botton.Location = new System.Drawing.Point(227, 19);
            this.Botton.Margin = new System.Windows.Forms.Padding(2);
            this.Botton.Name = "Botton";
            this.Botton.Size = new System.Drawing.Size(155, 44);
            this.Botton.TabIndex = 10;
            this.Botton.Text = "Вывести";
            this.Botton.UseVisualStyleBackColor = false;
            this.Botton.Click += new System.EventHandler(this.Botton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.Botton);
            this.Name = "Form1";
            this.Text = "Задание 11";
            this.Task.ResumeLayout(false);
            this.Task.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Task;
        private System.Windows.Forms.Label print;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.Label remore;
        private System.Windows.Forms.Label v3;
        private System.Windows.Forms.Label v2;
        private System.Windows.Forms.Label t_or_f;
        private System.Windows.Forms.Label v1;
        private System.Windows.Forms.Button Botton;
    }
}


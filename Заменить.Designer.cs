namespace Текстовый_Редактор
{
    partial class Заменить
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonЗамена = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonНайтиДЗам = new System.Windows.Forms.Button();
            this.buttonЗаменаВсё = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Заменить:";
            // 
            // buttonЗамена
            // 
            this.buttonЗамена.Location = new System.Drawing.Point(0, 68);
            this.buttonЗамена.Name = "buttonЗамена";
            this.buttonЗамена.Size = new System.Drawing.Size(93, 31);
            this.buttonЗамена.TabIndex = 3;
            this.buttonЗамена.Text = "Заменить";
            this.buttonЗамена.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Заменить на:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 22);
            this.textBox2.TabIndex = 6;
            // 
            // buttonНайтиДЗам
            // 
            this.buttonНайтиДЗам.Location = new System.Drawing.Point(99, 68);
            this.buttonНайтиДЗам.Name = "buttonНайтиДЗам";
            this.buttonНайтиДЗам.Size = new System.Drawing.Size(131, 31);
            this.buttonНайтиДЗам.TabIndex = 7;
            this.buttonНайтиДЗам.Text = "Найти далее";
            this.buttonНайтиДЗам.UseVisualStyleBackColor = true;
            // 
            // buttonЗаменаВсё
            // 
            this.buttonЗаменаВсё.Location = new System.Drawing.Point(236, 68);
            this.buttonЗаменаВсё.Name = "buttonЗаменаВсё";
            this.buttonЗаменаВсё.Size = new System.Drawing.Size(121, 31);
            this.buttonЗаменаВсё.TabIndex = 8;
            this.buttonЗаменаВсё.Text = "Заменить всё";
            this.buttonЗаменаВсё.UseVisualStyleBackColor = true;
            // 
            // Заменить
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 103);
            this.Controls.Add(this.buttonЗаменаВсё);
            this.Controls.Add(this.buttonНайтиДЗам);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonЗамена);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(379, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(379, 150);
            this.Name = "Заменить";
            this.Text = "Заменить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button buttonЗамена;
        public System.Windows.Forms.Button buttonНайтиДЗам;
        public System.Windows.Forms.Button buttonЗаменаВсё;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
    }
}
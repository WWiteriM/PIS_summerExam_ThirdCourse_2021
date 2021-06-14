
namespace Test_Exam_Task_3_Client
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
            this.XtextBox = new System.Windows.Forms.TextBox();
            this.YtextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XtextBox
            // 
            this.XtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XtextBox.Location = new System.Drawing.Point(68, 65);
            this.XtextBox.Name = "XtextBox";
            this.XtextBox.Size = new System.Drawing.Size(235, 29);
            this.XtextBox.TabIndex = 0;
            // 
            // YtextBox
            // 
            this.YtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YtextBox.Location = new System.Drawing.Point(337, 65);
            this.YtextBox.Name = "YtextBox";
            this.YtextBox.Size = new System.Drawing.Size(235, 29);
            this.YtextBox.TabIndex = 1;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextBox.Location = new System.Drawing.Point(203, 255);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(240, 29);
            this.ResultTextBox.TabIndex = 2;
            // 
            // Sum
            // 
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum.Location = new System.Drawing.Point(68, 123);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(99, 40);
            this.Sum.TabIndex = 3;
            this.Sum.Text = "Sum";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Sub
            // 
            this.Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sub.Location = new System.Drawing.Point(203, 123);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(100, 40);
            this.Sub.TabIndex = 4;
            this.Sub.Text = "Sub";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mul
            // 
            this.Mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mul.Location = new System.Drawing.Point(337, 122);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(106, 40);
            this.Mul.TabIndex = 5;
            this.Mul.Text = "Mul";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(471, 122);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(101, 41);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 410);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.YtextBox);
            this.Controls.Add(this.XtextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox XtextBox;
        private System.Windows.Forms.TextBox YtextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Clear;
    }
}


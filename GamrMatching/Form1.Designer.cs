namespace GamrMatching
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
            this.lGameName = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bEasy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bRanking = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lGameName
            // 
            this.lGameName.AutoSize = true;
            this.lGameName.Font = new System.Drawing.Font("Segoe Script", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGameName.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lGameName.Location = new System.Drawing.Point(32, 20);
            this.lGameName.Name = "lGameName";
            this.lGameName.Size = new System.Drawing.Size(363, 64);
            this.lGameName.TabIndex = 0;
            this.lGameName.Text = "Matching Game";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.Location = new System.Drawing.Point(30, 95);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(56, 20);
            this.lName.TabIndex = 1;
            this.lName.Text = "Player";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(33, 115);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(230, 20);
            this.tbName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose level";
            // 
            // bEasy
            // 
            this.bEasy.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEasy.Location = new System.Drawing.Point(0, 14);
            this.bEasy.Name = "bEasy";
            this.bEasy.Size = new System.Drawing.Size(154, 36);
            this.bEasy.TabIndex = 0;
            this.bEasy.Text = "Easy";
            this.bEasy.UseVisualStyleBackColor = true;
            this.bEasy.Click += new System.EventHandler(this.bEasy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bEasy);
            this.panel1.Location = new System.Drawing.Point(32, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 139);
            this.panel1.TabIndex = 5;
            // 
            // bRanking
            // 
            this.bRanking.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRanking.Location = new System.Drawing.Point(346, 375);
            this.bRanking.Name = "bRanking";
            this.bRanking.Size = new System.Drawing.Size(108, 38);
            this.bRanking.TabIndex = 7;
            this.bRanking.Text = "Ranking";
            this.bRanking.UseVisualStyleBackColor = true;
            this.bRanking.Click += new System.EventHandler(this.bRanking_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 425);
            this.Controls.Add(this.bRanking);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lGameName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lGameName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEasy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bRanking;
    }
}


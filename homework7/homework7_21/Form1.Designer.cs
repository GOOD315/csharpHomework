namespace homework7_21
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
            this.Name1 = new System.Windows.Forms.Label();
            this.Name2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblTuz = new System.Windows.Forms.Label();
            this.btnTuz1 = new System.Windows.Forms.Button();
            this.btnTuz10 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name1
            // 
            this.Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name1.Location = new System.Drawing.Point(32, 63);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(182, 59);
            this.Name1.TabIndex = 0;
            this.Name1.Text = "ВЫ";
            // 
            // Name2
            // 
            this.Name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name2.Location = new System.Drawing.Point(283, 63);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(182, 59);
            this.Name2.TabIndex = 0;
            this.Name2.Text = "СОПЕРНИК";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "21";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(158, 242);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 53);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "СТАРТ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnTake
            // 
            this.btnTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTake.Location = new System.Drawing.Point(158, 242);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(130, 53);
            this.btnTake.TabIndex = 1;
            this.btnTake.Text = "ВЗЯТЬ";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.Black;
            this.lblPlayer1.Location = new System.Drawing.Point(43, 140);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(60, 54);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "0";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.Black;
            this.lblPlayer2.Location = new System.Drawing.Point(337, 140);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(60, 54);
            this.lblPlayer2.TabIndex = 0;
            this.lblPlayer2.Text = "0";
            // 
            // lblTuz
            // 
            this.lblTuz.AutoSize = true;
            this.lblTuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTuz.Location = new System.Drawing.Point(32, 193);
            this.lblTuz.Name = "lblTuz";
            this.lblTuz.Size = new System.Drawing.Size(65, 31);
            this.lblTuz.TabIndex = 2;
            this.lblTuz.Text = "ТУЗ";
            // 
            // btnTuz1
            // 
            this.btnTuz1.Location = new System.Drawing.Point(27, 227);
            this.btnTuz1.Name = "btnTuz1";
            this.btnTuz1.Size = new System.Drawing.Size(32, 38);
            this.btnTuz1.TabIndex = 3;
            this.btnTuz1.Text = "+1";
            this.btnTuz1.UseVisualStyleBackColor = true;
            this.btnTuz1.Click += new System.EventHandler(this.butnTuz1_Click);
            // 
            // btnTuz10
            // 
            this.btnTuz10.Location = new System.Drawing.Point(65, 227);
            this.btnTuz10.Name = "btnTuz10";
            this.btnTuz10.Size = new System.Drawing.Size(38, 38);
            this.btnTuz10.TabIndex = 3;
            this.btnTuz10.Text = "+11";
            this.btnTuz10.UseVisualStyleBackColor = true;
            this.btnTuz10.Click += new System.EventHandler(this.butnTuz11_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(158, 301);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(130, 53);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "СТОП";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessage.Location = new System.Drawing.Point(109, 125);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(196, 99);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Вы проиграли";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 374);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnTuz10);
            this.Controls.Add(this.btnTuz1);
            this.Controls.Add(this.lblTuz);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.Name2);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label Name2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblTuz;
        private System.Windows.Forms.Button btnTuz1;
        private System.Windows.Forms.Button btnTuz10;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblMessage;
    }
}


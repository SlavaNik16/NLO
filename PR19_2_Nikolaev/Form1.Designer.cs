namespace PR19_2_Nikolaev
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartBut = new System.Windows.Forms.Button();
            this.LaserBut = new System.Windows.Forms.Button();
            this.StopBut = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // StartBut
            // 
            this.StartBut.BackColor = System.Drawing.Color.Lime;
            this.StartBut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBut.Location = new System.Drawing.Point(12, 12);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(88, 34);
            this.StartBut.TabIndex = 0;
            this.StartBut.Text = "Старт";
            this.StartBut.UseVisualStyleBackColor = false;
            this.StartBut.Click += new System.EventHandler(this.StartBut_Click);
            // 
            // LaserBut
            // 
            this.LaserBut.BackColor = System.Drawing.Color.Cyan;
            this.LaserBut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LaserBut.Location = new System.Drawing.Point(124, 12);
            this.LaserBut.Name = "LaserBut";
            this.LaserBut.Size = new System.Drawing.Size(189, 34);
            this.LaserBut.TabIndex = 1;
            this.LaserBut.Text = "Включить Лазер";
            this.LaserBut.UseVisualStyleBackColor = false;
            this.LaserBut.Click += new System.EventHandler(this.LaserBut_Click);
            // 
            // StopBut
            // 
            this.StopBut.BackColor = System.Drawing.Color.Red;
            this.StopBut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopBut.Location = new System.Drawing.Point(336, 12);
            this.StopBut.Name = "StopBut";
            this.StopBut.Size = new System.Drawing.Size(88, 34);
            this.StopBut.TabIndex = 2;
            this.StopBut.Text = "Стоп";
            this.StopBut.UseVisualStyleBackColor = false;
            this.StopBut.Click += new System.EventHandler(this.StopBut_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(463, 19);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(113, 20);
            this.ResultBox.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "player.bmp");
            this.imageList1.Images.SetKeyName(1, "player1.bmp");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.StopBut);
            this.Controls.Add(this.LaserBut);
            this.Controls.Add(this.StartBut);
            this.Name = "Form1";
            this.Text = "Игра \"НЛО\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBut;
        private System.Windows.Forms.Button LaserBut;
        private System.Windows.Forms.Button StopBut;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ImageList imageList1;
    }
}


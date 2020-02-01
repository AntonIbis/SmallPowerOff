namespace SmallWinPowerOff
{
    partial class MainForm
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Timer1Sec = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblSet = new System.Windows.Forms.Label();
            this.LblDateTimeNow = new System.Windows.Forms.Label();
            this.TimePik = new System.Windows.Forms.DateTimePicker();
            this.TimerOff = new System.Windows.Forms.Timer(this.components);
            this.TextTimerOff = new System.Windows.Forms.TextBox();
            this.UpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnStart.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.BtnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.Location = new System.Drawing.Point(225, 272);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(150, 50);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "ПУСК";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.UpPanel.Controls.Add(this.label1);
            this.UpPanel.Controls.Add(this.BtnMinimize);
            this.UpPanel.Controls.Add(this.BtnClose);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(0, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(600, 30);
            this.UpPanel.TabIndex = 1;
            this.UpPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(224, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Small Power Off";
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.Location = new System.Drawing.Point(529, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(30, 30);
            this.BtnMinimize.TabIndex = 2;
            this.BtnMinimize.Text = "_";
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.ForeColor = System.Drawing.Color.Transparent;
            this.BtnClose.Location = new System.Drawing.Point(565, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 370);
            this.panel2.TabIndex = 0;
            // 
            // Timer1Sec
            // 
            this.Timer1Sec.Interval = 1000;
            this.Timer1Sec.Tick += new System.EventHandler(this.Timer1Sec_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(595, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 370);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(590, 5);
            this.panel3.TabIndex = 2;
            // 
            // LblSet
            // 
            this.LblSet.AutoSize = true;
            this.LblSet.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSet.ForeColor = System.Drawing.Color.Transparent;
            this.LblSet.Location = new System.Drawing.Point(156, 187);
            this.LblSet.Name = "LblSet";
            this.LblSet.Size = new System.Drawing.Size(179, 26);
            this.LblSet.TabIndex = 3;
            this.LblSet.Text = "Выключить через:";
            // 
            // LblDateTimeNow
            // 
            this.LblDateTimeNow.AutoSize = true;
            this.LblDateTimeNow.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDateTimeNow.ForeColor = System.Drawing.Color.Transparent;
            this.LblDateTimeNow.Location = new System.Drawing.Point(177, 104);
            this.LblDateTimeNow.Name = "LblDateTimeNow";
            this.LblDateTimeNow.Size = new System.Drawing.Size(247, 26);
            this.LblDateTimeNow.TabIndex = 3;
            this.LblDateTimeNow.Text = "Сейчас: 00.00.00 00:00:00";
            // 
            // TimePik
            // 
            this.TimePik.CalendarForeColor = System.Drawing.Color.Transparent;
            this.TimePik.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TimePik.Checked = false;
            this.TimePik.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimePik.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePik.Location = new System.Drawing.Point(341, 184);
            this.TimePik.Name = "TimePik";
            this.TimePik.Size = new System.Drawing.Size(104, 33);
            this.TimePik.TabIndex = 6;
            // 
            // TimerOff
            // 
            this.TimerOff.Interval = 1000;
            this.TimerOff.Tick += new System.EventHandler(this.TimerOff_Tick);
            // 
            // TextTimerOff
            // 
            this.TextTimerOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TextTimerOff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTimerOff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextTimerOff.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextTimerOff.ForeColor = System.Drawing.Color.Transparent;
            this.TextTimerOff.Location = new System.Drawing.Point(5, 369);
            this.TextTimerOff.Name = "TextTimerOff";
            this.TextTimerOff.Size = new System.Drawing.Size(590, 26);
            this.TextTimerOff.TabIndex = 8;
            this.TextTimerOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.TextTimerOff);
            this.Controls.Add(this.TimePik);
            this.Controls.Add(this.LblDateTimeNow);
            this.Controls.Add(this.LblSet);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UpPanel);
            this.Controls.Add(this.BtnStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.UpPanel.ResumeLayout(false);
            this.UpPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Panel panel2;
        protected internal System.Windows.Forms.Timer Timer1Sec;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSet;
        private System.Windows.Forms.Label LblDateTimeNow;
        protected internal System.Windows.Forms.DateTimePicker TimePik;
        private System.Windows.Forms.Timer TimerOff;
        private System.Windows.Forms.TextBox TextTimerOff;
        private System.Windows.Forms.Button BtnMinimize;
    }
}


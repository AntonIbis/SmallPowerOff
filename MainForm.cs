using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmallWinPowerOff
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Timer1Sec.Start();
            TimePik.Format = DateTimePickerFormat.Time;
            TimePik.ShowUpDown = true;
        }

        #region Перемещение формы
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        DateTime TimeOff;

        private void UpPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            string msg = "Вы уверены, что хотите выйти? Если приложение закроется - таймер отключится.";
            if (TimerOff.Enabled)
            {
                DialogResult result = MessageBox.Show(msg, "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    Dispose();
                    Close();
                    Application.Exit();
                }
            }
            else
            {
                Dispose();
                Close();
                Application.Exit();
            }
        }
        private void Timer1Sec_Tick(object sender, EventArgs e)
        {
            LblDateTimeNow.Text = $"Сейчас: {DateTime.Now}";
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (TimerOff.Enabled == false)
            {
                int ToSec = (TimePik.Value.Hour * 3600) + (TimePik.Value.Minute * 60) + (TimePik.Value.Second);
                TimeOff = DateTime.Now.AddSeconds(ToSec);
                //MessageBox.Show(ToSec.ToString());
                TimerOff.Start();
                BtnStart.Text = "ОТМЕНА";
            }
            else
            {
                TimerOff.Stop();

                this.TopMost = false;

                this.BackColor = Color.FromArgb(28, 28, 28);
                TextTimerOff.Text = "Таймер остановлен";
                BtnStart.Text = "ПУСК";

            }
        }
        private void TimerOff_Tick(object sender, EventArgs e)
        {
            TimeSpan ts;
            if (DateTime.Now < TimeOff)
            {
                ts = TimeOff - DateTime.Now;
                TextTimerOff.Text = $"До отключения осталось {ts.Hours} часов {ts.Minutes} минут {ts.Seconds} секунд";
                if (ts.Hours == 0 & ts.Minutes == 0 & ts.Seconds <= 30)
                {
                    this.Activate();
                    this.BackColor = Color.Red;
                    this.WindowState = FormWindowState.Normal;
                    this.TopMost = true;
                    TextTimerOff.Text = $"Внимание! Компьютер выключится через {ts.Seconds} секунд";
                }
            }
            else
            {
                Process.Start("shutdown", "/s /t 01");
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            TimePik.Value = DateTime.Now.AddSeconds(30) - DateTime.Now.TimeOfDay;
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

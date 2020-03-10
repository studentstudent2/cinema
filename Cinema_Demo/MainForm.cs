using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Cinema_Demo
{
    public partial class MainForm : Form
    {
        private ToolTip toolTip;

        //Для передвижения
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        //Для заокругления углов
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        //Для добавления тени
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            //Заокругление углов
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            mainPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, mainPanel.Width, mainPanel.Height, 20, 20));

            //Плавное открітие формі
            this.Opacity = 0;
            Timer t = new Timer();
            t.Enabled = true;
            t.Tick += new EventHandler((tsender, te) =>
            {
                if (this.Opacity == 1)
                {
                    t.Stop();
                }
                else
                {
                    this.Opacity += 0.1;
                }
            });
            t.Interval = 20;
            t.Start();

            //Создание таймера для получения даты
            Timer t2 = new Timer();
            t2.Enabled = true;
            t2.Tick += new EventHandler((tsender, te) =>
            {
                //Установка даты
                yearField.Text = DateTime.Now.ToString();
            });
            t2.Interval = 20;
            t2.Start();

            //Установка подсказок
            toolTip = new ToolTip();

            toolTip.SetToolTip(closeButton, "Закрыть");
            toolTip.SetToolTip(minimizeButton, "Свернуть");
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(Handle, 0x0112, 0xf012, 0);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
            RedondearBordes(10);
        }

        public static string static_day;

        public void days(int numday)
        {
            lbDays.Text = numday + "";
        }

        private void RedondearBordes(int radio)
        {
            System.Drawing.Drawing2D.GraphicsPath forma = new System.Drawing.Drawing2D.GraphicsPath();
            forma.StartFigure();
            forma.AddArc(new Rectangle(0, 0, radio * 2, radio * 2), 180, 90);
            forma.AddLine(radio, 0, this.Width - radio, 0);
            forma.AddArc(new Rectangle(this.Width - radio * 2, 0, radio * 2, radio * 2), -90, 90);
            forma.AddLine(this.Width, radio, this.Width, this.Height - radio);
            forma.AddArc(new Rectangle(this.Width - radio * 2, this.Height - radio * 2, radio * 2, radio * 2), 0, 90);
            forma.AddLine(this.Width - radio, this.Height, radio, this.Height);
            forma.AddArc(new Rectangle(0, this.Height - radio * 2, radio * 2, radio * 2), 90, 90);
            forma.CloseFigure();
            this.Region = new System.Drawing.Region(forma);
        }

        private void UserControlDays_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
            this.BackColor = Color.LightGray;
        }

        private void UserControlDays_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
            this.BackColor = Color.Transparent;
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbDays.Text;
            Eventos eventos = new Eventos();
            eventos.Show(); 
        }
    }
}

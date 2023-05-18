using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar aqui la libreria de conexion a la bd en caso de usar una

namespace Calendar
{
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
        }

        //sentencia de conexion o metodo de conexion
        //String conn = "Server=localhost;user id=root;database=basededatos";


        private void Eventos_Load(object sender, EventArgs e)
        {
                txtfecha.Text = Form1.static_month+"/"+UserControlDays.static_day + "/"+ Form1.static_year;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mysqlconnection conn = new mysqlconnection(connstring);
            /*abrir conexion
              conn.open();
              string sql = "insert into calendario(fecha, evento)values(?,?)";
              mysqlcommand cmd = conn.createcommand();
              cmd.prameters.addvalue("fecha",txtfecha.text);
              cmd.prameters.addvalue("evento",txtevento.text);
              cmd.executenonquery();
              messagebox.show("saved");
              cmd.dispose();
              conn.close();
             */
        }
    }
}

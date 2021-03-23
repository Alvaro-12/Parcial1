using Parcial1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClsEmpleado clsEmpleado = new ClsEmpleado();
            clsEmpleado.deletusuarios(Convert.ToInt32(Txt.Text));
            //{
            //    ClsDUserlist clsDUserlist = new ClsDUserlist();
            //    clsDUserlist.deletusuarios(Convert.ToInt32(TxtId.Text));
            //    carga();
            //    clear();
            //}
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eMPLEADODataSet.Tbl_empleado' Puede moverla o quitarla según sea necesario.
            this.tbl_empleadoTableAdapter.Fill(this.eMPLEADODataSet.Tbl_empleado);

        }
    }
}

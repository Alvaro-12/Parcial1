using Parcial1.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.DAO
{
    class ClsEmpleado
    {
        public void deletusuarios(int iD)
        {
            try
            {

                using (EMPLEADOEntities db = new EMPLEADOEntities())
                {
                    int Eliminar = Convert.ToInt32(iD);
                    ClsEmpleado clsEmpleado = db.ClsEmpleado.Where(x => x.Id == Eliminar).Select(x => x).FirstOrDefault();
                    //new UserList();
                    // userList = db.UserList.Find(TxtId.Text);
                    db.ClsEmpleado.Remove(clsEmpleado);
                    db.SaveChanges();

                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }


        }







    }
}

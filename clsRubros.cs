using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCapelloArticulos
{
    internal class clsRubros
    {
        public string NombreArchivo = "Rubros.csv";
        public string[] TipoRubro = new string[3];

        private void LeerArchivo()
        {
            StreamReader LD = new StreamReader("../../Archivos/Rubros.csv");

            for (int i = 0; i < TipoRubro.Length; i++)
            {
                string datosLeidos = LD.ReadLine();
                
                if (datosLeidos != null)
                {
                    TipoRubro[i] = datosLeidos;
                }
            }

            LD.Close();
            LD.Dispose();
        }

        public void PasarDatosCbo(ComboBox cbo)
        {
            LeerArchivo();
            cbo.DataSource = TipoRubro;
        }
    }
}

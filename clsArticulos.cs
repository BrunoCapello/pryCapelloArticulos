using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCapelloArticulos
{
    internal class clsArticulos
    {
        public struct regArticulos
        {
            public string Codigo;
            public string Desc;
            public Decimal Costo;
            public string Rubro;
            public Int32 Stock;
            public Decimal Valor;
        }

        public string nombreArchivo = "Articulos.csv";

        public regArticulos[] Articulos = new regArticulos[12];

        private void LeerArchivo()
        {
            StreamReader LD = new StreamReader("../../Archivos/Articulos.csv");
            LD.ReadLine();

            for (int i = 0; i < Articulos.Length; i++)
            {
                string datosLeidos = LD.ReadLine();
                
                if (datosLeidos != null)
                {
                    string[] vecDatos = datosLeidos.Split(',');

                    Articulos[i].Codigo = vecDatos[0];
                    Articulos[i].Desc = vecDatos[1];
                    Articulos[i].Costo = Convert.ToDecimal(vecDatos[2]);
                    Articulos[i].Rubro = vecDatos[3];
                    Articulos[i].Stock = Convert.ToInt32(vecDatos[4]);
                    Articulos[i].Valor = Articulos[i].Costo * Articulos[i].Stock;
                }
            }
            LD.Close();
            LD.Dispose();
        }

        public void CargarDgv(DataGridView dgv, ComboBox cbo, Label lblCantidadTotal, Label lblValorTotal)
        {
            LeerArchivo();

            Int32 contador = 0;
            Decimal total = 0;

            if (cbo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una opción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            dgv.Rows.Clear();
            for (int i = 0; i < Articulos.Length; i++)
            {
                if (Articulos[i].Rubro == cbo.Text)
                {
                    dgv.Rows.Add(
                        Articulos[i].Codigo,
                        Articulos[i].Desc,
                        Articulos[i].Costo,
                        Articulos[i].Stock,
                        Articulos[i].Valor
                        );

                    contador++;
                    total += Articulos[i].Valor;
                }
            }

            lblCantidadTotal.Text = contador.ToString();
            lblValorTotal.Text = total.ToString();
        }

        public void ExportarArchivo(string rubro)
        {
            LeerArchivo();

            Int32 contador = 0;
            Decimal total = 0;

            StreamWriter PD = new StreamWriter("../../Archivos/ Listado de " + rubro + ".csv", false, Encoding.UTF8);

            PD.WriteLine("Rubro " + rubro);
            PD.WriteLine("");
            PD.WriteLine("Codigo;Costo;Descripcion;Stock;Valor");

            for (int i = 0; i < Articulos.Length; i++)
            {
                if (Articulos[i].Rubro == rubro)
                {
                    PD.Write(Articulos[i].Codigo);
                    PD.Write(";");
                    PD.Write(Articulos[i].Costo);
                    PD.Write(";");
                    PD.Write(Articulos[i].Desc);
                    PD.Write(";");
                    PD.Write(Articulos[i].Stock);
                    PD.Write(";");
                    PD.WriteLine(Articulos[i].Valor);

                    contador++;
                    total += Articulos[i].Valor;
                }
            }

            PD.WriteLine("");
            PD.WriteLine("Total de Artículos: " + contador);
            PD.WriteLine("Total  $" + total);

            PD.Close();
            PD.Dispose();

            MessageBox.Show("Rubro Exportado Correctamente", rubro, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

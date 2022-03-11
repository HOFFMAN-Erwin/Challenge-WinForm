using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge_WinForm
{
    public partial class Form1 : Form
    {
        MostrarArreglo mostrarArreglo = new MostrarArreglo();

        public Form1()
        {
            InitializeComponent();
            mostrarArreglo.f1 = this;
            InicializarDGV();
        }

        private void InicializarDGV()
        {
            data_GV.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            data_GV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            data_GV.ColumnHeadersDefaultCellStyle.Font = new Font(data_GV.Font, FontStyle.Bold);
            data_GV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data_GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_GV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            data_GV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            data_GV.GridColor = Color.Black;
            data_GV.RowHeadersVisible = false;
            data_GV.AllowUserToOrderColumns = false;
            data_GV.AllowUserToAddRows = false;
            data_GV.AllowUserToDeleteRows = false;
            data_GV.ReadOnly = true;
            data_GV.AllowUserToResizeRows = false;
            data_GV.SelectionMode = DataGridViewSelectionMode.CellSelect;
            data_GV.MultiSelect = false;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            mostrarArreglo.CantidadDatos();
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            mostrarArreglo.PromedioEdadSociosRacin();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            mostrarArreglo.ListadoPersonasCasadasYUniversitarios();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            mostrarArreglo.ListaHinchaRiver();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mostrarArreglo.ListadoCantidadSocios();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            data_GV.Rows.Clear();
            data_GV.Refresh();
            data_GV.Columns.Clear();
            tablaTitulo.Text = "";
        }

        private void data_GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void FormatearGDV (int gridType, string titulo)
        {
            data_GV.Rows.Clear();
            data_GV.Refresh();
            data_GV.Columns.Clear();
            tablaTitulo.Text = titulo;


            switch (gridType)
            {
                case 1:
                    data_GV.ColumnCount = 1;
                    data_GV.Columns[0].Name = "Personas registradas";
                    break;
                case 2:
                    data_GV.ColumnCount = 1;
                    data_GV.Columns[0].Name = "Edad promedio";
                    break;
                case 3:
                    data_GV.ColumnCount = 3;
                    data_GV.Columns[0].Name = "Edad";
                    data_GV.Columns[1].Name = "Nombre";
                    data_GV.Columns[2].Name = "Equipo";


                    break;
                case 4:
                    data_GV.ColumnCount = 2;
                    data_GV.Columns[0].Name = "Nombre";
                    data_GV.Columns[1].Name = "Cantidad de hinchas";
                    break;
                case 5:
                    data_GV.ColumnCount = 5;
                    data_GV.Columns[0].Name = "Equipo";
                    data_GV.Columns[1].Name = "Numero de Socios";
                    data_GV.Columns[2].Name = "Promedio de edades";
                    data_GV.Columns[3].Name = "Menor edad registrada";
                    data_GV.Columns[4].Name = "Mayor edad registrada";

                    break;
                default:
                    data_GV.ColumnCount = 0;
                    break;
            }
        }

        public void PopularGDV(string[] row0)
        {
            data_GV.Rows.Add(row0);
        }


            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_MouseEnter(object sender, EventArgs e)
        {
            textoDinamico.Text = "Visualizar la cantidad total de personas registradas.";
        }

        private void btn_1_Enter(object sender, EventArgs e)
        {
            textoDinamico.Text = "Visualizar la cantidad total de personas registradas.";
        }

        private void btn_2_MouseEnter(object sender, EventArgs e)
        {
            textoDinamico.Text = "Visualizar promedio de edad de los socios de Racing.";
        }

        private void btn_2_Enter(object sender, EventArgs e)
        {
            textoDinamico.Text = "Visualizar promedio de edad de los socios de Racing.";
        }


        private void btn_3_Enter(object sender, EventArgs e)
        {
            textoDinamico.Text = "Visualizar las primeras 100 personas casadas y con estudios universitarios en orden.";

        }

        private void btn_3_MouseEnter(object sender, EventArgs e)
        {
            textoDinamico.Text = "Visualizar las primeras 100 personas casadas y con estudios universitarios en orden.";
        }

        private void btn_4_Enter(object sender, EventArgs e)
        {
            textoDinamico.Text = "Visualizar los 5 nombres mas comunes entre los hinchas de River.";
        }

        private void btn_4_MouseEnter(object sender, EventArgs e)
        {
            textoDinamico.Text = "Visualizar los 5 nombres mas comunes entre los hinchas de River.";
        }
        private void btn_5_Enter(object sender, EventArgs e)
        {
            textoDinamico.Text = "Visualizar un listado ordenado segun clubes con las edades de sus socios.";
        }

        private void btn_5_MouseEnter(object sender, EventArgs e)
        {
            textoDinamico.Text = "Visualizar un listado ordenado segun clubes con las edades de sus socios.";
        }

        private void btn_clear_Enter(object sender, EventArgs e)
        {
            textoDinamico.Text = "Limpiar la tabla de vizualisaciones.";
        }

        private void btn_clear_MouseEnter(object sender, EventArgs e)
        {
            textoDinamico.Text = "Limpiar la tabla de vizualisaciones.";
        }


    }
}

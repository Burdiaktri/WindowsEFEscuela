using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFEscuela.Dac;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela
{
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { Nombre = txtNombre.Text,
                                           Apellido= txtApellido.Text,
                                           FechaNacimiento = Convert.ToDateTime(txtFecha.Text),
                                           ProfesorId = Convert.ToInt32(txtProfesor.Text)};

            int filasAfectadas = AbmAlumno.Insert(alumno);
            if(filasAfectadas > 0)
            {
                MessageBox.Show("Insert ok");
                MostarAlumnos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Alumno alumno = new Alumno()
            {
                IdAlumno = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = Convert.ToDateTime(txtFecha.Text),
                ProfesorId = Convert.ToInt32(txtProfesor.Text)
            };

            int filasAfectadas = AbmAlumno.Update(alumno);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Update ok");
                MostarAlumnos();
            }
        }

        private void MostarAlumnos()
        {
            gridAlumnos.DataSource = AbmAlumno.SelectAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno()
            {
                IdAlumno = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = Convert.ToDateTime(txtFecha.Text),
                ProfesorId = Convert.ToInt32(txtProfesor.Text)
            };

            int filasAfectadas = AbmAlumno.Eliminar(alumno);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Eliminacion ok");
                MostarAlumnos();
            }
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            MostarAlumnos();
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            Alumno alumno = AbmAlumno.SelectById(id);
            MessageBox.Show(alumno.Nombre);
        }
    }
}

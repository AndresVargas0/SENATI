﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Proyecto_Final.Interfazes
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
        //Boton Matricular
        private void matricular_Click(object sender, EventArgs e)
        {
            //Variables a Usar
            string Nombre = TextBox1.Text;
            string Apellido = TextBox2.Text;
            string Apoderado = TextBox3.Text;
            string Dni = TextBox4.Text;
            string Telefono = TextBox5.Text;
            string Grado = ComboBox2.Text;
            string Seccion = ComboBox1.Text;
            //Funcion para Asegurar que lo Campos esten rellenados
            if (string.IsNullOrEmpty(Nombre) ||
                string.IsNullOrEmpty(Apellido) ||
                string.IsNullOrEmpty(Dni) ||
                string.IsNullOrEmpty(Apoderado) ||
                string.IsNullOrEmpty(Telefono) ||
                string.IsNullOrEmpty(Grado) ||
                string.IsNullOrEmpty(Seccion))
            {
                MessageBox.Show("Algunos Campos no Fueron Rellenados");
                return;
            }
            else
            {
            //Conexion a BD
            ConexionDB.ConexionDB conexion = new ConexionDB.ConexionDB();
            SqlConnection conn = conexion.ObtenerConexion();
                try
                {
                    //Consulta para Insertar los Datos de las Variables a la tabla en la BD
                    string query = "INSERT INTO Estudiantes_Matriculados (Nombre,Apellido,Apoderado,Dni,Telefono,Grado,Seccion) VALUES (@Nombre,@Apellido,@Apoderado,@Dni,@Telefono,@Grado,@Seccion)";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        //Parametros a usar en la Consulta
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Apellido", Apellido);
                        command.Parameters.AddWithValue("@Apoderado", Apoderado);
                        command.Parameters.AddWithValue("@Dni", Dni);
                        command.Parameters.AddWithValue("@Telefono", Telefono);
                        command.Parameters.AddWithValue("@Grado", Grado);
                        command.Parameters.AddWithValue("@Seccion", Seccion);
                        //Verificar Cambios en la Tabla
                        int rowsAffected = command.ExecuteNonQuery();
                        //Mensajes de Confirmacion o Error
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Estudiante Registrado Correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se Pudo Registrar al Alumno");

                        }
                    }
                }
                //Error Adicional
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //Boton para Actualizar la Tabla
        private void actualizar_Click(object sender, EventArgs e)
        {
            //Conexion a BD
            ConexionDB.ConexionDB conexion = new ConexionDB.ConexionDB();
            SqlConnection conn = conexion.ObtenerConexion();
            //Limpia los Datos de la Tabla
            tabla.DataSource = null;
            //Realiza la Consulta para llamar a la Tabla Actualizada
            string selectQuery = "SELECT * FROM Estudiantes_Matriculados";
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn))
                {
                    DataTable dataTable = new DataTable();
                    //Adapta el Contenido Actualizado de la tabla en la BD a la tabla del Admin 
                    adapter.Fill(dataTable);
                    tabla.DataSource = dataTable;
                }
            }
        }
        //Boton Eliminar
        private void eliminar_Click(object sender, EventArgs e)
        {
            //Variable de Referencia
            string Dni = TextBox4.Text;

            //Conexion a BD
            ConexionDB.ConexionDB conexion = new ConexionDB.ConexionDB();
            SqlConnection conn = conexion.ObtenerConexion();

            try
            {
                //Consulta para Eliminar
                string delete = "DELETE FROM Estudiantes_Matriculados WHERE Dni = @Dni;";
                SqlCommand command = new SqlCommand(delete, conn);

                //Parametros Utilizados
                command.Parameters.AddWithValue("@Dni", Dni);
                //Verificar Cambios en la Tabla
                int rowsAffected = command.ExecuteNonQuery();
                //Mensajes de Confirmacion o Error
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Estudiante Eliminado");
                }
                else
                {
                    MessageBox.Show("Error, ese estudiante no Existe en la BD");
                }
            }
            //Error Adicional
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex.Message);
            }
        }
        //Boton Salir
        private void salir_Click(object sender, EventArgs e)
        {
            //Cerrar Ventana y Regregsar al Login
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void estudiantesMatriculadosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void informe_Click(object sender, EventArgs e)
        {
            //Conexion a BD
            ConexionDB.ConexionDB conexion = new ConexionDB.ConexionDB();
            SqlConnection conn = conexion.ObtenerConexion();
            //Consulta para Seleccionar todos los Registros de la Tabla de la BD
            string query = "SELECT * FROM Estudiantes_Matriculados";
            SqlCommand cmd = new SqlCommand(query, conn);
            //El SqlDataReader lee el Contenido de los Registros de la Tabla
            SqlDataReader reader = cmd.ExecuteReader();
            //Pasamos el Argumento creado con SqlDataReader
            GenerarInforme(reader);
            //Cerramos la Conexion a la BD
            reader.Close();
        }

        static void GenerarInforme(SqlDataReader reader)
        {
            //Inicia un Bucle que Recorre cada Fila de Resultados Existentes en la Tabla
            while (reader.Read())
            {
                //Cada String obtiene el valor de cada Columna Asignada
                string Nombre = reader.GetString(0);
                string Apellido = reader.GetString(1);
                string Apoderado = reader.GetString(2);
                string Dni = reader.GetString(3);
                string Telefono = reader.GetString(4);
                string Grado = reader.GetString(5);
                string Seccion = reader.GetString(6);
                //Imprime los Valores Obtenidos por Consola
                Console.WriteLine($"\nNOMBRE: {Nombre}\n"+
                    $"APELLIDO: {Apellido}\n"+
                    $"APODERADO: {Apoderado}\n"+
                    $"DNI: {Dni}\n" +
                    $"TELEFONO: {Telefono}\n" +
                    $"GRADO: {Grado}\n" +
                    $"SECCION: {Seccion}\n");
            }
        }
    }
}
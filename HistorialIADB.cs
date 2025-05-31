using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal_02
{
    public class HistorialIADB
    {
        public static bool Guardar(string prompt, string respuesta)
        {
            string connectionString = "Server=DESKTOP-AN2IAAL\\SQLEXPRESS02;Database=saludBotJutiapaDB;Trusted_Connection=True;"; // O usa la tuya ya configurada
            string query = "INSERT INTO HistorialIA (Prompt, Respuesta, FechaHora) VALUES (@Prompt, @Respuesta, @FechaHora)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Prompt", prompt);
                        cmd.Parameters.AddWithValue("@Respuesta", respuesta);
                        cmd.Parameters.AddWithValue("@FechaHora", DateTime.Now);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            
                            MessageBox.Show("✅ Datos guardados correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("❌ Error al guardar en base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }
    }
}


using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;


using System.IO;

namespace ProyectoFinal_02
{
    public partial class Form1 : Form
    {
        
        string apiKey = "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";

        private async Task<string> ConsultarIA_Groq(string pregunta)
        {
            var client = new RestClient("https://api.groq.com/openai/v1/chat/completions");

            var request = new RestRequest();
            request.AddHeader("Authorization", $"Bearer {apiKey}");
            request.AddHeader("Content-Type", "application/json");

            var body = new
            {
                model = "llama3-70b-8192",
                messages = new[]
                {
                new { role = "system", content = "Eres un asistente médico que da explicaciones claras y útiles sobre temas de salud." },
                new { role = "user", content = pregunta }
            },
                temperature = 0.7
            };

            request.AddJsonBody(body);

            var response = await client.PostAsync(request);

            if (response.IsSuccessful)
            {
                var doc = System.Text.Json.JsonDocument.Parse(response.Content);
                string respuesta = doc.RootElement
                    .GetProperty("choices")[0]
                    .GetProperty("message")
                    .GetProperty("content")
                    .GetString();
                return respuesta;
            }
            else
            {
                return "Error al consultar la IA.";
            }
        }


        public Form1()
        {

            InitializeComponent();

        }
        private System.Windows.Forms.Button btnConsejos;
        private System.Windows.Forms.ListBox ________________________Listado_Consejos________________________;
        
        private TextBox txtEdad;
        private ComboBox cmbGenero;
        private Button btnConsejosPersonalizados;
        private RichTextBox rtbConsejos;



    private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSintomas.Clear();     
            txtRespuesta.Clear();     
            txtPreguntaSalud.Clear();
            txtEdad.Clear(); 
            cmbGenero.SelectedIndex = -1; 
            rtbConsejos.Clear(); 
            ________________________Listado_Consejos________________________.Items.Clear(); 
            Centros_De_Salud_Cercanos.Items.Clear();
            richTextBoxRespuestaSalud.Clear();
            cmbMunicipios.SelectedIndex = 0;

        }

        private void cmbMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Centros_De_Salud_Cercanos.Items.Clear();

           
            switch (cmbMunicipios.SelectedItem.ToString())
            {
                case "":
                    break;
                case "Jutiapa":
                    Centros_De_Salud_Cercanos.Items.Add("Centro de Salud Jutiapa");
                    Centros_De_Salud_Cercanos.Items.Add("Hospital Nacional de Jutiapa");
                    break;
                case "El Progreso":
                    Centros_De_Salud_Cercanos.Items.Add("Puesto de Salud El Progreso");
                    break;
                case "Santa Catarina Mita":
                    Centros_De_Salud_Cercanos.Items.Add("Centro de Salud Santa Catarina Mita");
                    break;
                case "Moyuta":
                    Centros_De_Salud_Cercanos.Items.Add("Clínica Moyuta");
                    break;
                case "Zapotitlán":
                    Centros_De_Salud_Cercanos.Items.Add("Centro de Salud Zapotitlán");
                    break;
                case "Yupiltepeque":
                    Centros_De_Salud_Cercanos.Items.Add("Puesto de Salud Yupiltepeque");
                    break;
                case "Quesada":
                    Centros_De_Salud_Cercanos.Items.Add("Centro de Salud Quesada");
                    break;
            }
        }

        

        private async Task<string> ObtenerConsejosPersonalizadosDesdeGroq(string pregunta)
        {
            string apiKey = "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"; // Cambia aquí por tu clave real
            string endpoint = "https://api.groq.com/openai/v1/chat/completions";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                var requestBody = new
                {
                    model = "llama3-70b-8192",
                    messages = new[]
                    {
                new { role = "user", content = pregunta }
            },
                    temperature = 0.7
                };

                var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(requestBody), System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(endpoint, content);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var doc = System.Text.Json.JsonDocument.Parse(json);
                    string reply = doc.RootElement
                                      .GetProperty("choices")[0]
                                      .GetProperty("message")
                                      .GetProperty("content")
                                      .GetString();
                    return reply;
                }
                else
                {
                    return $"Error al consultar la API: {response.StatusCode}";
                }
            }
        }

        private async void btnConsejosPersonalizados_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEdad.Text, out int edad) && cmbGenero.SelectedItem != null)
            {
                string genero = cmbGenero.SelectedItem.ToString().ToLower();
                string pronombre = (genero == "masculino") ? "hombre" : "mujer";
                string pregunta = $"Soy {pronombre} de {edad} años, ¿qué chequeos médicos debería hacerme?";

                rtbConsejos.Text = "Consultando...";

                string respuesta = await ObtenerConsejosPersonalizadosDesdeGroq(pregunta);
                rtbConsejos.Text = respuesta;
            }
            else
            {
                MessageBox.Show("Por favor ingresa una edad válida y selecciona el género.");
            }
        }
        private void btnConsejos_Click(object sender, EventArgs e)
        {
            ________________________Listado_Consejos________________________.Items.Clear();
            var consejos = ConsejosPrimerosAuxilios.ObtenerConsejos();
            foreach (var consejo in consejos)
            {
                ________________________Listado_Consejos________________________.Items.Add(consejo);
            }
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string apiKey = "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"; 
            string endpoint = "https://api.groq.com/openai/v1/chat/completions";

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

            var data = new
            {
                model = "llama3-70b-8192", 
                messages = new[]
                {
                    new { role = "system", content = "Eres un asistente virtual médico comunitario en Jutiapa. Ayuda a los usuarios con síntomas comunes y da consejos básicos o indica si deben ir al centro de salud." },
                    new { role = "user", content = txtSintomas.Text }
                }
            };

            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(endpoint, content);
                string respuestaTexto = await response.Content.ReadAsStringAsync();

             
               
                var resultado = JsonConvert.DeserializeObject<JObject>(respuestaTexto);

                

                if (resultado["choices"] != null && resultado["choices"].HasValues)
                {
                    string respuestaIA = resultado["choices"][0]["message"]["content"].ToString();
                    txtRespuesta.Text = respuestaIA;
                    string prompt = txtSintomas.Text; 
                 

                  

                    
                    HistorialIADB.Guardar(prompt, respuestaIA);
                }
                else if (resultado["error"] != null)
                {
                    MessageBox.Show("Error: " + resultado["error"]["message"]);
                }
                else
                {
                    MessageBox.Show("La respuesta de la IA no contiene información válida.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión o de formato: " + ex.Message);
            }

        }

        
        private async void btnConsultarIA_Click_1(object sender, EventArgs e)
        {
            string pregunta = txtPreguntaSalud.Text.Trim();

            if (string.IsNullOrEmpty(pregunta))
            {
                MessageBox.Show("Por favor escribe una pregunta sobre salud.");
                return;
            }

            btnConsultarIA.Enabled = false;
            btnConsultarIA.Text = "Consultando...";

            string respuesta = await ConsultarIA_Groq(pregunta);

            richTextBoxRespuestaSalud.Text = respuesta;

            btnConsultarIA.Enabled = true;
            btnConsultarIA.Text = "Quiero aprender sobre salud";
        }



        private void lstConsejos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void btnExportarPDF_Click_1(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(richTextBoxRespuestaSalud.Text))
            {
                MessageBox.Show("No hay contenido para exportar.");
                return;
            }

           
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Guardar contenido educativo en PDF",
                FileName = "EducacionSalud_Jutiapa.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25, 25, 30, 30);
                        var writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        
                        var bf = iTextSharp.text.pdf.BaseFont.CreateFont(iTextSharp.text.pdf.BaseFont.HELVETICA,
                                                                         iTextSharp.text.pdf.BaseFont.CP1252,
                                                                         iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

                        var fontTitulo = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLD);
                        var fontCuerpo = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

                        
                        doc.Add(new iTextSharp.text.Paragraph("📘 Educación Médica Personalizada\n\n", fontTitulo));
                        doc.Add(new iTextSharp.text.Paragraph(richTextBoxRespuestaSalud.Text, fontCuerpo));

                        doc.Close();
                        writer.Close();
                    }

                    MessageBox.Show("PDF generado y guardado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al guardar el PDF: " + ex.Message);
                }
            }
        }

    }
}

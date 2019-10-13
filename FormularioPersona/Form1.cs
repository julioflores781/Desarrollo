#region Librerias o paquetes

using FormularioPersona.Modelo.Prueba;
using Modelo.Prueba;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

#endregion

namespace FormularioPersona
{
    public partial class Form1 : Form
    {
        #region Basura
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtDoc_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Botones o eventos

        /// <summary>
        /// Llama a la Funcion EliminaPersona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTElimina_Click(object sender, EventArgs e)
        {
            EliminaPersona();
            limpiarCampos();
        }

        /// <summary>
        /// Llama a la Funcion ConsultaPersona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTBusca_Click(object sender, EventArgs e)
        {
            ConsultaPersona();
        }


        /// <summary>
        /// Llama a la Funcion ActualizaPersona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTActualiza_Click(object sender, EventArgs e)
        {
            ActualizaPersona();
            limpiarCampos();
        }

        /// <summary>
        /// Llama a la Funcion CreaPersona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTCrea_Click(object sender, EventArgs e)
        {
            CreaPersona();
            limpiarCampos();
        }
        /// <summary>
        /// Limpia los campos TXT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        /// <summary>
        /// Limpia los datos que se muestran en el listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            LimpiaLista();
        } 
        #endregion

        
        #region Metodos

        public string Send<T>(string url, T objectRequest, string method = "POST")
        {

            string result = "";
            try
            {


                JavaScriptSerializer js = new JavaScriptSerializer();

                //serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                //peticion
                WebRequest request = WebRequest.Create(url);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 100000; //esto es opcional

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

            }
            catch (Exception e)
            {

                result = e.Message;

            }

            return result;
        }

        /// <summary>
        /// Genera la conversion a Json de los datos que se van a enviar 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url">Hace la llamada a la api correspondiente por la url que se le pase</param>
        /// <param name="method">Metodo GET</param>
        /// <returns></returns>
        public string Consulta<T>(string url, string method = "GET")
        {

            string result = "";
            try
            {

                JavaScriptSerializer js = new JavaScriptSerializer();

                //peticion
                WebRequest request = WebRequest.Create(url);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 100000; //esto es opcional



                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

            }
            catch (Exception e)
            {

                result = e.Message;

            }

            return result;
        }

        #endregion

        

        #region Funciones

        /// <summary>
        /// Crea registros con datos basicos 
        /// </summary>
        public void CreaPersona()
        
        {
            if (TxtId.Text == "" && TxtNombre.Text == "" && TxtApellido.Text == "" && TxtDoc.Text == "")
            {
                MessageBox.Show("Debe introducir datos");
            }
            else
            {
                string url = "http://localhost:14427/api/CreaPersona";

                ClassCrea oPersona = new ClassCrea();
                oPersona.documento = TxtDoc.Text;
                oPersona.nombre = TxtNombre.Text;
                oPersona.apellido1 = TxtApellido.Text;


                string Resultado = Send<ClassCrea>(url, oPersona, "POST");
                MessageBox.Show("Se inserto un nuevo registro:");
            }
            
        }

        /// <summary>
        /// Elimina registros de la tabla persona por el codigo_personal
        /// </summary>
        public void EliminaPersona()
        {
            if (TxtId.Text == "" && TxtNombre.Text == "" && TxtApellido.Text == "" && TxtDoc.Text == "")
            {
                MessageBox.Show("Debe introducir datos");
            }
            else
            {
                string url = "http://localhost:14427/api/EliminaPersona";

                ListaPersona oPersona = new ListaPersona();
                oPersona.codigo_personal = int.Parse(TxtId.Text);
                oPersona.documento = TxtDoc.Text;
                oPersona.nombre = TxtNombre.Text;
                oPersona.apellido1 = TxtApellido.Text;


                string Resultado = Consulta<ListaPersona>(string.Format("{0}?id={1}", url, oPersona.codigo_personal), "GET");
                MessageBox.Show("Se Elimino el Registro Correctamente");
            }
        }

        /// <summary>
        /// Genera diferentes consultas a la tabla persona
        /// </summary>
        public void ConsultaPersona()
        {
            
            string url = "http://localhost:14427/api/ObtenerPersona";
            
            ListaPersona oPersona = new ListaPersona();
            
            if (TxtId.Text == ""&&TxtNombre.Text==""&&TxtApellido.Text==""&&TxtDoc.Text=="" )
            {
                JavaScriptSerializer jesonserializar = new JavaScriptSerializer();
                
                //MessageBox.Show("No colocaste datos");
               string Resultado = Consulta<ClassActualiza>(string.Format(url), "GET");

                List<ListaPersona> listRegistro = jesonserializar.Deserialize<List<ListaPersona>>(Resultado);
                Encabezado FldEncabezado = new Encabezado();
                FldEncabezado.Items = listRegistro;

                listViewPersona.CheckBoxes = true;
                ListViewItem lista = new ListViewItem();

                LimpiaLista();
               
                foreach (ListaPersona Lista in listRegistro)
                {
                    lista = listViewPersona.Items.Add(Lista.codigo_personal.ToString());
                    lista.SubItems.Add(Lista.documento);
                    lista.SubItems.Add(Lista.nombre);
                    lista.SubItems.Add(Lista.apellido1);
                    lista.SubItems.Add(Lista.fecha_creacion.ToShortDateString());
                }


            }
            else if (TxtId.Text != "" && TxtNombre.Text == "" && TxtApellido.Text == "" && TxtDoc.Text == "")
            {
                oPersona.codigo_personal = int.Parse(TxtId.Text);
                string Resultado = Consulta<ListaPersona>(string.Format("{0}?id={1}", url, oPersona.codigo_personal), "GET");


                oPersona = JsonConvert.DeserializeObject<ListaPersona>(Resultado);
               
                
            }
            else if (TxtId.Text == "" && TxtNombre.Text != "" && TxtApellido.Text == "" && TxtDoc.Text == "")
            {
                oPersona.nombre = TxtNombre.Text;
                string Resultado = Consulta<ListaPersona>(string.Format("{0}?nombre={1}", url, oPersona.nombre), "GET");


                oPersona = JsonConvert.DeserializeObject<ListaPersona>(Resultado);
            }
            else if (TxtId.Text == "" && TxtNombre.Text == "" && TxtApellido.Text != "" && TxtDoc.Text == "")
            {
                string urlApellido = "http://localhost:14427/api/obtenerPersonaApellido";
                oPersona.apellido1 = TxtApellido.Text;
                string Resultado = Consulta<ListaPersona>(string.Format("{0}?Apellido1={1}", urlApellido, oPersona.apellido1), "GET");


                oPersona = JsonConvert.DeserializeObject<ListaPersona>(Resultado);
            }
            else if (TxtId.Text == "" && TxtNombre.Text == "" && TxtApellido.Text == "" && TxtDoc.Text != "")
            {
                string urlDocumento = "http://localhost:14427/api/obtenerPersonaDocumento"; 
                oPersona.documento = TxtDoc.Text;
                string Resultado = Consulta<ListaPersona>(string.Format("{0}?Documento={1}", urlDocumento, oPersona.documento), "GET");


                oPersona = JsonConvert.DeserializeObject<ListaPersona>(Resultado);
            }
            else
            {
                MessageBox.Show("Se encuentra desactibada la busqueda por dos campos");
                limpiarCampos();
            }
            
            if (oPersona != null)
            {

                TxtNombre.Text = oPersona.nombre;
                TxtApellido.Text = oPersona.apellido1;
                TxtDoc.Text = oPersona.documento;

                listViewPersona.CheckBoxes = true;
                ListViewItem lista = new ListViewItem();
                
                
                    lista = listViewPersona.Items.Add(oPersona.codigo_personal.ToString());
                    lista.SubItems.Add(oPersona.documento);
                    lista.SubItems.Add(oPersona.nombre);
                    lista.SubItems.Add(oPersona.apellido1);
                lista.SubItems.Add(oPersona.fecha_creacion.ToString());
                
               


            }
            else
            {
                MessageBox.Show("No se encontraron registros");
                limpiarCampos();
            }


        }

        /// <summary>
        /// Modifica los datos de las personas existentes por el codigo_personal
        /// </summary>
        public void ActualizaPersona()
        {
            if (TxtId.Text == "" && TxtNombre.Text == "" && TxtApellido.Text == "" && TxtDoc.Text == "")
            {
                MessageBox.Show("Debe introducir datos");
            }
            else
            {
                string url = "http://localhost:14427/api/ModificaPersona";

                ClassActualiza oPersona = new ClassActualiza();
                oPersona.codigo_personal = int.Parse(TxtId.Text);
                oPersona.documento = TxtDoc.Text;
                oPersona.nombre = TxtNombre.Text;
                oPersona.apellido1 = TxtApellido.Text;

                string Resultado = Send<ClassActualiza>(url, oPersona, "POST");
                MessageBox.Show("Se actualizo el registro con exito:");
            }
        }

        /// <summary>
        /// Limpiar campos del formulario
        /// </summary>
        public void limpiarCampos()
        {
            TxtId.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtApellido.Text = string.Empty;
            TxtDoc.Text = string.Empty;
                                   
        }

        /// <summary>
        /// Limpia el listView
        /// </summary>
        public void LimpiaLista()
        {
            listViewPersona.Items.Clear();
        }

        #endregion


    }           
}


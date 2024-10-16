using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Ejercicio1.Models;

namespace Ejercicio1
{

    public partial class FormPrincipal : Form
    {

        FiscalizadorVTV ente = new FiscalizadorVTV();
            
        public FormPrincipal()
        {
            InitializeComponent();
            
            Preinicializacion();
        }

        public void Preinicializacion()
        {
            //inicializacion con algunos valores para depuración

            VTV vtv;

            #region caso 1
            vtv = ente.AgregarVTV("ABC123", new Propietario(45675654, "Marianela"), new DateTime(2020, 12, 5));
            ((EvaluacionParametrica)vtv[0]).ValorMedido = 56;
            ((EvaluacionParametrica)vtv[1]).ValorMedido = 10;
            ((EvaluacionParametrica)vtv[2]).ValorMedido = 0.6;
            ((EvaluacionParametrica)vtv[3]).ValorMedido = 11000;
            ((EvaluacionParametrica)vtv[4]).ValorMedido = 12000;
            ((EvaluacionSimple)vtv[5]).HaVerificado = true;
            #endregion

            #region caso 2
            ente.AgregarVTV("ABC456", new Propietario(43675651, "Leandro"), new DateTime(2023, 3, 5));
            ((EvaluacionParametrica)vtv[0]).ValorMedido = 25;
            ((EvaluacionParametrica)vtv[1]).ValorMedido = 30;
            ((EvaluacionParametrica)vtv[2]).ValorMedido = 1;
            ((EvaluacionParametrica)vtv[3]).ValorMedido = 11000;
            ((EvaluacionParametrica)vtv[4]).ValorMedido = 12000;
            ((EvaluacionSimple)vtv[5]).HaVerificado = false;
            #endregion

            #region caso 3
            ente.AgregarVTV("ABC789", new Propietario(40675603, "Luisa"), new DateTime(2024, 5, 10));
            ((EvaluacionParametrica)vtv[0]).ValorMedido = 25;
            ((EvaluacionParametrica)vtv[1]).ValorMedido = 25;
            ((EvaluacionParametrica)vtv[2]).ValorMedido = 0.4;
            ((EvaluacionParametrica)vtv[3]).ValorMedido = 11000;
            ((EvaluacionParametrica)vtv[4]).ValorMedido = 33000;
            ((EvaluacionSimple)vtv[5]).HaVerificado = true;
            #endregion
        }
            

        private void btnIniciarCargarVTV_Click(object sender, EventArgs e)
        {
            try
            {
                #region captura de datos del formulario principal
                int dni = Convert.ToInt32(tbDNI.Text);
                string nombre = tbApellidoNombres.Text;
                string patente = tbPatente.Text;
                DateTime fechaHoy = dtpFechaHoy.Value;
                #endregion

                Propietario propietario = new Propietario(dni, nombre);
                VTV vtv = ente.AgregarVTV(patente, propietario, fechaHoy);

                #region cargando cada verificacion
                for (int idx = 0; idx < vtv.CantidadVerificaciones; idx++)
                {
                    FormEvaluacion fEva = new FormEvaluacion();
                    fEva.tbNombre.Text = vtv[idx].Nombre;
                    fEva.tbDescripcion.Text = vtv[idx].Descripcion;

                    if (vtv[idx] is EvaluacionParametrica)
                    {
                        EvaluacionParametrica ev = (EvaluacionParametrica)vtv[idx];
                        fEva.tbMaximo.Text = ev.ValorMaximo.ToString();
                        fEva.tbMinimo.Text = ev.ValorMinimo.ToString();
                        fEva.lbUnidad.Text = ev.Unidad;
                        fEva.gbParametrico.Enabled = true;
                        fEva.gbSimple.Enabled = false;
                        //completar
                    }
                    else if (vtv[idx] is EvaluacionSimple)
                    {
                        //completar
                        fEva.tbMaximo.Text = "-";
                        fEva.tbMinimo.Text = "-";
                        fEva.lbUnidad.Text = "-";
                        fEva.gbParametrico.Enabled = false;
                        fEva.gbSimple.Enabled = true;
                    }

                    fEva.ShowDialog();

                    if (vtv[idx] is EvaluacionParametrica)
                    {
                        EvaluacionParametrica ev = (EvaluacionParametrica)vtv[idx];
                        ev.ValorMedido = Convert.ToDouble(fEva.tbValorMedido.Text);
                    }
                    else if (vtv[idx] is EvaluacionSimple)
                    {
                        EvaluacionSimple ev = (EvaluacionSimple)vtv[idx];
                        ev.HaVerificado = fEva.chkVerfificado.Checked;
                    }
                }
                #endregion

                #region mostrar certificado
                FormVer fVer = new FormVer();
                foreach (string linea in vtv.EmitirComprobante())
                {
                    fVer.tbVer.Text += linea + Environment.NewLine;
                }
                fVer.ShowDialog();
                #endregion

                #region limpiando controles
                tbDNI.Clear();
                tbApellidoNombres.Clear();
                tbPatente.Clear();
                #endregion
            }
            catch (DNINoValidoException ex)
            {
                MessageBox.Show(ex.Message,"Error en el DNI",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EmailNoValidoException ex)
            {
                MessageBox.Show(ex.Message, "Error en el Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (PatenteNoValidoException ex)
            {
                MessageBox.Show(ex.Message, "Error en la patente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine +ex.StackTrace);
            }
        }
        
        private void btnVer_Click(object sender, EventArgs e)
        {
            FormVer ver = new FormVer();

            ente.OrdenarVTVsPorDNIPropietario();

            for (int n = 0; n < ente.CantidadVTVs; n++)
            {
                ver.tbVer.Text += ente[n].ToString() + Environment.NewLine;
            }

            ver.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormVer ver = new FormVer();

            ente.OrdenarVTVsPorDNIPropietario();
            
            string patente=tbPatente.Text.Trim().ToUpper();

            foreach (VTV vtv in ente.VerVTVPorPatente(patente))
            {
                ver.tbVer.Text += vtv.ToString() + Environment.NewLine;
            }

            ver.ShowDialog();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Fichero csv|(*.csv)";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { 
                string path=openFileDialog1.FileName;

                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    List<string> lineas= new List<string>();
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);

                    sr = new StreamReader(fs);
                    string linea = sr.ReadLine();//descarto las cabeceras
                    linea = sr.ReadLine();//descarto las cabeceras
                    while (sr.EndOfStream == false)
                    {
                        lineas.Add(sr.ReadLine());
                    }
                    ente.ImportarVTVs(lineas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al exportar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                {
                    if (sr!=null) sr.Close();
                    if(fs!=null) fs.Close();
                }
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

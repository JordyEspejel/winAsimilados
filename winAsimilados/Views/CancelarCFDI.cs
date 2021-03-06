﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C = winAsimilados.Controller;
using E = winAsimilados.Entities;
using V = winAsimilados.Views;
using System.Windows.Controls;
using System.IO;
using DevExpress.XtraEditors;
using System.Net;

namespace winAsimilados.Views
{
    public partial class CancelarCFDI : Form
    {
        E.BitacoraXML bitacora = new E.BitacoraXML();
        string fechaIni;
        string fechaFinal;
        string uuid;
        string folio, fecPago, fecIni, fecFin, empresa, rfcEmpl,selloCFD;
        string usuario = Properties.Settings.Default.Usuario.ToString().ToUpper();
        string ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(ip => ip.AddressFamily.ToString().ToUpper().Equals("INTERNETWORK")).FirstOrDefault().ToString();
        string RFCEmpr, Empr;
        decimal total;
        string pacTimbrado, ambiente;
        C.Controller Controlador = new C.Controller();
        public CancelarCFDI(string RFC, string Empresa)
        {
            RFCEmpr = RFC;
            Empr = Empresa;
            InitializeComponent();
        }

        private void CancelarCFDI_Load(object sender, EventArgs e)
        {
            pacTimbrado = Properties.Settings.Default.PAC.ToString();
            ambiente = Properties.Settings.Default.Ambiente.ToString();
            RefrescaTabla();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            fechaIni = FecIni.Value.ToString("dd/MM/yyyy");
            fechaFinal = FecFinal.Value.ToString("dd/MM/yyyy");
            Controlador.Buscar12(gridControl1, fechaIni, fechaFinal);
            gridControl1.Visible = true;
        }
        private  void RefrescaTabla()
        {
            fechaIni = FecIni.Value.ToString("dd/MM/yyyy");
            fechaFinal = FecFinal.Value.ToString("dd/MM/yyyy");
            Controlador.Buscar12(gridControl1, fechaIni, fechaFinal);
            gridControl1.Visible = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string status = "";
                if (pacTimbrado.Equals("NT") && ambiente.Equals("Pruebas"))
                {
                    XtraMessageBox.Show("Cancelacíón NT-LINK en ambiente de pruebas no sportado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var UUIDSAT = new List<E.CancelarUUID>();
                E.CancelarUUID[] uid = null;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.IsRowSelected(i))
                    {
                        folio = gridView1.GetRowCellValue(i, gridView1.Columns[0]).ToString();
                        uuid = gridView1.GetRowCellValue(i, gridView1.Columns[1]).ToString();
                        fecPago = gridView1.GetRowCellValue(i, gridView1.Columns[7]).ToString();
                        fecIni = gridView1.GetRowCellValue(i, gridView1.Columns[8]).ToString();
                        fecFin = gridView1.GetRowCellValue(i, gridView1.Columns[9]).ToString();
                        rfcEmpl = gridView1.GetRowCellValue(i, gridView1.Columns[4]).ToString();
                        selloCFD = gridView1.GetRowCellValue(i, gridView1.Columns[10]).ToString();
                        total = Convert.ToDecimal(gridView1.GetRowCellValue(i, gridView1.Columns[11]).ToString());
                        status = gridView1.GetRowCellValue(i, gridView1.Columns[6]).ToString();
                        if (status.Equals("Cancelado"))
                        {
                            XtraMessageBox.Show("El folio: " + folio + " Con UUID: " + uuid + "Ya fue cancelado anteiormente.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                            //UUIDSAT.RemoveAll(UUID => UUID.Equals(uuid));
                        }
                        else
                        {
                            UUIDSAT.Add(new E.CancelarUUID
                            {
                                Folio = folio,
                                UUID = uuid,
                                FecPago = Convert.ToDateTime(fecPago),
                                FecInicio = Convert.ToDateTime(fecIni),
                                FecFinal = Convert.ToDateTime(fecFin),
                                Empresa = Empr,
                                IPMovimiento = ip,
                                Usuario = usuario,
                                RFCEmpl = rfcEmpl,
                                selloCFD = selloCFD,
                                total = total
                            });
                            uid = UUIDSAT.ToArray();
                        }
                    }

                }
                //Controlador.Generar12(UUID, splashScreenManager1);
                Controlador.CancelarCFDI(UUIDSAT, splashScreenManager1, RFCEmpr,pacTimbrado, ambiente);
                RefrescaTabla();
            }
            catch (Exception btn)
            {
                XtraMessageBox.Show(btn.Message + "Error modulo CancelarCFDI: \nBtnAceptar", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }
    }
}

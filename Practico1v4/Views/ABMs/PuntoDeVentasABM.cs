﻿using Practico1v4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Practico1v4.Helpers;
using Practico1v4.Reportes;

//TODO:desabilitar copiar y pegar en todos los textbox
//TODO: que no pueda meter espacios

namespace Practico1v4.Views
{
    public partial class PuntoDeVentasABM : Form
    {
        public PuntoDeVentasABM()
        {
            InitializeComponent();
        }

        VentasDBContext contextGlobal = new VentasDBContext(Common.TenantData.tenant.ConnectionString);

        private void PuntoDeVentasABM_Load(object sender, EventArgs e)
        {
            using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
            {
                context.PuntosDeVenta.Load();
                this.dataGridView1.DataSource = context.PuntosDeVenta.Local.ToBindingList();
            }
            modificarButton.Enabled = false;
            //MessageBoxManager.Register();
        }

        private void insertarButton_Click(object sender, EventArgs e)
        {
            PuntoDeVenta p = new PuntoDeVenta();
            p.Descripcion = descripcionTextBox.Text;
            p.Id = (string.IsNullOrWhiteSpace(idTextBox.Text)) ? 0 : Convert.ToInt32(idTextBox.Text);

            if (string.IsNullOrWhiteSpace(descripcionTextBox.Text))
            {
                errorProvider1.SetError(descripcionTextBox, "Requerido");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
            {
                if (p.Id == 0 && !string.IsNullOrWhiteSpace(p.Descripcion)) //insertar
                {
                    context.PuntosDeVenta.Add(p);
                    context.SaveChanges();
                }
                
            }
            actualizarGrilla();
            limpiarCampos();
        }

        private void actualizarGrilla()
        {
            this.dataGridView1.DataSource = null;
            using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
            {
                context.PuntosDeVenta.Load();
                this.dataGridView1.DataSource = context.PuntosDeVenta.Local.ToBindingList();
            }
            //this.dataGridView1.Update();
            //this.dataGridView1.Refresh();
        }

        private void buscarTextBox_TextChanged(object sender, EventArgs e)
        {
            string filter = buscarTextBox.Text;
            dataGridView1.DataSource = contextGlobal.PuntosDeVenta.Where(x => x.Descripcion.Contains(filter)).ToList();
        }


        private void borrarButton_Click(object sender, EventArgs e)
        {
            //chequear si no tiene fks
            PuntoDeVenta p = new PuntoDeVenta();
            p.Descripcion = descripcionTextBox.Text;
            p.Id = (string.IsNullOrWhiteSpace(idTextBox.Text)) ? 0 : Convert.ToInt32(idTextBox.Text);
            using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
            {
                if (context.Vendedores.Where(x => x.PuntoDeVenta.Id == p.Id).Any())
                {
                    using (new CenterWinDialog(this))
                    {
                        MessageBox.Show("Violacion de integridad referencial", "No se puede borrar " + p.Descripcion + " ");
                    }
                }
                else if (p.Id != 0)
                {
                    using (new CenterWinDialog(this))
                    {
                        MessageBoxManager.Cancel = "Cancelar";
                        DialogResult r = MessageBox.Show("Realmente desea eliminar el Punto de Venta?", "Cuidado", MessageBoxButtons.OKCancel);
                        if (r != DialogResult.Cancel)
                        {
                            context.Entry(p).State = EntityState.Deleted;
                            context.SaveChanges();
                            actualizarGrilla();
                        }
                       
                    }
                }
            }
            limpiarCampos();
            limpiarButton.PerformClick();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            PuntoDeVenta p = new PuntoDeVenta();
            p.Descripcion = descripcionTextBox.Text;
            p.Id = (string.IsNullOrWhiteSpace(idTextBox.Text)) ? 0 : Convert.ToInt32(idTextBox.Text);
            using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
            {
                if (!string.IsNullOrWhiteSpace(p.Descripcion)) //modificar
                {
					//context.Entry(p).State = EntityState.Modified;
					//para que ande bien el audit
					var entry = context.PuntosDeVenta.Find(p.Id);
					context.Entry(entry).CurrentValues.SetValues(p);
					context.SaveChanges();
                }
                
            }
            actualizarGrilla();
            limpiarCampos();
            modificarButton.Enabled = false;
            borrarButton.Enabled = false;
        }

        //private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridView dgv = sender as DataGridView;
        //    if (dgv == null)
        //        return;
        //    if (dgv.CurrentRow.Selected)
        //    {
        //        string desc = dgv.CurrentRow.Cells[1].Value.ToString();
        //        descripcionTextBox.Text = desc;
        //    }
        //}

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                PuntoDeVenta p = new PuntoDeVenta();
                p.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
                {
                    p = context.PuntosDeVenta.Where(x => x.Id == p.Id).FirstOrDefault();
                    descripcionTextBox.Text = p.Descripcion;
                    idTextBox.Text = Convert.ToString(p.Id);
                }
                modificarButton.Enabled = true;
                borrarButton.Enabled = true;
                insertarButton.Enabled = false;
            }
        }

        private void limpiarCampos()
        {
            descripcionTextBox.Clear();
            idTextBox.Clear();
            errorProvider1.Clear();
            
        }

        private void PuntoDeVentasABM_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBoxManager.Unregister();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            insertarButton.Enabled = true;
            modificarButton.Enabled = false;
            borrarButton.Enabled = false;
        }

        private void reporteButton_Click(object sender, EventArgs e)
        {
            Reportes.frmPuntoDeVentasReporte rpt = new Reportes.frmPuntoDeVentasReporte();
            rpt.ShowDialog(this);
        }
    }
}

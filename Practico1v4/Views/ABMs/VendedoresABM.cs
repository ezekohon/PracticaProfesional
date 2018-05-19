using Practico1v4.Models;
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
using System.Reflection;
using Practico1v4.Helpers;
using System.Text.RegularExpressions;
using Practico1v4.Reportes;

namespace Practico1v4.Views
{
    public partial class VendedoresABM : Form
    {
        public VendedoresABM()
        {
            InitializeComponent();
            //Reportes.PuntosDeVentaReporte rpt = new PuntosDeVentaReporte();
            //rpt.
        }

        VentasDBContext contextGlobal = new VentasDBContext();

        private void VendedoresABM_Load(object sender, EventArgs e)
        {
            //using (var context = new VentasDBContext())
            //{
            //    context.Vendedores.Load();
            //    context.PuntosDeVenta.Load();
             
            //}
            actualizarGrilla();
            modificarButton.Enabled = false;
            borrarButton.Enabled = false;
        }

        private void insertarButton_Click(object sender, EventArgs e)
        {
            bool puedoInsertar = true;
            Vendedor v = new Vendedor();
            v.Id = (string.IsNullOrWhiteSpace(idTextBox.Text)) ? 0 : Convert.ToInt32(idTextBox.Text);

            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                nombreErrorProvider.SetError(nombreTextBox, "Requerido");
                nombreErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                puedoInsertar = false;
                //return;
            }
            else { nombreErrorProvider.Clear(); }

            if (string.IsNullOrWhiteSpace(apellidoTextBox.Text))
            {
                apellidoErrorProvider.SetError(apellidoTextBox, "Requerido");
                apellidoErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                puedoInsertar = false;
                //return;
            }
            else { apellidoErrorProvider.Clear(); }

            if (string.IsNullOrWhiteSpace(puntoIdTextBox.Text.ToString()))
            {
                puntoErrorProvider.SetError(puntoIdTextBox, "Requerido");
                puntoErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                puedoInsertar = false;
                //return;
            }
            else { puntoErrorProvider.Clear(); }

            if (string.IsNullOrWhiteSpace(zonaIdTextBox.Text.ToString()))
            {
                zonaErrorProvider.SetError(zonaIdTextBox, "Requerido");
                zonaErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                puedoInsertar = false;
                //return;
            }
            else { zonaErrorProvider.Clear(); }

            v.Nombre = nombreTextBox.Text;
            v.Apellido = apellidoTextBox.Text;
            //v.Ciudad = ciudadTextBox.Text;
            //v.Direccion = direccionTextBox.Text;
            //v.Telefono = Convert.ToInt32(telefonoTextBox.Text);
            int puntoId = (string.IsNullOrWhiteSpace(puntoIdTextBox.Text)) ? 0 : Convert.ToInt32(puntoIdTextBox.Text);
            int zonaId = (string.IsNullOrWhiteSpace(zonaIdTextBox.Text)) ? 0 : Convert.ToInt32(zonaIdTextBox.Text);
            PuntoDeVenta pdv = contextGlobal.PuntosDeVenta.Where(p => p.Id == puntoId).FirstOrDefault();
            Zona z = contextGlobal.Zonas.Where(p => p.Id == zonaId).FirstOrDefault();

            using (var context = new VentasDBContext())
            {
                if (v.Id == 0 && puedoInsertar) //insertar
                {
                    context.Vendedores.Add(v);
                    //para que no se cree un nuevo punto de venta
                    context.PuntosDeVenta.Attach(pdv);
                    
                    v.PuntoDeVenta = pdv;
                    context.Zonas.Attach(z);
                    v.Zona = z;
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    { throw ex;  }
                        
                    
                    limpiarCampos();
                }
             
            }
            actualizarGrilla();
            
        }

        private void borrarButton_Click(object sender, EventArgs e)
        {

            Vendedor v = new Vendedor();

            v.Id = (string.IsNullOrWhiteSpace(idTextBox.Text)) ? 0 : Convert.ToInt32(idTextBox.Text);
            using (var context = new VentasDBContext())
            {
                if (v.Id != 0)
                {
                    v = context.Vendedores.Where(x => x.Id == v.Id).Include(x => x.PuntoDeVenta).Include(x => x.Zona).FirstOrDefault();
                    using (new CenterWinDialog(this))
                    {
                        
                        DialogResult r = MessageBox.Show("Realmente desea eliminar el Vendedor?", "Cuidado", MessageBoxButtons.OKCancel);
                        if (r != DialogResult.Cancel)
                        {
                            context.Entry(v).State = EntityState.Deleted;
                            context.SaveChanges();
                            actualizarGrilla();
                        }

                    }
                }
            }
            limpiarButton.PerformClick();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            bool puedoInsertar = true;
            Vendedor v = new Vendedor();
            v.Id = (string.IsNullOrWhiteSpace(idTextBox.Text)) ? 0 : Convert.ToInt32(idTextBox.Text);
            v.Nombre = nombreTextBox.Text;
            v.Apellido = apellidoTextBox.Text;
            int puntoId = (string.IsNullOrWhiteSpace(puntoIdTextBox.Text)) ? 0 : Convert.ToInt32(puntoIdTextBox.Text);
            int zonaId = (string.IsNullOrWhiteSpace(zonaIdTextBox.Text)) ? 0 : Convert.ToInt32(zonaIdTextBox.Text);
            PuntoDeVenta pdv = contextGlobal.PuntosDeVenta.Where(p => p.Id == puntoId).FirstOrDefault();
            Zona z = contextGlobal.Zonas.Where(p => p.Id == zonaId).FirstOrDefault();
            //v.PuntoDeVenta = contextGlobal.PuntosDeVenta.Where(p => p.Id == puntoId).FirstOrDefault();
            v.PuntoDeVentaId = puntoId;
            v.PuntoDeVenta = null;
            v.ZonaId = zonaId;
            v.Zona = null;

            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                nombreErrorProvider.SetError(nombreTextBox, "Requerido");
                nombreErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                puedoInsertar = false;
                //return;
            }
            else { nombreErrorProvider.Clear(); }

            if (string.IsNullOrWhiteSpace(apellidoTextBox.Text))
            {
                apellidoErrorProvider.SetError(apellidoTextBox, "Requerido");
                apellidoErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                puedoInsertar = false;
                //return;
            }
            else { apellidoErrorProvider.Clear(); }

            if (string.IsNullOrWhiteSpace(puntoIdTextBox.Text.ToString()))
            {
                puntoErrorProvider.SetError(puntoIdTextBox, "Requerido");
                puntoErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                puedoInsertar = false;
                //return;
            }
            else { puntoErrorProvider.Clear(); }

            if (string.IsNullOrWhiteSpace(zonaIdTextBox.Text.ToString()))
            {
                zonaErrorProvider.SetError(zonaIdTextBox, "Requerido");
                zonaErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                puedoInsertar = false;
                //return;
            }
            else { zonaErrorProvider.Clear(); }

            using (var context = new VentasDBContext())
            {
                if (puedoInsertar) //modificar
                {
                    //context.PuntosDeVenta.Attach(pdv);
                    //v.PuntoDeVenta = pdv;
                    context.Entry(v).State = EntityState.Modified;
                    context.SaveChanges();
                    actualizarGrilla();

                }
            }
            limpiarCampos();
            limpiarButton.PerformClick();
        }

        private void buscarTextBox_TextChanged(object sender, EventArgs e)
        {
            string filter = buscarTextBox.Text;
            //dataGridView1.DataSource = contextGlobal.Vendedores.Where(x => x.Nombre.Contains(filter) || x.Apellido.Contains(filter)).ToList();
            using (var context = new VentasDBContext())
            {
                var query = from p in context.PuntosDeVenta
                            join v in context.Vendedores on p.Id equals v.PuntoDeVenta.Id
                            join z in context.Zonas on v.ZonaId equals z.Id
                            where v.Nombre.Contains(filter) || v.Apellido.Contains(filter)
                            select new 
                            {
                                Id = v.Id,
                                PuntoDeVenta_Id = v.PuntoDeVentaId,
                                PuntoDeVenta = v.PuntoDeVenta.Descripcion,
                                Zona_Id = v.ZonaId,
                                Zona = v.Zona.Descripcion,
                                Nombre = v.Nombre,
                                Apellido = v.Apellido
                            };
                this.dataGridView1.DataSource = query.ToList();
            }
        }

        private void buscarTextBox2_TextChanged(object sender, EventArgs e)
        {
            string filter = buscarTextBox2.Text;

                using (var context = new VentasDBContext())
                {
                    var query = from p in context.PuntosDeVenta
                                join v in context.Vendedores on p.Id equals v.PuntoDeVenta.Id
                                join z in context.Zonas on v.ZonaId equals z.Id
                                where v.PuntoDeVentaId.ToString().Contains(filter) || v.PuntoDeVenta.Descripcion.Contains(filter)
                                select new
                                {
                                    Id = v.Id,
                                    PuntoDeVenta_Id = v.PuntoDeVentaId,
                                    PuntoDeVenta = v.PuntoDeVenta.Descripcion,
                                    Zona_Id = v.ZonaId,
                                    Zona = v.Zona.Descripcion,
                                    Nombre = v.Nombre,
                                    Apellido = v.Apellido
                                };
                    this.dataGridView1.DataSource = query.ToList();
                }
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Vendedor v = new Vendedor();
                v.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                using (var context = new VentasDBContext())
                {
                    v = context.Vendedores.Where(x => x.Id == v.Id).Include(x => x.PuntoDeVenta).Include(x => x.Zona).FirstOrDefault();
                 
                    idTextBox.Text = Convert.ToString(v.Id);
                    nombreTextBox.Text = v.Nombre;
                    apellidoTextBox.Text = v.Apellido;
                    puntoIdTextBox.Text = Convert.ToString(v.PuntoDeVenta.Id);
                    puntoTextBox.Text = v.PuntoDeVenta.Descripcion;
                    zonaIdTextBox.Text = Convert.ToString(v.Zona.Id);
                    zonaTextBox.Text = v.Zona.Descripcion;
                }
                modificarButton.Enabled = true;
                borrarButton.Enabled = true;
                insertarButton.Enabled = false;
            }
        }

        private void actualizarGrilla()
        {
            using (var context = new VentasDBContext())
            {
                var query = from p in context.PuntosDeVenta
                            join v in context.Vendedores on p.Id equals v.PuntoDeVenta.Id
                            join z in context.Zonas on v.ZonaId equals z.Id
                            select new
                            {
                                Id = v.Id,
                                PuntoDeVenta_Id = v.PuntoDeVentaId,
                                PuntoDeVenta = v.PuntoDeVenta.Descripcion,
                                Zona_Id = v.ZonaId,
                                Zona = v.Zona.Descripcion,
                                Nombre = v.Nombre,
                                Apellido = v.Apellido
                            };
                this.dataGridView1.DataSource = query.ToList();
                //context.Vendedores.Load();
                //this.dataGridView1.DataSource = context.Vendedores.Local.ToBindingList();//Include(x => x.PuntoDeVenta);

            }
        }

        //private void autocompletarTextBox()
        //{
        //    puntoTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    puntoTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    AutoCompleteStringCollection c = new AutoCompleteStringCollection();
        //    using (var context = new VentasDBContext())
        //    {
        //        var query = from p in context.PuntosDeVenta
        //                    select p.Descripcion;
        //        c.AddRange(query.ToArray());
        //    }
        //    puntoTextBox.AutoCompleteCustomSource = c;
        //}


        private void puntoIdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                int id = (puntoIdTextBox.Text != "") ? Convert.ToInt32(puntoIdTextBox.Text) : 0;
                if (id != 0)
                {
                    using (var context = new VentasDBContext())
                    {
                        
                        PuntoDeVenta pdv = context.PuntosDeVenta.Where(p => p.Id == id).FirstOrDefault();
                        if (pdv!=null)
                        {
                            puntoIdTextBox.Text = pdv.Id.ToString();
                            puntoTextBox.Text = pdv.Descripcion;
                        }
                        else
                        {
                            //mostrar error y la grid
                            //MessageBoxManager.Register();
                            //using (new CenterWinDialog(this))
                            //{
                            //    MessageBox.Show("No existe el Punto de Venta. Elija uno de la tabla.", "Error");
                            //}
                            //MessageBoxManager.Unregister();
                            context.PuntosDeVenta.Load();
                            DGVHelp.DataSource = context.PuntosDeVenta.Local.ToBindingList();
                            DGVHelp.Visible = true;
                        }
                    }
                }
            }
            else if (e.KeyCode.ToString() == "F1")
            {
                //abrir grid
                using (var context = new VentasDBContext())
                {
                    context.PuntosDeVenta.Load();
                    DGVHelp.DataSource = context.PuntosDeVenta.Local.ToBindingList();
                    DGVHelp.Visible = true;
                }
            }
        }

        private void puntoIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo puede ingresar numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void DGVHelp_DoubleClick(object sender, EventArgs e)
        {
            if (DGVHelp.CurrentRow.Index != -1)
            {
                PuntoDeVenta p = new PuntoDeVenta();
                p.Id = Convert.ToInt32(DGVHelp.CurrentRow.Cells[0].Value);
                using (var context = new VentasDBContext())
                {
                    p = context.PuntosDeVenta.Where(x => x.Id == p.Id).FirstOrDefault();
                    puntoTextBox.Text = p.Descripcion;
                    puntoIdTextBox.Text = Convert.ToString(p.Id);
                }
                DGVHelp.Visible = false;
            }
        }

        private void limpiarCampos()
        {
            idTextBox.Clear();
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            puntoIdTextBox.Clear();
            puntoTextBox.Clear();
            zonaIdTextBox.Clear();
            zonaTextBox.Clear();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            insertarButton.Enabled = true;
            modificarButton.Enabled = false;
            borrarButton.Enabled = false;
            apellidoErrorProvider.Clear();
            nombreErrorProvider.Clear();
            puntoErrorProvider.Clear();
        }

        private void puntoIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void zonaIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void DGVHelp2_DoubleClick(object sender, EventArgs e)
        {
            if (DGVHelp2.CurrentRow.Index != -1)
            {
                Zona p = new Zona();
                p.Id = Convert.ToInt32(DGVHelp2.CurrentRow.Cells[0].Value);
                using (var context = new VentasDBContext())
                {
                    p = context.Zonas.Where(x => x.Id == p.Id).FirstOrDefault();
                    zonaTextBox.Text = p.Descripcion;
                    zonaIdTextBox.Text = Convert.ToString(p.Id);
                }
                DGVHelp2.Visible = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void zonaIdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                int id = (zonaIdTextBox.Text != "") ? Convert.ToInt32(zonaIdTextBox.Text) : 0;
                if (id != 0)
                {
                    using (var context = new VentasDBContext())
                    {

                        Zona pdv = context.Zonas.Where(p => p.Id == id).FirstOrDefault();
                        if (pdv != null)
                        {
                            zonaIdTextBox.Text = pdv.Id.ToString();
                            zonaTextBox.Text = pdv.Descripcion;
                        }
                        else
                        {
                            //mostrar error y la grid
                            //MessageBoxManager.Register();
                            //using (new CenterWinDialog(this))
                            //{
                            //    MessageBox.Show("No existe el Punto de Venta. Elija uno de la tabla.", "Error");
                            //}
                            //MessageBoxManager.Unregister();
                            context.Zonas.Load();
                            DGVHelp2.DataSource = context.Zonas.Local.ToBindingList();
                            DGVHelp2.Visible = true;
                        }
                    }
                }
            }
            else if (e.KeyCode.ToString() == "F1")
            {
                //abrir grid
                using (var context = new VentasDBContext())
                {
                    context.Zonas.Load();
                    DGVHelp2.DataSource = context.Zonas.Local.ToBindingList();
                    DGVHelp2.Visible = true;
                }
            }
        }

        private void zonaIdTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //solo puede ingresar numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void reporteButton_Click(object sender, EventArgs e)
        {
            Reportes.frmVendedoresReporte rpt = new Reportes.frmVendedoresReporte();
            rpt.ShowDialog(this);
        }
    }
}

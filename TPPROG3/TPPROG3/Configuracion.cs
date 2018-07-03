using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPPROG3
{
 public partial class Configuracion : Form
 {
  public Configuracion()
  {
   InitializeComponent();
  }

  private void CargarColores(){


  }

  private void Configuracion_Load(object sender, EventArgs e)
  {
   string[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor));
   cmbx_color_fondo.Items.AddRange(colores);
   cmbx_color_fuente.Items.AddRange(colores);
  }

  private void cmbx_color_fuente_DrawItem(object sender, DrawItemEventArgs e)
  {
   e.DrawBackground();
   string texto = cmbx_color_fuente.Items[e.Index].ToString();
   Brush borde = new SolidBrush(e.ForeColor);
   Color color = Color.FromName(texto);
   Brush pincel = new SolidBrush(color);
   Pen boli = new Pen(e.ForeColor);
   e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 50, e.Bounds.Height - 4));
   e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 48, e.Bounds.Height - 6));
   e.Graphics.DrawString(texto, e.Font, borde, e.Bounds.Left + 65, e.Bounds.Top + 2);
   e.DrawFocusRectangle();

  }

  private void cmbx_color_fondo_DrawItem(object sender, DrawItemEventArgs e)
  {
   e.DrawBackground();
   string texto = cmbx_color_fuente.Items[e.Index].ToString();
   Brush borde = new SolidBrush(e.ForeColor);
   Color color = Color.FromName(texto);
   Brush pincel = new SolidBrush(color);
   Pen boli = new Pen(e.ForeColor);
   e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 50, e.Bounds.Height - 4));
   e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 48, e.Bounds.Height - 6));
   e.Graphics.DrawString(texto, e.Font, borde, e.Bounds.Left + 65, e.Bounds.Top + 2);
   e.DrawFocusRectangle();
  }
 }
}

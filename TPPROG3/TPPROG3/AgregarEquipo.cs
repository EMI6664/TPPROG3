﻿using System;
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
 public partial class AgregarEquipo : Form
 {
  public AgregarEquipo()
  {
   InitializeComponent();
  }

  private void btn_agregar_Click(object sender, EventArgs e)
  {
   MessageBox.Show("Equipo Agregado Satisfactoriamente");
  }
 }
}

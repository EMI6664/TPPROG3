﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TPPROG3
{
    public partial class frmModificarCli : Form
    {
        public frmModificarCli()
        {
            InitializeComponent();
        }

        void MostrarClientes()
        {
            string comando = "Select Nombre,Apellido,Direccion,Telefono,Codpostal as 'Codigo Postal', Provincia, Ciudad,DNI from Clientes";
            Tablas DATA = new Tablas();
            dataGridView1.DataSource = DATA.TraerTabla(comando, "Clientes");
        }

        private void frmModificarCli_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tablas DATA = new Tablas();
            Consultas BusquedaCliente = new Consultas();
            string comando = BusquedaCliente.CrearConsultaCliente(comboBox1.SelectedIndex.ToString());
            dataGridView1.DataSource = DATA.TraerTabla(comando, "Clientes");
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Tablas Data = new Tablas();
            string A = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            int Reg_ag = 0;
            Reg_ag = Data.BorrarEnDBCliente("Execute dltCli", "dltCli", A);
            MessageBox.Show("Cliente Borrado Satisfactoriamente");
            MostrarClientes();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNom.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtApe.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtDir.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtTel.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtCP.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtProv.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtCiu.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtDNI.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Tablas Data = new Tablas();
            int Reg_ag = Data.CargarTablaEnDBClientes("execute modCli", "modCli", txtNom.Text, txtApe.Text, txtDir.Text, txtTel.Text, txtCP.Text, txtProv.Text, txtCiu.Text, txtDNI.Text);
            if(txtNom.Text == "")
            {
                MessageBox.Show("Seleccione un cliente a modificar");
            }
            else
            {
            MessageBox.Show("Cliente Modificado Satisfactoriamente");
            }
            
            MostrarClientes();
            txtNom.Text = txtApe.Text = txtDir.Text = txtTel.Text = txtCP.Text = txtProv.Text = txtCiu.Text = txtDNI.Text = "";
        }
        /*
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione Una Marca");
                return;
            }
        }
        */
    }
}

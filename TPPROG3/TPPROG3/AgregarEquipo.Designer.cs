﻿namespace TPPROG3
{
 partial class AgregarEquipo
 {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing)
  {
   if (disposing && (components != null))
   {
    components.Dispose();
   }
   base.Dispose(disposing);
  }

  #region Windows Form Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
   this.lbl_num_serie = new System.Windows.Forms.Label();
   this.lbl_marca = new System.Windows.Forms.Label();
   this.lbl_modelo = new System.Windows.Forms.Label();
   this.lbl_tipo = new System.Windows.Forms.Label();
   this.lbl_dni_dueño = new System.Windows.Forms.Label();
   this.txt_numero_serie = new System.Windows.Forms.TextBox();
   this.btn_agregar = new System.Windows.Forms.Button();
   this.cmbx_modelo = new System.Windows.Forms.ComboBox();
   this.cmbx_marca = new System.Windows.Forms.ComboBox();
   this.cmbx_dni = new System.Windows.Forms.ComboBox();
   this.cmbx_tipo = new System.Windows.Forms.ComboBox();
   this.dataGridView1 = new System.Windows.Forms.DataGridView();
   ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_num_serie
   // 
   this.lbl_num_serie.AutoSize = true;
   this.lbl_num_serie.Location = new System.Drawing.Point(12, 23);
   this.lbl_num_serie.Name = "lbl_num_serie";
   this.lbl_num_serie.Size = new System.Drawing.Size(91, 13);
   this.lbl_num_serie.TabIndex = 0;
   this.lbl_num_serie.Text = "Numero De Serie:";
   // 
   // lbl_marca
   // 
   this.lbl_marca.AutoSize = true;
   this.lbl_marca.Location = new System.Drawing.Point(12, 48);
   this.lbl_marca.Name = "lbl_marca";
   this.lbl_marca.Size = new System.Drawing.Size(40, 13);
   this.lbl_marca.TabIndex = 1;
   this.lbl_marca.Text = "Marca:";
   // 
   // lbl_modelo
   // 
   this.lbl_modelo.AutoSize = true;
   this.lbl_modelo.Location = new System.Drawing.Point(12, 75);
   this.lbl_modelo.Name = "lbl_modelo";
   this.lbl_modelo.Size = new System.Drawing.Size(45, 13);
   this.lbl_modelo.TabIndex = 2;
   this.lbl_modelo.Text = "Modelo:";
   // 
   // lbl_tipo
   // 
   this.lbl_tipo.AutoSize = true;
   this.lbl_tipo.Location = new System.Drawing.Point(445, 23);
   this.lbl_tipo.Name = "lbl_tipo";
   this.lbl_tipo.Size = new System.Drawing.Size(31, 13);
   this.lbl_tipo.TabIndex = 3;
   this.lbl_tipo.Text = "Tipo:";
   // 
   // lbl_dni_dueño
   // 
   this.lbl_dni_dueño.AutoSize = true;
   this.lbl_dni_dueño.Location = new System.Drawing.Point(445, 48);
   this.lbl_dni_dueño.Name = "lbl_dni_dueño";
   this.lbl_dni_dueño.Size = new System.Drawing.Size(83, 13);
   this.lbl_dni_dueño.TabIndex = 4;
   this.lbl_dni_dueño.Text = "DNI Del Dueño:";
   // 
   // txt_numero_serie
   // 
   this.txt_numero_serie.Location = new System.Drawing.Point(109, 20);
   this.txt_numero_serie.Name = "txt_numero_serie";
   this.txt_numero_serie.Size = new System.Drawing.Size(313, 20);
   this.txt_numero_serie.TabIndex = 6;
   // 
   // btn_agregar
   // 
   this.btn_agregar.Location = new System.Drawing.Point(15, 384);
   this.btn_agregar.Name = "btn_agregar";
   this.btn_agregar.Size = new System.Drawing.Size(105, 23);
   this.btn_agregar.TabIndex = 12;
   this.btn_agregar.Text = "Agregar Equipo";
   this.btn_agregar.UseVisualStyleBackColor = true;
   this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
   // 
   // cmbx_modelo
   // 
   this.cmbx_modelo.FormattingEnabled = true;
   this.cmbx_modelo.Location = new System.Drawing.Point(109, 75);
   this.cmbx_modelo.Name = "cmbx_modelo";
   this.cmbx_modelo.Size = new System.Drawing.Size(313, 21);
   this.cmbx_modelo.TabIndex = 14;
   // 
   // cmbx_marca
   // 
   this.cmbx_marca.FormattingEnabled = true;
   this.cmbx_marca.Location = new System.Drawing.Point(109, 48);
   this.cmbx_marca.Name = "cmbx_marca";
   this.cmbx_marca.Size = new System.Drawing.Size(313, 21);
   this.cmbx_marca.TabIndex = 15;
   // 
   // cmbx_dni
   // 
   this.cmbx_dni.FormattingEnabled = true;
   this.cmbx_dni.Location = new System.Drawing.Point(547, 48);
   this.cmbx_dni.Name = "cmbx_dni";
   this.cmbx_dni.Size = new System.Drawing.Size(241, 21);
   this.cmbx_dni.TabIndex = 16;
   // 
   // cmbx_tipo
   // 
   this.cmbx_tipo.FormattingEnabled = true;
   this.cmbx_tipo.Location = new System.Drawing.Point(547, 20);
   this.cmbx_tipo.Name = "cmbx_tipo";
   this.cmbx_tipo.Size = new System.Drawing.Size(241, 21);
   this.cmbx_tipo.TabIndex = 17;
   // 
   // dataGridView1
   // 
   this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
   this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dataGridView1.Location = new System.Drawing.Point(15, 110);
   this.dataGridView1.Name = "dataGridView1";
   this.dataGridView1.Size = new System.Drawing.Size(773, 254);
   this.dataGridView1.TabIndex = 13;
   // 
   // AgregarEquipo
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(800, 425);
   this.Controls.Add(this.cmbx_tipo);
   this.Controls.Add(this.cmbx_dni);
   this.Controls.Add(this.cmbx_marca);
   this.Controls.Add(this.cmbx_modelo);
   this.Controls.Add(this.dataGridView1);
   this.Controls.Add(this.btn_agregar);
   this.Controls.Add(this.txt_numero_serie);
   this.Controls.Add(this.lbl_dni_dueño);
   this.Controls.Add(this.lbl_tipo);
   this.Controls.Add(this.lbl_modelo);
   this.Controls.Add(this.lbl_marca);
   this.Controls.Add(this.lbl_num_serie);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "AgregarEquipo";
   this.Text = "Agregar Equipo";
   ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_num_serie;
  private System.Windows.Forms.Label lbl_marca;
  private System.Windows.Forms.Label lbl_modelo;
  private System.Windows.Forms.Label lbl_tipo;
  private System.Windows.Forms.Label lbl_dni_dueño;
  private System.Windows.Forms.TextBox txt_numero_serie;
  private System.Windows.Forms.Button btn_agregar;
  private System.Windows.Forms.ComboBox cmbx_modelo;
  private System.Windows.Forms.ComboBox cmbx_marca;
  private System.Windows.Forms.ComboBox cmbx_dni;
  private System.Windows.Forms.ComboBox cmbx_tipo;
  private System.Windows.Forms.DataGridView dataGridView1;
 }
}
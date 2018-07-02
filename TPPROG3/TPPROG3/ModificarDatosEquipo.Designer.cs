namespace TPPROG3
{
 partial class ModificarDatosEquipo
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
   this.gbx_datos_equipo = new System.Windows.Forms.GroupBox();
   this.txt_numero_equipo = new System.Windows.Forms.TextBox();
   this.txt_numero_serie = new System.Windows.Forms.TextBox();
   this.txt_marca = new System.Windows.Forms.TextBox();
   this.txt_dni = new System.Windows.Forms.TextBox();
   this.txt_tipo = new System.Windows.Forms.TextBox();
   this.txt_modelo = new System.Windows.Forms.TextBox();
   this.lbl_dni_dueño = new System.Windows.Forms.Label();
   this.lbl_tipo_equipo = new System.Windows.Forms.Label();
   this.lbl_modelo = new System.Windows.Forms.Label();
   this.lbl_marca = new System.Windows.Forms.Label();
   this.lbl_num_serie = new System.Windows.Forms.Label();
   this.lbl_num_equipo = new System.Windows.Forms.Label();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   this.btn_asentar_cambios = new System.Windows.Forms.Button();
   this.gbx_datos_equipo.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // gbx_datos_equipo
   // 
   this.gbx_datos_equipo.Controls.Add(this.txt_numero_equipo);
   this.gbx_datos_equipo.Controls.Add(this.txt_numero_serie);
   this.gbx_datos_equipo.Controls.Add(this.txt_marca);
   this.gbx_datos_equipo.Controls.Add(this.txt_dni);
   this.gbx_datos_equipo.Controls.Add(this.txt_tipo);
   this.gbx_datos_equipo.Controls.Add(this.txt_modelo);
   this.gbx_datos_equipo.Controls.Add(this.lbl_dni_dueño);
   this.gbx_datos_equipo.Controls.Add(this.lbl_tipo_equipo);
   this.gbx_datos_equipo.Controls.Add(this.lbl_modelo);
   this.gbx_datos_equipo.Controls.Add(this.lbl_marca);
   this.gbx_datos_equipo.Controls.Add(this.lbl_num_serie);
   this.gbx_datos_equipo.Controls.Add(this.lbl_num_equipo);
   this.gbx_datos_equipo.Location = new System.Drawing.Point(12, 12);
   this.gbx_datos_equipo.Name = "gbx_datos_equipo";
   this.gbx_datos_equipo.Size = new System.Drawing.Size(776, 101);
   this.gbx_datos_equipo.TabIndex = 0;
   this.gbx_datos_equipo.TabStop = false;
   this.gbx_datos_equipo.Text = "Datos Del Equipo Seleccionado";
   // 
   // txt_numero_equipo
   // 
   this.txt_numero_equipo.Location = new System.Drawing.Point(112, 17);
   this.txt_numero_equipo.Name = "txt_numero_equipo";
   this.txt_numero_equipo.Size = new System.Drawing.Size(271, 20);
   this.txt_numero_equipo.TabIndex = 1;
   // 
   // txt_numero_serie
   // 
   this.txt_numero_serie.Location = new System.Drawing.Point(112, 43);
   this.txt_numero_serie.Name = "txt_numero_serie";
   this.txt_numero_serie.Size = new System.Drawing.Size(271, 20);
   this.txt_numero_serie.TabIndex = 2;
   // 
   // txt_marca
   // 
   this.txt_marca.Location = new System.Drawing.Point(112, 69);
   this.txt_marca.Name = "txt_marca";
   this.txt_marca.Size = new System.Drawing.Size(271, 20);
   this.txt_marca.TabIndex = 3;
   // 
   // txt_dni
   // 
   this.txt_dni.Location = new System.Drawing.Point(479, 69);
   this.txt_dni.Name = "txt_dni";
   this.txt_dni.Size = new System.Drawing.Size(291, 20);
   this.txt_dni.TabIndex = 4;
   // 
   // txt_tipo
   // 
   this.txt_tipo.Location = new System.Drawing.Point(479, 43);
   this.txt_tipo.Name = "txt_tipo";
   this.txt_tipo.Size = new System.Drawing.Size(291, 20);
   this.txt_tipo.TabIndex = 5;
   // 
   // txt_modelo
   // 
   this.txt_modelo.Location = new System.Drawing.Point(479, 14);
   this.txt_modelo.Name = "txt_modelo";
   this.txt_modelo.Size = new System.Drawing.Size(291, 20);
   this.txt_modelo.TabIndex = 6;
   // 
   // lbl_dni_dueño
   // 
   this.lbl_dni_dueño.AutoSize = true;
   this.lbl_dni_dueño.Location = new System.Drawing.Point(389, 69);
   this.lbl_dni_dueño.Name = "lbl_dni_dueño";
   this.lbl_dni_dueño.Size = new System.Drawing.Size(83, 13);
   this.lbl_dni_dueño.TabIndex = 5;
   this.lbl_dni_dueño.Text = "DNI Del Dueño:";
   // 
   // lbl_tipo_equipo
   // 
   this.lbl_tipo_equipo.AutoSize = true;
   this.lbl_tipo_equipo.Location = new System.Drawing.Point(389, 43);
   this.lbl_tipo_equipo.Name = "lbl_tipo_equipo";
   this.lbl_tipo_equipo.Size = new System.Drawing.Size(84, 13);
   this.lbl_tipo_equipo.TabIndex = 4;
   this.lbl_tipo_equipo.Text = "Tipo De Equipo:";
   // 
   // lbl_modelo
   // 
   this.lbl_modelo.AutoSize = true;
   this.lbl_modelo.Location = new System.Drawing.Point(389, 17);
   this.lbl_modelo.Name = "lbl_modelo";
   this.lbl_modelo.Size = new System.Drawing.Size(45, 13);
   this.lbl_modelo.TabIndex = 3;
   this.lbl_modelo.Text = "Modelo:";
   // 
   // lbl_marca
   // 
   this.lbl_marca.AutoSize = true;
   this.lbl_marca.Location = new System.Drawing.Point(6, 72);
   this.lbl_marca.Name = "lbl_marca";
   this.lbl_marca.Size = new System.Drawing.Size(40, 13);
   this.lbl_marca.TabIndex = 2;
   this.lbl_marca.Text = "Marca:";
   // 
   // lbl_num_serie
   // 
   this.lbl_num_serie.AutoSize = true;
   this.lbl_num_serie.Location = new System.Drawing.Point(6, 46);
   this.lbl_num_serie.Name = "lbl_num_serie";
   this.lbl_num_serie.Size = new System.Drawing.Size(91, 13);
   this.lbl_num_serie.TabIndex = 1;
   this.lbl_num_serie.Text = "Numero De Serie:";
   // 
   // lbl_num_equipo
   // 
   this.lbl_num_equipo.AutoSize = true;
   this.lbl_num_equipo.Location = new System.Drawing.Point(6, 20);
   this.lbl_num_equipo.Name = "lbl_num_equipo";
   this.lbl_num_equipo.Size = new System.Drawing.Size(100, 13);
   this.lbl_num_equipo.TabIndex = 0;
   this.lbl_num_equipo.Text = "Numero De Equipo:";
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(12, 129);
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.Size = new System.Drawing.Size(776, 254);
   this.grd_datos.TabIndex = 1;
   // 
   // btn_asentar_cambios
   // 
   this.btn_asentar_cambios.Location = new System.Drawing.Point(12, 389);
   this.btn_asentar_cambios.Name = "btn_asentar_cambios";
   this.btn_asentar_cambios.Size = new System.Drawing.Size(156, 23);
   this.btn_asentar_cambios.TabIndex = 2;
   this.btn_asentar_cambios.Text = "Realizar Cambios";
   this.btn_asentar_cambios.UseVisualStyleBackColor = true;
   // 
   // ModificarDatosEquipo
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(800, 420);
   this.Controls.Add(this.btn_asentar_cambios);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.gbx_datos_equipo);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MinimizeBox = false;
   this.Name = "ModificarDatosEquipo";
   this.Text = "Modificar Datos De  Equipos";
   this.gbx_datos_equipo.ResumeLayout(false);
   this.gbx_datos_equipo.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.GroupBox gbx_datos_equipo;
  private System.Windows.Forms.Label lbl_dni_dueño;
  private System.Windows.Forms.Label lbl_tipo_equipo;
  private System.Windows.Forms.Label lbl_modelo;
  private System.Windows.Forms.Label lbl_marca;
  private System.Windows.Forms.Label lbl_num_serie;
  private System.Windows.Forms.Label lbl_num_equipo;
  private System.Windows.Forms.TextBox txt_numero_equipo;
  private System.Windows.Forms.TextBox txt_numero_serie;
  private System.Windows.Forms.TextBox txt_marca;
  private System.Windows.Forms.TextBox txt_dni;
  private System.Windows.Forms.TextBox txt_tipo;
  private System.Windows.Forms.TextBox txt_modelo;
  private System.Windows.Forms.DataGridView grd_datos;
  private System.Windows.Forms.Button btn_asentar_cambios;
 }
}
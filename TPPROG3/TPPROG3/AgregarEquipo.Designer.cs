namespace TPPROG3
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
   this.txt_marca = new System.Windows.Forms.TextBox();
   this.txt_dni_dueño = new System.Windows.Forms.TextBox();
   this.txt_tipo = new System.Windows.Forms.TextBox();
   this.txt_modelo = new System.Windows.Forms.TextBox();
   this.btn_agregar = new System.Windows.Forms.Button();
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
   // txt_marca
   // 
   this.txt_marca.Location = new System.Drawing.Point(109, 45);
   this.txt_marca.Name = "txt_marca";
   this.txt_marca.Size = new System.Drawing.Size(313, 20);
   this.txt_marca.TabIndex = 7;
   // 
   // txt_dni_dueño
   // 
   this.txt_dni_dueño.Location = new System.Drawing.Point(534, 45);
   this.txt_dni_dueño.Name = "txt_dni_dueño";
   this.txt_dni_dueño.Size = new System.Drawing.Size(254, 20);
   this.txt_dni_dueño.TabIndex = 8;
   // 
   // txt_tipo
   // 
   this.txt_tipo.Location = new System.Drawing.Point(533, 20);
   this.txt_tipo.Name = "txt_tipo";
   this.txt_tipo.Size = new System.Drawing.Size(255, 20);
   this.txt_tipo.TabIndex = 9;
   // 
   // txt_modelo
   // 
   this.txt_modelo.Location = new System.Drawing.Point(109, 75);
   this.txt_modelo.Name = "txt_modelo";
   this.txt_modelo.Size = new System.Drawing.Size(313, 20);
   this.txt_modelo.TabIndex = 10;
   // 
   // btn_agregar
   // 
   this.btn_agregar.Location = new System.Drawing.Point(15, 384);
   this.btn_agregar.Name = "btn_agregar";
   this.btn_agregar.Size = new System.Drawing.Size(105, 23);
   this.btn_agregar.TabIndex = 12;
   this.btn_agregar.Text = "Agregar Equipo";
   this.btn_agregar.UseVisualStyleBackColor = true;
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
   this.Controls.Add(this.dataGridView1);
   this.Controls.Add(this.btn_agregar);
   this.Controls.Add(this.txt_modelo);
   this.Controls.Add(this.txt_tipo);
   this.Controls.Add(this.txt_dni_dueño);
   this.Controls.Add(this.txt_marca);
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
  private System.Windows.Forms.TextBox txt_marca;
  private System.Windows.Forms.TextBox txt_dni_dueño;
  private System.Windows.Forms.TextBox txt_tipo;
  private System.Windows.Forms.TextBox txt_modelo;
  private System.Windows.Forms.Button btn_agregar;
  private System.Windows.Forms.DataGridView dataGridView1;
 }
}
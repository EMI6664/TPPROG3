namespace TPPROG3
{
 partial class DetalleService
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
   this.lbl_seleccion = new System.Windows.Forms.Label();
   this.cmbx_seleccion_repuesto = new System.Windows.Forms.ComboBox();
   this.btn_Agregar = new System.Windows.Forms.Button();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   this.btn_quitar = new System.Windows.Forms.Button();
   this.btn_realizar_cambios = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_seleccion
   // 
   this.lbl_seleccion.AutoSize = true;
   this.lbl_seleccion.Location = new System.Drawing.Point(12, 24);
   this.lbl_seleccion.Name = "lbl_seleccion";
   this.lbl_seleccion.Size = new System.Drawing.Size(242, 13);
   this.lbl_seleccion.TabIndex = 0;
   this.lbl_seleccion.Text = "Seleccione Un Repuesto Para Agregar Al Detalle:";
   // 
   // cmbx_seleccion_repuesto
   // 
   this.cmbx_seleccion_repuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbx_seleccion_repuesto.FormattingEnabled = true;
   this.cmbx_seleccion_repuesto.Location = new System.Drawing.Point(260, 21);
   this.cmbx_seleccion_repuesto.Name = "cmbx_seleccion_repuesto";
   this.cmbx_seleccion_repuesto.Size = new System.Drawing.Size(335, 21);
   this.cmbx_seleccion_repuesto.TabIndex = 1;
   // 
   // btn_Agregar
   // 
   this.btn_Agregar.Location = new System.Drawing.Point(601, 21);
   this.btn_Agregar.Name = "btn_Agregar";
   this.btn_Agregar.Size = new System.Drawing.Size(135, 23);
   this.btn_Agregar.TabIndex = 2;
   this.btn_Agregar.Text = "Agregar Repuesto";
   this.btn_Agregar.UseVisualStyleBackColor = true;
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(15, 57);
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.Size = new System.Drawing.Size(721, 352);
   this.grd_datos.TabIndex = 3;
   // 
   // btn_quitar
   // 
   this.btn_quitar.Location = new System.Drawing.Point(661, 415);
   this.btn_quitar.Name = "btn_quitar";
   this.btn_quitar.Size = new System.Drawing.Size(75, 23);
   this.btn_quitar.TabIndex = 4;
   this.btn_quitar.Text = "Quitar";
   this.btn_quitar.UseVisualStyleBackColor = true;
   // 
   // btn_realizar_cambios
   // 
   this.btn_realizar_cambios.Location = new System.Drawing.Point(15, 415);
   this.btn_realizar_cambios.Name = "btn_realizar_cambios";
   this.btn_realizar_cambios.Size = new System.Drawing.Size(111, 23);
   this.btn_realizar_cambios.TabIndex = 5;
   this.btn_realizar_cambios.Text = "Realizar Cambios";
   this.btn_realizar_cambios.UseVisualStyleBackColor = true;
   // 
   // DetalleService
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(754, 450);
   this.Controls.Add(this.btn_realizar_cambios);
   this.Controls.Add(this.btn_quitar);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.btn_Agregar);
   this.Controls.Add(this.cmbx_seleccion_repuesto);
   this.Controls.Add(this.lbl_seleccion);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "DetalleService";
   this.Text = "Agregar/Quitar Detalles De Service";
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_seleccion;
  private System.Windows.Forms.ComboBox cmbx_seleccion_repuesto;
  private System.Windows.Forms.Button btn_Agregar;
  private System.Windows.Forms.DataGridView grd_datos;
  private System.Windows.Forms.Button btn_quitar;
  private System.Windows.Forms.Button btn_realizar_cambios;
 }
}
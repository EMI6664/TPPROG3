namespace TPPROG3
{
 partial class Configuracion
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
   this.lbl_fuente = new System.Windows.Forms.Label();
   this.lbl_tamaño_fuente = new System.Windows.Forms.Label();
   this.lbl_color_fuente = new System.Windows.Forms.Label();
   this.lbl_color_fondo = new System.Windows.Forms.Label();
   this.cmbx_fuente = new System.Windows.Forms.ComboBox();
   this.cmbx_color_fuente = new System.Windows.Forms.ComboBox();
   this.cmbx_color_fondo = new System.Windows.Forms.ComboBox();
   this.num_tamaño = new System.Windows.Forms.NumericUpDown();
   this.btn_confirmar_cambios = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)(this.num_tamaño)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_fuente
   // 
   this.lbl_fuente.AutoSize = true;
   this.lbl_fuente.Location = new System.Drawing.Point(12, 25);
   this.lbl_fuente.Name = "lbl_fuente";
   this.lbl_fuente.Size = new System.Drawing.Size(40, 13);
   this.lbl_fuente.TabIndex = 0;
   this.lbl_fuente.Text = "Fuente";
   // 
   // lbl_tamaño_fuente
   // 
   this.lbl_tamaño_fuente.AutoSize = true;
   this.lbl_tamaño_fuente.Location = new System.Drawing.Point(12, 70);
   this.lbl_tamaño_fuente.Name = "lbl_tamaño_fuente";
   this.lbl_tamaño_fuente.Size = new System.Drawing.Size(95, 13);
   this.lbl_tamaño_fuente.TabIndex = 1;
   this.lbl_tamaño_fuente.Text = "Tamaño de la letra";
   // 
   // lbl_color_fuente
   // 
   this.lbl_color_fuente.AutoSize = true;
   this.lbl_color_fuente.Location = new System.Drawing.Point(12, 124);
   this.lbl_color_fuente.Name = "lbl_color_fuente";
   this.lbl_color_fuente.Size = new System.Drawing.Size(90, 13);
   this.lbl_color_fuente.TabIndex = 2;
   this.lbl_color_fuente.Text = "Color de la fuente";
   // 
   // lbl_color_fondo
   // 
   this.lbl_color_fondo.AutoSize = true;
   this.lbl_color_fondo.Location = new System.Drawing.Point(12, 180);
   this.lbl_color_fondo.Name = "lbl_color_fondo";
   this.lbl_color_fondo.Size = new System.Drawing.Size(76, 13);
   this.lbl_color_fondo.TabIndex = 3;
   this.lbl_color_fondo.Text = "Color de fondo";
   // 
   // cmbx_fuente
   // 
   this.cmbx_fuente.FormattingEnabled = true;
   this.cmbx_fuente.Location = new System.Drawing.Point(108, 17);
   this.cmbx_fuente.Name = "cmbx_fuente";
   this.cmbx_fuente.Size = new System.Drawing.Size(266, 21);
   this.cmbx_fuente.TabIndex = 5;
   // 
   // cmbx_color_fuente
   // 
   this.cmbx_color_fuente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
   this.cmbx_color_fuente.FormattingEnabled = true;
   this.cmbx_color_fuente.Location = new System.Drawing.Point(108, 121);
   this.cmbx_color_fuente.Name = "cmbx_color_fuente";
   this.cmbx_color_fuente.Size = new System.Drawing.Size(266, 21);
   this.cmbx_color_fuente.TabIndex = 6;
   this.cmbx_color_fuente.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbx_color_fuente_DrawItem);
   // 
   // cmbx_color_fondo
   // 
   this.cmbx_color_fondo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
   this.cmbx_color_fondo.FormattingEnabled = true;
   this.cmbx_color_fondo.Location = new System.Drawing.Point(108, 180);
   this.cmbx_color_fondo.Name = "cmbx_color_fondo";
   this.cmbx_color_fondo.Size = new System.Drawing.Size(266, 21);
   this.cmbx_color_fondo.TabIndex = 7;
   this.cmbx_color_fondo.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbx_color_fondo_DrawItem);
   // 
   // num_tamaño
   // 
   this.num_tamaño.Location = new System.Drawing.Point(108, 68);
   this.num_tamaño.Name = "num_tamaño";
   this.num_tamaño.Size = new System.Drawing.Size(266, 20);
   this.num_tamaño.TabIndex = 8;
   this.num_tamaño.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
   // 
   // btn_confirmar_cambios
   // 
   this.btn_confirmar_cambios.Location = new System.Drawing.Point(15, 240);
   this.btn_confirmar_cambios.Name = "btn_confirmar_cambios";
   this.btn_confirmar_cambios.Size = new System.Drawing.Size(130, 23);
   this.btn_confirmar_cambios.TabIndex = 9;
   this.btn_confirmar_cambios.Text = "Confirmar Cambios";
   this.btn_confirmar_cambios.UseVisualStyleBackColor = true;
   // 
   // Configuracion
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(426, 284);
   this.Controls.Add(this.btn_confirmar_cambios);
   this.Controls.Add(this.num_tamaño);
   this.Controls.Add(this.cmbx_color_fondo);
   this.Controls.Add(this.cmbx_color_fuente);
   this.Controls.Add(this.cmbx_fuente);
   this.Controls.Add(this.lbl_color_fondo);
   this.Controls.Add(this.lbl_color_fuente);
   this.Controls.Add(this.lbl_tamaño_fuente);
   this.Controls.Add(this.lbl_fuente);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "Configuracion";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Configuracion";
   this.Load += new System.EventHandler(this.Configuracion_Load);
   ((System.ComponentModel.ISupportInitialize)(this.num_tamaño)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_fuente;
  private System.Windows.Forms.Label lbl_tamaño_fuente;
  private System.Windows.Forms.Label lbl_color_fuente;
  private System.Windows.Forms.Label lbl_color_fondo;
  private System.Windows.Forms.ComboBox cmbx_fuente;
  private System.Windows.Forms.ComboBox cmbx_color_fuente;
  private System.Windows.Forms.ComboBox cmbx_color_fondo;
  private System.Windows.Forms.NumericUpDown num_tamaño;
  private System.Windows.Forms.Button btn_confirmar_cambios;
 }
}
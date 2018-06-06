namespace TPPROG3
{
 partial class BuscarPorNumSerie
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
   this.lbl_numero_serie = new System.Windows.Forms.Label();
   this.txt_num_serie = new System.Windows.Forms.TextBox();
   this.grd_datos = new System.Windows.Forms.DataGridView();
   this.btn_buscar = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).BeginInit();
   this.SuspendLayout();
   // 
   // lbl_numero_serie
   // 
   this.lbl_numero_serie.AutoSize = true;
   this.lbl_numero_serie.Location = new System.Drawing.Point(12, 19);
   this.lbl_numero_serie.Name = "lbl_numero_serie";
   this.lbl_numero_serie.Size = new System.Drawing.Size(187, 13);
   this.lbl_numero_serie.TabIndex = 0;
   this.lbl_numero_serie.Text = "Ingrese El Numero De Serie Deseado:";
   // 
   // txt_num_serie
   // 
   this.txt_num_serie.Location = new System.Drawing.Point(205, 16);
   this.txt_num_serie.Name = "txt_num_serie";
   this.txt_num_serie.Size = new System.Drawing.Size(447, 20);
   this.txt_num_serie.TabIndex = 1;
   // 
   // grd_datos
   // 
   this.grd_datos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.grd_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.grd_datos.Location = new System.Drawing.Point(12, 42);
   this.grd_datos.Name = "grd_datos";
   this.grd_datos.Size = new System.Drawing.Size(640, 92);
   this.grd_datos.TabIndex = 2;
   // 
   // btn_buscar
   // 
   this.btn_buscar.Location = new System.Drawing.Point(12, 149);
   this.btn_buscar.Name = "btn_buscar";
   this.btn_buscar.Size = new System.Drawing.Size(109, 23);
   this.btn_buscar.TabIndex = 3;
   this.btn_buscar.Text = "Buscar Equipo";
   this.btn_buscar.UseVisualStyleBackColor = true;
   // 
   // BuscarPorNumSerie
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(658, 181);
   this.Controls.Add(this.btn_buscar);
   this.Controls.Add(this.grd_datos);
   this.Controls.Add(this.txt_num_serie);
   this.Controls.Add(this.lbl_numero_serie);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "BuscarPorNumSerie";
   this.Text = "Buscar Equipo Por Numero De Serie";
   ((System.ComponentModel.ISupportInitialize)(this.grd_datos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lbl_numero_serie;
  private System.Windows.Forms.TextBox txt_num_serie;
  private System.Windows.Forms.DataGridView grd_datos;
  private System.Windows.Forms.Button btn_buscar;
 }
}
namespace TPPROG3
{
 partial class BuscarPorModelo
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
   this.cmbx_seleccion = new System.Windows.Forms.ComboBox();
   this.dataGridView1 = new System.Windows.Forms.DataGridView();
   this.txt_modelo = new System.Windows.Forms.TextBox();
   this.btn_buscar = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
   this.SuspendLayout();
   // 
   // cmbx_seleccion
   // 
   this.cmbx_seleccion.FormattingEnabled = true;
   this.cmbx_seleccion.Items.AddRange(new object[] {
            "Comienza Con",
            "Termina Con",
            "Es Igual A"});
   this.cmbx_seleccion.Location = new System.Drawing.Point(12, 11);
   this.cmbx_seleccion.Name = "cmbx_seleccion";
   this.cmbx_seleccion.Size = new System.Drawing.Size(184, 21);
   this.cmbx_seleccion.TabIndex = 8;
   // 
   // dataGridView1
   // 
   this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
   this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dataGridView1.Location = new System.Drawing.Point(12, 51);
   this.dataGridView1.Name = "dataGridView1";
   this.dataGridView1.Size = new System.Drawing.Size(523, 264);
   this.dataGridView1.TabIndex = 7;
   // 
   // txt_modelo
   // 
   this.txt_modelo.Location = new System.Drawing.Point(202, 12);
   this.txt_modelo.Name = "txt_modelo";
   this.txt_modelo.Size = new System.Drawing.Size(252, 20);
   this.txt_modelo.TabIndex = 6;
   // 
   // btn_buscar
   // 
   this.btn_buscar.Location = new System.Drawing.Point(460, 9);
   this.btn_buscar.Name = "btn_buscar";
   this.btn_buscar.Size = new System.Drawing.Size(75, 23);
   this.btn_buscar.TabIndex = 5;
   this.btn_buscar.Text = "Buscar";
   this.btn_buscar.UseVisualStyleBackColor = true;
   // 
   // BuscarPorModelo
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(552, 328);
   this.Controls.Add(this.cmbx_seleccion);
   this.Controls.Add(this.dataGridView1);
   this.Controls.Add(this.txt_modelo);
   this.Controls.Add(this.btn_buscar);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "BuscarPorModelo";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Buscar Equipo Por Modelo";
   ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.ComboBox cmbx_seleccion;
  private System.Windows.Forms.DataGridView dataGridView1;
  private System.Windows.Forms.TextBox txt_modelo;
  private System.Windows.Forms.Button btn_buscar;
 }
}
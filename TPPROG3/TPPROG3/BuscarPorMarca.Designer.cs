namespace TPPROG3
{
 partial class BuscarPorMarca
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
   this.btn_buscar = new System.Windows.Forms.Button();
   this.txt_marca = new System.Windows.Forms.TextBox();
   this.dataGridView1 = new System.Windows.Forms.DataGridView();
   this.cmbx_seleccion = new System.Windows.Forms.ComboBox();
   ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
   this.SuspendLayout();
   // 
   // btn_buscar
   // 
   this.btn_buscar.Location = new System.Drawing.Point(460, 9);
   this.btn_buscar.Name = "btn_buscar";
   this.btn_buscar.Size = new System.Drawing.Size(75, 23);
   this.btn_buscar.TabIndex = 0;
   this.btn_buscar.Text = "Buscar";
   this.btn_buscar.UseVisualStyleBackColor = true;
   // 
   // txt_marca
   // 
   this.txt_marca.Location = new System.Drawing.Point(202, 12);
   this.txt_marca.Name = "txt_marca";
   this.txt_marca.Size = new System.Drawing.Size(252, 20);
   this.txt_marca.TabIndex = 1;
   // 
   // dataGridView1
   // 
   this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
   this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dataGridView1.Location = new System.Drawing.Point(12, 51);
   this.dataGridView1.Name = "dataGridView1";
   this.dataGridView1.Size = new System.Drawing.Size(523, 264);
   this.dataGridView1.TabIndex = 3;
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
   this.cmbx_seleccion.TabIndex = 4;
   // 
   // BuscarPorMarca
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.SystemColors.ControlDark;
   this.ClientSize = new System.Drawing.Size(545, 332);
   this.Controls.Add(this.cmbx_seleccion);
   this.Controls.Add(this.dataGridView1);
   this.Controls.Add(this.txt_marca);
   this.Controls.Add(this.btn_buscar);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MinimizeBox = false;
   this.Name = "BuscarPorMarca";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Buscar Equipo Por Marca";
   ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Button btn_buscar;
  private System.Windows.Forms.TextBox txt_marca;
  private System.Windows.Forms.DataGridView dataGridView1;
  private System.Windows.Forms.ComboBox cmbx_seleccion;
 }
}
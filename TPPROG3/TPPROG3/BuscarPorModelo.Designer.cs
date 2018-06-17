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
   this.dataGridView1 = new System.Windows.Forms.DataGridView();
   this.btn_buscar = new System.Windows.Forms.Button();
   this.cmbx_modelo = new System.Windows.Forms.ComboBox();
   ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
   this.SuspendLayout();
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
   // btn_buscar
   // 
   this.btn_buscar.Location = new System.Drawing.Point(324, 9);
   this.btn_buscar.Name = "btn_buscar";
   this.btn_buscar.Size = new System.Drawing.Size(75, 23);
   this.btn_buscar.TabIndex = 5;
   this.btn_buscar.Text = "Buscar";
   this.btn_buscar.UseVisualStyleBackColor = true;
   // 
   // cmbx_modelo
   // 
   this.cmbx_modelo.FormattingEnabled = true;
   this.cmbx_modelo.Location = new System.Drawing.Point(12, 9);
   this.cmbx_modelo.Name = "cmbx_modelo";
   this.cmbx_modelo.Size = new System.Drawing.Size(306, 21);
   this.cmbx_modelo.TabIndex = 8;
   // 
   // BuscarPorModelo
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(552, 328);
   this.Controls.Add(this.cmbx_modelo);
   this.Controls.Add(this.dataGridView1);
   this.Controls.Add(this.btn_buscar);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "BuscarPorModelo";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Buscar Equipo Por Modelo";
   ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion
  private System.Windows.Forms.DataGridView dataGridView1;
  private System.Windows.Forms.Button btn_buscar;
  private System.Windows.Forms.ComboBox cmbx_modelo;
 }
}
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
   this.dataGridView1 = new System.Windows.Forms.DataGridView();
   this.cmbx_marca = new System.Windows.Forms.ComboBox();
   ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
   this.SuspendLayout();
   // 
   // btn_buscar
   // 
   this.btn_buscar.Location = new System.Drawing.Point(304, 9);
   this.btn_buscar.Name = "btn_buscar";
   this.btn_buscar.Size = new System.Drawing.Size(75, 23);
   this.btn_buscar.TabIndex = 0;
   this.btn_buscar.Text = "Buscar";
   this.btn_buscar.UseVisualStyleBackColor = true;
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
   // cmbx_marca
   // 
   this.cmbx_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbx_marca.FormattingEnabled = true;
   this.cmbx_marca.Location = new System.Drawing.Point(12, 9);
   this.cmbx_marca.Name = "cmbx_marca";
   this.cmbx_marca.Size = new System.Drawing.Size(286, 21);
   this.cmbx_marca.TabIndex = 4;
   // 
   // BuscarPorMarca
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.SystemColors.ControlDark;
   this.ClientSize = new System.Drawing.Size(545, 332);
   this.Controls.Add(this.cmbx_marca);
   this.Controls.Add(this.dataGridView1);
   this.Controls.Add(this.btn_buscar);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MinimizeBox = false;
   this.Name = "BuscarPorMarca";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Buscar Equipo Por Marca";
   ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btn_buscar;
  private System.Windows.Forms.DataGridView dataGridView1;
  private System.Windows.Forms.ComboBox cmbx_marca;
 }
}
namespace TPPROG3
{
 partial class GenerarSalidaService
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
   this.textBox1 = new System.Windows.Forms.TextBox();
   this.lbl_total = new System.Windows.Forms.Label();
   this.textBox2 = new System.Windows.Forms.TextBox();
   this.lbl_detalle = new System.Windows.Forms.Label();
   this.lbl_num_service = new System.Windows.Forms.Label();
   this.txt_num_service = new System.Windows.Forms.TextBox();
   this.btn_buscar = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // textBox1
   // 
   this.textBox1.Location = new System.Drawing.Point(61, 346);
   this.textBox1.Name = "textBox1";
   this.textBox1.Size = new System.Drawing.Size(198, 20);
   this.textBox1.TabIndex = 0;
   // 
   // lbl_total
   // 
   this.lbl_total.AutoSize = true;
   this.lbl_total.Location = new System.Drawing.Point(12, 346);
   this.lbl_total.Name = "lbl_total";
   this.lbl_total.Size = new System.Drawing.Size(49, 13);
   this.lbl_total.TabIndex = 1;
   this.lbl_total.Text = "Total ($):";
   // 
   // textBox2
   // 
   this.textBox2.Location = new System.Drawing.Point(61, 38);
   this.textBox2.Multiline = true;
   this.textBox2.Name = "textBox2";
   this.textBox2.Size = new System.Drawing.Size(539, 291);
   this.textBox2.TabIndex = 2;
   // 
   // lbl_detalle
   // 
   this.lbl_detalle.AutoSize = true;
   this.lbl_detalle.Location = new System.Drawing.Point(12, 38);
   this.lbl_detalle.Name = "lbl_detalle";
   this.lbl_detalle.Size = new System.Drawing.Size(43, 13);
   this.lbl_detalle.TabIndex = 3;
   this.lbl_detalle.Text = "Detalle:";
   // 
   // lbl_num_service
   // 
   this.lbl_num_service.AutoSize = true;
   this.lbl_num_service.Location = new System.Drawing.Point(12, 9);
   this.lbl_num_service.Name = "lbl_num_service";
   this.lbl_num_service.Size = new System.Drawing.Size(103, 13);
   this.lbl_num_service.TabIndex = 4;
   this.lbl_num_service.Text = "Numero De Service:";
   // 
   // txt_num_service
   // 
   this.txt_num_service.Location = new System.Drawing.Point(121, 9);
   this.txt_num_service.Name = "txt_num_service";
   this.txt_num_service.Size = new System.Drawing.Size(169, 20);
   this.txt_num_service.TabIndex = 5;
   // 
   // btn_buscar
   // 
   this.btn_buscar.Location = new System.Drawing.Point(296, 9);
   this.btn_buscar.Name = "btn_buscar";
   this.btn_buscar.Size = new System.Drawing.Size(75, 23);
   this.btn_buscar.TabIndex = 6;
   this.btn_buscar.Text = "Buscar";
   this.btn_buscar.UseVisualStyleBackColor = true;
   // 
   // GenerarSalidaService
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(612, 378);
   this.Controls.Add(this.btn_buscar);
   this.Controls.Add(this.txt_num_service);
   this.Controls.Add(this.lbl_num_service);
   this.Controls.Add(this.lbl_detalle);
   this.Controls.Add(this.textBox2);
   this.Controls.Add(this.lbl_total);
   this.Controls.Add(this.textBox1);
   this.Name = "GenerarSalidaService";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Generar Salida De Service";
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.TextBox textBox1;
  private System.Windows.Forms.Label lbl_total;
  private System.Windows.Forms.TextBox textBox2;
  private System.Windows.Forms.Label lbl_detalle;
  private System.Windows.Forms.Label lbl_num_service;
  private System.Windows.Forms.TextBox txt_num_service;
  private System.Windows.Forms.Button btn_buscar;
 }
}
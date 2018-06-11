namespace TPPROG3
{
 partial class AdministrarUsuarios
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
   this.btn_agregar = new System.Windows.Forms.Button();
   this.btn_quitar = new System.Windows.Forms.Button();
   this.lbl_nombre = new System.Windows.Forms.Label();
   this.btn_realizar_cambios = new System.Windows.Forms.Button();
   this.lbl_password = new System.Windows.Forms.Label();
   this.txt_password = new System.Windows.Forms.TextBox();
   this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
   ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
   this.SuspendLayout();
   // 
   // dataGridView1
   // 
   this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
   this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dataGridView1.Location = new System.Drawing.Point(12, 106);
   this.dataGridView1.Name = "dataGridView1";
   this.dataGridView1.Size = new System.Drawing.Size(347, 325);
   this.dataGridView1.TabIndex = 0;
   // 
   // btn_agregar
   // 
   this.btn_agregar.Location = new System.Drawing.Point(155, 58);
   this.btn_agregar.Name = "btn_agregar";
   this.btn_agregar.Size = new System.Drawing.Size(204, 23);
   this.btn_agregar.TabIndex = 1;
   this.btn_agregar.Text = "Agregar Usuario";
   this.btn_agregar.UseVisualStyleBackColor = true;
   // 
   // btn_quitar
   // 
   this.btn_quitar.Location = new System.Drawing.Point(12, 437);
   this.btn_quitar.Name = "btn_quitar";
   this.btn_quitar.Size = new System.Drawing.Size(168, 23);
   this.btn_quitar.TabIndex = 2;
   this.btn_quitar.Text = "Quitar Usuario";
   this.btn_quitar.UseVisualStyleBackColor = true;
   // 
   // lbl_nombre
   // 
   this.lbl_nombre.AutoSize = true;
   this.lbl_nombre.Location = new System.Drawing.Point(9, 9);
   this.lbl_nombre.Name = "lbl_nombre";
   this.lbl_nombre.Size = new System.Drawing.Size(140, 13);
   this.lbl_nombre.TabIndex = 3;
   this.lbl_nombre.Text = "Nombre Del Nuevo Usuario:";
   // 
   // btn_realizar_cambios
   // 
   this.btn_realizar_cambios.Location = new System.Drawing.Point(186, 437);
   this.btn_realizar_cambios.Name = "btn_realizar_cambios";
   this.btn_realizar_cambios.Size = new System.Drawing.Size(173, 23);
   this.btn_realizar_cambios.TabIndex = 4;
   this.btn_realizar_cambios.Text = "Realizar Cambios";
   this.btn_realizar_cambios.UseVisualStyleBackColor = true;
   // 
   // lbl_password
   // 
   this.lbl_password.AutoSize = true;
   this.lbl_password.Location = new System.Drawing.Point(9, 35);
   this.lbl_password.Name = "lbl_password";
   this.lbl_password.Size = new System.Drawing.Size(93, 13);
   this.lbl_password.TabIndex = 5;
   this.lbl_password.Text = "Clave De Usuario:";
   // 
   // txt_password
   // 
   this.txt_password.Location = new System.Drawing.Point(155, 32);
   this.txt_password.Name = "txt_password";
   this.txt_password.Size = new System.Drawing.Size(204, 20);
   this.txt_password.TabIndex = 6;
   // 
   // txt_nombre_usuario
   // 
   this.txt_nombre_usuario.Location = new System.Drawing.Point(155, 6);
   this.txt_nombre_usuario.Name = "txt_nombre_usuario";
   this.txt_nombre_usuario.Size = new System.Drawing.Size(204, 20);
   this.txt_nombre_usuario.TabIndex = 7;
   // 
   // AdministrarUsuarios
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.DarkGray;
   this.ClientSize = new System.Drawing.Size(380, 469);
   this.Controls.Add(this.txt_nombre_usuario);
   this.Controls.Add(this.txt_password);
   this.Controls.Add(this.lbl_password);
   this.Controls.Add(this.btn_realizar_cambios);
   this.Controls.Add(this.lbl_nombre);
   this.Controls.Add(this.btn_quitar);
   this.Controls.Add(this.btn_agregar);
   this.Controls.Add(this.dataGridView1);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.MaximizeBox = false;
   this.Name = "AdministrarUsuarios";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Administrar Usuarios";
   ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.DataGridView dataGridView1;
  private System.Windows.Forms.Button btn_agregar;
  private System.Windows.Forms.Button btn_quitar;
  private System.Windows.Forms.Label lbl_nombre;
  private System.Windows.Forms.Button btn_realizar_cambios;
  private System.Windows.Forms.Label lbl_password;
  private System.Windows.Forms.TextBox txt_password;
  private System.Windows.Forms.TextBox txt_nombre_usuario;
 }
}
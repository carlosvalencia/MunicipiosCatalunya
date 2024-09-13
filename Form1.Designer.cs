
namespace MunicipiosCatalunya
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.listProvincias = new System.Windows.Forms.ListBox();
      this.listComarcas = new System.Windows.Forms.ListBox();
      this.listMunicipios = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.botTodos = new System.Windows.Forms.Button();
      this.botArtFinal = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // listProvincias
      // 
      this.listProvincias.FormattingEnabled = true;
      this.listProvincias.ItemHeight = 15;
      this.listProvincias.Location = new System.Drawing.Point(16, 27);
      this.listProvincias.Name = "listProvincias";
      this.listProvincias.Size = new System.Drawing.Size(207, 79);
      this.listProvincias.TabIndex = 0;
      this.listProvincias.SelectedIndexChanged += new System.EventHandler(this.listProvincias_SelectedIndexChanged);
      // 
      // listComarcas
      // 
      this.listComarcas.FormattingEnabled = true;
      this.listComarcas.ItemHeight = 15;
      this.listComarcas.Location = new System.Drawing.Point(16, 136);
      this.listComarcas.Name = "listComarcas";
      this.listComarcas.Size = new System.Drawing.Size(207, 199);
      this.listComarcas.TabIndex = 1;
      this.listComarcas.SelectedIndexChanged += new System.EventHandler(this.listComarcas_SelectedIndexChanged);
      // 
      // listMunicipios
      // 
      this.listMunicipios.FormattingEnabled = true;
      this.listMunicipios.ItemHeight = 15;
      this.listMunicipios.Location = new System.Drawing.Point(259, 27);
      this.listMunicipios.Name = "listMunicipios";
      this.listMunicipios.Size = new System.Drawing.Size(234, 274);
      this.listMunicipios.TabIndex = 2;
      this.listMunicipios.Click += new System.EventHandler(this.listMunicipios_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 15);
      this.label1.TabIndex = 4;
      this.label1.Text = "Provincias";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(17, 118);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 15);
      this.label2.TabIndex = 5;
      this.label2.Text = "Comarcas";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(259, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(143, 15);
      this.label3.TabIndex = 6;
      this.label3.Text = "Municipios seleccionados";
      // 
      // botTodos
      // 
      this.botTodos.Location = new System.Drawing.Point(259, 307);
      this.botTodos.Name = "botTodos";
      this.botTodos.Size = new System.Drawing.Size(234, 28);
      this.botTodos.TabIndex = 7;
      this.botTodos.Text = "Todos los municipios";
      this.botTodos.UseVisualStyleBackColor = true;
      this.botTodos.Click += new System.EventHandler(this.botTodos_Click);
      // 
      // botArtFinal
      // 
      this.botArtFinal.Location = new System.Drawing.Point(17, 341);
      this.botArtFinal.Name = "botArtFinal";
      this.botArtFinal.Size = new System.Drawing.Size(476, 28);
      this.botArtFinal.TabIndex = 8;
      this.botArtFinal.Text = "Iniciar con el artículo de nombre de municipio al final";
      this.botArtFinal.UseVisualStyleBackColor = true;
      this.botArtFinal.Click += new System.EventHandler(this.botArtFinal_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(511, 388);
      this.Controls.Add(this.botArtFinal);
      this.Controls.Add(this.botTodos);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.listMunicipios);
      this.Controls.Add(this.listComarcas);
      this.Controls.Add(this.listProvincias);
      this.Name = "Form1";
      this.Text = "Catalunya Municipios, Comarcas y Provincias";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listProvincias;
    private System.Windows.Forms.ListBox listComarcas;
    private System.Windows.Forms.ListBox listMunicipios;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button botTodos;
    private System.Windows.Forms.Button botArtFinal;
  }
}


namespace intentoTp2
{
    partial class frmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.btnAgCat = new System.Windows.Forms.Button();
            this.btnAgMar = new System.Windows.Forms.Button();
            this.btnEliMod = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(22, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(22, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(22, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Descripción:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(156, 60);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(370, 33);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(156, 100);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(370, 33);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(156, 486);
            this.txtDescripcion.MaxLength = 150;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(370, 138);
            this.txtDescripcion.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(156, 366);
            this.txtPrecio.MaxLength = 10;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(105, 33);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbCategoria.Location = new System.Drawing.Point(156, 406);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCategoria.Size = new System.Drawing.Size(159, 33);
            this.cmbCategoria.TabIndex = 5;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbMarca.Location = new System.Drawing.Point(156, 446);
            this.cmbMarca.MaxDropDownItems = 2;
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(159, 33);
            this.cmbMarca.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(225, 659);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(22, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Imagen:";
            // 
            // txtImagen
            // 
            this.txtImagen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagen.Location = new System.Drawing.Point(156, 140);
            this.txtImagen.MaxLength = 1000;
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(370, 33);
            this.txtImagen.TabIndex = 3;
            this.txtImagen.Leave += new System.EventHandler(this.txtImagen_Leave);
            // 
            // picImagen
            // 
            this.picImagen.Location = new System.Drawing.Point(156, 179);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(370, 181);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 20;
            this.picImagen.TabStop = false;
            // 
            // btnAgCat
            // 
            this.btnAgCat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgCat.BackgroundImage")));
            this.btnAgCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgCat.Location = new System.Drawing.Point(385, 406);
            this.btnAgCat.Name = "btnAgCat";
            this.btnAgCat.Size = new System.Drawing.Size(37, 33);
            this.btnAgCat.TabIndex = 21;
            this.btnAgCat.UseVisualStyleBackColor = true;
            this.btnAgCat.Click += new System.EventHandler(this.btnAgCat_Click);
            // 
            // btnAgMar
            // 
            this.btnAgMar.BackgroundImage = global::intentoTp2.Properties.Resources.agregar1;
            this.btnAgMar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgMar.Location = new System.Drawing.Point(385, 447);
            this.btnAgMar.Name = "btnAgMar";
            this.btnAgMar.Size = new System.Drawing.Size(37, 33);
            this.btnAgMar.TabIndex = 22;
            this.btnAgMar.UseVisualStyleBackColor = true;
            this.btnAgMar.Click += new System.EventHandler(this.btnAgMar_Click);
            // 
            // btnEliMod
            // 
            this.btnEliMod.Location = new System.Drawing.Point(130, 659);
            this.btnEliMod.Name = "btnEliMod";
            this.btnEliMod.Size = new System.Drawing.Size(75, 23);
            this.btnEliMod.TabIndex = 23;
            this.btnEliMod.Text = "ELIMINAR";
            this.btnEliMod.UseVisualStyleBackColor = true;
            this.btnEliMod.Visible = false;
            this.btnEliMod.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(323, 659);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::intentoTp2.Properties.Resources.fondo_primer_rojo_oscuro_tela_textura_mate_terciopelo_113767_1448;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 709);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliMod);
            this.Controls.Add(this.btnAgMar);
            this.Controls.Add(this.btnAgCat);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCTO";
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Button btnAgCat;
        private System.Windows.Forms.Button btnAgMar;
        private System.Windows.Forms.Button btnEliMod;
        private System.Windows.Forms.Button btnCancelar;
    }
}
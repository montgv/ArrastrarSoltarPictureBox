namespace ArrastrarSoltarPictureBox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBoxIzq = new System.Windows.Forms.PictureBox();
            this.picBoxDer = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIzq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDer)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxIzq
            // 
            this.picBoxIzq.Image = ((System.Drawing.Image)(resources.GetObject("picBoxIzq.Image")));
            this.picBoxIzq.Location = new System.Drawing.Point(63, 101);
            this.picBoxIzq.Name = "picBoxIzq";
            this.picBoxIzq.Size = new System.Drawing.Size(295, 337);
            this.picBoxIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIzq.TabIndex = 0;
            this.picBoxIzq.TabStop = false;
            this.picBoxIzq.DragDrop += new System.Windows.Forms.DragEventHandler(this.picBoxIzq_DragDrop);
            this.picBoxIzq.DragEnter += new System.Windows.Forms.DragEventHandler(this.picBoxIzq_DragEnter);
            this.picBoxIzq.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxIzq_MouseDown);
            // 
            // picBoxDer
            // 
            this.picBoxDer.Location = new System.Drawing.Point(488, 101);
            this.picBoxDer.Name = "picBoxDer";
            this.picBoxDer.Size = new System.Drawing.Size(304, 337);
            this.picBoxDer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDer.TabIndex = 1;
            this.picBoxDer.TabStop = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(145, 39);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(561, 32);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Mover la imagen de un pictureBox a otro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.picBoxDer);
            this.Controls.Add(this.picBoxIzq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIzq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxIzq;
        private System.Windows.Forms.PictureBox picBoxDer;
        private System.Windows.Forms.Label lbTitulo;
    }
}


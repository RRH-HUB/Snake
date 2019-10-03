namespace Snake
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
            this.components = new System.ComponentModel.Container();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.puntuacion = new System.Windows.Forms.Label();
            this.Puntos = new System.Windows.Forms.Label();
            this.bucle = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.LightCyan;
            this.Canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Canvas.InitialImage = null;
            this.Canvas.Location = new System.Drawing.Point(39, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Padding = new System.Windows.Forms.Padding(5);
            this.Canvas.Size = new System.Drawing.Size(1200, 600);
            this.Canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            // 
            // puntuacion
            // 
            this.puntuacion.AutoSize = true;
            this.puntuacion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.puntuacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.puntuacion.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacion.ForeColor = System.Drawing.Color.Red;
            this.puntuacion.Location = new System.Drawing.Point(305, 620);
            this.puntuacion.Name = "puntuacion";
            this.puntuacion.Size = new System.Drawing.Size(183, 32);
            this.puntuacion.TabIndex = 1;
            this.puntuacion.Text = "Puntuacion";
            // 
            // Puntos
            // 
            this.Puntos.AutoSize = true;
            this.Puntos.BackColor = System.Drawing.SystemColors.Highlight;
            this.Puntos.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntos.ForeColor = System.Drawing.Color.Lime;
            this.Puntos.Location = new System.Drawing.Point(520, 620);
            this.Puntos.Name = "Puntos";
            this.Puntos.Size = new System.Drawing.Size(34, 34);
            this.Puntos.TabIndex = 2;
            this.Puntos.Text = "0";
            // 
            // bucle
            // 
            this.bucle.Enabled = true;
            this.bucle.Interval = 300;
            this.bucle.Tick += new System.EventHandler(this.bucle_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.Puntos);
            this.Controls.Add(this.puntuacion);
            this.Controls.Add(this.Canvas);
            this.Name = "Form1";
            this.Text = "SNAKE!!!!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Label puntuacion;
        private System.Windows.Forms.Label Puntos;
        private System.Windows.Forms.Timer bucle;
    }
}


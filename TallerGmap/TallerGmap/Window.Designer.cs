namespace TallerGmap
{
    partial class Window
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
            this.earthquakesControl = new TallerGmap.UserControls.EarthquakesControl();
            this.gmapControl = new TallerGmap.UserControls.GmapControl();
            this.infoControl = new TallerGmap.UserControls.InfoControl();
            this.SuspendLayout();
            // 
            // earthquakesControl
            // 
            this.earthquakesControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.earthquakesControl.Location = new System.Drawing.Point(1, -1);
            this.earthquakesControl.Name = "earthquakesControl";
            this.earthquakesControl.Size = new System.Drawing.Size(252, 374);
            this.earthquakesControl.TabIndex = 0;
            // 
            // gmapControl
            // 
            this.gmapControl.Location = new System.Drawing.Point(259, -1);
            this.gmapControl.Name = "gmapControl";
            this.gmapControl.Size = new System.Drawing.Size(252, 374);
            this.gmapControl.TabIndex = 1;
            // 
            // infoControl
            // 
            this.infoControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoControl.Location = new System.Drawing.Point(503, -1);
            this.infoControl.Name = "infoControl";
            this.infoControl.Size = new System.Drawing.Size(252, 374);
            this.infoControl.TabIndex = 2;
            // 
            // Window
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(740, 374);
            this.Controls.Add(this.infoControl);
            this.Controls.Add(this.gmapControl);
            this.Controls.Add(this.earthquakesControl);
            this.Name = "Window";
            this.Text = "Earthquakes";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.EarthquakesControl earthquakesControl;
        private UserControls.GmapControl gmapControl;
        private UserControls.InfoControl infoControl;
    }
}


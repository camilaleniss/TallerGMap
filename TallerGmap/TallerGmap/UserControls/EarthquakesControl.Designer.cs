namespace TallerGmap.UserControls
{
    partial class EarthquakesControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listEarthquakes = new System.Windows.Forms.ListView();
            this.butShowmore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listEarthquakes
            // 
            this.listEarthquakes.Location = new System.Drawing.Point(0, 0);
            this.listEarthquakes.Name = "listEarthquakes";
            this.listEarthquakes.Size = new System.Drawing.Size(252, 329);
            this.listEarthquakes.TabIndex = 0;
            this.listEarthquakes.UseCompatibleStateImageBehavior = false;
            // 
            // butShowmore
            // 
            this.butShowmore.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShowmore.Location = new System.Drawing.Point(0, 336);
            this.butShowmore.Name = "butShowmore";
            this.butShowmore.Size = new System.Drawing.Size(252, 35);
            this.butShowmore.TabIndex = 1;
            this.butShowmore.Text = "More Information";
            this.butShowmore.UseVisualStyleBackColor = true;
            // 
            // EarthquakesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.butShowmore);
            this.Controls.Add(this.listEarthquakes);
            this.Name = "EarthquakesControl";
            this.Size = new System.Drawing.Size(252, 374);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listEarthquakes;
        private System.Windows.Forms.Button butShowmore;
    }
}

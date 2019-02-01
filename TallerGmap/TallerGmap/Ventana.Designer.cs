namespace TallerGmap
{
    partial class Ventana
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
            this.listData = new System.Windows.Forms.ListView();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.butShowmore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listData
            // 
            this.listData.Location = new System.Drawing.Point(0, 0);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(231, 343);
            this.listData.TabIndex = 0;
            this.listData.UseCompatibleStateImageBehavior = false;
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(227, 0);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(258, 343);
            this.gMap.TabIndex = 1;
            this.gMap.Zoom = 0D;
            // 
            // butShowmore
            // 
            this.butShowmore.Location = new System.Drawing.Point(13, 360);
            this.butShowmore.Name = "butShowmore";
            this.butShowmore.Size = new System.Drawing.Size(75, 23);
            this.butShowmore.TabIndex = 2;
            this.butShowmore.Text = "Ver más";
            this.butShowmore.UseVisualStyleBackColor = true;
            // 
            // Ventana
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(481, 395);
            this.Controls.Add(this.butShowmore);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.listData);
            this.Name = "Ventana";
            this.Text = "Earthquakes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listData;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.Button butShowmore;
    }
}


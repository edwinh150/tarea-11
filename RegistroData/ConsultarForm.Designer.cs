namespace RegistroData
{
    partial class ConsultarForm
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
            this.ResultadodataGridView = new System.Windows.Forms.DataGridView();
            this.Mostrarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultadodataGridView
            // 
            this.ResultadodataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultadodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultadodataGridView.Location = new System.Drawing.Point(12, 33);
            this.ResultadodataGridView.Name = "ResultadodataGridView";
            this.ResultadodataGridView.Size = new System.Drawing.Size(335, 274);
            this.ResultadodataGridView.TabIndex = 0;
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.Location = new System.Drawing.Point(197, 4);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Mostrarbutton.TabIndex = 1;
            this.Mostrarbutton.Text = "Mostrar";
            this.Mostrarbutton.UseVisualStyleBackColor = true;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // ConsultarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 319);
            this.Controls.Add(this.Mostrarbutton);
            this.Controls.Add(this.ResultadodataGridView);
            this.Name = "ConsultarForm";
            this.Text = "ConsultarForm";
            ((System.ComponentModel.ISupportInitialize)(this.ResultadodataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultadodataGridView;
        private System.Windows.Forms.Button Mostrarbutton;
    }
}

namespace proyectoFarmacia_v1
{
	partial class fechaHora
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
			this.components = new System.ComponentModel.Container();
			this.lblHora = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.thoraFecha = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lblHora
			// 
			this.lblHora.AutoSize = true;
			this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblHora.Location = new System.Drawing.Point(366, 386);
			this.lblHora.Name = "lblHora";
			this.lblHora.Size = new System.Drawing.Size(299, 108);
			this.lblHora.TabIndex = 0;
			this.lblHora.Text = "label1";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.lblFecha.Location = new System.Drawing.Point(418, 494);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(86, 31);
			this.lblFecha.TabIndex = 1;
			this.lblFecha.Text = "label2";
			// 
			// thoraFecha
			// 
			this.thoraFecha.Enabled = true;
			this.thoraFecha.Tick += new System.EventHandler(this.thoraFecha_Tick);
			// 
			// fechaHora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(780, 585);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.lblHora);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fechaHora";
			this.Text = "fechaHora";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHora;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Timer thoraFecha;
	}
}
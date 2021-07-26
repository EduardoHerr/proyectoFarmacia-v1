
namespace proyectoFarmacia_v1
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblIntentos = new System.Windows.Forms.Label();
			this.btnIngreso = new System.Windows.Forms.Button();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.lblIntentos);
			this.panel1.Controls.Add(this.btnIngreso);
			this.panel1.Controls.Add(this.txtPass);
			this.panel1.Controls.Add(this.txtUser);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(422, 234);
			this.panel1.TabIndex = 0;
			// 
			// lblIntentos
			// 
			this.lblIntentos.AutoSize = true;
			this.lblIntentos.Location = new System.Drawing.Point(165, 216);
			this.lblIntentos.Name = "lblIntentos";
			this.lblIntentos.Size = new System.Drawing.Size(0, 13);
			this.lblIntentos.TabIndex = 6;
			// 
			// btnIngreso
			// 
			this.btnIngreso.Location = new System.Drawing.Point(306, 193);
			this.btnIngreso.Name = "btnIngreso";
			this.btnIngreso.Size = new System.Drawing.Size(75, 23);
			this.btnIngreso.TabIndex = 5;
			this.btnIngreso.Text = "INGRESAR";
			this.btnIngreso.UseVisualStyleBackColor = true;
			this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(165, 159);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(137, 20);
			this.txtPass.TabIndex = 4;
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(165, 85);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(139, 20);
			this.txtUser.TabIndex = 3;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::proyectoFarmacia_v1.Properties.Resources.key_password_icon_142997;
			this.pictureBox2.Location = new System.Drawing.Point(89, 135);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(70, 70);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::proyectoFarmacia_v1.Properties.Resources.account_avatar_face_man_people_profile_user_icon_123197;
			this.pictureBox1.Location = new System.Drawing.Point(89, 59);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(70, 70);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(86, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(275, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "BIENVENIDO A FARMAWARE";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(445, 259);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnIngreso;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblIntentos;
	}
}
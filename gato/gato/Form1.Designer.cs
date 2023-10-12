namespace gato
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
            this.gato = new System.Windows.Forms.PictureBox();
            this.timerMovimiento = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comida = new System.Windows.Forms.PictureBox();
            this.alcohol = new System.Windows.Forms.PictureBox();
            this.barraVida = new System.Windows.Forms.ProgressBar();
            this.barraComida = new System.Windows.Forms.ProgressBar();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.comida2 = new System.Windows.Forms.PictureBox();
            this.comida1 = new System.Windows.Forms.PictureBox();
            this.comida3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alcohol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comida2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comida1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comida3)).BeginInit();
            this.SuspendLayout();
            // 
            // gato
            // 
            this.gato.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.gato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gato.Image = global::gato.Properties.Resources.picasion_com_ef5d33ca91aa21a0da41849339bb383e;
            this.gato.Location = new System.Drawing.Point(376, 256);
            this.gato.Name = "gato";
            this.gato.Size = new System.Drawing.Size(51, 46);
            this.gato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gato.TabIndex = 4;
            this.gato.TabStop = false;
            // 
            // timerMovimiento
            // 
            this.timerMovimiento.Tick += new System.EventHandler(this.timerMovimiento_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gato.Properties.Resources.agua;
            this.pictureBox1.Location = new System.Drawing.Point(150, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 25);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // comida
            // 
            this.comida.Image = global::gato.Properties.Resources._198_49_ciotola_superpremium_and_premium_2;
            this.comida.Location = new System.Drawing.Point(358, 441);
            this.comida.Name = "comida";
            this.comida.Size = new System.Drawing.Size(69, 53);
            this.comida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comida.TabIndex = 31;
            this.comida.TabStop = false;
            // 
            // alcohol
            // 
            this.alcohol.Image = global::gato.Properties.Resources.JOHNNIE_WALKER_BLUE_LABEL_75a;
            this.alcohol.Location = new System.Drawing.Point(542, 229);
            this.alcohol.Name = "alcohol";
            this.alcohol.Size = new System.Drawing.Size(61, 52);
            this.alcohol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alcohol.TabIndex = 32;
            this.alcohol.TabStop = false;
            // 
            // barraVida
            // 
            this.barraVida.Location = new System.Drawing.Point(85, 26);
            this.barraVida.Name = "barraVida";
            this.barraVida.Size = new System.Drawing.Size(100, 13);
            this.barraVida.TabIndex = 34;
            // 
            // barraComida
            // 
            this.barraComida.Location = new System.Drawing.Point(85, 51);
            this.barraComida.Name = "barraComida";
            this.barraComida.Size = new System.Drawing.Size(100, 13);
            this.barraComida.TabIndex = 35;
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(12, 51);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(34, 13);
            this.lblComida.TabIndex = 36;
            this.lblComida.Text = "Vida: ";
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Location = new System.Drawing.Point(12, 26);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(45, 13);
            this.lblVida.TabIndex = 37;
            this.lblVida.Text = "Comida:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::gato.Properties.Resources.agua;
            this.pictureBox2.Location = new System.Drawing.Point(443, 364);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 25);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::gato.Properties.Resources.agua;
            this.pictureBox3.Location = new System.Drawing.Point(443, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 25);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::gato.Properties.Resources.agua;
            this.pictureBox4.Location = new System.Drawing.Point(150, 441);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(160, 25);
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::gato.Properties.Resources.agua;
            this.pictureBox5.Location = new System.Drawing.Point(741, 441);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(160, 25);
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::gato.Properties.Resources.agua;
            this.pictureBox6.Location = new System.Drawing.Point(443, 516);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(160, 25);
            this.pictureBox6.TabIndex = 42;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::gato.Properties.Resources.agua;
            this.pictureBox7.Location = new System.Drawing.Point(150, 256);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(160, 25);
            this.pictureBox7.TabIndex = 43;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::gato.Properties.Resources.agua;
            this.pictureBox8.Location = new System.Drawing.Point(741, 256);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(160, 25);
            this.pictureBox8.TabIndex = 44;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::gato.Properties.Resources.agua;
            this.pictureBox9.Location = new System.Drawing.Point(741, 111);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(160, 25);
            this.pictureBox9.TabIndex = 45;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::gato.Properties.Resources.agua;
            this.pictureBox10.Location = new System.Drawing.Point(443, 167);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(160, 25);
            this.pictureBox10.TabIndex = 46;
            this.pictureBox10.TabStop = false;
            // 
            // comida2
            // 
            this.comida2.Image = global::gato.Properties.Resources._198_49_ciotola_superpremium_and_premium_2;
            this.comida2.Location = new System.Drawing.Point(785, 296);
            this.comida2.Name = "comida2";
            this.comida2.Size = new System.Drawing.Size(69, 53);
            this.comida2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comida2.TabIndex = 47;
            this.comida2.TabStop = false;
            // 
            // comida1
            // 
            this.comida1.Image = global::gato.Properties.Resources._198_49_ciotola_superpremium_and_premium_2;
            this.comida1.Location = new System.Drawing.Point(208, 167);
            this.comida1.Name = "comida1";
            this.comida1.Size = new System.Drawing.Size(69, 53);
            this.comida1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comida1.TabIndex = 48;
            this.comida1.TabStop = false;
            // 
            // comida3
            // 
            this.comida3.Image = global::gato.Properties.Resources._198_49_ciotola_superpremium_and_premium_2;
            this.comida3.Location = new System.Drawing.Point(604, 51);
            this.comida3.Name = "comida3";
            this.comida3.Size = new System.Drawing.Size(69, 53);
            this.comida3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comida3.TabIndex = 49;
            this.comida3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gato.Properties.Resources.cesped;
            this.ClientSize = new System.Drawing.Size(1047, 537);
            this.Controls.Add(this.comida3);
            this.Controls.Add(this.comida1);
            this.Controls.Add(this.comida2);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.lblComida);
            this.Controls.Add(this.barraComida);
            this.Controls.Add(this.barraVida);
            this.Controls.Add(this.alcohol);
            this.Controls.Add(this.comida);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alcohol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comida2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comida1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comida3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox gato;
        private System.Windows.Forms.Timer timerMovimiento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox comida;
        private System.Windows.Forms.PictureBox alcohol;
        private System.Windows.Forms.ProgressBar barraVida;
        private System.Windows.Forms.ProgressBar barraComida;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox comida2;
        private System.Windows.Forms.PictureBox comida1;
        private System.Windows.Forms.PictureBox comida3;
    }
}


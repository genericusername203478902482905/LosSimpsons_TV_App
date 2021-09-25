
namespace LosSimpsons_Random_App
{
    partial class SimpsonsTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpsonsTV));
            this.checkedListBoxTemporadas = new System.Windows.Forms.CheckedListBox();
            this.botonReproducir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cafecito = new System.Windows.Forms.LinkLabel();
            this.sideshowBob = new System.Windows.Forms.PictureBox();
            this.banner = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sideshowBob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxTemporadas
            // 
            this.checkedListBoxTemporadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.checkedListBoxTemporadas.FormattingEnabled = true;
            this.checkedListBoxTemporadas.Items.AddRange(new object[] {
            "Temporada 1",
            "Temporada 2",
            "Temporada 3",
            "Temporada 4",
            "Temporada 5",
            "Temporada 6",
            "Temporada 7",
            "Temporada 8",
            "Temporada 9",
            "Temporada 10",
            "Temporada 11",
            "Temporada 12"});
            this.checkedListBoxTemporadas.Location = new System.Drawing.Point(15, 137);
            this.checkedListBoxTemporadas.Name = "checkedListBoxTemporadas";
            this.checkedListBoxTemporadas.Size = new System.Drawing.Size(287, 268);
            this.checkedListBoxTemporadas.TabIndex = 0;
            // 
            // botonReproducir
            // 
            this.botonReproducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botonReproducir.Location = new System.Drawing.Point(330, 137);
            this.botonReproducir.Name = "botonReproducir";
            this.botonReproducir.Size = new System.Drawing.Size(216, 67);
            this.botonReproducir.TabIndex = 1;
            this.botonReproducir.Text = "Reproducir Episodio Aleatorio";
            this.botonReproducir.UseVisualStyleBackColor = true;
            this.botonReproducir.Click += new System.EventHandler(this.botonReproducir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione las temporadas que desea incluir.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(384, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "¿Disfrutando la app?\r\nComprame un cafecito :)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cafecito
            // 
            this.cafecito.AutoSize = true;
            this.cafecito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cafecito.Location = new System.Drawing.Point(349, 406);
            this.cafecito.Name = "cafecito";
            this.cafecito.Size = new System.Drawing.Size(207, 17);
            this.cafecito.TabIndex = 5;
            this.cafecito.TabStop = true;
            this.cafecito.Text = "https://cafecito.app/juancarruyo";
            this.cafecito.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cafecito_LinkClicked);
            // 
            // sideshowBob
            // 
            this.sideshowBob.Image = global::LosSimpsons_Random_App.Properties.Resources.sideshowbob;
            this.sideshowBob.Location = new System.Drawing.Point(352, 210);
            this.sideshowBob.Name = "sideshowBob";
            this.sideshowBob.Size = new System.Drawing.Size(183, 158);
            this.sideshowBob.TabIndex = 6;
            this.sideshowBob.TabStop = false;
            // 
            // banner
            // 
            this.banner.Image = global::LosSimpsons_Random_App.Properties.Resources.the_simpsons_banner_db96ea;
            this.banner.Location = new System.Drawing.Point(12, 12);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(534, 86);
            this.banner.TabIndex = 3;
            this.banner.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label3.Location = new System.Drawing.Point(10, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Los Simpsons es propiedad de Disney y todos sus distribuidores.";
            // 
            // SimpsonsTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(558, 426);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sideshowBob);
            this.Controls.Add(this.cafecito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonReproducir);
            this.Controls.Add(this.checkedListBoxTemporadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SimpsonsTV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simpsons TV (Classic)";
            this.Load += new System.EventHandler(this.SimpsonsTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sideshowBob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxTemporadas;
        private System.Windows.Forms.Button botonReproducir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel cafecito;
        private System.Windows.Forms.PictureBox sideshowBob;
        private System.Windows.Forms.Label label3;
    }
}


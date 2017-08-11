namespace PokemonRoad
{
    partial class MeetCharmander
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Attack = new System.Windows.Forms.Button();
            this.Defend = new System.Windows.Forms.Button();
            this.Super = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PokemonRoad.Properties.Resources._004;
            this.pictureBox1.Location = new System.Drawing.Point(226, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Attack
            // 
            this.Attack.BackgroundImage = global::PokemonRoad.Properties.Resources.button;
            this.Attack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Attack.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Attack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Attack.Location = new System.Drawing.Point(276, 523);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(132, 50);
            this.Attack.TabIndex = 1;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            // 
            // Defend
            // 
            this.Defend.BackgroundImage = global::PokemonRoad.Properties.Resources.button;
            this.Defend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Defend.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Defend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Defend.Location = new System.Drawing.Point(451, 523);
            this.Defend.Name = "Defend";
            this.Defend.Size = new System.Drawing.Size(132, 50);
            this.Defend.TabIndex = 2;
            this.Defend.Text = "Defend";
            this.Defend.UseVisualStyleBackColor = true;
            // 
            // Super
            // 
            this.Super.BackgroundImage = global::PokemonRoad.Properties.Resources.button;
            this.Super.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Super.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Super.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Super.Location = new System.Drawing.Point(25, 413);
            this.Super.Name = "Super";
            this.Super.Size = new System.Drawing.Size(132, 50);
            this.Super.TabIndex = 3;
            this.Super.Text = "Super";
            this.Super.UseVisualStyleBackColor = true;
            // 
            // MeetCharmander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonRoad.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(789, 599);
            this.Controls.Add(this.Super);
            this.Controls.Add(this.Defend);
            this.Controls.Add(this.Attack);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MeetCharmander";
            this.Text = "MeetCharmander";
            this.Load += new System.EventHandler(this.MeetCharmander_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.Button Defend;
        private System.Windows.Forms.Button Super;
    }
}
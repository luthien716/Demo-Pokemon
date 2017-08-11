namespace PokemonRoad
{
    partial class MeetBulbasaur
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
            this.EnemyHp = new System.Windows.Forms.Label();
            this.SelfHp = new System.Windows.Forms.Label();
            this.Super = new System.Windows.Forms.Button();
            this.Attack = new System.Windows.Forms.Button();
            this.Defend = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EnemyHp
            // 
            this.EnemyHp.AutoSize = true;
            this.EnemyHp.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHp.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.EnemyHp.ForeColor = System.Drawing.SystemColors.Control;
            this.EnemyHp.Location = new System.Drawing.Point(214, 21);
            this.EnemyHp.Name = "EnemyHp";
            this.EnemyHp.Size = new System.Drawing.Size(275, 69);
            this.EnemyHp.TabIndex = 0;
            this.EnemyHp.Text = "EnemyHp";
            // 
            // SelfHp
            // 
            this.SelfHp.AutoSize = true;
            this.SelfHp.BackColor = System.Drawing.Color.Transparent;
            this.SelfHp.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.SelfHp.ForeColor = System.Drawing.SystemColors.Control;
            this.SelfHp.Location = new System.Drawing.Point(214, 456);
            this.SelfHp.Name = "SelfHp";
            this.SelfHp.Size = new System.Drawing.Size(198, 69);
            this.SelfHp.TabIndex = 1;
            this.SelfHp.Text = "SelfHp";
            // 
            // Super
            // 
            this.Super.BackgroundImage = global::PokemonRoad.Properties.Resources.button;
            this.Super.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Super.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Super.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Super.Location = new System.Drawing.Point(48, 446);
            this.Super.Name = "Super";
            this.Super.Size = new System.Drawing.Size(123, 52);
            this.Super.TabIndex = 2;
            this.Super.Text = "Super";
            this.Super.UseVisualStyleBackColor = true;
            this.Super.Click += new System.EventHandler(this.Super_Click);
            // 
            // Attack
            // 
            this.Attack.BackColor = System.Drawing.Color.Transparent;
            this.Attack.BackgroundImage = global::PokemonRoad.Properties.Resources.button;
            this.Attack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Attack.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Attack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Attack.Location = new System.Drawing.Point(240, 522);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(123, 52);
            this.Attack.TabIndex = 3;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = false;
            this.Attack.Click += new System.EventHandler(this.Attack_Click);
            // 
            // Defend
            // 
            this.Defend.BackgroundImage = global::PokemonRoad.Properties.Resources.button;
            this.Defend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Defend.Cursor = System.Windows.Forms.Cursors.Default;
            this.Defend.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Defend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Defend.Location = new System.Drawing.Point(404, 522);
            this.Defend.Name = "Defend";
            this.Defend.Size = new System.Drawing.Size(123, 52);
            this.Defend.TabIndex = 4;
            this.Defend.Text = "Defend";
            this.Defend.UseVisualStyleBackColor = true;
            this.Defend.Click += new System.EventHandler(this.Defend_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PokemonRoad.Properties.Resources._001;
            this.pictureBox1.Location = new System.Drawing.Point(198, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 377);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MeetBulbasaur
            // 
            this.BackgroundImage = global::PokemonRoad.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(789, 599);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Defend);
            this.Controls.Add(this.Attack);
            this.Controls.Add(this.Super);
            this.Controls.Add(this.SelfHp);
            this.Controls.Add(this.EnemyHp);
            this.Name = "MeetBulbasaur";
            this.Load += new System.EventHandler(this.MeetBulbasaur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label EnemyHp;
        private System.Windows.Forms.Label SelfHp;
        private System.Windows.Forms.Button Super;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.Button Defend;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
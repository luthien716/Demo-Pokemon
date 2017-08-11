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
            this.SuspendLayout();
            // 
            // EnemyHp
            // 
            this.EnemyHp.AutoSize = true;
            this.EnemyHp.Location = new System.Drawing.Point(260, 27);
            this.EnemyHp.Name = "EnemyHp";
            this.EnemyHp.Size = new System.Drawing.Size(64, 24);
            this.EnemyHp.TabIndex = 0;
            this.EnemyHp.Text = "label1";
            // 
            // SelfHp
            // 
            this.SelfHp.AutoSize = true;
            this.SelfHp.Location = new System.Drawing.Point(260, 462);
            this.SelfHp.Name = "SelfHp";
            this.SelfHp.Size = new System.Drawing.Size(64, 24);
            this.SelfHp.TabIndex = 1;
            this.SelfHp.Text = "label1";
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
            this.Attack.BackgroundImage = global::PokemonRoad.Properties.Resources.button;
            this.Attack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Attack.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Attack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Attack.Location = new System.Drawing.Point(240, 522);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(123, 52);
            this.Attack.TabIndex = 3;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
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
            // MeetBulbasaur
            // 
            this.BackgroundImage = global::PokemonRoad.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(789, 599);
            this.Controls.Add(this.Defend);
            this.Controls.Add(this.Attack);
            this.Controls.Add(this.Super);
            this.Controls.Add(this.SelfHp);
            this.Controls.Add(this.EnemyHp);
            this.Name = "MeetBulbasaur";
            this.Load += new System.EventHandler(this.MeetBulbasaur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label EnemyHp;
        private System.Windows.Forms.Label SelfHp;
        private System.Windows.Forms.Button Super;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.Button Defend;
    }
}
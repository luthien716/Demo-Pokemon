namespace PokemonRoad
{
    partial class PokemonRoad
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PalletTown = new System.Windows.Forms.Button();
            this.ViridianCity = new System.Windows.Forms.Button();
            this.PewterCity = new System.Windows.Forms.Button();
            this.MtMoon = new System.Windows.Forms.Button();
            this.CeruleanCity = new System.Windows.Forms.Button();
            this.VermilionCity = new System.Windows.Forms.Button();
            this.CurrentStage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PalletTown
            // 
            this.PalletTown.BackColor = System.Drawing.Color.Transparent;
            this.PalletTown.FlatAppearance.BorderSize = 0;
            this.PalletTown.Image = global::PokemonRoad.Properties.Resources.PalletTown;
            this.PalletTown.Location = new System.Drawing.Point(277, 330);
            this.PalletTown.Name = "PalletTown";
            this.PalletTown.Size = new System.Drawing.Size(90, 90);
            this.PalletTown.TabIndex = 0;
            this.PalletTown.UseVisualStyleBackColor = false;
            this.PalletTown.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViridianCity
            // 
            this.ViridianCity.BackColor = System.Drawing.Color.Transparent;
            this.ViridianCity.FlatAppearance.BorderSize = 0;
            this.ViridianCity.Image = global::PokemonRoad.Properties.Resources.ViridianCity;
            this.ViridianCity.Location = new System.Drawing.Point(277, 216);
            this.ViridianCity.Name = "ViridianCity";
            this.ViridianCity.Size = new System.Drawing.Size(90, 90);
            this.ViridianCity.TabIndex = 1;
            this.ViridianCity.UseVisualStyleBackColor = false;
            // 
            // PewterCity
            // 
            this.PewterCity.BackColor = System.Drawing.Color.Transparent;
            this.PewterCity.BackgroundImage = global::PokemonRoad.Properties.Resources.PewterCity;
            this.PewterCity.FlatAppearance.BorderSize = 0;
            this.PewterCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PewterCity.Location = new System.Drawing.Point(277, 81);
            this.PewterCity.Name = "PewterCity";
            this.PewterCity.Size = new System.Drawing.Size(90, 90);
            this.PewterCity.TabIndex = 2;
            this.PewterCity.UseVisualStyleBackColor = false;
            // 
            // MtMoon
            // 
            this.MtMoon.BackColor = System.Drawing.Color.Transparent;
            this.MtMoon.BackgroundImage = global::PokemonRoad.Properties.Resources.MtMoon;
            this.MtMoon.FlatAppearance.BorderSize = 0;
            this.MtMoon.Location = new System.Drawing.Point(435, 81);
            this.MtMoon.Name = "MtMoon";
            this.MtMoon.Size = new System.Drawing.Size(90, 90);
            this.MtMoon.TabIndex = 3;
            this.MtMoon.UseVisualStyleBackColor = false;
            // 
            // CeruleanCity
            // 
            this.CeruleanCity.BackColor = System.Drawing.Color.Transparent;
            this.CeruleanCity.BackgroundImage = global::PokemonRoad.Properties.Resources.CeruleanCity;
            this.CeruleanCity.FlatAppearance.BorderSize = 0;
            this.CeruleanCity.Location = new System.Drawing.Point(584, 81);
            this.CeruleanCity.Name = "CeruleanCity";
            this.CeruleanCity.Size = new System.Drawing.Size(90, 90);
            this.CeruleanCity.TabIndex = 4;
            this.CeruleanCity.UseVisualStyleBackColor = false;
            // 
            // VermilionCity
            // 
            this.VermilionCity.BackColor = System.Drawing.Color.Transparent;
            this.VermilionCity.BackgroundImage = global::PokemonRoad.Properties.Resources.VermilionCity;
            this.VermilionCity.FlatAppearance.BorderSize = 0;
            this.VermilionCity.Image = global::PokemonRoad.Properties.Resources.PalletTown;
            this.VermilionCity.Location = new System.Drawing.Point(584, 216);
            this.VermilionCity.Name = "VermilionCity";
            this.VermilionCity.Size = new System.Drawing.Size(90, 90);
            this.VermilionCity.TabIndex = 5;
            this.VermilionCity.UseVisualStyleBackColor = false;
            // 
            // CurrentStage
            // 
            this.CurrentStage.AutoSize = true;
            this.CurrentStage.BackColor = System.Drawing.Color.Transparent;
            this.CurrentStage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CurrentStage.Location = new System.Drawing.Point(165, 9);
            this.CurrentStage.Name = "CurrentStage";
            this.CurrentStage.Size = new System.Drawing.Size(81, 30);
            this.CurrentStage.TabIndex = 6;
            this.CurrentStage.Text = "label1";
            // 
            // PokemonRoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PokemonRoad.Properties.Resources.StageMap;
            this.ClientSize = new System.Drawing.Size(789, 599);
            this.Controls.Add(this.CurrentStage);
            this.Controls.Add(this.VermilionCity);
            this.Controls.Add(this.CeruleanCity);
            this.Controls.Add(this.MtMoon);
            this.Controls.Add(this.PewterCity);
            this.Controls.Add(this.ViridianCity);
            this.Controls.Add(this.PalletTown);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PokemonRoad";
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.PokemonRoad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PalletTown;
        private System.Windows.Forms.Button ViridianCity;
        private System.Windows.Forms.Button PewterCity;
        private System.Windows.Forms.Button MtMoon;
        private System.Windows.Forms.Button CeruleanCity;
        private System.Windows.Forms.Button VermilionCity;
        private System.Windows.Forms.Label CurrentStage;
    }
}


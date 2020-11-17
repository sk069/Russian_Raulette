namespace Russian_Raulette
{
    partial class gameForm
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
            this.image_display = new System.Windows.Forms.PictureBox();
            this.load_button = new System.Windows.Forms.Button();
            this.spin_button = new System.Windows.Forms.Button();
            this.shoot_button = new System.Windows.Forms.Button();
            this.shootaway_button = new System.Windows.Forms.Button();
            this.playagain_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image_display)).BeginInit();
            this.SuspendLayout();
            // 
            // image_display
            // 
            this.image_display.Location = new System.Drawing.Point(165, 23);
            this.image_display.Name = "image_display";
            this.image_display.Size = new System.Drawing.Size(438, 215);
            this.image_display.TabIndex = 0;
            this.image_display.TabStop = false;
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(43, 297);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(75, 23);
            this.load_button.TabIndex = 1;
            this.load_button.Text = "LOAD";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // spin_button
            // 
            this.spin_button.Location = new System.Drawing.Point(181, 297);
            this.spin_button.Name = "spin_button";
            this.spin_button.Size = new System.Drawing.Size(75, 23);
            this.spin_button.TabIndex = 2;
            this.spin_button.Text = "SPIN";
            this.spin_button.UseVisualStyleBackColor = true;
            this.spin_button.Click += new System.EventHandler(this.spin_button_Click);
            // 
            // shoot_button
            // 
            this.shoot_button.Location = new System.Drawing.Point(312, 296);
            this.shoot_button.Name = "shoot_button";
            this.shoot_button.Size = new System.Drawing.Size(75, 23);
            this.shoot_button.TabIndex = 3;
            this.shoot_button.Text = "SHOOT";
            this.shoot_button.UseVisualStyleBackColor = true;
            this.shoot_button.Click += new System.EventHandler(this.shoot_button_Click);
            // 
            // shootaway_button
            // 
            this.shootaway_button.Location = new System.Drawing.Point(454, 296);
            this.shootaway_button.Name = "shootaway_button";
            this.shootaway_button.Size = new System.Drawing.Size(121, 23);
            this.shootaway_button.TabIndex = 4;
            this.shootaway_button.Text = "SHOOT AWAY";
            this.shootaway_button.UseVisualStyleBackColor = true;
            this.shootaway_button.Click += new System.EventHandler(this.shootaway_button_Click);
            // 
            // playagain_button
            // 
            this.playagain_button.Location = new System.Drawing.Point(540, 397);
            this.playagain_button.Name = "playagain_button";
            this.playagain_button.Size = new System.Drawing.Size(108, 23);
            this.playagain_button.TabIndex = 5;
            this.playagain_button.Text = "PLAY AGAIN";
            this.playagain_button.UseVisualStyleBackColor = true;
            this.playagain_button.Click += new System.EventHandler(this.playagain_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(690, 397);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "EXIT";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Russian_Raulette.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.playagain_button);
            this.Controls.Add(this.shootaway_button);
            this.Controls.Add(this.shoot_button);
            this.Controls.Add(this.spin_button);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.image_display);
            this.Name = "gameForm";
            this.Text = "Russian Raulette Game";
            ((System.ComponentModel.ISupportInitialize)(this.image_display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox image_display;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button spin_button;
        private System.Windows.Forms.Button shoot_button;
        private System.Windows.Forms.Button shootaway_button;
        private System.Windows.Forms.Button playagain_button;
        private System.Windows.Forms.Button exit_button;
    }
}


namespace Sonic_Randomizer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_romselect = new System.Windows.Forms.TextBox();
            this.btn_romselect = new System.Windows.Forms.Button();
            this.btn_randomize = new System.Windows.Forms.Button();
            this.cb_game = new System.Windows.Forms.ComboBox();
            this.openFile_Rom = new System.Windows.Forms.OpenFileDialog();
            this.radio_SFX_Random = new System.Windows.Forms.RadioButton();
            this.radio_SFX_Same = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_SFX_None = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_Music_None = new System.Windows.Forms.RadioButton();
            this.radio_Music_Random = new System.Windows.Forms.RadioButton();
            this.radio_Music_Same = new System.Windows.Forms.RadioButton();
            this.chk_rings = new System.Windows.Forms.CheckBox();
            this.chk_checksum = new System.Windows.Forms.CheckBox();
            this.chk_objects = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_palets = new System.Windows.Forms.CheckBox();
            this.chk_paletCycle = new System.Windows.Forms.CheckBox();
            this.chk_levelselect = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chk_monitors = new System.Windows.Forms.CheckBox();
            this.chk_intro = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chk_lifes = new System.Windows.Forms.CheckBox();
            this.chk_SSonicRingFix = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_SSonicRings = new System.Windows.Forms.NumericUpDown();
            this.chk_SSonicMusic = new System.Windows.Forms.CheckBox();
            this.chk_debug = new System.Windows.Forms.CheckBox();
            this.chk_superSonic = new System.Windows.Forms.CheckBox();
            this.cb_lockon = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SSonicRings)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_romselect
            // 
            this.txt_romselect.AllowDrop = true;
            this.txt_romselect.Location = new System.Drawing.Point(16, 15);
            this.txt_romselect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_romselect.Name = "txt_romselect";
            this.txt_romselect.Size = new System.Drawing.Size(281, 22);
            this.txt_romselect.TabIndex = 2;
            this.txt_romselect.TextChanged += new System.EventHandler(this.txt_romselect_TextChanged);
            // 
            // btn_romselect
            // 
            this.btn_romselect.Location = new System.Drawing.Point(307, 12);
            this.btn_romselect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_romselect.Name = "btn_romselect";
            this.btn_romselect.Size = new System.Drawing.Size(76, 28);
            this.btn_romselect.TabIndex = 3;
            this.btn_romselect.Text = "...";
            this.btn_romselect.UseVisualStyleBackColor = true;
            this.btn_romselect.Click += new System.EventHandler(this.btn_romselect_Click);
            // 
            // btn_randomize
            // 
            this.btn_randomize.Location = new System.Drawing.Point(16, 421);
            this.btn_randomize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_randomize.Name = "btn_randomize";
            this.btn_randomize.Size = new System.Drawing.Size(367, 28);
            this.btn_randomize.TabIndex = 4;
            this.btn_randomize.Text = "Randomize";
            this.btn_randomize.UseVisualStyleBackColor = true;
            this.btn_randomize.Click += new System.EventHandler(this.btn_randomize_Click);
            // 
            // cb_game
            // 
            this.cb_game.FormattingEnabled = true;
            this.cb_game.Items.AddRange(new object[] {
            "Sonic",
            "Sonic 2 (Rev1)",
            "Sonic 3"});
            this.cb_game.Location = new System.Drawing.Point(16, 47);
            this.cb_game.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_game.Name = "cb_game";
            this.cb_game.Size = new System.Drawing.Size(195, 24);
            this.cb_game.TabIndex = 5;
            this.cb_game.SelectedIndexChanged += new System.EventHandler(this.cb_game_SelectedIndexChanged);
            // 
            // openFile_Rom
            // 
            this.openFile_Rom.FileName = "openFileDialog1";
            // 
            // radio_SFX_Random
            // 
            this.radio_SFX_Random.AutoSize = true;
            this.radio_SFX_Random.Location = new System.Drawing.Point(7, 52);
            this.radio_SFX_Random.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_SFX_Random.Name = "radio_SFX_Random";
            this.radio_SFX_Random.Size = new System.Drawing.Size(78, 20);
            this.radio_SFX_Random.TabIndex = 6;
            this.radio_SFX_Random.TabStop = true;
            this.radio_SFX_Random.Text = "Random";
            this.radio_SFX_Random.UseVisualStyleBackColor = true;
            this.radio_SFX_Random.CheckedChanged += new System.EventHandler(this.radio_SFX_Random_CheckedChanged);
            // 
            // radio_SFX_Same
            // 
            this.radio_SFX_Same.AutoSize = true;
            this.radio_SFX_Same.Location = new System.Drawing.Point(7, 80);
            this.radio_SFX_Same.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_SFX_Same.Name = "radio_SFX_Same";
            this.radio_SFX_Same.Size = new System.Drawing.Size(62, 20);
            this.radio_SFX_Same.TabIndex = 7;
            this.radio_SFX_Same.TabStop = true;
            this.radio_SFX_Same.Text = "Same";
            this.radio_SFX_Same.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_SFX_None);
            this.groupBox1.Controls.Add(this.radio_SFX_Random);
            this.groupBox1.Controls.Add(this.radio_SFX_Same);
            this.groupBox1.Location = new System.Drawing.Point(16, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(169, 113);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SFX";
            // 
            // radio_SFX_None
            // 
            this.radio_SFX_None.AutoSize = true;
            this.radio_SFX_None.Location = new System.Drawing.Point(8, 23);
            this.radio_SFX_None.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_SFX_None.Name = "radio_SFX_None";
            this.radio_SFX_None.Size = new System.Drawing.Size(59, 20);
            this.radio_SFX_None.TabIndex = 8;
            this.radio_SFX_None.TabStop = true;
            this.radio_SFX_None.Text = "None";
            this.radio_SFX_None.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_Music_None);
            this.groupBox2.Controls.Add(this.radio_Music_Random);
            this.groupBox2.Controls.Add(this.radio_Music_Same);
            this.groupBox2.Location = new System.Drawing.Point(213, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(169, 113);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Music";
            // 
            // radio_Music_None
            // 
            this.radio_Music_None.AutoSize = true;
            this.radio_Music_None.Location = new System.Drawing.Point(8, 23);
            this.radio_Music_None.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_Music_None.Name = "radio_Music_None";
            this.radio_Music_None.Size = new System.Drawing.Size(59, 20);
            this.radio_Music_None.TabIndex = 8;
            this.radio_Music_None.TabStop = true;
            this.radio_Music_None.Text = "None";
            this.radio_Music_None.UseVisualStyleBackColor = true;
            // 
            // radio_Music_Random
            // 
            this.radio_Music_Random.AutoSize = true;
            this.radio_Music_Random.Location = new System.Drawing.Point(7, 52);
            this.radio_Music_Random.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_Music_Random.Name = "radio_Music_Random";
            this.radio_Music_Random.Size = new System.Drawing.Size(78, 20);
            this.radio_Music_Random.TabIndex = 6;
            this.radio_Music_Random.TabStop = true;
            this.radio_Music_Random.Text = "Random";
            this.radio_Music_Random.UseVisualStyleBackColor = true;
            // 
            // radio_Music_Same
            // 
            this.radio_Music_Same.AutoSize = true;
            this.radio_Music_Same.Location = new System.Drawing.Point(7, 80);
            this.radio_Music_Same.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_Music_Same.Name = "radio_Music_Same";
            this.radio_Music_Same.Size = new System.Drawing.Size(62, 20);
            this.radio_Music_Same.TabIndex = 7;
            this.radio_Music_Same.TabStop = true;
            this.radio_Music_Same.Text = "Same";
            this.radio_Music_Same.UseVisualStyleBackColor = true;
            // 
            // chk_rings
            // 
            this.chk_rings.AutoSize = true;
            this.chk_rings.Location = new System.Drawing.Point(16, 23);
            this.chk_rings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_rings.Name = "chk_rings";
            this.chk_rings.Size = new System.Drawing.Size(112, 20);
            this.chk_rings.TabIndex = 10;
            this.chk_rings.Text = "Rings Layouts";
            this.chk_rings.UseVisualStyleBackColor = true;
            // 
            // chk_checksum
            // 
            this.chk_checksum.AutoSize = true;
            this.chk_checksum.Location = new System.Drawing.Point(8, 25);
            this.chk_checksum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_checksum.Name = "chk_checksum";
            this.chk_checksum.Size = new System.Drawing.Size(173, 20);
            this.chk_checksum.TabIndex = 11;
            this.chk_checksum.Text = "Bypass ROM Checksum";
            this.chk_checksum.UseVisualStyleBackColor = true;
            // 
            // chk_objects
            // 
            this.chk_objects.AutoSize = true;
            this.chk_objects.Location = new System.Drawing.Point(8, 22);
            this.chk_objects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_objects.Name = "chk_objects";
            this.chk_objects.Size = new System.Drawing.Size(123, 20);
            this.chk_objects.TabIndex = 12;
            this.chk_objects.Text = "Objects Layouts";
            this.chk_objects.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_palets);
            this.groupBox3.Controls.Add(this.chk_paletCycle);
            this.groupBox3.Controls.Add(this.chk_objects);
            this.groupBox3.Location = new System.Drawing.Point(557, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(221, 182);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "WARNING!";
            // 
            // chk_palets
            // 
            this.chk_palets.AutoSize = true;
            this.chk_palets.Location = new System.Drawing.Point(8, 79);
            this.chk_palets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_palets.Name = "chk_palets";
            this.chk_palets.Size = new System.Drawing.Size(121, 20);
            this.chk_palets.TabIndex = 11;
            this.chk_palets.Text = "Graphics palets";
            this.chk_palets.UseVisualStyleBackColor = true;
            // 
            // chk_paletCycle
            // 
            this.chk_paletCycle.AutoSize = true;
            this.chk_paletCycle.Location = new System.Drawing.Point(8, 50);
            this.chk_paletCycle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_paletCycle.Name = "chk_paletCycle";
            this.chk_paletCycle.Size = new System.Drawing.Size(138, 20);
            this.chk_paletCycle.TabIndex = 11;
            this.chk_paletCycle.Text = "Levels Palet Cycle";
            this.chk_paletCycle.UseVisualStyleBackColor = true;
            // 
            // chk_levelselect
            // 
            this.chk_levelselect.AutoSize = true;
            this.chk_levelselect.Location = new System.Drawing.Point(8, 53);
            this.chk_levelselect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_levelselect.Name = "chk_levelselect";
            this.chk_levelselect.Size = new System.Drawing.Size(101, 20);
            this.chk_levelselect.TabIndex = 0;
            this.chk_levelselect.Text = "Level Select";
            this.chk_levelselect.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chk_monitors);
            this.groupBox5.Controls.Add(this.chk_rings);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Location = new System.Drawing.Point(16, 201);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(787, 213);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Level Randomizer";
            // 
            // chk_monitors
            // 
            this.chk_monitors.AutoSize = true;
            this.chk_monitors.Location = new System.Drawing.Point(16, 52);
            this.chk_monitors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_monitors.Name = "chk_monitors";
            this.chk_monitors.Size = new System.Drawing.Size(114, 20);
            this.chk_monitors.TabIndex = 14;
            this.chk_monitors.Text = "Monitors Effect";
            this.chk_monitors.UseVisualStyleBackColor = true;
            // 
            // chk_intro
            // 
            this.chk_intro.AutoSize = true;
            this.chk_intro.Location = new System.Drawing.Point(255, 23);
            this.chk_intro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_intro.Name = "chk_intro";
            this.chk_intro.Size = new System.Drawing.Size(122, 20);
            this.chk_intro.TabIndex = 1;
            this.chk_intro.Text = "Game Intro Skip";
            this.chk_intro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_intro.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chk_lifes);
            this.groupBox6.Controls.Add(this.chk_SSonicRingFix);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.num_SSonicRings);
            this.groupBox6.Controls.Add(this.chk_SSonicMusic);
            this.groupBox6.Controls.Add(this.chk_debug);
            this.groupBox6.Controls.Add(this.chk_superSonic);
            this.groupBox6.Controls.Add(this.chk_levelselect);
            this.groupBox6.Controls.Add(this.chk_checksum);
            this.groupBox6.Controls.Add(this.chk_intro);
            this.groupBox6.Location = new System.Drawing.Point(391, 15);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(412, 178);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fixes";
            // 
            // chk_lifes
            // 
            this.chk_lifes.AutoSize = true;
            this.chk_lifes.Location = new System.Drawing.Point(8, 150);
            this.chk_lifes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_lifes.Name = "chk_lifes";
            this.chk_lifes.Size = new System.Drawing.Size(95, 20);
            this.chk_lifes.TabIndex = 18;
            this.chk_lifes.Text = "Infinite Lifes";
            this.chk_lifes.UseVisualStyleBackColor = true;
            // 
            // chk_SSonicRingFix
            // 
            this.chk_SSonicRingFix.AutoSize = true;
            this.chk_SSonicRingFix.Location = new System.Drawing.Point(255, 110);
            this.chk_SSonicRingFix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_SSonicRingFix.Name = "chk_SSonicRingFix";
            this.chk_SSonicRingFix.Size = new System.Drawing.Size(144, 20);
            this.chk_SSonicRingFix.TabIndex = 17;
            this.chk_SSonicRingFix.Text = "SSonic Fixed Rings";
            this.chk_SSonicRingFix.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "SSonic Rings:";
            // 
            // num_SSonicRings
            // 
            this.num_SSonicRings.Location = new System.Drawing.Point(319, 146);
            this.num_SSonicRings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num_SSonicRings.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_SSonicRings.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_SSonicRings.Name = "num_SSonicRings";
            this.num_SSonicRings.Size = new System.Drawing.Size(85, 22);
            this.num_SSonicRings.TabIndex = 15;
            this.num_SSonicRings.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // chk_SSonicMusic
            // 
            this.chk_SSonicMusic.AutoSize = true;
            this.chk_SSonicMusic.Location = new System.Drawing.Point(255, 81);
            this.chk_SSonicMusic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_SSonicMusic.Name = "chk_SSonicMusic";
            this.chk_SSonicMusic.Size = new System.Drawing.Size(129, 20);
            this.chk_SSonicMusic.TabIndex = 14;
            this.chk_SSonicMusic.Text = "No SSonic Music";
            this.chk_SSonicMusic.UseVisualStyleBackColor = true;
            // 
            // chk_debug
            // 
            this.chk_debug.AutoSize = true;
            this.chk_debug.Location = new System.Drawing.Point(8, 81);
            this.chk_debug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_debug.Name = "chk_debug";
            this.chk_debug.Size = new System.Drawing.Size(106, 20);
            this.chk_debug.TabIndex = 13;
            this.chk_debug.Text = "Debug Mode";
            this.chk_debug.UseVisualStyleBackColor = true;
            // 
            // chk_superSonic
            // 
            this.chk_superSonic.AutoSize = true;
            this.chk_superSonic.Location = new System.Drawing.Point(255, 53);
            this.chk_superSonic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_superSonic.Name = "chk_superSonic";
            this.chk_superSonic.Size = new System.Drawing.Size(100, 20);
            this.chk_superSonic.TabIndex = 12;
            this.chk_superSonic.Text = "Super Sonic";
            this.chk_superSonic.UseVisualStyleBackColor = true;
            // 
            // cb_lockon
            // 
            this.cb_lockon.AutoSize = true;
            this.cb_lockon.Location = new System.Drawing.Point(219, 49);
            this.cb_lockon.Margin = new System.Windows.Forms.Padding(4);
            this.cb_lockon.Name = "cb_lockon";
            this.cb_lockon.Size = new System.Drawing.Size(143, 20);
            this.cb_lockon.TabIndex = 19;
            this.cb_lockon.Text = "Knuckles \"Lock On\"";
            this.cb_lockon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 464);
            this.Controls.Add(this.cb_lockon);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_game);
            this.Controls.Add(this.btn_randomize);
            this.Controls.Add(this.btn_romselect);
            this.Controls.Add(this.txt_romselect);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Sonic Randomizer 0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.form_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.form_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SSonicRings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_romselect;
        private System.Windows.Forms.Button btn_romselect;
        private System.Windows.Forms.Button btn_randomize;
        private System.Windows.Forms.ComboBox cb_game;
        private System.Windows.Forms.OpenFileDialog openFile_Rom;
        private System.Windows.Forms.RadioButton radio_SFX_Random;
        private System.Windows.Forms.RadioButton radio_SFX_Same;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_SFX_None;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_Music_None;
        private System.Windows.Forms.RadioButton radio_Music_Random;
        private System.Windows.Forms.RadioButton radio_Music_Same;
        private System.Windows.Forms.CheckBox chk_rings;
        private System.Windows.Forms.CheckBox chk_checksum;
        private System.Windows.Forms.CheckBox chk_objects;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_levelselect;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chk_intro;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chk_paletCycle;
        private System.Windows.Forms.CheckBox chk_palets;
        private System.Windows.Forms.CheckBox chk_superSonic;
        private System.Windows.Forms.CheckBox chk_debug;
        private System.Windows.Forms.CheckBox chk_monitors;
        private System.Windows.Forms.CheckBox chk_SSonicMusic;
        private System.Windows.Forms.NumericUpDown num_SSonicRings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_SSonicRingFix;
        private System.Windows.Forms.CheckBox chk_lifes;
        private System.Windows.Forms.CheckBox cb_lockon;
    }
}


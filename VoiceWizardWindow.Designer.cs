namespace TTSWizardFree
{
    partial class VoiceWizardWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoiceWizardWindow));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxErase = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDelayHere = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.logClearButton = new System.Windows.Forms.Button();
            this.speechTTSButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.hideVRCTextButton = new System.Windows.Forms.Button();
            this.TTSButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBoxErase);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBoxDelay);
            this.tabPage2.Controls.Add(this.checkBox6);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.buttonDelayHere);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.checkBox3.Location = new System.Drawing.Point(22, 147);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(125, 24);
            this.checkBox3.TabIndex = 47;
            this.checkBox3.Text = "Voice Enabled";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "After changing output device in settings you must click this button (or restart a" +
    "pp)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Update Output Device";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 44;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 43;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // textBoxErase
            // 
            this.textBoxErase.Location = new System.Drawing.Point(26, 286);
            this.textBoxErase.Name = "textBoxErase";
            this.textBoxErase.Size = new System.Drawing.Size(125, 27);
            this.textBoxErase.TabIndex = 42;
            this.textBoxErase.Text = "5000";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(26, 205);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 33;
            this.textBox4.Text = "Ctrl + G";
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Location = new System.Drawing.Point(26, 35);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(125, 27);
            this.textBoxDelay.TabIndex = 24;
            this.textBoxDelay.Text = "250";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.checkBox6.Location = new System.Drawing.Point(26, 256);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(206, 24);
            this.checkBox6.TabIndex = 41;
            this.checkBox6.Text = "Hide Text After Delay (ms)";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(22, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(291, 24);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Send OSC Messages to VRC Avatar Text";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(22, 87);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(190, 24);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "Output Transcript in Log";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(157, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Unchangeable";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(22, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "STTTS Shortcut";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(22, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Delay Debug (ms)";
            // 
            // buttonDelayHere
            // 
            this.buttonDelayHere.Location = new System.Drawing.Point(157, 33);
            this.buttonDelayHere.Name = "buttonDelayHere";
            this.buttonDelayHere.Size = new System.Drawing.Size(94, 29);
            this.buttonDelayHere.TabIndex = 26;
            this.buttonDelayHere.Text = "Change";
            this.buttonDelayHere.UseVisualStyleBackColor = true;
            this.buttonDelayHere.Click += new System.EventHandler(this.buttonDelayHere_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.logClearButton);
            this.tabPage1.Controls.Add(this.speechTTSButton);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.hideVRCTextButton);
            this.tabPage1.Controls.Add(this.TTSButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Spoken Language";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "en-GB",
            "en-US",
            "de-DE",
            "es-ES",
            "fr-FR",
            "ja-JP",
            "zh-CN",
            "zh-TW"});
            this.comboBox1.Location = new System.Drawing.Point(28, 397);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 28);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Tag = "Sara";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 38);
            this.button2.TabIndex = 19;
            this.button2.Text = "Clear Text";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(28, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(354, 158);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "Read this aloud.";
            // 
            // logClearButton
            // 
            this.logClearButton.Location = new System.Drawing.Point(389, 132);
            this.logClearButton.Name = "logClearButton";
            this.logClearButton.Size = new System.Drawing.Size(93, 38);
            this.logClearButton.TabIndex = 17;
            this.logClearButton.Text = "Clear Log";
            this.logClearButton.UseVisualStyleBackColor = true;
            this.logClearButton.Click += new System.EventHandler(this.logClearButton_Click);
            // 
            // speechTTSButton
            // 
            this.speechTTSButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.speechTTSButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.speechTTSButton.Location = new System.Drawing.Point(28, 185);
            this.speechTTSButton.Name = "speechTTSButton";
            this.speechTTSButton.Size = new System.Drawing.Size(453, 129);
            this.speechTTSButton.TabIndex = 5;
            this.speechTTSButton.Text = "Speech To Text To Speech (Toggle)";
            this.speechTTSButton.UseVisualStyleBackColor = true;
            this.speechTTSButton.Click += new System.EventHandler(this.speechTTSButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(488, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(223, 428);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // hideVRCTextButton
            // 
            this.hideVRCTextButton.Location = new System.Drawing.Point(367, 320);
            this.hideVRCTextButton.Name = "hideVRCTextButton";
            this.hideVRCTextButton.Size = new System.Drawing.Size(114, 55);
            this.hideVRCTextButton.TabIndex = 16;
            this.hideVRCTextButton.Text = "Hide VRC Text Display";
            this.hideVRCTextButton.UseVisualStyleBackColor = true;
            this.hideVRCTextButton.Click += new System.EventHandler(this.hideVRCTextButton_Click);
            // 
            // TTSButton
            // 
            this.TTSButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TTSButton.Location = new System.Drawing.Point(389, 12);
            this.TTSButton.Name = "TTSButton";
            this.TTSButton.Size = new System.Drawing.Size(92, 70);
            this.TTSButton.TabIndex = 10;
            this.TTSButton.Text = "TTS";
            this.TTSButton.UseVisualStyleBackColor = true;
            this.TTSButton.Click += new System.EventHandler(this.TTSButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Voice";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(28, 343);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(247, 28);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.Tag = "Sara";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 467);
            this.tabControl1.TabIndex = 27;
            // 
            // VoiceWizardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(751, 481);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "VoiceWizardWindow";
            this.Text = "TTS Voice Wizard [Lite]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage2;
        private Button button1;
        private TextBox textBoxErase;
        private TextBox textBox4;
        private TextBox textBoxDelay;
        public CheckBox checkBox6;
        public CheckBox checkBox1;
        public CheckBox checkBox2;
        private Label label12;
        private Label label11;
        private Label label7;
        private Button buttonDelayHere;
        private TabPage tabPage1;
        private Button logClearButton;
        public Button speechTTSButton;
        private RichTextBox richTextBox1;
        private Button hideVRCTextButton;
        private Button TTSButton;
        private Label label2;
        public ComboBox comboBox2;
        private TabControl tabControl1;
        private Button button2;
        private RichTextBox richTextBox2;
        private Label label1;
        private Label label3;
        private Button button3;
        private Label label4;
        public ComboBox comboBox1;
        public CheckBox checkBox3;
    }
}
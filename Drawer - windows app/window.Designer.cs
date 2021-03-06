﻿namespace Draw
{
    partial class Window
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupSend = new System.Windows.Forms.GroupBox();
            this.connect = new System.Windows.Forms.Button();
            this.combo = new System.Windows.Forms.ComboBox();
            this.groupDraw = new System.Windows.Forms.GroupBox();
            this.hundred = new System.Windows.Forms.Label();
            this.five = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.groupeColor = new System.Windows.Forms.GroupBox();
            this.draw = new System.Windows.Forms.RadioButton();
            this.erase = new System.Windows.Forms.RadioButton();
            this.setSize = new System.Windows.Forms.TrackBar();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.groupSend.SuspendLayout();
            this.groupDraw.SuspendLayout();
            this.groupeColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSend
            // 
            this.groupSend.Controls.Add(this.connect);
            this.groupSend.Controls.Add(this.combo);
            this.groupSend.Location = new System.Drawing.Point(584, 203);
            this.groupSend.Margin = new System.Windows.Forms.Padding(4);
            this.groupSend.Name = "groupSend";
            this.groupSend.Padding = new System.Windows.Forms.Padding(4);
            this.groupSend.Size = new System.Drawing.Size(267, 107);
            this.groupSend.TabIndex = 5;
            this.groupSend.TabStop = false;
            this.groupSend.Text = "Send to Arduino";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(8, 62);
            this.connect.Margin = new System.Windows.Forms.Padding(4);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(251, 34);
            this.connect.TabIndex = 2;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(8, 28);
            this.combo.Margin = new System.Windows.Forms.Padding(4);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(249, 24);
            this.combo.TabIndex = 0;
            // 
            // groupDraw
            // 
            this.groupDraw.Controls.Add(this.hundred);
            this.groupDraw.Controls.Add(this.five);
            this.groupDraw.Controls.Add(this.clear);
            this.groupDraw.Controls.Add(this.groupeColor);
            this.groupDraw.Controls.Add(this.setSize);
            this.groupDraw.Location = new System.Drawing.Point(584, 15);
            this.groupDraw.Margin = new System.Windows.Forms.Padding(4);
            this.groupDraw.Name = "groupDraw";
            this.groupDraw.Padding = new System.Windows.Forms.Padding(4);
            this.groupDraw.Size = new System.Drawing.Size(267, 181);
            this.groupDraw.TabIndex = 4;
            this.groupDraw.TabStop = false;
            this.groupDraw.Text = "Draw settings";
            // 
            // hundred
            // 
            this.hundred.AutoSize = true;
            this.hundred.Location = new System.Drawing.Point(225, 63);
            this.hundred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hundred.Name = "hundred";
            this.hundred.Size = new System.Drawing.Size(32, 17);
            this.hundred.TabIndex = 8;
            this.hundred.Text = "100";
            // 
            // five
            // 
            this.five.AutoSize = true;
            this.five.Location = new System.Drawing.Point(17, 63);
            this.five.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(16, 17);
            this.five.TabIndex = 7;
            this.five.Text = "5";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(8, 139);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(251, 34);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // groupeColor
            // 
            this.groupeColor.Controls.Add(this.draw);
            this.groupeColor.Controls.Add(this.erase);
            this.groupeColor.Location = new System.Drawing.Point(8, 86);
            this.groupeColor.Margin = new System.Windows.Forms.Padding(4);
            this.groupeColor.Name = "groupeColor";
            this.groupeColor.Padding = new System.Windows.Forms.Padding(4);
            this.groupeColor.Size = new System.Drawing.Size(251, 46);
            this.groupeColor.TabIndex = 4;
            this.groupeColor.TabStop = false;
            this.groupeColor.Text = "Color";
            // 
            // draw
            // 
            this.draw.AutoSize = true;
            this.draw.Checked = true;
            this.draw.Location = new System.Drawing.Point(8, 15);
            this.draw.Margin = new System.Windows.Forms.Padding(4);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(63, 21);
            this.draw.TabIndex = 2;
            this.draw.TabStop = true;
            this.draw.Text = "Black";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.CheckedChanged += new System.EventHandler(this.Draw_CheckedChanged);
            // 
            // erase
            // 
            this.erase.AutoSize = true;
            this.erase.Location = new System.Drawing.Point(85, 15);
            this.erase.Margin = new System.Windows.Forms.Padding(4);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(65, 21);
            this.erase.TabIndex = 3;
            this.erase.Text = "White";
            this.erase.UseVisualStyleBackColor = true;
            this.erase.CheckedChanged += new System.EventHandler(this.Erase_CheckedChanged);
            // 
            // setSize
            // 
            this.setSize.Location = new System.Drawing.Point(8, 23);
            this.setSize.Margin = new System.Windows.Forms.Padding(4);
            this.setSize.Maximum = 100;
            this.setSize.Minimum = 5;
            this.setSize.Name = "setSize";
            this.setSize.Size = new System.Drawing.Size(251, 56);
            this.setSize.SmallChange = 5;
            this.setSize.TabIndex = 0;
            this.setSize.TickFrequency = 5;
            this.setSize.Value = 10;
            this.setSize.Scroll += new System.EventHandler(this.SetSize_Scroll);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.canvas.Location = new System.Drawing.Point(16, 15);
            this.canvas.Margin = new System.Windows.Forms.Padding(4);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(560, 295);
            this.canvas.TabIndex = 3;
            this.canvas.TabStop = false;
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseClick);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(899, 343);
            this.Controls.Add(this.groupSend);
            this.Controls.Add(this.groupDraw);
            this.Controls.Add(this.canvas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Window";
            this.Padding = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.ShowIcon = false;
            this.Text = "Drawer";
            this.groupSend.ResumeLayout(false);
            this.groupDraw.ResumeLayout(false);
            this.groupDraw.PerformLayout();
            this.groupeColor.ResumeLayout(false);
            this.groupeColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupSend;
        public System.Windows.Forms.Button connect;
        public System.Windows.Forms.ComboBox combo;
        public System.Windows.Forms.GroupBox groupDraw;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.GroupBox groupeColor;
        private System.Windows.Forms.RadioButton draw;
        private System.Windows.Forms.RadioButton erase;
        private System.Windows.Forms.TrackBar setSize;
        public System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label hundred;
        private System.Windows.Forms.Label five;
    }
}


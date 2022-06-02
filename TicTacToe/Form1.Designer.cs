using System;

namespace TicTacToe
{
    partial class Form1
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
            this.A1 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(32, 37);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 69);
            this.A1.TabIndex = 0;
            this.A1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.buttonClick);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(125, 37);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 69);
            this.B1.TabIndex = 1;
            this.B1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.buttonClick);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(225, 37);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 69);
            this.C1.TabIndex = 2;
            this.C1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.buttonClick);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(32, 121);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 69);
            this.A2.TabIndex = 3;
            this.A2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.buttonClick);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(125, 121);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 69);
            this.B2.TabIndex = 4;
            this.B2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.buttonClick);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(225, 121);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 69);
            this.C2.TabIndex = 5;
            this.C2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.buttonClick);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(32, 208);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 69);
            this.A3.TabIndex = 6;
            this.A3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.buttonClick);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(125, 208);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 69);
            this.B3.TabIndex = 7;
            this.B3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.buttonClick);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(225, 208);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 69);
            this.C3.TabIndex = 8;
            this.C3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.buttonClick);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(32, 324);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(75, 23);
            this.NewGameButton.TabIndex = 9;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGamebuttonClick);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(225, 324);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(339, 365);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.ResumeLayout(false);

        }

        private void EButtonClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NbuttonClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonClick(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button ExitButton;
    }
}


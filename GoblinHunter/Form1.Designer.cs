
namespace GoblinHunter
{
    partial class goblinHunterFRM
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
            this.upButtonPress = new System.Windows.Forms.Button();
            this.leftButtonPress = new System.Windows.Forms.Button();
            this.rightButtonPress = new System.Windows.Forms.Button();
            this.downButtonPress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // upButtonPress
            // 
            this.upButtonPress.Location = new System.Drawing.Point(512, 301);
            this.upButtonPress.Name = "upButtonPress";
            this.upButtonPress.Size = new System.Drawing.Size(50, 52);
            this.upButtonPress.TabIndex = 0;
            this.upButtonPress.Text = "^";
            this.upButtonPress.UseVisualStyleBackColor = true;
            // 
            // leftButtonPress
            // 
            this.leftButtonPress.Location = new System.Drawing.Point(456, 357);
            this.leftButtonPress.Name = "leftButtonPress";
            this.leftButtonPress.Size = new System.Drawing.Size(50, 52);
            this.leftButtonPress.TabIndex = 1;
            this.leftButtonPress.Text = "<";
            this.leftButtonPress.UseVisualStyleBackColor = true;
            // 
            // rightButtonPress
            // 
            this.rightButtonPress.Location = new System.Drawing.Point(568, 357);
            this.rightButtonPress.Name = "rightButtonPress";
            this.rightButtonPress.Size = new System.Drawing.Size(50, 52);
            this.rightButtonPress.TabIndex = 2;
            this.rightButtonPress.Text = ">";
            this.rightButtonPress.UseVisualStyleBackColor = true;
            // 
            // downButtonPress
            // 
            this.downButtonPress.Location = new System.Drawing.Point(512, 413);
            this.downButtonPress.Name = "downButtonPress";
            this.downButtonPress.Size = new System.Drawing.Size(50, 52);
            this.downButtonPress.TabIndex = 3;
            this.downButtonPress.Text = "v";
            this.downButtonPress.UseVisualStyleBackColor = true;
            this.downButtonPress.Click += new System.EventHandler(this.downButtonPress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player Stats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Attack DMG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hero Health:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hero Position";
            // 
            // goblinHunterFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.downButtonPress);
            this.Controls.Add(this.rightButtonPress);
            this.Controls.Add(this.leftButtonPress);
            this.Controls.Add(this.upButtonPress);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "goblinHunterFRM";
            this.Text = "Goblin Hunter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upButtonPress;
        private System.Windows.Forms.Button leftButtonPress;
        private System.Windows.Forms.Button rightButtonPress;
        private System.Windows.Forms.Button downButtonPress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


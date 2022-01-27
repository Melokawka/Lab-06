
namespace WinFormsApp2
{
    partial class Form1
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
            this.lblIn = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.rdbBig = new System.Windows.Forms.RadioButton();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.grpStyle = new System.Windows.Forms.GroupBox();
            this.checUnderL = new System.Windows.Forms.CheckBox();
            this.checItalic = new System.Windows.Forms.CheckBox();
            this.checBold = new System.Windows.Forms.CheckBox();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.rdbOrange = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.btn = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.grpSize.SuspendLayout();
            this.grpStyle.SuspendLayout();
            this.grpColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(68, 25);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(66, 15);
            this.lblIn.TabIndex = 0;
            this.lblIn.Text = "Podaj Tekst";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(157, 22);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(334, 23);
            this.txtBox.TabIndex = 1;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rdbLarge);
            this.grpSize.Controls.Add(this.rdbBig);
            this.grpSize.Controls.Add(this.rdbSmall);
            this.grpSize.Location = new System.Drawing.Point(68, 102);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(138, 157);
            this.grpSize.TabIndex = 2;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Wielkość";
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.Location = new System.Drawing.Point(7, 97);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(89, 19);
            this.rdbLarge.TabIndex = 2;
            this.rdbLarge.TabStop = true;
            this.rdbLarge.Text = "bardzo duża";
            this.rdbLarge.UseVisualStyleBackColor = true;
            // 
            // rdbBig
            // 
            this.rdbBig.AutoSize = true;
            this.rdbBig.Location = new System.Drawing.Point(7, 57);
            this.rdbBig.Name = "rdbBig";
            this.rdbBig.Size = new System.Drawing.Size(50, 19);
            this.rdbBig.TabIndex = 1;
            this.rdbBig.TabStop = true;
            this.rdbBig.Text = "duża";
            this.rdbBig.UseVisualStyleBackColor = true;
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Location = new System.Drawing.Point(7, 23);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(51, 19);
            this.rdbSmall.TabIndex = 0;
            this.rdbSmall.TabStop = true;
            this.rdbSmall.Text = "mała";
            this.rdbSmall.UseVisualStyleBackColor = true;
            // 
            // grpStyle
            // 
            this.grpStyle.Controls.Add(this.checUnderL);
            this.grpStyle.Controls.Add(this.checItalic);
            this.grpStyle.Controls.Add(this.checBold);
            this.grpStyle.Location = new System.Drawing.Point(243, 102);
            this.grpStyle.Name = "grpStyle";
            this.grpStyle.Size = new System.Drawing.Size(138, 157);
            this.grpStyle.TabIndex = 3;
            this.grpStyle.TabStop = false;
            this.grpStyle.Text = "Styl Czcionki";
            // 
            // checUnderL
            // 
            this.checUnderL.AutoSize = true;
            this.checUnderL.Location = new System.Drawing.Point(7, 98);
            this.checUnderL.Name = "checUnderL";
            this.checUnderL.Size = new System.Drawing.Size(93, 19);
            this.checUnderL.TabIndex = 2;
            this.checUnderL.Text = "Podkreślenie";
            this.checUnderL.UseVisualStyleBackColor = true;
            // 
            // checItalic
            // 
            this.checItalic.AutoSize = true;
            this.checItalic.Location = new System.Drawing.Point(7, 57);
            this.checItalic.Name = "checItalic";
            this.checItalic.Size = new System.Drawing.Size(84, 19);
            this.checItalic.TabIndex = 1;
            this.checItalic.Text = "Pochylenie";
            this.checItalic.UseVisualStyleBackColor = true;
            // 
            // checBold
            // 
            this.checBold.AutoSize = true;
            this.checBold.Location = new System.Drawing.Point(7, 22);
            this.checBold.Name = "checBold";
            this.checBold.Size = new System.Drawing.Size(90, 19);
            this.checBold.TabIndex = 0;
            this.checBold.Text = "Pogrubienie";
            this.checBold.UseVisualStyleBackColor = true;
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.rdbOrange);
            this.grpColor.Controls.Add(this.rdbBlue);
            this.grpColor.Controls.Add(this.rdbRed);
            this.grpColor.Location = new System.Drawing.Point(417, 102);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(138, 157);
            this.grpColor.TabIndex = 3;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Kolor Czcionki";
            // 
            // rdbOrange
            // 
            this.rdbOrange.AutoSize = true;
            this.rdbOrange.Location = new System.Drawing.Point(6, 97);
            this.rdbOrange.Name = "rdbOrange";
            this.rdbOrange.Size = new System.Drawing.Size(106, 19);
            this.rdbOrange.TabIndex = 8;
            this.rdbOrange.TabStop = true;
            this.rdbOrange.Text = "pomarańczowy";
            this.rdbOrange.UseVisualStyleBackColor = true;
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Location = new System.Drawing.Point(6, 57);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(71, 19);
            this.rdbBlue.TabIndex = 7;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "niebieski";
            this.rdbBlue.UseVisualStyleBackColor = true;
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(6, 23);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(75, 19);
            this.rdbRed.TabIndex = 6;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "czerwony";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(157, 345);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(224, 43);
            this.btn.TabIndex = 4;
            this.btn.Text = "Aktualizuj";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(243, 286);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(49, 15);
            this.lblOut.TabIndex = 5;
            this.lblOut.Text = "Rezultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 419);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.grpStyle);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpStyle.ResumeLayout(false);
            this.grpStyle.PerformLayout();
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.GroupBox grpStyle;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.RadioButton rdbBig;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.CheckBox checUnderL;
        private System.Windows.Forms.CheckBox checItalic;
        private System.Windows.Forms.CheckBox checBold;
        private System.Windows.Forms.RadioButton rdbOrange;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbRed;
    }
}


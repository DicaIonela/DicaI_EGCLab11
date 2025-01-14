
namespace OpenTK3_StandardTemplate_WinForms
{
    partial class MainForm
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
            this.showAxes = new System.Windows.Forms.CheckBox();
            this.changeBackground = new System.Windows.Forms.Button();
            this.lblOx = new System.Windows.Forms.Label();
            this.lblOy = new System.Windows.Forms.Label();
            this.lblOz = new System.Windows.Forms.Label();
            this.resetScene = new System.Windows.Forms.Button();
            this.enableRotation = new System.Windows.Forms.CheckBox();
            this.enableObjectRotation = new System.Windows.Forms.CheckBox();
            this.rbLightOFF = new System.Windows.Forms.RadioButton();
            this.rbLightOn = new System.Windows.Forms.RadioButton();
            this.ckLightMove = new System.Windows.Forms.CheckBox();
            this.ckTransparency = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // showAxes
            // 
            this.showAxes.AutoSize = true;
            this.showAxes.Checked = true;
            this.showAxes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAxes.Location = new System.Drawing.Point(1116, 16);
            this.showAxes.Margin = new System.Windows.Forms.Padding(4);
            this.showAxes.Name = "showAxes";
            this.showAxes.Size = new System.Drawing.Size(95, 20);
            this.showAxes.TabIndex = 0;
            this.showAxes.Text = "Show Axes";
            this.showAxes.UseVisualStyleBackColor = true;
            this.showAxes.CheckedChanged += new System.EventHandler(this.showAxes_CheckedChanged);
            // 
            // changeBackground
            // 
            this.changeBackground.Location = new System.Drawing.Point(1116, 281);
            this.changeBackground.Margin = new System.Windows.Forms.Padding(4);
            this.changeBackground.Name = "changeBackground";
            this.changeBackground.Size = new System.Drawing.Size(267, 39);
            this.changeBackground.TabIndex = 1;
            this.changeBackground.Text = "Change background color";
            this.changeBackground.UseVisualStyleBackColor = true;
            this.changeBackground.Click += new System.EventHandler(this.changeBackground_Click);
            // 
            // lblOx
            // 
            this.lblOx.BackColor = System.Drawing.Color.Red;
            this.lblOx.Location = new System.Drawing.Point(1145, 43);
            this.lblOx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOx.Name = "lblOx";
            this.lblOx.Size = new System.Drawing.Size(53, 25);
            this.lblOx.TabIndex = 2;
            this.lblOx.Text = "Ox";
            this.lblOx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOy
            // 
            this.lblOy.BackColor = System.Drawing.Color.Green;
            this.lblOy.Location = new System.Drawing.Point(1207, 43);
            this.lblOy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOy.Name = "lblOy";
            this.lblOy.Size = new System.Drawing.Size(53, 25);
            this.lblOy.TabIndex = 3;
            this.lblOy.Text = "Oy";
            this.lblOy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOz
            // 
            this.lblOz.BackColor = System.Drawing.Color.Blue;
            this.lblOz.Location = new System.Drawing.Point(1268, 43);
            this.lblOz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOz.Name = "lblOz";
            this.lblOz.Size = new System.Drawing.Size(53, 25);
            this.lblOz.TabIndex = 4;
            this.lblOz.Text = "Oz";
            this.lblOz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetScene
            // 
            this.resetScene.Location = new System.Drawing.Point(1116, 328);
            this.resetScene.Margin = new System.Windows.Forms.Padding(4);
            this.resetScene.Name = "resetScene";
            this.resetScene.Size = new System.Drawing.Size(267, 39);
            this.resetScene.TabIndex = 5;
            this.resetScene.Text = "Reset scene";
            this.resetScene.UseVisualStyleBackColor = true;
            this.resetScene.Click += new System.EventHandler(this.resetScene_Click);
            // 
            // enableRotation
            // 
            this.enableRotation.AutoSize = true;
            this.enableRotation.Location = new System.Drawing.Point(1116, 71);
            this.enableRotation.Margin = new System.Windows.Forms.Padding(4);
            this.enableRotation.Name = "enableRotation";
            this.enableRotation.Size = new System.Drawing.Size(163, 20);
            this.enableRotation.TabIndex = 6;
            this.enableRotation.Text = "Enable mouse rotation";
            this.enableRotation.UseVisualStyleBackColor = true;
            // 
            // enableObjectRotation
            // 
            this.enableObjectRotation.AutoSize = true;
            this.enableObjectRotation.Location = new System.Drawing.Point(1116, 102);
            this.enableObjectRotation.Margin = new System.Windows.Forms.Padding(4);
            this.enableObjectRotation.Name = "enableObjectRotation";
            this.enableObjectRotation.Size = new System.Drawing.Size(159, 20);
            this.enableObjectRotation.TabIndex = 7;
            this.enableObjectRotation.Text = "Enable object rotation";
            this.enableObjectRotation.UseVisualStyleBackColor = true;
            // 
            // rbLightOFF
            // 
            this.rbLightOFF.AutoSize = true;
            this.rbLightOFF.Checked = true;
            this.rbLightOFF.Location = new System.Drawing.Point(1116, 186);
            this.rbLightOFF.Name = "rbLightOFF";
            this.rbLightOFF.Size = new System.Drawing.Size(82, 20);
            this.rbLightOFF.TabIndex = 9;
            this.rbLightOFF.TabStop = true;
            this.rbLightOFF.Text = "LightOFF";
            this.rbLightOFF.UseVisualStyleBackColor = true;
            this.rbLightOFF.CheckedChanged += new System.EventHandler(this.rbLightOff_CheckedChanged);
            // 
            // rbLightOn
            // 
            this.rbLightOn.AutoSize = true;
            this.rbLightOn.Location = new System.Drawing.Point(1116, 157);
            this.rbLightOn.Name = "rbLightOn";
            this.rbLightOn.Size = new System.Drawing.Size(79, 20);
            this.rbLightOn.TabIndex = 10;
            this.rbLightOn.Text = "Light ON";
            this.rbLightOn.UseVisualStyleBackColor = true;
            this.rbLightOn.CheckedChanged += new System.EventHandler(this.rbLightOn_CheckedChanged);
            // 
            // ckLightMove
            // 
            this.ckLightMove.AutoSize = true;
            this.ckLightMove.Location = new System.Drawing.Point(1116, 213);
            this.ckLightMove.Margin = new System.Windows.Forms.Padding(4);
            this.ckLightMove.Name = "ckLightMove";
            this.ckLightMove.Size = new System.Drawing.Size(169, 20);
            this.ckLightMove.TabIndex = 11;
            this.ckLightMove.Text = "Enable Light Movement";
            this.ckLightMove.UseVisualStyleBackColor = true;
            this.ckLightMove.CheckedChanged += new System.EventHandler(this.ckLightMove_CheckedChanged);
            // 
            // ckTransparency
            // 
            this.ckTransparency.AutoSize = true;
            this.ckTransparency.Location = new System.Drawing.Point(1116, 241);
            this.ckTransparency.Margin = new System.Windows.Forms.Padding(4);
            this.ckTransparency.Name = "ckTransparency";
            this.ckTransparency.Size = new System.Drawing.Size(131, 20);
            this.ckTransparency.TabIndex = 12;
            this.ckTransparency.Text = "Transparent 50%";
            this.ckTransparency.UseVisualStyleBackColor = true;
            this.ckTransparency.CheckedChanged += new System.EventHandler(this.ckTransparency_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 768);
            this.Controls.Add(this.ckTransparency);
            this.Controls.Add(this.ckLightMove);
            this.Controls.Add(this.rbLightOn);
            this.Controls.Add(this.rbLightOFF);
            this.Controls.Add(this.enableObjectRotation);
            this.Controls.Add(this.enableRotation);
            this.Controls.Add(this.resetScene);
            this.Controls.Add(this.lblOz);
            this.Controls.Add(this.lblOy);
            this.Controls.Add(this.lblOx);
            this.Controls.Add(this.changeBackground);
            this.Controls.Add(this.showAxes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "OpenTK 3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox showAxes;
        private System.Windows.Forms.Button changeBackground;
        private System.Windows.Forms.Label lblOx;
        private System.Windows.Forms.Label lblOy;
        private System.Windows.Forms.Label lblOz;
        private System.Windows.Forms.Button resetScene;
        private System.Windows.Forms.CheckBox enableRotation;
        private System.Windows.Forms.CheckBox enableObjectRotation;
        private System.Windows.Forms.RadioButton rbLightOFF;
        private System.Windows.Forms.RadioButton rbLightOn;
        private System.Windows.Forms.CheckBox ckLightMove;
        private System.Windows.Forms.CheckBox ckTransparency;
    }
}


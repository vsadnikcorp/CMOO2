namespace CMOO_2_2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.boxArmy = new System.Windows.Forms.GroupBox();
            this.rbSoviet = new System.Windows.Forms.RadioButton();
            this.rbGerman = new System.Windows.Forms.RadioButton();
            this.cbUnitCreate = new System.Windows.Forms.Button();
            this.boxArmy.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxArmy
            // 
            this.boxArmy.Controls.Add(this.rbSoviet);
            this.boxArmy.Controls.Add(this.rbGerman);
            this.boxArmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxArmy.Location = new System.Drawing.Point(8, 15);
            this.boxArmy.Name = "boxArmy";
            this.boxArmy.Size = new System.Drawing.Size(117, 62);
            this.boxArmy.TabIndex = 0;
            this.boxArmy.TabStop = false;
            this.boxArmy.Text = "Army";
            // 
            // rbSoviet
            // 
            this.rbSoviet.AutoSize = true;
            this.rbSoviet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSoviet.Location = new System.Drawing.Point(11, 38);
            this.rbSoviet.Name = "rbSoviet";
            this.rbSoviet.Size = new System.Drawing.Size(55, 17);
            this.rbSoviet.TabIndex = 1;
            this.rbSoviet.TabStop = true;
            this.rbSoviet.Text = "Soviet";
            this.rbSoviet.UseVisualStyleBackColor = true;
            // 
            // rbGerman
            // 
            this.rbGerman.AutoSize = true;
            this.rbGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGerman.Location = new System.Drawing.Point(11, 15);
            this.rbGerman.Name = "rbGerman";
            this.rbGerman.Size = new System.Drawing.Size(62, 17);
            this.rbGerman.TabIndex = 0;
            this.rbGerman.TabStop = true;
            this.rbGerman.Text = "German";
            this.rbGerman.UseVisualStyleBackColor = true;
            // 
            // cbUnitCreate
            // 
            this.cbUnitCreate.Location = new System.Drawing.Point(10, 89);
            this.cbUnitCreate.Name = "cbUnitCreate";
            this.cbUnitCreate.Size = new System.Drawing.Size(114, 32);
            this.cbUnitCreate.TabIndex = 1;
            this.cbUnitCreate.Text = "Create Unit";
            this.cbUnitCreate.UseVisualStyleBackColor = true;
            this.cbUnitCreate.Click += new System.EventHandler(this.cbUnitCreate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 307);
            this.Controls.Add(this.cbUnitCreate);
            this.Controls.Add(this.boxArmy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "CMOO-2-2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.boxArmy.ResumeLayout(false);
            this.boxArmy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxArmy;
        private System.Windows.Forms.RadioButton rbSoviet;
        private System.Windows.Forms.RadioButton rbGerman;
        private System.Windows.Forms.Button cbUnitCreate;
    }
}


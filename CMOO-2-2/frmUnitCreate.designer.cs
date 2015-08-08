namespace CMOO_2_2
{
    partial class frmUnitCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnitCreate));
            this.tabUnitCreate = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblUnitDesc = new System.Windows.Forms.Label();
            this.lbUnitDesc = new System.Windows.Forms.ListBox();
            this.lblFormation = new System.Windows.Forms.Label();
            this.lbFormation = new System.Windows.Forms.ListBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lbService = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbRemove = new System.Windows.Forms.Button();
            this.cbPurchase = new System.Windows.Forms.Button();
            this.lblVariants = new System.Windows.Forms.Label();
            this.lblUnitPurch = new System.Windows.Forms.Label();
            this.lblUnitSelect = new System.Windows.Forms.Label();
            this.lbVariants = new System.Windows.Forms.ListBox();
            this.tvwUnitPurch = new System.Windows.Forms.TreeView();
            this.tvwUnitSelect = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbBack = new System.Windows.Forms.Button();
            this.cbNext = new System.Windows.Forms.Button();
            this.cbExit = new System.Windows.Forms.Button();
            this.tabUnitCreate.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUnitCreate
            // 
            this.tabUnitCreate.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabUnitCreate.Controls.Add(this.tabPage1);
            this.tabUnitCreate.Controls.Add(this.tabPage2);
            this.tabUnitCreate.Controls.Add(this.tabPage3);
            this.tabUnitCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUnitCreate.Location = new System.Drawing.Point(12, 43);
            this.tabUnitCreate.Name = "tabUnitCreate";
            this.tabUnitCreate.SelectedIndex = 0;
            this.tabUnitCreate.Size = new System.Drawing.Size(451, 445);
            this.tabUnitCreate.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblUnitDesc);
            this.tabPage1.Controls.Add(this.lbUnitDesc);
            this.tabPage1.Controls.Add(this.lblFormation);
            this.tabPage1.Controls.Add(this.lbFormation);
            this.tabPage1.Controls.Add(this.lblService);
            this.tabPage1.Controls.Add(this.lbService);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(443, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblUnitDesc
            // 
            this.lblUnitDesc.AutoSize = true;
            this.lblUnitDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitDesc.Location = new System.Drawing.Point(205, 14);
            this.lblUnitDesc.Name = "lblUnitDesc";
            this.lblUnitDesc.Size = new System.Drawing.Size(102, 13);
            this.lblUnitDesc.TabIndex = 9;
            this.lblUnitDesc.Text = "Unit Description:";
            // 
            // lbUnitDesc
            // 
            this.lbUnitDesc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbUnitDesc.Enabled = false;
            this.lbUnitDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnitDesc.FormattingEnabled = true;
            this.lbUnitDesc.ItemHeight = 16;
            this.lbUnitDesc.Location = new System.Drawing.Point(208, 30);
            this.lbUnitDesc.Name = "lbUnitDesc";
            this.lbUnitDesc.Size = new System.Drawing.Size(205, 308);
            this.lbUnitDesc.TabIndex = 8;
            // 
            // lblFormation
            // 
            this.lblFormation.AutoSize = true;
            this.lblFormation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormation.Location = new System.Drawing.Point(12, 123);
            this.lblFormation.Name = "lblFormation";
            this.lblFormation.Size = new System.Drawing.Size(66, 13);
            this.lblFormation.TabIndex = 7;
            this.lblFormation.Text = "Formation:";
            // 
            // lbFormation
            // 
            this.lbFormation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbFormation.Enabled = false;
            this.lbFormation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormation.FormattingEnabled = true;
            this.lbFormation.ItemHeight = 16;
            this.lbFormation.Location = new System.Drawing.Point(13, 139);
            this.lbFormation.Name = "lbFormation";
            this.lbFormation.Size = new System.Drawing.Size(152, 212);
            this.lbFormation.TabIndex = 6;
            this.lbFormation.DoubleClick += new System.EventHandler(this.lbFormation_DoubleClick);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(12, 13);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(54, 13);
            this.lblService.TabIndex = 5;
            this.lblService.Text = "Service:";
            // 
            // lbService
            // 
            this.lbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService.FormattingEnabled = true;
            this.lbService.ItemHeight = 16;
            this.lbService.Location = new System.Drawing.Point(11, 29);
            this.lbService.Name = "lbService";
            this.lbService.Size = new System.Drawing.Size(155, 68);
            this.lbService.TabIndex = 4;
            this.lbService.DoubleClick += new System.EventHandler(this.lbService_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbRemove);
            this.tabPage2.Controls.Add(this.cbPurchase);
            this.tabPage2.Controls.Add(this.lblVariants);
            this.tabPage2.Controls.Add(this.lblUnitPurch);
            this.tabPage2.Controls.Add(this.lblUnitSelect);
            this.tabPage2.Controls.Add(this.lbVariants);
            this.tabPage2.Controls.Add(this.tvwUnitPurch);
            this.tabPage2.Controls.Add(this.tvwUnitSelect);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(443, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Purchase";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbRemove
            // 
            this.cbRemove.Location = new System.Drawing.Point(201, 200);
            this.cbRemove.Name = "cbRemove";
            this.cbRemove.Size = new System.Drawing.Size(50, 25);
            this.cbRemove.TabIndex = 7;
            this.cbRemove.Text = "<<<<";
            this.cbRemove.UseVisualStyleBackColor = true;
            // 
            // cbPurchase
            // 
            this.cbPurchase.Location = new System.Drawing.Point(202, 167);
            this.cbPurchase.Name = "cbPurchase";
            this.cbPurchase.Size = new System.Drawing.Size(50, 25);
            this.cbPurchase.TabIndex = 6;
            this.cbPurchase.Text = ">>>>";
            this.cbPurchase.UseVisualStyleBackColor = true;
            // 
            // lblVariants
            // 
            this.lblVariants.AutoSize = true;
            this.lblVariants.Location = new System.Drawing.Point(262, 331);
            this.lblVariants.Name = "lblVariants";
            this.lblVariants.Size = new System.Drawing.Size(57, 13);
            this.lblVariants.TabIndex = 5;
            this.lblVariants.Text = "Variants:";
            // 
            // lblUnitPurch
            // 
            this.lblUnitPurch.AutoSize = true;
            this.lblUnitPurch.Location = new System.Drawing.Point(258, 13);
            this.lblUnitPurch.Name = "lblUnitPurch";
            this.lblUnitPurch.Size = new System.Drawing.Size(98, 13);
            this.lblUnitPurch.TabIndex = 4;
            this.lblUnitPurch.Text = "Purchased Unit:";
            // 
            // lblUnitSelect
            // 
            this.lblUnitSelect.AutoSize = true;
            this.lblUnitSelect.Location = new System.Drawing.Point(21, 11);
            this.lblUnitSelect.Name = "lblUnitSelect";
            this.lblUnitSelect.Size = new System.Drawing.Size(88, 13);
            this.lblUnitSelect.TabIndex = 3;
            this.lblUnitSelect.Text = "Selected Unit:";
            // 
            // lbVariants
            // 
            this.lbVariants.FormattingEnabled = true;
            this.lbVariants.Location = new System.Drawing.Point(261, 347);
            this.lbVariants.Name = "lbVariants";
            this.lbVariants.Size = new System.Drawing.Size(161, 56);
            this.lbVariants.TabIndex = 2;
            // 
            // tvwUnitPurch
            // 
            this.tvwUnitPurch.Location = new System.Drawing.Point(256, 29);
            this.tvwUnitPurch.Name = "tvwUnitPurch";
            this.tvwUnitPurch.Size = new System.Drawing.Size(167, 291);
            this.tvwUnitPurch.TabIndex = 1;
            // 
            // tvwUnitSelect
            // 
            this.tvwUnitSelect.Location = new System.Drawing.Point(20, 27);
            this.tvwUnitSelect.Name = "tvwUnitSelect";
            this.tvwUnitSelect.Size = new System.Drawing.Size(175, 379);
            this.tvwUnitSelect.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(443, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbBack
            // 
            this.cbBack.Location = new System.Drawing.Point(17, 505);
            this.cbBack.Name = "cbBack";
            this.cbBack.Size = new System.Drawing.Size(76, 30);
            this.cbBack.TabIndex = 1;
            this.cbBack.Text = "<<< Back";
            this.cbBack.UseVisualStyleBackColor = true;
            // 
            // cbNext
            // 
            this.cbNext.Location = new System.Drawing.Point(106, 505);
            this.cbNext.Name = "cbNext";
            this.cbNext.Size = new System.Drawing.Size(76, 30);
            this.cbNext.TabIndex = 2;
            this.cbNext.Text = "Next >>>";
            this.cbNext.UseVisualStyleBackColor = true;
            // 
            // cbExit
            // 
            this.cbExit.Location = new System.Drawing.Point(353, 505);
            this.cbExit.Name = "cbExit";
            this.cbExit.Size = new System.Drawing.Size(76, 30);
            this.cbExit.TabIndex = 3;
            this.cbExit.Text = "<< Exit >>";
            this.cbExit.UseVisualStyleBackColor = true;
            // 
            // frmUnitCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 552);
            this.Controls.Add(this.cbExit);
            this.Controls.Add(this.cbNext);
            this.Controls.Add(this.cbBack);
            this.Controls.Add(this.tabUnitCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUnitCreate";
            this.Text = "Create Unit";
            this.Load += new System.EventHandler(this.frmUnitCreate_Load);
            this.tabUnitCreate.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUnitCreate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblUnitDesc;
        private System.Windows.Forms.ListBox lbUnitDesc;
        private System.Windows.Forms.Label lblFormation;
        private System.Windows.Forms.ListBox lbFormation;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ListBox lbService;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cbRemove;
        private System.Windows.Forms.Button cbPurchase;
        private System.Windows.Forms.Label lblVariants;
        private System.Windows.Forms.Label lblUnitPurch;
        private System.Windows.Forms.Label lblUnitSelect;
        private System.Windows.Forms.ListBox lbVariants;
        private System.Windows.Forms.TreeView tvwUnitPurch;
        private System.Windows.Forms.TreeView tvwUnitSelect;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button cbBack;
        private System.Windows.Forms.Button cbNext;
        private System.Windows.Forms.Button cbExit;
    }
}
﻿namespace ColorInspector
{
    partial class InspectorForm
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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }

                // remove the hook when the application is closing
                Hooking.DestroyHook();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectorForm));
            this.txtColorHex = new System.Windows.Forms.TextBox();
            this.lblHex = new System.Windows.Forms.Label();
            this.btnInspect = new System.Windows.Forms.Button();
            this.lblMouseCoords = new System.Windows.Forms.Label();
            this.lblRGB = new System.Windows.Forms.Label();
            this.txtRGB = new System.Windows.Forms.TextBox();
            this.lbl900 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlColor = new ColorInspector.DrawingPanel();
            this.pnlZoom = new ColorInspector.DrawingPanel();
            this.pnlScan = new ColorInspector.DrawingPanel();
            this.SuspendLayout();
            // 
            // txtColorHex
            // 
            this.txtColorHex.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorHex.Location = new System.Drawing.Point(309, 74);
            this.txtColorHex.Name = "txtColorHex";
            this.txtColorHex.Size = new System.Drawing.Size(100, 23);
            this.txtColorHex.TabIndex = 2;
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(310, 58);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(29, 13);
            this.lblHex.TabIndex = 3;
            this.lblHex.Text = "Hex:";
            // 
            // btnInspect
            // 
            this.btnInspect.Location = new System.Drawing.Point(309, 109);
            this.btnInspect.Name = "btnInspect";
            this.btnInspect.Size = new System.Drawing.Size(100, 23);
            this.btnInspect.TabIndex = 4;
            this.btnInspect.Text = "Inspect";
            this.btnInspect.UseVisualStyleBackColor = true;
            this.btnInspect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnInspect_MouseDown);
            this.btnInspect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnInspect_MouseUp);
            // 
            // lblMouseCoords
            // 
            this.lblMouseCoords.AutoSize = true;
            this.lblMouseCoords.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblMouseCoords.Location = new System.Drawing.Point(9, 119);
            this.lblMouseCoords.Name = "lblMouseCoords";
            this.lblMouseCoords.Size = new System.Drawing.Size(125, 13);
            this.lblMouseCoords.TabIndex = 6;
            this.lblMouseCoords.Text = "Mouse Location: 0, 0";
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.Location = new System.Drawing.Point(306, 12);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(33, 13);
            this.lblRGB.TabIndex = 7;
            this.lblRGB.Text = "RGB:";
            // 
            // txtRGB
            // 
            this.txtRGB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRGB.Location = new System.Drawing.Point(309, 28);
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.Size = new System.Drawing.Size(100, 23);
            this.txtRGB.TabIndex = 8;
            // 
            // lbl900
            // 
            this.lbl900.AutoSize = true;
            this.lbl900.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl900.Location = new System.Drawing.Point(136, 98);
            this.lbl900.Name = "lbl900";
            this.lbl900.Size = new System.Drawing.Size(28, 12);
            this.lbl900.TabIndex = 9;
            this.lbl900.Text = "900%";
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl100.Location = new System.Drawing.Point(38, 98);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(28, 12);
            this.lbl100.TabIndex = 10;
            this.lbl100.Text = "100%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "Selected Color";
            // 
            // pnlColor
            // 
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlColor.Location = new System.Drawing.Point(207, 12);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(83, 83);
            this.pnlColor.TabIndex = 14;
            this.pnlColor.Click += new System.EventHandler(this.pnlColor_Click);
            // 
            // pnlZoom
            // 
            this.pnlZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlZoom.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pnlZoom.Location = new System.Drawing.Point(109, 12);
            this.pnlZoom.Name = "pnlZoom";
            this.pnlZoom.Size = new System.Drawing.Size(83, 83);
            this.pnlZoom.TabIndex = 12;
            this.pnlZoom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlZoom_MouseDown);
            // 
            // pnlScan
            // 
            this.pnlScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScan.Location = new System.Drawing.Point(12, 12);
            this.pnlScan.Name = "pnlScan";
            this.pnlScan.Size = new System.Drawing.Size(83, 83);
            this.pnlScan.TabIndex = 11;
            // 
            // InspectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 141);
            this.Controls.Add(this.btnInspect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.pnlZoom);
            this.Controls.Add(this.pnlScan);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.lbl900);
            this.Controls.Add(this.txtRGB);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.lblMouseCoords);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.txtColorHex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InspectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Inspector";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorInspector_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtColorHex;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Button btnInspect;
        private System.Windows.Forms.Label lblMouseCoords;
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.TextBox txtRGB;
        private System.Windows.Forms.Label lbl900;
        private System.Windows.Forms.Label lbl100;
        private DrawingPanel pnlScan;
        private DrawingPanel pnlZoom;
        private DrawingPanel pnlColor;
        private System.Windows.Forms.Label label1;
    }
}


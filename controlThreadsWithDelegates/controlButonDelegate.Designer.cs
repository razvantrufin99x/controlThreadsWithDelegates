﻿namespace controlThreadsWithDelegates
{
    partial class controlButonDelegate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // controlButonDelegate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name = "controlButonDelegate";
            this.Size = new System.Drawing.Size(77, 24);
            this.Load += new System.EventHandler(this.controlButonDelegate_Load);
            this.Click += new System.EventHandler(this.controlButonDelegate_Click);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

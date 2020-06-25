namespace imslicer
{
    partial class ImageForm
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
            this.imageFormSplitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureBoxImageForm = new System.Windows.Forms.PictureBox();
            this.buttonSaveSlice = new System.Windows.Forms.Button();
            this.buttonDeleteSlice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageFormSplitContainer)).BeginInit();
            this.imageFormSplitContainer.Panel1.SuspendLayout();
            this.imageFormSplitContainer.Panel2.SuspendLayout();
            this.imageFormSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageForm)).BeginInit();
            this.SuspendLayout();
            // 
            // imageFormSplitContainer
            // 
            this.imageFormSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageFormSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.imageFormSplitContainer.Name = "imageFormSplitContainer";
            this.imageFormSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // imageFormSplitContainer.Panel1
            // 
            this.imageFormSplitContainer.Panel1.Controls.Add(this.pictureBoxImageForm);
            // 
            // imageFormSplitContainer.Panel2
            // 
            this.imageFormSplitContainer.Panel2.Controls.Add(this.buttonDeleteSlice);
            this.imageFormSplitContainer.Panel2.Controls.Add(this.buttonSaveSlice);
            this.imageFormSplitContainer.Size = new System.Drawing.Size(394, 372);
            this.imageFormSplitContainer.SplitterDistance = 308;
            this.imageFormSplitContainer.TabIndex = 0;
            // 
            // pictureBoxImageForm
            // 
            this.pictureBoxImageForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImageForm.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImageForm.Name = "pictureBoxImageForm";
            this.pictureBoxImageForm.Size = new System.Drawing.Size(394, 308);
            this.pictureBoxImageForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImageForm.TabIndex = 0;
            this.pictureBoxImageForm.TabStop = false;
            // 
            // buttonSaveSlice
            // 
            this.buttonSaveSlice.Location = new System.Drawing.Point(12, 3);
            this.buttonSaveSlice.Name = "buttonSaveSlice";
            this.buttonSaveSlice.Size = new System.Drawing.Size(161, 57);
            this.buttonSaveSlice.TabIndex = 0;
            this.buttonSaveSlice.Text = "Save Slice";
            this.buttonSaveSlice.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSlice
            // 
            this.buttonDeleteSlice.Location = new System.Drawing.Point(221, 3);
            this.buttonDeleteSlice.Name = "buttonDeleteSlice";
            this.buttonDeleteSlice.Size = new System.Drawing.Size(161, 57);
            this.buttonDeleteSlice.TabIndex = 1;
            this.buttonDeleteSlice.Text = "Delete Slice";
            this.buttonDeleteSlice.UseVisualStyleBackColor = true;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.imageFormSplitContainer);
            this.Name = "ImageForm";
            this.Text = "Image Slice";
            this.imageFormSplitContainer.Panel1.ResumeLayout(false);
            this.imageFormSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageFormSplitContainer)).EndInit();
            this.imageFormSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer imageFormSplitContainer;
        private System.Windows.Forms.PictureBox pictureBoxImageForm;
        private System.Windows.Forms.Button buttonDeleteSlice;
        private System.Windows.Forms.Button buttonSaveSlice;
    }
}
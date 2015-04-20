namespace Yark
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
      this.bCompress = new System.Windows.Forms.Button();
      this.bDecompress = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // bCompress
      // 
      this.bCompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.bCompress.Location = new System.Drawing.Point(12, 12);
      this.bCompress.Name = "bCompress";
      this.bCompress.Size = new System.Drawing.Size(198, 23);
      this.bCompress.TabIndex = 0;
      this.bCompress.Text = "Архивация";
      this.bCompress.UseVisualStyleBackColor = true;
      this.bCompress.Click += new System.EventHandler(this.bCompress_Click);
      // 
      // bDecompress
      // 
      this.bDecompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.bDecompress.Location = new System.Drawing.Point(12, 41);
      this.bDecompress.Name = "bDecompress";
      this.bDecompress.Size = new System.Drawing.Size(198, 23);
      this.bDecompress.TabIndex = 1;
      this.bDecompress.Text = "Разархивация";
      this.bDecompress.UseVisualStyleBackColor = true;
      this.bDecompress.Click += new System.EventHandler(this.bDecompress_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(221, 73);
      this.Controls.Add(this.bDecompress);
      this.Controls.Add(this.bCompress);
      this.Name = "MainForm";
      this.Text = "Yark";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button bCompress;
    private System.Windows.Forms.Button bDecompress;
  }
}
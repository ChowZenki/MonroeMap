namespace WinFormSamples
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
        this.components = new System.ComponentModel.Container();
        this.mapImage = new SharpMap.Forms.MapImage();
        this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
        this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
        ((System.ComponentModel.ISupportInitialize)(this.mapImage)).BeginInit();
        this.SuspendLayout();
        // 
        // mapImage
        // 
        this.mapImage.ActiveTool = SharpMap.Forms.MapImage.Tools.None;
        this.mapImage.BackColor = System.Drawing.Color.White;
        this.mapImage.Cursor = System.Windows.Forms.Cursors.Cross;
        this.mapImage.Dock = System.Windows.Forms.DockStyle.Fill;
        this.mapImage.FineZoomFactor = 10;
        this.mapImage.Location = new System.Drawing.Point(219, 0);
        this.mapImage.Name = "mapImage";
        this.mapImage.QueryLayerIndex = 0;
        this.mapImage.Size = new System.Drawing.Size(466, 446);
        this.mapImage.TabIndex = 0;
        this.mapImage.TabStop = false;
        this.mapImage.WheelZoomMagnitude = 2;
        this.mapImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mapImage_MouseClick);
        this.mapImage.MouseHover += new System.EventHandler(this.mapImage_MouseHover);
        // 
        // flowLayoutPanel1
        // 
        this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
        this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 4, 4, 4);
        this.flowLayoutPanel1.Size = new System.Drawing.Size(219, 446);
        this.flowLayoutPanel1.TabIndex = 2;
        // 
        // toolTip1
        // 
        this.toolTip1.ShowAlways = true;
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(685, 446);
        this.Controls.Add(this.mapImage);
        this.Controls.Add(this.flowLayoutPanel1);
        this.Name = "MainForm";
        this.Text = "SharpMap Samples";
        ((System.ComponentModel.ISupportInitialize)(this.mapImage)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private SharpMap.Forms.MapImage mapImage;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}


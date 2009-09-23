using System;
using System.Windows.Forms;
using SharpMap.Layers;
using SharpMap.Data.Providers;

namespace WinFormSamples
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      this.mapImage.ActiveTool = SharpMap.Forms.MapImage.Tools.Pan;
      this.mapImage.Map = Samples.ShapefileSample.InitializeMap();
      this.mapImage.Map.Size = this.Size;
      this.mapImage.Refresh();
      mapImage.ActiveTool = SharpMap.Forms.MapImage.Tools.Query;

    }

    private void radioButton_Click(object sender, EventArgs e)
    {
        try
        {
            this.mapImage.Map = Samples.ShapefileSample.InitializeMap();
            this.mapImage.Map.Size = this.Size;
            this.mapImage.Refresh();
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Error");
        }
    }

    private void mapImage_MouseHover(object sender, EventArgs e)
    {
        toolTip1.SetToolTip(mapImage, "Yo");
    }

    private void mapImage_MouseClick(object sender, MouseEventArgs e)
    {
        var shapes = (mapImage.Map.Layers[0] as VectorLayer).DataSource as ShapeFile;
        toolTip1.Hide(mapImage);
//        var worldClick = mapImage.Map.ImageToWorld( new System.Drawing.PointF(e.Location));
//        shapes.ExecuteIntersectionQuery(worldClick)
    }



  }
}

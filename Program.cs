//This project require http://www.ghostscript.com/download/gsdnld.html installer

using System.Drawing.Imaging;
using Ghostscript.NET.Rasterizer;

string BaseDirectory = Environment.CurrentDirectory;
string path = Path.Combine(BaseDirectory, "test.pdf");
string path2 = Path.Combine(BaseDirectory, "test.png");

GhostscriptRasterizer rasterizer=new GhostscriptRasterizer();
rasterizer.Open(path);
var image= rasterizer.GetPage(100,1);
image.Save(path2,ImageFormat.Png);

Console.WriteLine($"{path2} file generated.");


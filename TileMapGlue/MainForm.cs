using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

/// <summary>
/// Tile map glue namespace
/// </summary>
namespace TileMapGlue
{
    /// <summary>
    /// Main form class
    /// </summary>
    public partial class MainForm : MaterialForm
    {
        /// <summary>
        /// Thread
        /// </summary>
        private Thread thread;

        /// <summary>
        /// Progress
        /// </summary>
        private int progress;

        /// <summary>
        /// X minimum
        /// </summary>
        private int xMin;

        /// <summary>
        /// X maximum
        /// </summary>
        private int xMax;

        /// <summary>
        /// Y minimum
        /// </summary>
        private int yMin;

        /// <summary>
        /// Y maximum
        /// </summary>
        private int yMax;

        /// <summary>
        /// Spacing X
        /// </summary>
        private uint spacingX;

        /// <summary>
        /// Spacing Y
        /// </summary>
        private uint spacingY;

        /// <summary>
        /// Tile resolution X
        /// </summary>
        private uint tileResolutionX;

        /// <summary>
        /// Tile resolution Y
        /// </summary>
        private uint tileResolutionY;

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            MaterialSkinManager material_skin_manager = MaterialSkinManager.Instance;
            material_skin_manager.AddFormToManage(this);
            material_skin_manager.Theme = MaterialSkinManager.Themes.DARK;
            material_skin_manager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        /// <summary>
        /// Swap values correctly
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="min">Minimum</param>
        /// <param name="max">Maximum</param>
        private static void SwapValuesCorrectly<T>(ref T min, ref T max) where T : IComparable<T>
        {
            if (max.CompareTo(min) < 0)
            {
                T t = min;
                min = max;
                max = t;
            }
        }

        /// <summary>
        /// Glue button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void glueButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(xMinimumTextField.Text.Trim(), out xMin) && int.TryParse(xMaximumTextField.Text.Trim(), out xMax) && int.TryParse(yMinimumTextField.Text.Trim(), out yMin) && int.TryParse(yMaximumTextField.Text.Trim(), out yMax) && uint.TryParse(spacingXTextField.Text.Trim(), out spacingX) && uint.TryParse(spacingYTextField.Text.Trim(), out spacingY) && uint.TryParse(tileResolutionXTextField.Text.Trim(), out tileResolutionX) && uint.TryParse(tileResolutionYTextField.Text.Trim(), out tileResolutionY))
            {
                if ((sourceTextField.Text.Trim().Length > 0) && (destinationTextField.Text.Trim().Length > 0))
                {
                    xMinimumTextField.Enabled = false;
                    xMaximumTextField.Enabled = false;
                    yMinimumTextField.Enabled = false;
                    yMaximumTextField.Enabled = false;
                    spacingXTextField.Enabled = false;
                    spacingYTextField.Enabled = false;
                    sourceTextField.Enabled = false;
                    destinationTextField.Enabled = false;
                    tileResolutionXTextField.Enabled = false;
                    tileResolutionYTextField.Enabled = false;
                    glueButton.Enabled = false;
                    SwapValuesCorrectly(ref xMin, ref xMax);
                    SwapValuesCorrectly(ref yMin, ref yMax);
                    glueProgressBar.Value = 0;
                    int tiles_x = 0;
                    int tiles_y = 0;
                    for (int x = xMin; x <= xMax; x += (int)spacingX + 1)
                    {
                        ++tiles_x;
                    }
                    for (int y = yMin; y <= yMax; y += (int)spacingY + 1)
                    {
                        ++tiles_y;
                    }
                    glueProgressBar.Maximum = tiles_x * tiles_y;
                    glueProgressBar.Visible = true;
                    progress = 0;
                    thread = new Thread(() =>
                    {
                        
                        string source = sourceTextField.Text;
                        string destination = Path.GetFullPath(destinationTextField.Text);
                        if (File.Exists(destination))
                        {
                            try
                            {
                                File.Delete(destination);
                            }
                            catch (Exception ex)
                            {
                                Console.Error.WriteLine(ex.Message);
                            }
                        }
                        try
                        {
                            using (Bitmap bitmap = new Bitmap(tiles_x * (int)tileResolutionX, tiles_y * (int)tileResolutionY, PixelFormat.Format32bppArgb))
                            {
                                for (int x, y = yMin, x_count, y_count = 0; y <= yMax; y += (int)spacingY + 1)
                                {
                                    x_count = 0;
                                    for (x = xMin; x <= xMax; x += (int)spacingX + 1)
                                    {
                                        string src = Path.GetFullPath(string.Format(source, x, y));
                                        string directory = Path.GetDirectoryName(destination);
                                        if (!(Directory.Exists(directory)))
                                        {
                                            try
                                            {
                                                Directory.CreateDirectory(directory);
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.Error.WriteLine(ex.Message);
                                            }
                                        }
                                        if (File.Exists(src))
                                        {
                                            try
                                            {
                                                using (Image image = Image.FromFile(src))
                                                {
                                                    int t_r_x = Math.Min(image.Width, (int)tileResolutionX);
                                                    int t_r_y = Math.Min(image.Height, (int)tileResolutionY);
                                                    using (Bitmap bmp = new Bitmap(image))
                                                    {
                                                        for (int l_x, l_y = 0; l_y < t_r_y; l_y++)
                                                        {
                                                            for (l_x = 0; l_x < t_r_x; l_x++)
                                                            {
                                                                bitmap.SetPixel((x_count * (int)tileResolutionX) + l_x, (y_count * (int)tileResolutionY) + l_y, bmp.GetPixel(l_x, l_y));
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.Error.WriteLine(ex.Message);
                                            }
                                        }
                                        ++x_count;
                                        progress = x_count + (y_count * tiles_x);
                                    }
                                    ++y_count;
                                }
                                try
                                {
                                    bitmap.Save(destination, ImageFormat.Png);
                                }
                                catch (Exception ex)
                                {
                                    Console.Error.WriteLine(ex.Message);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Error.WriteLine(ex.Message);
                        }
                    });
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("Please specify something for source and destination.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please use numbers for x minimum, x maximum, y minimum, y maximum tile size X and tile size Y to glue a tile map.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Thread time tick event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void threadTimer_Tick(object sender, EventArgs e)
        {
            if (glueProgressBar.Visible)
            {
                glueProgressBar.Value = progress;
                if (progress == glueProgressBar.Maximum)
                {
                    xMinimumTextField.Enabled = true;
                    xMaximumTextField.Enabled = true;
                    yMinimumTextField.Enabled = true;
                    yMaximumTextField.Enabled = true;
                    spacingXTextField.Enabled = true;
                    spacingYTextField.Enabled = true;
                    sourceTextField.Enabled = true;
                    destinationTextField.Enabled = true;
                    tileResolutionXTextField.Enabled = true;
                    tileResolutionYTextField.Enabled = true;
                    glueButton.Enabled = true;
                    glueProgressBar.Visible = false;
                }
            }
        }
    }
}

using System;
using System.Windows.Forms;

/// <summary>
/// Tile map glue namespace
/// </summary>
namespace TileMapGlue
{
    static class Program
    {
        /// <summary>
        /// Main entry point
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

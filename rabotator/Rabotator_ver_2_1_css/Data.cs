using System.Drawing.Printing;

namespace Rabotator
{
    public static class Data
    {
        public static bool orientationPageIsPortrait = false;
        public static PaperSize sizePage = new PaperSize("A4", 595, 842);
        public static string TODOstring;
 
    }

    public static class BookmarksList
    {
        public static string Name { get; set; }
        public static string Link { get; set; }
        public static string Description { get; set; }

    }
    
}

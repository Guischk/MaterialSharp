using System.Collections.Generic;
using System.Drawing;

namespace Material
{
    internal static class Material_Color
    {
        public readonly static Color Black = ColorTranslator.FromHtml("#000000");
        public readonly static Color White = ColorTranslator.FromHtml("#FFFFFF");

        public readonly static Dictionary<int, Color> Red = new Dictionary<int, Color>
        {
            {50, ColorTranslator.FromHtml("#FFEBEE")},
            {100, ColorTranslator.FromHtml("#FFCDD2")},
            {200, ColorTranslator.FromHtml("#EF9A9A")},
            {300, ColorTranslator.FromHtml("#E57373")},
            {400, ColorTranslator.FromHtml("#EF5350")},
            {500, ColorTranslator.FromHtml("#F44336")},
            {600, ColorTranslator.FromHtml("#D32F2F")},
            {700, ColorTranslator.FromHtml("#D32F2F")},
            {800, ColorTranslator.FromHtml("#C62828")},
            {900, ColorTranslator.FromHtml("#B71C1C")}
        };

        public readonly static Dictionary<int, Color> Pink = new Dictionary<int, Color>
        {
            {50, ColorTranslator.FromHtml("#FCE4EC")},
            {100, ColorTranslator.FromHtml("#F8BBD0")},
            {200, ColorTranslator.FromHtml("#F48FB1")},
            {300, ColorTranslator.FromHtml("#F06292")},
            {400, ColorTranslator.FromHtml("#EC407A")},
            {500, ColorTranslator.FromHtml("#E91E63")},
            {600, ColorTranslator.FromHtml("#D81B60")},
            {700, ColorTranslator.FromHtml("#C2185B")},
            {800, ColorTranslator.FromHtml("#AD1457")},
            {900, ColorTranslator.FromHtml("#880E4F")}
        };

        public readonly static Dictionary<int, Color> Purple = new Dictionary<int, Color>
        {
            {50, ColorTranslator.FromHtml("#F3E5F5")},
            {100, ColorTranslator.FromHtml("#E1BEE7")},
            {200, ColorTranslator.FromHtml("#CE93D8")},
            {300, ColorTranslator.FromHtml("#BA68C8")},
            {400, ColorTranslator.FromHtml("#AB47BC")},
            {500, ColorTranslator.FromHtml("#9C27B0")},
            {600, ColorTranslator.FromHtml("#8E24AA")},
            {700, ColorTranslator.FromHtml("#7B1FA2")},
            {800, ColorTranslator.FromHtml("#6A1B9A")},
            {900, ColorTranslator.FromHtml("#4A148C")}
        };

        public readonly static Dictionary<int, Color> DeepPurple = new Dictionary<int, Color>
        {
            {50, ColorTranslator.FromHtml("#EDE7F6")},
            {100, ColorTranslator.FromHtml("#D1C4E9")},
            {200, ColorTranslator.FromHtml("#B39DDB")},
            {300, ColorTranslator.FromHtml("#9575CD")},
            {400, ColorTranslator.FromHtml("#7E57C2")},
            {500, ColorTranslator.FromHtml("#673AB7")},
            {600, ColorTranslator.FromHtml("#5E35B1")},
            {700, ColorTranslator.FromHtml("#512DA8")},
            {800, ColorTranslator.FromHtml("#4527A0")},
            {900, ColorTranslator.FromHtml("#311B92")}
        };

        public readonly static Dictionary<int, Color> Indigo = new Dictionary<int, Color>
        {
            {50,  ColorTranslator.FromHtml("#E8EAF6")},
            {100, ColorTranslator.FromHtml("#C5CAE9")},
            {200, ColorTranslator.FromHtml("#9FA8DA")},
            {300, ColorTranslator.FromHtml("#7986CB")},
            {400, ColorTranslator.FromHtml("#5C6BC0")},
            {500, ColorTranslator.FromHtml("#3F51B5")},
            {600, ColorTranslator.FromHtml("#3949AB")},
            {700, ColorTranslator.FromHtml("#303F9F")},
            {800, ColorTranslator.FromHtml("#283593")},
            {900, ColorTranslator.FromHtml("#1A237E")}
        };

        public readonly static Dictionary<int, Color> Blue = new Dictionary<int, Color>
        {
            {50,  ColorTranslator.FromHtml("#E3F2FD")},
            {100, ColorTranslator.FromHtml("#BBDEFB")},
            {200, ColorTranslator.FromHtml("#90CAF9")},
            {300, ColorTranslator.FromHtml("#64B5F6")},
            {400, ColorTranslator.FromHtml("#42A5F5")},
            {500, ColorTranslator.FromHtml("#2196F3")},
            {600, ColorTranslator.FromHtml("#1E88E5")},
            {700, ColorTranslator.FromHtml("#1976D2")},
            {800, ColorTranslator.FromHtml("#1565C0")},
            {900, ColorTranslator.FromHtml("#0D47A1")}
        };

        public readonly static Dictionary<int, Color> LightBlue = new Dictionary<int, Color>
        {
            {50,  ColorTranslator.FromHtml("#E1F5FE")},
            {100, ColorTranslator.FromHtml("#B3E5FC")},
            {200, ColorTranslator.FromHtml("#81D4FA")},
            {300, ColorTranslator.FromHtml("#4FC3F7")},
            {400, ColorTranslator.FromHtml("#29B6F6")},
            {500, ColorTranslator.FromHtml("#03A9F4")},
            {600, ColorTranslator.FromHtml("#039BE5")},
            {700, ColorTranslator.FromHtml("#0288D1")},
            {800, ColorTranslator.FromHtml("#0277BD")},
            {900, ColorTranslator.FromHtml("#01579B")}
        };

        public readonly static Dictionary<int, Color> Cyan = new Dictionary<int, Color>
        {
            {50,  ColorTranslator.FromHtml("#E0F7FA")},
            {100, ColorTranslator.FromHtml("#B2EBF2")},
            {200, ColorTranslator.FromHtml("#80DEEA")},
            {300, ColorTranslator.FromHtml("#4DD0E1")},
            {400, ColorTranslator.FromHtml("#26C6DA")},
            {500, ColorTranslator.FromHtml("#00BCD4")},
            {600, ColorTranslator.FromHtml("#00ACC1")},
            {700, ColorTranslator.FromHtml("#0097A7")},
            {800, ColorTranslator.FromHtml("#00838F")},
            {900, ColorTranslator.FromHtml("#006064")}
        };

        public readonly static Dictionary<int, Color> Teal = new Dictionary<int, Color>
        {
            {50,  ColorTranslator.FromHtml("#E0F2F1")},
            {100, ColorTranslator.FromHtml("#B2DFDB")},
            {200, ColorTranslator.FromHtml("#80CBC4")},
            {300, ColorTranslator.FromHtml("#4DB6AC")},
            {400, ColorTranslator.FromHtml("#26A69A")},
            {500, ColorTranslator.FromHtml("#009688")},
            {600, ColorTranslator.FromHtml("#00897B")},
            {700, ColorTranslator.FromHtml("#00796B")},
            {800, ColorTranslator.FromHtml("#00695C")},
            {900, ColorTranslator.FromHtml("#004D40")}
        };

        public readonly static Dictionary<int, Color> Green = new Dictionary<int, Color>
        {
            {50,  ColorTranslator.FromHtml("#E8F5E9")},
            {100, ColorTranslator.FromHtml("#C8E6C9")},
            {200, ColorTranslator.FromHtml("#A5D6A7")},
            {300, ColorTranslator.FromHtml("#81C784")},
            {400, ColorTranslator.FromHtml("#66BB6A")},
            {500, ColorTranslator.FromHtml("#4CAF50")},
            {600, ColorTranslator.FromHtml("#43A047")},
            {700, ColorTranslator.FromHtml("#388E3C")},
            {800, ColorTranslator.FromHtml("#2E7D32")},
            {900, ColorTranslator.FromHtml("#1B5E20")}
        };

        public readonly static Dictionary<int, Color> LightGreen = new Dictionary<int, Color>
        {
            {50,  ColorTranslator.FromHtml("#F1F8E9")},
            {100, ColorTranslator.FromHtml("#DCEDC8")},
            {200, ColorTranslator.FromHtml("#C5E1A5")},
            {300, ColorTranslator.FromHtml("#AED581")},
            {400, ColorTranslator.FromHtml("#9CCC65")},
            {500, ColorTranslator.FromHtml("#8BC34A")},
            {600, ColorTranslator.FromHtml("#7CB342")},
            {700, ColorTranslator.FromHtml("#689F38")},
            {800, ColorTranslator.FromHtml("#558B2F")},
            {900, ColorTranslator.FromHtml("#33691E")}
        };

        public readonly static Dictionary<int, Color> Lime = new Dictionary<int, Color>
        {
            {50,  ColorTranslator.FromHtml("#F9FBE7")},
            {100, ColorTranslator.FromHtml("#F0F4C3")},
            {200, ColorTranslator.FromHtml("#E6EE9C")},
            {300, ColorTranslator.FromHtml("#DCE775")},
            {400, ColorTranslator.FromHtml("#D4E157")},
            {500, ColorTranslator.FromHtml("#CDDC39")},
            {600, ColorTranslator.FromHtml("#C0CA33")},
            {700, ColorTranslator.FromHtml("#AFB42B")},
            {800, ColorTranslator.FromHtml("#9E9D24")},
            {900, ColorTranslator.FromHtml("#827717")}
        };

        public readonly static Dictionary<int, Color> Yellow = new Dictionary<int, Color>
        {
            {50,  ColorTranslator.FromHtml("#FFFDE7")},
            {100, ColorTranslator.FromHtml("#FFF9C4")},
            {200, ColorTranslator.FromHtml("#FFF59D")},
            {300, ColorTranslator.FromHtml("#FFF176")},
            {400, ColorTranslator.FromHtml("#FFEE58")},
            {500, ColorTranslator.FromHtml("#FFEB3B")},
            {600, ColorTranslator.FromHtml("#FDD835")},
            {700, ColorTranslator.FromHtml("#FBC02D")},
            {800, ColorTranslator.FromHtml("#F9A825")},
            {900, ColorTranslator.FromHtml("#F57F17")}
        };

        public readonly static Dictionary<int, Color> Amber = new Dictionary<int, Color>
        {
            {50,  ColorTranslator.FromHtml("#FFF8E1")},
            {100, ColorTranslator.FromHtml("#FFECB3")},
            {200, ColorTranslator.FromHtml("#FFE082")},
            {300, ColorTranslator.FromHtml("#FFD54F")},
            {400, ColorTranslator.FromHtml("#FFCA28")},
            {500, ColorTranslator.FromHtml("#FFC107")},
            {600, ColorTranslator.FromHtml("#FFB300")},
            {700, ColorTranslator.FromHtml("#FFA000")},
            {800, ColorTranslator.FromHtml("#FF8F00")},
            {900, ColorTranslator.FromHtml("#FF6F00")}
        };

        public readonly static Dictionary<int, Color> Orange = new Dictionary<int, Color>
        {
            {50,  ColorTranslator.FromHtml("#FFF3E0")},
            {100, ColorTranslator.FromHtml("#FFE0B2")},
            {200, ColorTranslator.FromHtml("#FFCC80")},
            {300, ColorTranslator.FromHtml("#FFB74D")},
            {400, ColorTranslator.FromHtml("#FFA726")},
            {500, ColorTranslator.FromHtml("#FF9800")},
            {600, ColorTranslator.FromHtml("#FB8C00")},
            {700, ColorTranslator.FromHtml("#F57C00")},
            {800, ColorTranslator.FromHtml("#EF6C00")},
            {900, ColorTranslator.FromHtml("#E65100")}
        };

        public readonly static Dictionary<int, Color> DeepOrange = new Dictionary<int, Color>
        {
            {50,  ColorTranslator.FromHtml("#FBE9E7")},
            {100, ColorTranslator.FromHtml("#FFCCBC")},
            {200, ColorTranslator.FromHtml("#FFAB91")},
            {300, ColorTranslator.FromHtml("#FF8A65")},
            {400, ColorTranslator.FromHtml("#FF7043")},
            {500, ColorTranslator.FromHtml("#FF5722")},
            {600, ColorTranslator.FromHtml("#F4511E")},
            {700, ColorTranslator.FromHtml("#E64A19")},
            {800, ColorTranslator.FromHtml("#D84315")},
            {900, ColorTranslator.FromHtml("#BF360C")}
        };

        public readonly static Dictionary<int, Color> Brown = new Dictionary<int, Color>
        {
            {50,  ColorTranslator.FromHtml("#EFEBE9")},
            {100, ColorTranslator.FromHtml("#D7CCC8")},
            {200, ColorTranslator.FromHtml("#BCAAA4")},
            {300, ColorTranslator.FromHtml("#A1887F")},
            {400, ColorTranslator.FromHtml("#8D6E63")},
            {500, ColorTranslator.FromHtml("#795548")},
            {600, ColorTranslator.FromHtml("#6D4C41")},
            {700, ColorTranslator.FromHtml("#5D4037")},
            {800, ColorTranslator.FromHtml("#4E342E")},
            {900, ColorTranslator.FromHtml("#3E2723")}
        };

        public readonly static Dictionary<int, Color> Gray = new Dictionary<int, Color>
        {
            {50,  ColorTranslator.FromHtml("#FAFAFA")},
            {100, ColorTranslator.FromHtml("#F5F5F5")},
            {200, ColorTranslator.FromHtml("#EEEEEE")},
            {300, ColorTranslator.FromHtml("#E0E0E0")},
            {400, ColorTranslator.FromHtml("#BDBDBD")},
            {500, ColorTranslator.FromHtml("#9E9E9E")},
            {600, ColorTranslator.FromHtml("#757575")},
            {700, ColorTranslator.FromHtml("#616161")},
            {800, ColorTranslator.FromHtml("#424242")},
            {900, ColorTranslator.FromHtml("#212121")}
        };

        public readonly static Dictionary<int, Color> BlueGray = new Dictionary<int, Color>
        {
            {50,  ColorTranslator.FromHtml("#ECEFF1")},
            {100, ColorTranslator.FromHtml("#CFD8DC")},
            {200, ColorTranslator.FromHtml("#B0BEC5")},
            {300, ColorTranslator.FromHtml("#90A4AE")},
            {400, ColorTranslator.FromHtml("#78909C")},
            {500, ColorTranslator.FromHtml("#607D8B")},
            {600, ColorTranslator.FromHtml("#546E7A")},
            {700, ColorTranslator.FromHtml("#455A64")},
            {800, ColorTranslator.FromHtml("#37474F")},
            {900, ColorTranslator.FromHtml("#263238")}
        };
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySelectionColor
{
    internal static class Extensions
    {
        public static string ToRGBString(this Color color)
        {
            return $"{color.R} {color.G} {color.B}";
        }
    }
}

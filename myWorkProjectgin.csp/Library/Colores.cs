using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myWorkProjectgin.csp.Library.Colores
{
    public class publicColores
    {
        public static class Colores
        {
            // C# usa \x1b para el carácter de escape (en lugar de \033)
            // También puedes usar \u001b, ambos son equivalentes.

            // Código para resetear el color
            public const string RESET = "\x1b[0m";

            // Códigos de colores
            public const string ROJO = "\x1b[31m";
            public const string NEGRO = "\x1b[30m";
            public const string AMARILLO = "\x1b[33m";
            public const string AZUL = "\x1b[34m";
            public const string VERDE = "\x1b[32m";
            public const string MAGENTA = "\x1b[35m";
            public const string CIAN = "\x1b[36m";
            public const string BLANCO = "\x1b[37m";

            // Códigos de formato
            public const string SUBRAYADO = "\x1b[4m";
            public const string BOLD = "\x1b[1m"; // (Extra) Negrita
        }
    }
}

using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;
//using myWorkProjectgin.csp.Project.Colores;

namespace myWorkProjectgin.csp
{
    public class myWorkClass
    {
        public static void Main(string[] args)
        {
            /// <summary>
            /// agregar chunk
            /// </summary>
            //用于支持utf8编码输出
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //[STAThread] //设置单线程单元模型
            /// <summary>
            /// Main
            /// </summary>
            mainPos();
            static void mainPos()
            {
                string espacio = " ";
                //Console.Clear();
                Console.WriteLine(ColoresMain.AZUL + "Bienvenido, Selecciones el maquina de POS" + ColoresMain.RESET);
                Console.WriteLine(espacio);
                Console.WriteLine("1. Pos_1");
                Console.WriteLine("2. Pos_2");
                Console.WriteLine(espacio);
                Console.Write(">> ");
                string selectPos = Console.ReadLine() ?? string.Empty;
                while (true)
                {
                    if (selectPos == "1")
                    {
                        Thread.Sleep(80);
                        login();
                    }
                    else
                    {
                        Console.WriteLine(ColoresMain.ROJO + "Error.  Incorrecto>!  " + ColoresMain.RESET);
                        Environment.Exit(0);
                    }
                }
                

            }

            // Pos_1
            static void login()
            {

            }         
        }

        /// <summary>
        /// agregar chunk color,, (1)
        /// </summary>
        public static class ColoresMain
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
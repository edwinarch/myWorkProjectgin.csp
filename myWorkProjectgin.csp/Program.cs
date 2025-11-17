using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using myWorkProjectgin.csp.Project.Colores;
using myWorkProjectgin.csp.Library.Colores;
using myWorkProjectgin.csp.Library.ReadPassword;

namespace myWorkProjectgin.csp
{
    public class myWorkClass
    {
        public static void Main(string[] args)
        {
            /// <summary>
            /// agregar chunk main
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
                string esp = " ";              
                Console.WriteLine(publicColores.Colores.AZUL + "Bienvenido, Selecciones el maquina de POS" + publicColores.Colores.RESET);
                Console.WriteLine(esp);
                Console.WriteLine("1. Pos_1");
                Console.WriteLine("2. Pos_2");
                Console.WriteLine(esp);
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
                        Console.WriteLine(esp);
                        Console.WriteLine(publicColores.Colores.ROJO + "Error.  Incorrecto>!  " + publicColores.Colores.RESET);
                        Environment.Exit(0);
                    }
                }
            }

            // Pos_1
            static void login()
            {
                //chunk
                string esp = " ";
                //pwd
                string contra = "123";
                string contrachikycroos = "chiky";

                int intentos = 4;

                while (intentos > 0)
                {
                    while (true)
                    {
                        Console.WriteLine(esp);
                        Console.WriteLine(publicColores.Colores.VERDE + "Preparando..." + publicColores.Colores.RESET);
                        Console.Clear();
                        Console.WriteLine(publicColores.Colores.AZUL + "__ __LOGIN-POS__ __" + publicColores.Colores.RESET);
                        Console.WriteLine(esp);
                        Console.WriteLine("------------------------------------------------");
                        Console.Write("Ingresa tu contraseña: ");
                        string entrada = publicReadPassword.ReadPassword();   // ← 等价于 getpass.getpass()
                        Console.WriteLine("------------------------------------------------");

                        if (entrada == contra)   //primer plano 
                        {
                        
                            Console.WriteLine(esp);
                            Console.WriteLine(publicColores.Colores.VERDE + "Contraseña correcta. Acceso concedido." + publicColores.Colores.RESET);
                            Thread.Sleep(2000);
                            Environment.Exit(0);
                        }
                        else if (entrada == contrachikycroos)
                        {
                            Console.WriteLine(esp);
                            Console.WriteLine(publicColores.Colores.VERDE + "Bienvenido chiky! contraseña correcta." + publicColores.Colores.RESET);
                            Thread.Sleep(2000);
                            Environment.Exit(0);
                        }
                        else
                        {
                            intentos -= 1;

                            if (intentos > 0)
                            {

                                if (intentos == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine(publicColores.Colores.AZUL + "__ __LOGIN-POS__ __" + publicColores.Colores.RESET);
                                    Console.WriteLine(esp);
                                    Console.WriteLine("------------------------------------------------");
                                    Console.WriteLine("Incorrecta! Te quedan " + publicColores.Colores.VERDE + intentos + publicColores.Colores.RESET + " intentos. Inténtalo de nuevo: ");
                                    Console.WriteLine("------------------------------------------------");
                                    Thread.Sleep(2000);
                                }
                                else if (intentos == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine(publicColores.Colores.AZUL + "__ __LOGIN-POS__ __" + publicColores.Colores.RESET);
                                    Console.WriteLine(esp);
                                    Console.WriteLine("------------------------------------------------");
                                    Console.WriteLine("Incorrecta! Te quedan " + publicColores.Colores.AMARILLO + intentos + publicColores.Colores.RESET + " intentos. Inténtalo de nuevo: ");
                                    Console.WriteLine("------------------------------------------------");
                                    Thread.Sleep(2000);
                                }
                                else if (intentos == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(publicColores.Colores.AZUL + "__ __LOGIN-POS__ __" + publicColores.Colores.RESET);
                                    Console.WriteLine(esp);
                                    Console.WriteLine("------------------------------------------------");
                                    Console.WriteLine("Incorrecta! Te quedan " + publicColores.Colores.ROJO + intentos + publicColores.Colores.RESET + " intentos. Inténtalo de nuevo: ");
                                    Console.WriteLine("------------------------------------------------");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    // por si sale error
                                    Console.WriteLine("Error de cat pos. ");
                                    Environment.Exit(0);
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(esp);
                                Console.WriteLine(publicColores.Colores.AZUL + "------------------------------------------------" + publicColores.Colores.RESET);
                                Console.WriteLine(publicColores.Colores.ROJO + "Contraseña incorrecta. Te quedanron 0 intentos" + publicColores.Colores.RESET);
                                Console.WriteLine(publicColores.Colores.AZUL + "------------------------------------------------" + publicColores.Colores.RESET);
                                Console.WriteLine(esp);
                                Console.WriteLine(publicColores.Colores.ROJO + "!~!~!~!~!~!~!~!~" + publicColores.Colores.RESET);
                                Console.WriteLine("Contraseña incorrecta. " + publicColores.Colores.ROJO + "No te quedan intentos. Acceso denegado." + publicColores.Colores.RESET);
                                Console.WriteLine(publicColores.Colores.ROJO + "!~!~!~!~!~!~!~!~" + publicColores.Colores.RESET);
                                Thread.Sleep(2000);
                                Environment.Exit(0);
                            }
                        }
                    }
                }
            }         
        }

        /// <summary>
        /// agregar chunk color,, (1)           
        /// </summary>                      
        public static class ColoresMain
        {
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
            public const string SUBRAYADO = "\x1b[4m";
        }

        /// <summary>
        /// agregar chunk ocultos de ReadLine,, (2)
        /// </summary>
        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                keyInfo = Console.ReadKey(intercept: true); // 不显示按键

                if (keyInfo.Key == ConsoleKey.Enter)
                    break;

                if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (password.Length > 0)
                        password = password[..^1];
                    continue;
                }

                password += keyInfo.KeyChar;
            }

            Console.WriteLine(); // 换行
            return password;
        }      
    }
}
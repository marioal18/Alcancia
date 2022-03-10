namespace Alcancia
{
    class Alcancia
    {
        static void Main (string[] args)
        {
            int moneda = 0;
            int cantMone1 = 0;
            int cantMone2 = 0;
            int cantMone3 = 0;
            int cantMone4 = 0;
            int cantMone5 = 0;

            int total1 = 0;
            int total2 = 0;
            int total3 = 0;
            int total4 = 0;
            int total5 = 0;
            int total = 0;
            int pregunta = 0;

            int opcionDigitada = 0;
            int x;

            while (opcionDigitada != 4)
            {
                Console.WriteLine("1. Ingresar moneda");
                Console.WriteLine("2. Cantidad de monedas por denominacón");
                Console.WriteLine("3. Valor por denominacón");
                Console.WriteLine("4. Salir");
                Console.WriteLine("___________________________");
                Console.WriteLine("Ingrese una opcion: ");

                string opcionDigitada2 = Console.ReadLine();

                if (int.TryParse(opcionDigitada2, out x))
                {
                    opcionDigitada = int.Parse(opcionDigitada2);
                    
                    switch (opcionDigitada)
                    {
                        case 1:
                            do
                            {
                                System.Console.WriteLine("Ingrese la denominacion de la moneda");
                                System.Console.WriteLine("Valores: 50 , 100, 200, 500, 1000");
                                moneda = System.Convert.ToInt32(System.Console.ReadLine());

                                if (moneda == 50 || moneda == 100 || moneda == 200 || moneda == 500 || moneda == 1000)
                                {
                                    switch (moneda)
                                    {
                                        case 50:
                                            System.Console.WriteLine("Ingresaste 50");
                                            System.Console.WriteLine("Ingrese la cantidad cantidad");
                                            cantMone1 = System.Convert.ToInt32(System.Console.ReadLine());
                                            total1 = moneda * cantMone1;
                                            System.Console.WriteLine(total1);
                                            break;
                                        case 100:
                                            System.Console.WriteLine("Ingresaste 100");
                                            System.Console.WriteLine("Ingrese la cantidad cantidad");
                                            cantMone2 = System.Convert.ToInt32(System.Console.ReadLine());
                                            total2 = moneda * cantMone2;
                                            System.Console.WriteLine(total2);
                                            break;
                                        case 200:
                                            System.Console.WriteLine("Ingresaste 200");
                                            System.Console.WriteLine("Ingrese la cantidad cantidad");
                                            cantMone3 = System.Convert.ToInt32(System.Console.ReadLine());
                                            total3 = moneda * cantMone3;
                                            System.Console.WriteLine(total3);
                                            break;
                                        case 500:
                                            System.Console.WriteLine("Ingresaste 500");
                                            System.Console.WriteLine("Ingrese la cantidad cantidad");
                                            cantMone4 = System.Convert.ToInt32(System.Console.ReadLine());
                                            total4 = moneda * cantMone4;
                                            System.Console.WriteLine(total4);
                                            break;
                                        case 1000:
                                            System.Console.WriteLine("Ingresaste 1000");
                                            System.Console.WriteLine("Ingrese la cantidad cantidad");
                                            cantMone5 = System.Convert.ToInt32(System.Console.ReadLine());
                                            total5 = moneda * cantMone5;
                                            System.Console.WriteLine(total5);
                                            break;
                                    }

                                    int cantMone1total = cantMone1 + cantMone1;

                                    total = total1 + total2 + total3 + total4 + total5;
                                    System.Console.WriteLine("El total de su alcancía es de: " + total);

                                }
                                else
                                {
                                    System.Console.WriteLine("Ingrese una denominación existente");
                                }

                                System.Console.WriteLine("¿Quiere ingresar una moneda?");
                                pregunta = System.Convert.ToInt32(Console.ReadLine());

                            } while (pregunta == 1);

                            break;

                        case 2:
                            System.Console.WriteLine("¿De que denominación quiere saber la cantidad?");
                            Console.WriteLine("1. 50");
                            Console.WriteLine("2. 100");
                            Console.WriteLine("3. 200");
                            Console.WriteLine("4. 500");
                            Console.WriteLine("5. 1000");

                            int opciondenom = System.Convert.ToInt32(System.Console.ReadLine());

                            switch (opciondenom)
                            {
                                case 1:
                                    System.Console.WriteLine("Hay " + cantMone1 + " monedas de 500" );
                                    break;
                            }

                            break;

                        case 3:

                            break;

                        case 4:

                            break;

                        default:
                            Console.WriteLine("La opcion seleccionada no se encuentra disponible.");

                            break;
                    }
                }
                else
                {
                    opcionDigitada = 0;
                    Console.WriteLine("La opcion seleccionada no se encuentra disponible.");
                }
            }




        }
    }
}

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


            while (pregunta == 1)
            {
                System.Console.WriteLine("¿Quiere ingresar una moneda?");
                pregunta = System.Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine("Ingrese la denominacion de la moneda");
                System.Console.WriteLine("Valores: 50 , 100, 200, 500, 1000");
                moneda = System.Convert.ToInt32(System.Console.ReadLine());

                if (moneda == 50 || moneda == 100 || moneda == 200 || moneda == 500 || moneda == 1000)
                {
                    switch (moneda)
                    {
                        case 50:
                            System.Console.WriteLine("Ingresaste 50");
                            System.Console.WriteLine("cantidad");
                            cantMone1 = System.Convert.ToInt32(System.Console.ReadLine());
                            total1 = moneda * cantMone1;
                            System.Console.WriteLine(total1);
                            break;
                        case 100:
                            System.Console.WriteLine("Ingresaste 100");
                            System.Console.WriteLine("cantidad");
                            cantMone2 = System.Convert.ToInt32(System.Console.ReadLine());
                            total2 = moneda * cantMone2;
                            System.Console.WriteLine(total2);
                            break;
                        case 200:
                            System.Console.WriteLine("Ingresaste 200");
                            System.Console.WriteLine("cantidad");
                            cantMone3 = System.Convert.ToInt32(System.Console.ReadLine());
                            total3 = moneda * cantMone3;
                            System.Console.WriteLine(total3);
                            break;
                        case 500:
                            System.Console.WriteLine("Ingresaste 500");
                            System.Console.WriteLine("cantidad");
                            cantMone4 = System.Convert.ToInt32(System.Console.ReadLine());
                            total4 = moneda * cantMone4;
                            System.Console.WriteLine(total4);
                            break;
                        case 1000:
                            System.Console.WriteLine("Ingresaste 1000");
                            System.Console.WriteLine("cantidad");
                            cantMone5 = System.Convert.ToInt32(System.Console.ReadLine());
                            total5 = moneda * cantMone5;
                            System.Console.WriteLine(total5);
                            break;
                    }
                    total = total1 + total2 + total3 + total4 + total5;
                    System.Console.WriteLine("El total de su alcancía es de: " + total);
                }
                else
                {
                    System.Console.WriteLine("Ingrese una denominación existente");
                }
                Console.Clear();
            }

        }
    }
}

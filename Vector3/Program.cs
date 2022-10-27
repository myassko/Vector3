namespace Vector3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Vector a = new Vector(1, 4, 5);
            Vector b = new Vector(1, 2, 4);

            Console.WriteLine($"Вектор а-{a.ToString()}");
            Console.WriteLine($"Вектор b-{b.ToString()}");

            Console.WriteLine($"Длина вектора а={a.GetLength()}");
            Console.WriteLine($"Длина вектора b={b.GetLength()}");

            Vector v = a.GetAddition(b);
            Console.WriteLine($"Сложение векторов a и б={v.ToString()}");

            Vector z=a.GetSubtraction(b);
            Console.WriteLine($"Вычитание векторов a и б={z.ToString()}");

            Console.WriteLine($"Скалярное произведение a и b={a.Dot(b)}");

    
            Console.WriteLine($"Угол между а и b={a.GetAngle(b)} радиан");
            Console.WriteLine($"Угол между а и b={(a.GetAngle(b)*180)/Math.PI} градусов");
            Console.WriteLine($"Косинус угла между а и b={a.GetCos(b)}");

        }
    }
}
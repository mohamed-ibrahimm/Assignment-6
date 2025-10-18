using ClassLibrary1;
using System;

namespace Assignment_6
{
    internal class Program
    {
        public static void RunAsignment1()
        {
            var P = new Point3D(10, 10, 10);
            Console.WriteLine(P);

            var P1 = ReadPoint("Enter P1 (x y z): ");
            var P2 = ReadPoint("Enter P2 (x y z): ");

            Console.WriteLine(P1 == P2 ? "Equal" : "Not Equal");

            var arr = new[] { P, P1, P2 };
            Array.Sort(arr, (a, b) => a.X == b.X ? a.Y.CompareTo(b.Y) : a.X.CompareTo(b.X));
            foreach (var it in arr) Console.WriteLine(it);

            Console.WriteLine("Clone: " + P1.Clone());
        }

        static Point3D ReadPoint(string msg)
        {
            Console.Write(msg);
            var p = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (p.Length != 3
                || !int.TryParse(p[0], out int x)
                || !int.TryParse(p[1], out int y)
                || !int.TryParse(p[2], out int z))
            {
                Console.WriteLine("Invalid input, using default (0 0 0).");
                return new Point3D();
            }
            return new Point3D(x, y, z);
        }
        public static void RunAsignment2()
        {
            double a = 10, b = 5;

            Console.WriteLine($"Add: {Maths.Add(a, b)}");
            Console.WriteLine($"Subtract: {Maths.Subtract(a, b)}");
            Console.WriteLine($"Multiply: {Maths.Multiply(a, b)}");
            Console.WriteLine($"Divide: {Maths.Divide(a, b)}");
        }
        public static void RunAssignment3()
        {
            Console.Write("Enter user type (Regular, Premium, Guest): ");
            string userType = Console.ReadLine().Trim().ToLower();

            Console.Write("Enter user name: ");
            string name = Console.ReadLine();

            User user = userType switch
            {
                "regular" => new RegularUser(name),
                "premium" => new PremiumUser(name),
                "guest" => new GuestUser(name),
                _ => new GuestUser(name)
            };

            Console.Write("Enter product price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int qty = int.Parse(Console.ReadLine());

            Discount discount = user.GetDiscount();
            decimal discountAmount = discount?.CalculateDiscount(price, qty) ?? 0;
            decimal total = (price * qty) - discountAmount;

            Console.WriteLine($"\nUser: {user.Name}");
            Console.WriteLine($"Discount Type: {discount?.Name ?? "No Discount"}");
            Console.WriteLine($"Discount Amount: {discountAmount:C}");
            Console.WriteLine($"Final Price: {total:C}");
        }

        static void Main() => RunAssignment3();
    }
}

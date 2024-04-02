namespace modifiers.encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(10, 1,2, true);

            while (true)
            {
                Console.WriteLine("emeliyyati secin: ");
                Console.WriteLine("0 - İnformasiya almaq ücün");
                Console.WriteLine("1 - Shoot metodu ucun");
                Console.WriteLine("2 - Fire metodu ucun");
                Console.WriteLine("3 - GetRemainBulletCount metodu ucun");
                Console.WriteLine("4 - Reload metodu ucun");
                Console.WriteLine("5 - ChangeFireMode metodu ucun");
                Console.WriteLine("6 - Proqramdan dayandırmaq ucun");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        Console.WriteLine($"BulletCapacity: {weapon.BulletCapacity}");
                        Console.WriteLine($"BulletCount: {weapon.BulletCount}");
                        Console.WriteLine($"DischargeTime: {weapon.DischargeTime}");
                        Console.WriteLine($"ShootingMode: {(weapon.ShootingMode ? "avtomatik" : "tekli")}");
                        break;
                    case "1":
                        weapon.Shoot();
                        break;
                    case "2":
                        weapon.Fire();
                        break;
                    case "3":
                        Console.WriteLine($"Qalan gulle sayi: {weapon.GetRemainBulletCount()}");
                        break;
                    case "4":
                        weapon.Reload();
                        break;
                    case "5":
                        weapon.ChangeFireMode();
                        break;
                    case "6":
                        return; 
                }
            }
        }
    }
}

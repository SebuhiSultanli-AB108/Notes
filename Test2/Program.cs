using Test2.Models;

namespace Test2;

//                     //
//        /\_/\        //
//       ( o.o )       //
//         >^<         //
//                     //

internal class Program
{
    static void Main()
    {
        Console.WriteLine("                            ╾━╤デ╦︻ \n");
        Console.Write("Max Ammo: ");
        int maxAmmo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ammo: ");
        int ammo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Mag Fixed Empty Seconds: ");
        int magFixedMtSec = Convert.ToInt32(Console.ReadLine());
        Console.Write("Is Auto(true/false): ");
        bool isAuto = Convert.ToBoolean(Console.ReadLine());
        Weapon weapon = new Weapon(maxAmmo,ammo,magFixedMtSec,isAuto);
        Console.WriteLine("0 - Shoot\n" +
                          "1 - Fire\n" +
                          "2 - Fire Mode\n" +
                          "3 - Remaining bullets\n" +
                          "4 - Info\n" +
                          "5 - Reload\n" +
                          "6 - Exit\n");

        while (true)
        {
            
            bool stopTheGame = false;
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 0:
                    weapon.Shoot();
                    break;
                case 1:
                    weapon.Fire();
                    break;
                case 2:
                    Console.Write("Is Auto(true/false): ");
                    bool Auto = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine(Auto);
                    weapon.ChangeFireMode(Auto);
                    Console.WriteLine(weapon.IsAuto);
                    break;
                case 3:
                    weapon.GetRemainBulletCount();
                    break;
                case 4:
                    weapon.MagInfo();
                    break;
                case 5:
                    weapon.Reload();
                    break;
                case 6:
                    stopTheGame = true;
                    break;
                default:
                    Console.WriteLine("Give me a input between 0 and 5 please!");
                    break;
            }
            if (stopTheGame) break;
        }
    }
}
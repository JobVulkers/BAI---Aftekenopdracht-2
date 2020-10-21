using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace BAI
{
    public partial class BAI_Afteken2
    {
        public static bool Vooruit(uint b)
        {

            if (b >> 7 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static uint Vermogen(uint b)
        {
            if ((b & (1 << 5)) == 0 && (b & (1 << 6)) == 0)
            {
                return 0;
            }
            else if ((b & (1 << 5)) != 0 && (b & (1 << 6)) == 0)
            {
                return 33;
            }
            else if ((b & (1 << 5)) == 0 && (b & (1 << 6)) != 0)
            {
                return 67;
            }
            else if ((b & (1 << 5)) != 0 && (b & (1 << 6)) != 0)
            {
                return 100;
            } else
            {
                return 0;
            }

        }
        public static bool Wagon(uint b)
        {
            if ((b & (1 << 4)) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Licht(uint b)
        {
            if ((b & (1 << 3)) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static uint ID(uint b)
        {
            uint Result = 0;

            Result = b << 29;
            Result = Result >> 29;
            Console.WriteLine(Result + " hallo");

            return Result;

        }

        public static HashSet<uint> Alle(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            // *** IMPLEMENTATION HERE *** //
            return set;
        }
        public static HashSet<uint> ZonderLicht(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            // *** IMPLEMENTATION HERE *** //
            return set;
        }
        public static HashSet<uint> MetWagon(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            // *** IMPLEMENTATION HERE *** //
            return set;
        }
        public static HashSet<uint> SelecteerID(List<uint> inputStroom, uint lower, uint upper)
        {
            HashSet<uint> set = new HashSet<uint>();
            // *** IMPLEMENTATION HERE *** //
            return set;
        }

        public static HashSet<uint> Opg3a(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            // *** IMPLEMENTATION HERE *** //
            return set;
        }

        public static HashSet<uint> Opg3b(List<uint> inputStroom)
        {
            HashSet<uint> set = new HashSet<uint>();
            // *** IMPLEMENTATION HERE *** //
            return set;
        }

        public static void ToonInfo(uint b)
        {
            Console.WriteLine($"ID {ID(b)}, Licht {Licht(b)}, Wagon {Wagon(b)}, Vermogen {Vermogen(b)}, Vooruit {Vooruit(b)}");
        }

        public static List<uint> GetInputStroom()
        {
            List<uint> inputStream = new List<uint>();
            for (uint i = 0; i < 256; i++)
            {
                inputStream.Add(i);
            }
            return inputStream;
        }

        public static void PrintSet(HashSet<uint> x)
        {
            Console.Write("{");
            foreach (uint i in x)
                Console.Write($" {i}");
            Console.WriteLine($" }} ({x.Count} elementen)");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("=== Opgave 1 ===");
            ToonInfo(210);
            Console.WriteLine();

           /* List<uint> inputStroom = GetInputStroom();

            Console.WriteLine("=== Opgave 2 ===");
            HashSet<uint> alle = Alle(inputStroom);
            PrintSet(alle);
            HashSet<uint> zonderLicht = ZonderLicht(inputStroom);
            PrintSet(zonderLicht);
            HashSet<uint> metWagon = MetWagon(inputStroom);
            PrintSet(metWagon);
            HashSet<uint> groter6 = SelecteerID(inputStroom, 6, 7);
            PrintSet(groter6);
            Console.WriteLine();

            Console.WriteLine("=== Opgave 3a ===");
            HashSet<uint> opg3a = Opg3a(inputStroom);
            PrintSet(opg3a);
            foreach (uint b in opg3a)
            {
                ToonInfo(b);
            }
            Console.WriteLine();

            Console.WriteLine("=== Opgave 3b ===");
            HashSet<uint> opg3b = Opg3b(inputStroom);
            PrintSet(opg3b);
            foreach (uint b in opg3b)
            {
                ToonInfo(b);
            }
            Console.WriteLine();*/
        }
    }
}

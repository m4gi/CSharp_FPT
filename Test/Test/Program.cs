//using System;

//namespace Format1
//{
//    enum Gender
//    {
//        Female = 1,
//        Male,
//        Unknown
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter your name:");
//            String input = Console.ReadLine();
//            Console.WriteLine("Enter your gender: ");
//            String gen = Console.ReadLine();
//            Gender myGender;
//            //bool result = Enum.TryParse(gen, out myGender);
//            if (Enum.TryParse(gen, out myGender))
//            {
//                switch (myGender) 
//                {
//                    case Gender.Female:
//                        Console.WriteLine("{0}\nHi Girl", input);
//                        break;
//                    case Gender.Male:
//                        Console.WriteLine("{0}\nHi Boy", input);
//                        break;
//                    case Gender.Unknown:
//                        Console.WriteLine("{0}\nHi", input);
//                        break;
//                }

//            }
//            else { Console.WriteLine("Error!!!"); }
//        }
        
//}  

    
//}
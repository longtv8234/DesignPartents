namespace FactoryPatternDemo
{
    public interface INetwork
    {
        string GetNameNetWork();
        string CheckAccountMoney();
        string GetCarrierNumber();

    }

    class Viettel : INetwork
    {
        public string CheckAccountMoney()
        {
            return "*101#";
        }

        public string GetCarrierNumber()
        {
            return "086, 096, 097, 098, 032, 033, 034, 035, 036, 037, 038, 039";
        }

        public string GetNameNetWork()
        {
            return "VIETTEL";
        }

    }

    class Mobifone : INetwork
    {
        public string CheckAccountMoney()
        {
            return "*101#";
        }

        public string GetCarrierNumber()
        {
            return "090, 093, 0120, 0121, 0122, 0126, 0128, 089";
        }

        public string GetNameNetWork()
        {
            return "MOBIFONE";
        }
    }


    public class Vinaphone : INetwork
    {
        public string CheckAccountMoney()
        {
            return "*101#";
        }

        public string GetCarrierNumber()
        {
            return "091, 094, 083, 084, 085, 081, 082";
        }

        public string GetNameNetWork()
        {
            return "VINAPHONE";
        }
    }


    public class Vietnamobile : INetwork
    {
        public string CheckAccountMoney()
        {
            return "*101#";
        }

        public string GetCarrierNumber()
        {
            return "092, 056, 058";
        }

        public string GetNameNetWork()
        {
            return "VIETNAMOBILE";
        }
    }


    public class Gmobile : INetwork
    {
        public string CheckAccountMoney()
        {
            return "*101#";
        }

        public string GetCarrierNumber()
        {
            return "099, 059";
        }

        public string GetNameNetWork()
        {
            return "GMOBILE";
        }
    }



    public enum NetworkType
    {
        VIETTEL,
        MOBIFONE,
        VINAPHONE,
        VIETNAMOBILE,
        GMOBILE,
    }



    public abstract class NetworkFactory
    {
        public abstract INetwork Create(NetworkType type);
    }


    class ConcreteCreator : NetworkFactory
    {
        public override INetwork Create(NetworkType type)
        {
            switch (type)
            {
                case NetworkType.VIETTEL:
                    return new Viettel();

                case NetworkType.MOBIFONE:
                    return new Mobifone();

                case NetworkType.VINAPHONE:
                    return new Vinaphone();

                case NetworkType.VIETNAMOBILE:
                    return new Vietnamobile();

                case NetworkType.GMOBILE:
                    return new Gmobile();
                default:
                    throw new ArgumentException("Invalid type", "type");

            }
        }
    }


    class TestFactoryMethod
    {
        static void Test(string[] args)
        {
            var factory = new ConcreteCreator();
            INetwork viettel = factory.Create(NetworkType.VIETTEL);
            Console.WriteLine(viettel.GetNameNetWork());
            Console.WriteLine(viettel.GetCarrierNumber());
            Console.WriteLine("===========================================");

            INetwork vinaphone = factory.Create(NetworkType.VINAPHONE);
            Console.WriteLine(vinaphone.GetNameNetWork());
            Console.WriteLine(vinaphone.GetCarrierNumber());
            Console.WriteLine("===========================================");

            INetwork mobiphone = factory.Create(NetworkType.MOBIFONE);
            Console.WriteLine(mobiphone.GetNameNetWork());
            Console.WriteLine(mobiphone.GetCarrierNumber());
            Console.WriteLine("===========================================");

            INetwork vietnamobile = factory.Create(NetworkType.VIETNAMOBILE);
            Console.WriteLine(vietnamobile.GetNameNetWork());
            Console.WriteLine(vietnamobile.GetCarrierNumber());
            Console.WriteLine("===========================================");

            INetwork gmobile = factory.Create(NetworkType.GMOBILE);
            Console.WriteLine(gmobile.GetNameNetWork());
            Console.WriteLine(gmobile.GetCarrierNumber());

            Console.ReadLine();
        }
    }
}
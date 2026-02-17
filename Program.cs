namespace Village
{
    internal class Program
    {
        public struct Villager
        {
            private bool _genderIsMale;
            private bool _hasStupidBlueHat;
            private bool _hasPointyThing;
            private bool _hasBucket;
            private bool _isInYellow;

            public bool GenderIsMale => _genderIsMale;
            public bool HasStupidBlueHat => _hasStupidBlueHat;
            public bool HasPointyThing => _hasPointyThing;
            public bool IsInYellow => _isInYellow;
            public bool HasBucket => _hasBucket;

            public Villager(bool male, bool blueHat, bool pointyThing, bool bucket, bool inYellow)
            {
                _genderIsMale = male;
                _hasStupidBlueHat = blueHat;
                _hasPointyThing = pointyThing;
                _hasBucket = bucket;
                _isInYellow = inYellow;
            }
        }
        public struct Village
        {
            private string _name;
            private Villager[] _villagers;

            public string Name => _name;
            public Villager[] Villagers => _villagers;

            public Village(string name)
            {
                _name = name;
                _villagers = new Villager[0];
            }
            public void AddVillager(bool male, bool blueHat, bool pointyThing, bool bucket, bool inYellow)
            {
                Array.Resize(ref  _villagers, _villagers.Length+1);
                _villagers[^1] = new Villager(male, blueHat, pointyThing, bucket, inYellow);
            }
        }
        static void Main(string[] args)
        {
            var Balbesy = new Village("Balbesy");
            //                 male  bluehat pointything  bucket  yellow  
            Balbesy.AddVillager(true, true, true, false, false);
            Balbesy.AddVillager(true, true, false, true, false);
            Balbesy.AddVillager(true, false, false, false, false);
            Balbesy.AddVillager(true, true, false, false, false);
            Balbesy.AddVillager(false, false, false, false, false);
            Balbesy.AddVillager(true, false, true, false, false);
            Balbesy.AddVillager(true, false, false, false, true);
            Balbesy.AddVillager(false, true, false, false, false);


        }
    }
}

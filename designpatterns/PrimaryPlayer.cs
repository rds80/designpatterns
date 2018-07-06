namespace designpatterns
{
    public sealed class PrimaryPlayer
    {
        private static readonly PrimaryPlayer _instance;
        public string Name { get; set; }
        public int Level { get; set; }

        private PrimaryPlayer() { }

        static PrimaryPlayer()
        {
            _instance = new PrimaryPlayer()
            {
                Name = "Raptor",
                Level = 1
            };
        }

        public static PrimaryPlayer Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
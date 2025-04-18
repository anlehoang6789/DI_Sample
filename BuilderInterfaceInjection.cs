namespace DISample {
    public class BuilderInterfaceInjection : IToolHouse {
        private Hammer _hammer;
        private Saw _saw;

        // Interface Injection

        public void SetHammer ( Hammer hammer ) {
            _hammer = hammer;
        }

        public void SetSaw ( Saw saw ) {
            _saw = saw;
        }

        public void BuildHouse () {
            Console.WriteLine("Building a house with interface injection");
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House built!");
        }
    }
}

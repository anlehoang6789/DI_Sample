namespace DISample {
    public class BuilderConstructorInjectionV2 {
        //public Saw _saw;
        //public Hammer _hammer;
        private readonly ITool _hammer;
        private readonly ITool _saw;

        // Constructor injection với dạng xài interface chứ không phải là class
        public BuilderConstructorInjectionV2 ( ITool hammer, ITool saw ) {
            _hammer = hammer;
            _saw = saw;
        }
        public void BuildHouse () {
            Console.WriteLine("Building something");
            _hammer.Use();
            _saw.Use();
        }
    }
}

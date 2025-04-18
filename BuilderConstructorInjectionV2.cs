namespace DISample {
    public class BuilderConstructorInjectionV2 {
        private readonly ITool _tool;

        // Constructor injection với dạng xài interface chứ không phải là class
        public BuilderConstructorInjectionV2 ( ITool tool ) {
            _tool = tool;
        }
        public void BuildHouse () {
            Console.WriteLine("Building something");
            _tool.Use();
        }
    }
}

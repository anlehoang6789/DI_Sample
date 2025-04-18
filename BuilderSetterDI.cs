namespace DISample {
    public class BuilderSetterDI {
        public Hammer Hammer { get; set; }
        public Saw Saw { get; set; }

        // Setter Injection
        public void BuildHouse () {
            Hammer.Use();
            Saw.Use();
            Console.WriteLine("House built!");
        }
    }
}

namespace DISample {
    public class BuilderDIConstructor {
        private Hammer _hammer;
        private Saw _saw;

        // Constructor Injection
        // Chúng ta sẽ truyền các dependency vào trong constructor của Builder
        public BuilderDIConstructor ( Hammer hammer, Saw saw ) {
            _hammer = hammer;
            _saw = saw;
            // Bây giờ chúng ta không cần khởi tạo Hammer và Saw trong constructor của Builder nữa.
            // Chúng ta sẽ truyền vào các dependency này từ bên ngoài.
        }

        public void BuildHouse () {
            Console.WriteLine("Building a house...");
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House built!");
        }
    }
}

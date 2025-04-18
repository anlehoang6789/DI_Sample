namespace DISample {
    internal class Program {
        static void Main ( string[] args ) {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();

            //BuilderDIConstructor builder = new BuilderDIConstructor(hammer, saw); làm theo dạng constructor injection

            //Làm theo dạng setter injection
            //BuilderSetterDI builder = new BuilderSetterDI();
            //builder.Hammer = hammer; 
            //builder.Saw = saw; 

            //Làm theo dạng interface injection
            BuilderInterfaceInjection builder = new BuilderInterfaceInjection();
            builder.SetHammer(hammer); //truyền vào hammer
            builder.SetSaw(saw); //truyền vào saw

            builder.BuildHouse();

            Console.ReadLine();
        }
    }
}

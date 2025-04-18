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
            //BuilderInterfaceInjection builder = new BuilderInterfaceInjection();
            //builder.SetHammer(hammer); 
            //builder.SetSaw(saw); 

            //Constructor injection V2
            BuilderConstructorInjectionV2 builder = new BuilderConstructorInjectionV2(hammer, saw);
            BuilderConstructorInjectionV2 builderNew = new(new Hammer(), new Saw()); //Cách viết tắt của C# 9.0

            builder.BuildHouse();

            Console.ReadLine();
        }
    }
}

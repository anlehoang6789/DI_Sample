namespace DISample {
    public class Builder {
        //Sử dụng Hammer theo cách bình thường 
        private Hammer _hammer; //bước này chỉ mới khai báo biến chứ chưa dùng được các phương thức nằm bên trong    class => muốn dùng được thì phải cho nó biến thành 1 đối tượng

        private Saw _saw;

        public Builder () {
            _hammer = new Hammer();
            _saw = new Saw();
            //Tại sao phải khởi tạo Hammer và Saw trong constructor của Builder?
            // Ở đây chúng ta có method BuildHouse() sẽ sử dụng Hammer và Saw để xây nhà.
            // Nên khi chúng ta khởi tạo 1 đối tượng Builder mới thì để xài thg BuildHouse(), nếu chúng ta không khởi tạo Hammer và Saw thì sẽ không thể sử dụng được các phương thức bên trong class Hammer và Saw.
        }

        public void BuildHouse () {
            Console.WriteLine("Building a house...");
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House built!");
        }
    }
}

//Có thể gọi lớp Hammer và Saw là các dependency của lớp Builder.
//muốn xây 1 căn nhà thì cần có búa và cưa. => Builder phụ thuộc vào Hammer và Saw.
// Phía trên là cách sử dụng dependency theo cách bình thường. --> 
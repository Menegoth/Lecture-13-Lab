using System;

namespace Lecture_13_Lab {
    class Rectangle {
        static void Main(string[] args) {

            Rectangle rect = new Rectangle();   
            MyDelegate rectDele = new MyDelegate(rect.Area);
            rectDele += new MyDelegate(rect.Perimeter);
            rectDele.Invoke(6.0, 4.5);
            rectDele.Invoke(12.0, 6.4);

        }

        public delegate void MyDelegate(double height, double width);

        public void Area (double height, double width) {
            Console.WriteLine("Area is: " + height * width);
        }

        public void Perimeter (double height, double width) {
            Console.WriteLine("Perimeter is: " + (height * 2) + (width * 2));
        }

    }
}

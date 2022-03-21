namespace Lab_09_Task_01
{
    internal abstract class Two_D : Shape
    {
        public double area, perimeter;
        public abstract double Area();
        public abstract double Perimeter();
        public override string whoAmI()
        {
            string info = "My name is " + this.name + ". I am a two dimensional shape.";
            return info;
        }
    }
    internal abstract class Three_D : Shape
    {
        public double surface_area, volume;
        public abstract double Surface_Area();
        public abstract double Volume();
        public override string whoAmI()
        {
            string info = "My name is " + this.name + ". I am a three dimensional shape.";
            return info;
        }
    }
    internal class Square : Two_D
    {
        public int length;
        void setName()
        {
            name = "Square";
        }
        public override double Area()
        {
            this.area = Math.Pow(length, 2);
            return this.area;
        }
        public override double Perimeter()
        {
            this.perimeter = 4 * length;
            return this.perimeter;
        }
        public override string whoAmI()
        {
            string info = "My name is " + name + ". I am a two dimensional shape.";
            return info;
        }
    }
    internal class Rectangle : Two_D
    {
        public int length, width;
        public override double Area()
        {
            this.area = length*width;
            return this.area;
        }
        public override double Perimeter()
        {
            this.perimeter = 2 * length + 2 * width;
            return this.perimeter;
        }
        void setName()
        {
            this.name = "Rectangle";
        }
    }
    internal class Circle : Two_D
    {
        public int radius;
        public override double Area()
        {
            this.area = Math.PI * Math.Pow(radius,2);
            return this.area;
        }
        public override double Perimeter()
        {
            this.perimeter = 2 * radius * Math.PI;
            return this.perimeter;
        }
        void setName()
        {
            this.name = "Circle";
        }
    }
    internal class Triangle : Two_D
    {
        public int length1, length2, length3;
        public override double Perimeter()
        {
            this.perimeter = length1 + length2 + length3;
            return this.perimeter;
        }
        public override double Area()
        {
            double dummy = perimeter * (perimeter - length1) * (perimeter - length2) * (perimeter - length3);
            this.area = Math.Sqrt(dummy);
            return this.area;
        }
        void setName()
        {
            this.name = "Triangle";
        }
    }
    internal class Hexagon : Two_D
    {
        public int length;
        public override double Perimeter()
        {
            this.perimeter = length * 6;
            return this.perimeter;
        }
        public override double Area()
        {
            this.area = 3.0 / 2.0 * Math.Sqrt(3) * Math.Pow(length,2);
            return this.area;
        }
        void setName()
        {
            this.name = "Hexagon";
        }
    }
    internal class Octagon : Two_D
    {
        public int length;
        public override double Perimeter()
        {
            this.perimeter = length * 8;
            return this.perimeter;
        }
        public override double Area()
        {
            this.area = 2 * (1 + Math.Sqrt(2)) * Math.Pow(length,2);
            return this.area;
        }
        void setName()
        {
            this.name = "Octagon";
        }
    }
    internal class Cube : Three_D
    {
        public int length;
        public override double Surface_Area()
        {
            this.surface_area = 6 * Math.Pow(length, 2);
            return surface_area;
        }
        public override double Volume()
        {
            this.volume = Math.Pow(length, 3);
            return this.volume;
        }
        void setName()
        {
            this.name = "Cube";
        }
    }
    internal class Sphere : Three_D
    {
        public int radius;
        public override double Surface_Area()
        {
            this.surface_area = 4 * Math.PI * Math.Pow(radius, 2);
            return surface_area;
        }
        public override double Volume()
        {
            this.volume = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
            return this.volume;
        }
        void setName()
        {
            this.name = "Sphere";
        }

    }
    internal class Cone : Three_D
    {
        public int height, radius;
        public override double Surface_Area()
        {
            this.surface_area = Math.PI * radius * (radius + Math.Sqrt(radius*radius + height * height));
            return surface_area;
        }
        public override double Volume()
        {
            this.volume = 1 / 3.0 * Math.PI *  Math.Pow(radius, 2) * height;
            return this.volume;
        }
        void setName()
        {
            this.name = "Cone";
        }
    }
    internal class Cylinder : Three_D
    {
        public int radius, height;

        public override double Surface_Area()
        {
            this.surface_area = 2 * Math.PI * radius * (radius + height);
            return surface_area;
        }
        public override double Volume()
        {
            this.volume = Math.PI * height * Math.Pow(radius, 2);
            return this.volume;
        }
        void setName()
        {
            this.name = "Cylinder";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();
            Hexagon hexagon = new Hexagon();
            Octagon octagon = new Octagon();

            Cube cube = new Cube();
            Sphere sphere = new Sphere();
            Cone cone = new Cone();
            Cylinder cylinder = new Cylinder();

            square.length = 4;
            circle.radius = 4;
            hexagon.length = 4;
            octagon.length = 4;
            rectangle.length = 4;
            rectangle.width = 6;

            cube.length = 4;
            sphere.radius = 4;
            cylinder.radius = 4;
            cylinder.height = 6;
            cone.radius = 4;
            cone.height = 6;

            Console.WriteLine(square.Area());
            Console.WriteLine(rectangle.Area());
            Console.WriteLine(circle.Area());
            Console.WriteLine(hexagon.Area());
            Console.WriteLine(octagon.Area());
            Console.WriteLine("\n");
            Console.WriteLine(cube.Surface_Area());
            Console.WriteLine(cone.Surface_Area());
            Console.WriteLine(cylinder.Surface_Area());
            Console.WriteLine(sphere.Surface_Area());
            Console.WriteLine("\n");
            Console.WriteLine(square.name);
        }
    }
}

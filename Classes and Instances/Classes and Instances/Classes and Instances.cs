using System;

namespace Classes_and_Instances
{
    class ClassesandInstances
    {
        static void Main(string[] args)
        {
            #region Task1
            //        // Declare an instance of Circle class called c1.
            //        // Construct the instance c1 by invoking the "default" constructor
            //        // which sets its radius and color to their default value.
            //        Circle c1 = new Circle();
            //        // Invoke public methods on instance c1, via dot operator.
            //        Console.WriteLine("The circle has radius of "
            //           + c1.getRadius() + " and area of " + c1.getArea());
            //        //The circle has radius of 1.0 and area of 3.141592653589793

            //        // Declare an instance of class circle called c2.
            //        // Construct the instance c2 by invoking the second constructor
            //        // with the given radius and default color.
            //        Circle c2 = new Circle(2.0);
            //        // Invoke public methods on instance c2, via dot operator.
            //        Console.WriteLine("The circle has radius of "
            //           + c2.getRadius() + " and area of " + c2.getArea());
            //        //The circle has radius of 2.0 and area of 12.566370614359172


            //        Circle c3 = new Circle(2.5, "green");
            //        Console.WriteLine("The circle has radius" 
            //            + c3.getRadius() + " and area of " + c3.getArea() + " with color " + c3.getColor());


            //        // Setiranje na nova vrednost i instanciranje na konsruktor so hardkodirani vrednsti
            //        Circle c4 = new Circle();
            //        c4.setRadius(1.5);
            //        Console.WriteLine("New radius is" + c4.getRadius());
            //        c4.setColor("blue");
            //        Console.WriteLine("New color is" + c4.getColor());


            //        Circle c5 = new Circle(5.5);
            //        Console.WriteLine(c5.toString());


            //        Circle c6 = new Circle(6.6);
            //        Console.WriteLine(c6.toString());
            //        Console.WriteLine(c6);
            //        Console.WriteLine("Operator '+' invokes toString() too:" + c6);
            #endregion

            #region Task2

            //Circle c1 = new Circle(1.1);
            //Console.WriteLine(c1.getRadius());

            //Circle c2 = new Circle();
            //Console.WriteLine(c2.getRadius());
            //Console.WriteLine(c2.toString());
            //Console.WriteLine(c2);

            //c1.setRadius(2.2);
            //Console.WriteLine(c1.getRadius());
            //Console.WriteLine("the area is " + c1.getArea() + "the perimetar is " + c1.getCircumference());

            #endregion

            #region Task3

            //Rectangle r1 = new Rectangle(1.2f, 3.4F);
            //Console.WriteLine(r1.toString());

            //Rectangle r2 = new Rectangle();
            //Console.WriteLine(r2.getArea());

            //r1.setLength(5.6f);
            //r1.setWidth(7.8f);
            //Console.WriteLine(r1.toString());
            //Console.WriteLine("length is: " + r1.getLength());
            //Console.WriteLine("length is: " + r1.getWidth());

            //Console.WriteLine("area is: " + r1.getArea());
            //Console.WriteLine("perimeter is: " + r1.getPerimeter());

            #endregion

            #region Task4

            // Test constructor and toString()
            //Employee e1 = new Employee(8, "Bob", "Bobsky", 2500);
            //Console.WriteLine(e1.toString());

            //// Test Setters and Getters
            //e1.setSalary(999);
            //Console.WriteLine(e1.toString());
            //Console.WriteLine("Id is: " + e1.getId());
            //Console.WriteLine("First name is: " + e1.getFirstName());
            //Console.WriteLine("Last name is: " + e1.getLastName());
            //Console.WriteLine("The salary is: " + e1.getSalary());

            //Console.WriteLine("Name is: " + e1.getName());
            //Console.WriteLine("Annual salary is: " + e1.getAnnualSalary());

            //// Test raiseSalary()
            //Console.WriteLine(e1.raiseSalary(10));

            #endregion

            #region Task5



            #endregion

            Console.ReadLine();
        }

        #region Task1
        //    public class Circle
        //    {
        //        private double radius;
        //        private string color;

        //        public Circle()
        //        {
        //            radius = 1.0;
        //            color = "red";
        //        }

        //        public Circle(double radius)
        //        {
        //            this.radius = radius;
        //            color = "red";
        //        }

        //        public Circle(double radius, string color)
        //        {
        //            this.radius = radius;
        //            this.color = color;
        //        }

        //        public string getColor()
        //        {
        //            return color;
        //        }

        //        public double getRadius()
        //        {
        //            return radius;
        //        }

        //        public double getArea()
        //        {
        //            return radius * radius * Math.PI;
        //        }

        //        public void setColor(string color)
        //        {
        //            this.color = color;
        //        }

        //        public void setRadius(double radius)
        //        {
        //            this.radius = radius;
        //        }

        //        public string toString()
        //        {
        //            return "Circle[radius=" + radius + " color=" + color + "]";
        //        }
        //    }
        #endregion

        #region Task2

        //public class Circle
        //{

        //    private double radius;

        //    public Circle()
        //    {
        //        radius = 1.0;
        //    }

        //    public Circle(double radius)
        //    {
        //        this.radius = radius;
        //    }

        //    public double getRadius()
        //    {
        //        return radius;
        //    }
        //    public void setRadius(double radius)
        //    {
        //        this.radius = radius;
        //    }

        //    public double getArea()
        //    {
        //        return radius * radius * Math.PI;
        //    }

        //    public double getCircumference()
        //    {
        //        return 2 * Math.PI * radius;
        //    }

        //    public string toString()
        //    {
        //        return "Circle";
        //    }
        //}

        #endregion

        #region Task3

        //public class Rectangle
        //{
        //    private float length;
        //    private float width;

        //    public Rectangle()
        //    {
        //        length = 1.2f;
        //        width = 3.4f;
        //    }

        //    public Rectangle(float length, float width)
        //    {
        //        this.length = length;
        //        this.width = width;
        //    }

        //    public float getLength()
        //    {
        //        return length;
        //    }

        //    public void setLength(float length)
        //    {
        //        this.length = length;
        //    }

        //    public float getWidth()
        //    {
        //        return width;
        //    }

        //    public void setWidth(float width)
        //    {
        //        this.width = width;
        //    }

        //    public double getArea()
        //    {
        //        return width * length;
        //    }

        //    public double getPerimeter()
        //    {
        //        return 2 * length + 2 * width;
        //    }

        //    public string toString()
        //    {
        //       return $"{length} + {width}";
        //    }

        //}


        #endregion

        #region Task4

        //public class Employee
        //{
        //    private int id;
        //    private string firstName;
        //    private string lastName;
        //    private int salary;

        //    public Employee(int id, string firstName, string lastName, int salary)
        //    {
        //        this.id = id;
        //        this.firstName = firstName;
        //        this.lastName = lastName;
        //        this.salary = salary;
        //    }

        //    public int getId()
        //    {
        //        return id;
        //    }

        //    public string getFirstName()
        //    {
        //        return firstName;
        //    }

        //    public string getLastName()
        //    {
        //        return lastName;
        //    }

        //    public string getName()
        //    {
        //        return $"{ firstName } { lastName }";
        //    }

        //    public int getSalary()
        //    {
        //        return salary;
        //    }

        //    public void setSalary(int salary)
        //    {
        //        this.salary = salary;
        //    }

        //    public int getAnnualSalary()
        //    {
        //        return salary * 12;
        //    }

        //    public int raiseSalary(int percent)
        //    {
        //        return salary * percent / 100 + salary;
        //    }

        //    public string toString()
        //    {
        //        return $"Employee with id {id} first name {firstName} and last name {lastName} has salary {salary}";
        //    }

        //}


        #endregion

        #region Task5



        #endregion

    }
}

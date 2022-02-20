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

            // Test constructor and toString()
            //InvoiceItem inv1 = new InvoiceItem ("A101", "Pen Red", 888, 0.08);
            //Console.WriteLine(inv1.toString());

            //// Test Setters and Getters
            //inv1.setQty(999);
            //inv1.setUnitPrice(0.99);
            //Console.WriteLine(inv1.toString());
            //Console.WriteLine("Id is: " + inv1.getId());
            //Console.WriteLine("Description is: " + inv1.getDesc());
            //Console.WriteLine("Quantity is: " + inv1.getQty());
            //Console.WriteLine("IUnitePrice is: " + inv1.getUnitPrice());

            //// Test getTotal()
            //Console.WriteLine("The total is: " + inv1.getTotal());

            #endregion

            #region Task6

            // Test constructor and toString()
            //Account a1 = new Account("A101", "Tan Ah Teck", 88);
            //Console.WriteLine(a1.toString());

            //Account a2 = new Account("A102", "Kumar");
            //Console.WriteLine(a2.getBalance() + a2.getName() + a2.getId());

            //// Test Getters
            //Console.WriteLine("Id: " + a1.getId());
            //Console.WriteLine("Name: " + a1.getName());
            //Console.WriteLine("Balance: " + a1.getBalance());

            //// Test credit() and debit()
            //a1.credit(100);
            //Console.WriteLine(a1.getId() + a1.getName() + a1.getBalance());
            //a1.Debit(50);
            //Console.WriteLine(a1.getBalance());

            //// Test transfer()
            //a1.transferTo(a2.toString, 100);


            #endregion

            #region Task7

            // Test constructor and toString()
            //Date d1 = new Date(1, 2, 2014);
            //Console.WriteLine(d1.toString());

            //// Test Setters and Getters
            //d1.setMonth(12);
            //d1.setDay(9);
            //d1.setYear(2099);
            //Console.WriteLine(d1.toString());
            //Console.WriteLine("Month: " + d1.getMonth());
            //Console.WriteLine("Day: " + d1.getDay());
            //Console.WriteLine("Year: " + d1.getYear());

            //// Test setDate()
            //d1.setDate(3, 4, 2016);
            //Console.WriteLine(d1.toString());


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

        //public class InvoiceItem
        //{
        //    private string id;
        //    private string desc;
        //    private int qty;
        //    private double unitPrice;

        //    public InvoiceItem (string id, string desc, int qty, double unitPrice)
        //    {
        //        this.id = id;
        //        this.desc = desc;
        //        this.qty = qty;
        //        this.unitPrice = unitPrice;
        //    }

        //    public string getId()
        //    {
        //        return id;
        //    }

        //    public string getDesc()
        //    {
        //        return desc;
        //    }

        //    public int getQty()
        //    {
        //        return qty;
        //    }

        //    public void setQty(int qty)
        //    {
        //        this.qty = qty;
        //    }

        //    public double getUnitPrice()
        //    {
        //        return unitPrice;
        //    }

        //    public void setUnitPrice( double unitPrice)
        //    {
        //        this.unitPrice = unitPrice;
        //    }

        //    public double getTotal()
        //    {
        //        return unitPrice * qty;
        //    }

        //    public string toString()
        //    {
        //        return $"Invoiceitem with id {id}, description {desc}, quantity {qty} and unit price {unitPrice}";
        //    }
        //}

        #endregion

        #region Task6

        //public class Account
        //{
        //    private string id;
        //    private string name;
        //    private int balance = 0;

        //    public Account(string id, string name)
        //    {
        //        this.id = id;
        //        this.name = name;
        //    }

        //    public Account(string id, string name, int balance)
        //    {
        //        this.id = id;
        //        this.name = name;
        //        this.balance = balance;
        //    }

        //    public string getId()
        //    {
        //        return id;
        //    }

        //    public string getName()
        //    {
        //        return name;
        //    }

        //    public int getBalance()
        //    {
        //        return balance;
        //    }

        //    public int credit(int balance)
        //    {
        //        balance = 10;
        //        return balance;
        //    }

        //    public int Debit(int amount)
        //    {
        //        if(amount <= balance)
        //        {
        //            return balance -= amount;
        //        }
        //        else
        //        {
        //            return -1;
        //        }
        //    }

        //    public int transferTo(int amount, Account another)
        //    {
        //        if(amount <= balance)
        //        {
        //            another.balance += amount;
        //        }
        //        else
        //        {
        //            //return "Amount exceeded balance";
        //        }

        //        return balance;
        //    }

        //    public string toString()
        //    {
        //        return $"Account with id {id}, name {name} and balance {balance}";
        //    }
        //}

        #endregion

        #region Task7

        //public class Date
        //{
        //    private int day;
        //    private int month;
        //    private int year;

        //    public Date(int day, int month, int year)
        //    {
        //        this.day = day;
        //        this.month = month;
        //        this.year = year;
        //    }

        //    public int getDay()
        //    {
        //        return day;
        //    }

        //    public int getMonth()
        //    {
        //        return month;
        //    }

        //    public int getYear()
        //    {
        //        return year;
        //    }

        //    public void setDay(int day)
        //    {
        //        this.day = day;
        //    }

        //    public void setMonth(int month)
        //    {
        //        this.month = month;
        //    }

        //    public void setYear(int year)
        //    {
        //        this.year = year;
        //    }

        //    public void setDate(int day, int month, int year)
        //    {
        //        this.day = day;
        //        this.month = month;
        //        this.year = year;
        //    }

        //    public string toString()
        //    {
        //        return $"Day {day} month {month} year {year}";
        //    }

        //}

        #endregion

    }
}

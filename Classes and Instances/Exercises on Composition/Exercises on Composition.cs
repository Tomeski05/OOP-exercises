using System;

namespace Exercises_on_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm');
            //Console.WriteLine(ahTeck.toString());

            //ahTeck.setEmail("paulTan@nowhere.com");
            //Console.WriteLine("name is: " + ahTeck.getName());     
            //Console.WriteLine("email is: " + ahTeck.getEmail());   
            //Console.WriteLine("gender is: " + ahTeck.getGender());

            //Book dummyBook = new Book("Java for dummy", ahTeck, 19.95, 99);
            //Console.WriteLine(dummyBook.toString());

            //dummyBook.setPrice(29.95);
            //dummyBook.setQty(28);
            //Console.WriteLine("name is: " + dummyBook.getName());
            //Console.WriteLine("price is: " + dummyBook.getPrice());
            //Console.WriteLine("qty is: " + dummyBook.getQty()); 
            //Console.WriteLine("Author's name is: " + dummyBook.getAuthor().getName());
            //Console.WriteLine("Author's email is: " + dummyBook.getAuthor().getEmail());

            #endregion

            #region Task2

            //Author a1 = new Author("Tan Ah Teck", "ahteck@nowhere.com");
            //Console.WriteLine(a1.toString());

            //a1.setEmail("ahteck@somewhere.com");
            //Console.WriteLine(a1.toString());
            //Console.WriteLine("name is: " + a1.getName());
            //Console.WriteLine("email is: " + a1.getEmail());

            //Book b1 = new Book("12345", "Java for dummies", a1, 8.8, 88);
            //Console.WriteLine(b1.toString());

            //b1.setPrice(9.9);
            //b1.setQty(99);
            //Console.WriteLine(b1.toString());
            //Console.WriteLine("isbn is: " + b1.getISBN());
            //Console.WriteLine("name is: " + b1.getName());
            //Console.WriteLine("price is: " + b1.getPrice());
            //Console.WriteLine("qty is: " + b1.getQty());
            //Console.WriteLine("author's name: " + b1.getAuthorName());
            //Console.WriteLine("author's name: " + b1.getAuthor().getName());
            //Console.WriteLine("author's email: " + b1.getAuthor().getEmail());


            #endregion

            #region Task3

            //Customer c1 = new Customer(88, "Tan Ah Teck", 10);
            //Console.WriteLine(c1.toString());  

            //c1.setDiscount(8);
            //Console.WriteLine(c1.toString());
            //Console.WriteLine("id is: " + c1.getID());
            //Console.WriteLine("name is: " + c1.getName());
            //Console.WriteLine("discount is: " + c1.getDiscount());


            //Invoice inv1 = new Invoice(101, c1, 888.8);
            //Console.WriteLine(inv1.toString());

            //inv1.setAmount(999.9);
            //Console.WriteLine(inv1.toString());
            //Console.WriteLine("id is: " + inv1.getID());
            //Console.WriteLine("customer is: " + inv1.getCustomer());
            //Console.WriteLine("amount is: " + inv1.getAmount());
            //Console.WriteLine("customer's id is: " + inv1.getCustomerID());
            //Console.WriteLine("customer's name is: " + inv1.getCustomerName());
            //Console.WriteLine("customer's discount is: " + inv1.getCustomerDiscount());
            //Console.WriteLine("amount after discount is: ", inv1.getAmountAfterDiscount());

            #endregion

            #region Task4

            //Account account = new Account(1, new Customer(2, "Ha Gia Kinh", 'm'), 10000.0);
            //Console.WriteLine(account.toString());
            //account.withdraw(100);
            //Console.WriteLine(account);
            //Console.WriteLine(account.getCustomerName());
            //account.deposit(500);
            //Console.WriteLine(account);

            #endregion

            #region Task5

            //MyPoint p1 = new MyPoint();  
            //Console.WriteLine(p1.toString());     
            //p1.setX(8);   
            //p1.setY(6);
            //Console.WriteLine("x is: " + p1.getX());
            //Console.WriteLine("y is: " + p1.getY());
            //p1.setXY(3, 0);
            //Console.WriteLine(p1.getXY()[0]);
            //Console.WriteLine(p1.getXY()[1]);
            //Console.WriteLine(p1);

            //MyPoint p2 = new MyPoint(0, 4);
            //Console.WriteLine(p2);

            //Console.WriteLine(p1.distance(p2));
            //Console.WriteLine(p2.distance(p1));
            //Console.WriteLine(p1.distance(5, 6));
            //Console.WriteLine(p1.distance());

            #endregion

            #region Task6

            //MyLine myLine = new MyLine(new MyPoint(0, 1), new MyPoint(3, 4));
            //Console.WriteLine(myLine.getLength());
            //Console.WriteLine(myLine.getGradient());
            //Console.WriteLine(myLine.toString());
            //Console.WriteLine(Arrays.toString(myLine.getBeginXY()));
            //Console.WriteLine(Arrays.toString(myLine.getEndXY()));

            #endregion

            #region Task7

            //MyCircle myCircle = new MyCircle(new MyPoint(5, 8), 6);
            //Console.WriteLine(myCircle.distance(new MyCircle(new MyPoint(30, 46), 2)));
            //Console.WriteLine(myCircle.getArea());
            //Console.WriteLine(myCircle.getCircumference());
            //Console.WriteLine(myCircle.toString());
            //Console.WriteLine(Arrays.toString(myCircle.getCenterXY()));

            #endregion

            #region Task8

            //MyTriangle myTriangle = new MyTriangle(new MyPoint(5, 5), new MyPoint(15, 15), new MyPoint(5, 25));
            //Console.WriteLine(myTriangle.getPerimeter());
            //Console.WriteLine(myTriangle.getType());
            //Console.WriteLine(myTriangle.getV1());
            //Console.WriteLine(myTriangle.getV2());
            //Console.WriteLine(myTriangle.getV3());
            //Console.WriteLine(myTriangle.toString());

            #endregion

            Console.ReadLine();
        }

        #region Task1
        //public class Author
        //{
        //    private string name;
        //    private string email;
        //    private char gender;

        //    public Author(string name, string email, char gender)
        //    {
        //        this.name = name;
        //        this.email = email;
        //        this.gender = gender;
        //    }

        //    public string getName()
        //    {
        //        return name;
        //    }

        //    public void setName(string name)
        //    {
        //        this.name = name;
        //    }

        //    public string getEmail()
        //    {
        //        return email;
        //    }

        //    public void setEmail(string email)
        //    {
        //        this.email = email;
        //    }

        //    public char getGender()
        //    {
        //        return gender;
        //    }

        //    public void setGender(char gender)
        //    {
        //        if (gender == 'm' || gender == 'f')
        //        {
        //            this.gender = gender;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Gender of 'm' or 'f'");
        //        }
        //    }

        //    public string toString()
        //    {
        //        return $"Author name {name} with email {email} and gender {gender}";
        //    }

        //}

        //public class Book
        //{
        //    private string name;
        //    private Author author;
        //    private double price;
        //    private int qty = 0;


        //    public Book(string name, Author author, double price)
        //    {
        //        this.name = name;
        //        this.author = author;
        //        this.price = price;
        //    }

        //    public Book(string name, Author author, double price, int qty)
        //    {
        //        this.name = name;
        //        this.author = author;
        //        this.price = price;
        //        this.qty = qty;
        //    }

        //    public string getName()
        //    {
        //        return name;
        //    }

        //    public Author getAuthor()
        //    {
        //        return author;
        //    }

        //    public double getPrice()
        //    {
        //        return price;
        //    }

        //    public void setPrice(double price)
        //    {
        //        this.price = price;
        //    }

        //    public int getQty()
        //    {
        //        return qty;
        //    }

        //    public void setQty(int qty)
        //    {
        //        this.qty = qty;
        //    }

        //    public string toString()
        //    {
        //        return $"Book name {name} from author {author.getName()} his email {author.getEmail()} gender {author.getGender()} price {price} and quantity {qty}";

        //    }

        //}

        #endregion

        #region Task2

        //public class Author
        //{
        //    private string name;
        //    private string email;


        //    public Author(string name, string email)
        //    {
        //        this.name = name;
        //        this.email = email;
        //    }

        //    public string getName()
        //    {
        //        return name;
        //    }

        //    public string getEmail()
        //    {
        //        return email;
        //    }

        //    public void setEmail(string email)
        //    {
        //        this.email = email;
        //    }

        //    public virtual string toString()
        //    {
        //        return $"Author name {name} with email {email}";
        //    }

        //}


        //public class Book
        //{
        //    private string isbn;
        //    private string name;
        //    private Author author;
        //    private double price;
        //    private int qty = 0;


        //    public Book(string isbn, string name, Author author, double price)
        //    {
        //        this.isbn = isbn;
        //        this.name = name;
        //        this.author = author;
        //        this.price = price;
        //    }

        //    public Book(string isbn, string name, Author author, double price, int qty)
        //    {
        //        this.isbn = isbn;
        //        this.name = name;
        //        this.author = author;
        //        this.price = price;
        //        this.qty = qty;
        //    }

        //    public string getISBN()
        //    {
        //        return isbn;
        //    }

        //    public string getName()
        //    {
        //        return name;
        //    }

        //    public Author getAuthor()
        //    {
        //        return author;
        //    }

        //    public double getPrice()
        //    {
        //        return price;
        //    }

        //    public void setPrice(double price)
        //    {
        //        this.price = price;
        //    }

        //    public int getQty()
        //    {
        //        return qty;
        //    }

        //    public void setQty(int qty)
        //    {
        //        this.qty = qty;
        //    }

        //    public string getAuthorName()
        //    {
        //        return author.getName();
        //    }

        //    public string toString()
        //    {
        //        return $"Book name {name} and isbn {isbn} from author {author.getName()} his email {author.getEmail()} price {price} and quantity {qty}";

        //    }

        //}


        #endregion

        #region Task3

        //public class Customer
        //{
        //    private int id;
        //    private string name;
        //    private int discount;

        //    public Customer(int id, string name, int discount)
        //    {
        //        this.id = id;
        //        this.name = name;
        //        this.discount = discount;
        //    }

        //    public int getID()
        //    {
        //        return id;
        //    }

        //    public string getName()
        //    {
        //        return name;
        //    }

        //    public int getDiscount()
        //    {
        //        return discount;
        //    }

        //    public void setDiscount(int discount)
        //    {
        //        this.discount = discount;
        //    }

        //    public string toString()
        //    {
        //        return $"Name {name} with id {id} and discount {discount} ";
        //    }

        //}

        //public class Invoice
        //{
        //    private int id;
        //    private Customer customer;
        //    private double amount;

        //    public Invoice(int id, Customer customer, double amount)
        //    {
        //        this.id = id;
        //        this.customer = customer;
        //        this.amount = amount;
        //    }

        //    public int getID()
        //    {
        //        return id;
        //    }

        //    public Customer getCustomer()
        //    {
        //        return customer;
        //    }

        //    public void setCustomer(Customer customer)
        //    {
        //        this.customer = customer;
        //    }

        //    public double getAmount()
        //    {
        //        return amount;
        //    }

        //    public void setAmount(double amount)
        //    {
        //        this.amount = amount;
        //    }

        //    public int getCustomerID()
        //    {
        //        return customer.getID();
        //    }

        //    public string getCustomerName()
        //    {
        //        return customer.getName();
        //    }

        //    public int getCustomerDiscount()
        //    {
        //        return customer.getDiscount();
        //    }

        //    public double getAmountAfterDiscount()            //// !!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //    {
        //        return amount - ((amount * customer.getDiscount()) / 100);
        //    }

        //    public string toString()
        //    {
        //        return $"Invoice id {id} customer {customer.getName()} with amount {amount} ";
        //    }

        //}


        #endregion

        #region Task4

        //public class Customer
        //{
        //    private int ID;
        //    private string name;
        //    private char gender;

        //    public Customer(int id, string name, char gender)
        //    {
        //        this.ID = id;
        //        this.name = name;
        //        this.gender = gender;
        //    }

        //    public int getID()
        //    {
        //        return ID;
        //    }

        //    public string getName()
        //    {
        //        return name;
        //    }

        //    public char getGender()
        //    {
        //        return gender;
        //    }

        //    public string toString()
        //    {
        //        return $"Name {name} with id {ID}";
        //    }


        //    public class Account
        //    {
        //        private int id;
        //        private Customer customer;
        //        private double balance;

        //        public Account(int id, Customer customer, double balance)
        //        {
        //            this.id = id;
        //            this.customer = customer;
        //            this.balance = balance;
        //        }

        //        public Account(int id, Customer customer)
        //        {
        //            this.id = id;
        //            this.customer = customer;
        //        }

        //        public int getId()
        //        {
        //            return id;
        //        }

        //        public void setId(int id)
        //        {
        //            this.id = id;
        //        }

        //        public Customer getCustomer()
        //        {
        //            return customer;
        //        }

        //        public void setCustomer(Customer customer)
        //        {
        //            this.customer = customer;
        //        }

        //        public double getBalance()
        //        {
        //            return balance;
        //        }

        //        public void setBalance(double balance)
        //        {
        //            this.balance = balance;
        //        }

        //        public String getCustomerName()
        //        {
        //            return this.customer.getName();
        //        }

        //        public Account deposit(double amount)
        //        {
        //            this.balance += amount;
        //            return this;
        //        }

        //        public Account withdraw(double amount, double balance)
        //        {
        //            if (amount > this.balance)
        //            {
        //                Console.WriteLine("amount withdraw exceeds the current balance!");
        //            }
        //            else
        //            {
        //                this.balance -= amount;
        //            }
        //            return this;
        //        }
        //    }
        //}

        #endregion

        #region Task5

        //public class MyPoint
        //{
        //    private int x;
        //    private int y;

        //    public MyPoint()
        //    {

        //    }

        //    public MyPoint(int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }

        //    public int getX()
        //    {
        //        return x;
        //    }

        //    public void setX(int x)
        //    {
        //        this.x = x;
        //    }

        //    public int getY()
        //    {
        //        return y;
        //    }

        //    public void setY(int y)
        //    {
        //        this.y = y;
        //    }

        //    public int[] getXY()
        //    {
        //        return new int[] { this.x, this.y };
        //    }

        //    public void setXY(int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }

        //    public double distance(int x, int y)
        //    {
        //        return (double)Math.Sqrt(Math.Pow((x - this.x), 2) + Math.Pow((y - this.y), 2));
        //    }

        //    public double distance(MyPoint another)
        //    {
        //        return (double)Math.Sqrt(Math.Pow((another.x - this.x), 2) + Math.Pow((another.y - this.y), 2));
        //    }

        //    public double distance()
        //    {
        //        return (double)Math.Sqrt(Math.Pow((0 - this.x), 2) + Math.Pow((0 - this.y), 2));
        //    }

        //    public string toString()
        //    {
        //        return $"({ x} + { y} + )";
        //    }

        //}

        #endregion

        #region Task6

        //class MyPoint
        //{
        //    private int x;
        //    private int y;

        //    public MyPoint()
        //    {
        //    }

        //    public MyPoint(int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }

        //    public int getX()
        //    {
        //        return x;
        //    }

        //    public void setX(int x)
        //    {
        //        this.x = x;
        //    }

        //    public int getY()
        //    {
        //        return y;
        //    }

        //    public void setY(int y)
        //    {
        //        this.y = y;
        //    }

        //    public int[] getXY()
        //    {
        //        return new int[] { this.x, this.y };
        //    }

        //    public void setXY(int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }

        //    public double distance(int x, int y)
        //    {
        //        return (double)Math.Sqrt(Math.Pow((x - this.x), 2) + Math.Pow((y - this.y), 2));
        //    }

        //    public double distance(MyPoint another)
        //    {
        //        return (double)Math.Sqrt(Math.Pow((another.x - this.x), 2) + Math.Pow((another.y - this.y), 2));
        //    }

        //    public double distance()
        //    {
        //        return (double)Math.Sqrt(Math.Pow((0 - this.x), 2) + Math.Pow((0 - this.y), 2));
        //    }

        //}


        //public class MyLine
        //{
        //    private MyPoint begin;
        //    private MyPoint end;

        //    public MyLine(int x1, int y1, int x2, int y2)
        //    {
        //        this.begin = new MyPoint(x1, y1);
        //        this.end = new MyPoint(x2, y2);
        //    }

        //    public MyLine()
        //    {
        //        this.begin = begin;
        //        this.end = end;
        //    }

        //    public MyPoint getBegin()
        //    {
        //        return begin;
        //    }

        //    public void setBegin(MyPoint begin)
        //    {
        //        this.begin = begin;
        //    }

        //    public MyPoint getEnd()
        //    {
        //        return end;
        //    }

        //    public void setEnd(MyPoint end)
        //    {
        //        this.end = end;
        //    }

        //    public void setBeginX(int x)
        //    {
        //        this.begin.setX(x);
        //    }

        //    public int getBeginX()
        //    {
        //        return begin.getX();
        //    }

        //    public void setBeginY(int y)
        //    {
        //        this.begin.setY(y);
        //    }

        //    public int getBeginY()
        //    {
        //        return begin.getY();
        //    }

        //    public void setEndX(int x)
        //    {
        //        this.end.setX(x);
        //    }

        //    public int getEndX()
        //    {
        //        return end.getX();
        //    }

        //    public void setEndY(int y)
        //    {
        //        this.end.setY(y);
        //    }

        //    public int getEndY()
        //    {
        //        return end.getY();
        //    }

        //    public void setBeginXY(int x, int y)
        //    {
        //        this.begin.setXY(x, y);
        //    }

        //    public int[] getBeginXY()
        //    {
        //        return begin.getXY();
        //    }

        //    public void setEndXY(int x, int y)
        //    {
        //        this.end.setXY(x, y);
        //    }

        //    public int[] getEndXY()
        //    {
        //        return end.getXY();
        //    }

        //    public double getLength()
        //    {
        //        return begin.distance(this.end);
        //    }

        //    public double getGradient()
        //    {
        //        return getGradient();
        //    }
        //}

        #endregion

        #region Task7

        //class MyPoint
        //{

        //    private int x;
        //    private int y;

        //    public MyPoint()
        //    {
        //    }

        //    public MyPoint(int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }

        //    public int getX()
        //    {
        //        return x;
        //    }

        //    public void setX(int x)
        //    {
        //        this.x = x;
        //    }

        //    public int getY()
        //    {
        //        return y;
        //    }

        //    public void setY(int y)
        //    {
        //        this.y = y;
        //    }

        //    public int[] getXY()
        //    {
        //        return new int[] { this.x, this.y };
        //    }

        //    public void setXY(int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }

        //    public double distance(int x, int y)
        //    {
        //        return (double)Math.Sqrt(Math.Pow((x - this.x), 2) + Math.Pow((y - this.y), 2));
        //    }

        //    public double distance(MyPoint another)
        //    {
        //        return (double)Math.Sqrt(Math.Pow((another.x - this.x), 2) + Math.Pow((another.y - this.y), 2));
        //    }

        //    public double distance()
        //    {
        //        return (double)Math.Sqrt(Math.Pow((0 - this.x), 2) + Math.Pow((0 - this.y), 2));
        //    }

        //    public string toString()
        //    {
        //        return
        //    }

        //}


        //public class MyCircle
        //{
        //    private MyPoint center;
        //    private int radius;

        //    public MyCircle()
        //    {
        //    }

        //    public MyCircle(MyPoint center, int radius)
        //    {
        //        this.center = center;
        //        this.radius = radius;
        //    }

        //    public MyCircle(int x, int y, int radius)
        //    {
        //        this.center = new MyPoint(x, y);
        //        this.radius = radius;
        //    }

        //    public MyPoint getCenter()
        //    {
        //        return center;
        //    }

        //    public void setCenter(MyPoint center)
        //    {
        //        this.center = center;
        //    }

        //    public int getRadius()
        //    {
        //        return radius;
        //    }

        //    public void setRadius(int radius)
        //    {
        //        this.radius = radius;
        //    }

        //    public int getCenterX()
        //    {
        //        return this.center.getX();
        //    }
        //    public int getCenterY()
        //    {
        //        return this.center.getY();
        //    }

        //    public void setCenterX(int x)
        //    {
        //        this.center.setX(x);
        //    }

        //    public void setCenterY(int y)
        //    {
        //        this.center.setX(y);
        //    }

        //    public int[] getCenterXY()
        //    {
        //        return this.center.getXY();
        //    }

        //    public void setCenterXY(int x, int y)
        //    {
        //        this.center.setXY(x, y);
        //    }

        //    public double getArea()
        //    {
        //        return Math.Pow(this.radius, 2) * Math.PI;
        //    }

        //    public double getCircumference()
        //    {
        //        return this.radius * 2 * Math.PI;
        //    }

        //    public double distance(MyCircle another)
        //    {
        //        return this.center.distance(another.center);
        //    }

        //    public string toString()
        //    {
        //        return $"";
        //    }

        //}


        #endregion

        #region Task8

        //class MyPoint
        //{

        //    private int x;
        //    private int y;

        //    public MyPoint()
        //    {
        //    }

        //    public MyPoint(int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }

        //    public int getX()
        //    {
        //        return x;
        //    }

        //    public void setX(int x)
        //    {
        //        this.x = x;
        //    }

        //    public int getY()
        //    {
        //        return y;
        //    }

        //    public void setY(int y)
        //    {
        //        this.y = y;
        //    }

        //    public int[] getXY()
        //    {
        //        return new int[] { this.x, this.y };
        //    }

        //    public void setXY(int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }

        //    public double distance(int x, int y)
        //    {
        //        return (double)Math.Sqrt(Math.Pow((x - this.x), 2) + Math.Pow((y - this.y), 2));
        //    }

        //    public double distance(MyPoint another)
        //    {
        //        return (double)Math.Sqrt(Math.Pow((another.x - this.x), 2) + Math.Pow((another.y - this.y), 2));
        //    }

        //    public double distance()
        //    {
        //        return (double)Math.Sqrt(Math.Pow((0 - this.x), 2) + Math.Pow((0 - this.y), 2));
        //    }
        //}

        //public class MyTriangle
        //{
        //    private MyPoint v1;
        //    private MyPoint v2;
        //    private MyPoint v3;

        //    public MyTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        //    {
        //        this.v1 = new MyPoint(x1, y1);
        //        this.v2 = new MyPoint(x2, y2);
        //        this.v3 = new MyPoint(x3, y3);
        //    }

        //    public MyTriangle(MyPoint v1, MyPoint v2, MyPoint v3)
        //    {
        //        this.v1 = v1;
        //        this.v2 = v2;
        //        this.v3 = v3;
        //    }

        //    public MyPoint getV1()
        //    {
        //        return v1;
        //    }

        //    public void setV1(MyPoint v1)
        //    {
        //        this.v1 = v1;
        //    }

        //    public MyPoint getV2()
        //    {
        //        return v2;
        //    }

        //    public void setV2(MyPoint v2)
        //    {
        //        this.v2 = v2;
        //    }

        //    public MyPoint getV3()
        //    {
        //        return v3;
        //    }

        //    public void setV3(MyPoint v3)
        //    {
        //        this.v3 = v3;
        //    }

        //    public double getPerimeter()
        //    {
        //        return this.v1.distance(this.v2) + this.v2.distance(this.v3) + this.v3.distance(this.v1);
        //    }

        //    public string getType()
        //    {
        //        if (this.v1.distance(this.v2) == this.v2.distance(this.v3) && this.v1.distance(this.v2) == this.v3.distance(this.v1))
        //        {
        //            return "Equilateral";
        //        }
        //        else if (this.v1.distance(this.v2) == this.v2.distance(this.v3) ||
        //               this.v1.distance(this.v2) == this.v3.distance(this.v1) ||
        //               this.v3.distance(this.v1) == this.v2.distance(this.v3)
        //               )
        //        {
        //            return "Isosceles";
        //        }
        //        else
        //        {
        //            return "Scalene";
        //        }
        //    }
        //}

        //public string toString()
        //{
        //    return
        //     }


        #endregion

    }
}

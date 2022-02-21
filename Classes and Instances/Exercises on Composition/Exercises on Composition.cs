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

        public class Customer
        {
            private int ID;
            private string name;
            private char gender;

            public Customer(int id, string name, char gender)
            {
                this.ID = id;
                this.name = name;
                this.gender = gender;
            }

            public int getID()
            {
                return ID;
            }

            public string getName()
            {
                return name;
            }

            public char getGender()
            {
                return gender;
            }

            public string toString()
            {
                return $"Name {name} with id {ID}";
            }



        }

        #endregion

    }
}

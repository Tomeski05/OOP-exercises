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

            Author a1 = new Author("Tan Ah Teck", "ahteck@nowhere.com");
            Console.WriteLine(a1.toString());

            a1.setEmail("ahteck@somewhere.com");
            Console.WriteLine(a1.toString());
            Console.WriteLine("name is: " + a1.getName());
            Console.WriteLine("email is: " + a1.getEmail());

            Book b1 = new Book("12345", "Java for dummies", a1, 8.8, 88);
            Console.WriteLine(b1.toString());

            b1.setPrice(9.9);
            b1.setQty(99);
            Console.WriteLine(b1.toString());
            Console.WriteLine("isbn is: " + b1.getISBN());
            Console.WriteLine("name is: " + b1.getName());
            Console.WriteLine("price is: " + b1.getPrice());
            Console.WriteLine("qty is: " + b1.getQty());
            Console.WriteLine("author's name: " + b1.getAuthorName());
            Console.WriteLine("author's name: " + b1.getAuthor().getName());
            Console.WriteLine("author's email: " + b1.getAuthor().getEmail());


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

        public class Author
        {
            private string name;
            private string email;


            public Author(string name, string email)
            {
                this.name = name;
                this.email = email;
            }

            public string getName()
            {
                return name;
            }

            public string getEmail()
            {
                return email;
            }

            public void setEmail(string email)
            {
                this.email = email;
            }

            public virtual string toString()
            {
                return $"Author name {name} with email {email}";
            }

        }


        public class Book
        {
            private string isbn;
            private string name;
            private Author author;
            private double price;
            private int qty = 0;


            public Book(string isbn, string name, Author author, double price)
            {
                this.isbn = isbn;
                this.name = name;
                this.author = author;
                this.price = price;
            }

            public Book(string isbn, string name, Author author, double price, int qty)
            {
                this.isbn = isbn;
                this.name = name;
                this.author = author;
                this.price = price;
                this.qty = qty;
            }

            public string getISBN()
            {
                return isbn;
            }

            public string getName()
            {
                return name;
            }

            public Author getAuthor()
            {
                return author;
            }

            public double getPrice()
            {
                return price;
            }

            public void setPrice(double price)
            {
                this.price = price;
            }

            public int getQty()
            {
                return qty;
            }

            public void setQty(int qty)
            {
                this.qty = qty;
            }

            public string getAuthorName()
            {
                return author.getName();
            }

            public string toString()
            {
                return $"Book name {name} and isbn {isbn} from author {author.getName()} his email {author.getEmail()} price {price} and quantity {qty}";

            }

        }


        #endregion

    }
}

using System;

namespace Exercises_on_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm');
            Console.WriteLine(ahTeck.toString());

            ahTeck.setEmail("paulTan@nowhere.com");
            Console.WriteLine("name is: " + ahTeck.getName());     
            Console.WriteLine("email is: " + ahTeck.getEmail());   
            Console.WriteLine("gender is: " + ahTeck.getGender());

            Book dummyBook = new Book("Java for dummy", ahTeck, 19.95, 99);
            Console.WriteLine(dummyBook.toString());

            dummyBook.setPrice(29.95);
            dummyBook.setQty(28);
            Console.WriteLine("name is: " + dummyBook.getName());
            Console.WriteLine("price is: " + dummyBook.getPrice());
            Console.WriteLine("qty is: " + dummyBook.getQty()); 
            Console.WriteLine("Author's name is: " + dummyBook.getAuthor().getName());
            Console.WriteLine("Author's email is: " + dummyBook.getAuthor().getEmail());


            Console.ReadLine();
        }

        public class Author
        {
            private string name;
            private string email;
            private char gender;

            public Author(string name, string email, char gender)
            {
                this.name = name;
                this.email = email;
                this.gender = gender;
            }

            public string getName()
            {
                return name;
            }

            public void setName(string name)
            {
                this.name = name;
            }

            public string getEmail()
            {
                return email;
            }

            public void setEmail(string email)
            {
                this.email = email;
            }

            public char getGender()
            {
                return gender;
            }

            public void setGender(char gender)
            {
                if (gender == 'm' || gender == 'f')
                {
                    this.gender = gender;
                }
                else
                {
                    Console.WriteLine("Gender of 'm' or 'f'");
                }
            }

            public string toString()
            {
                return $"Author name {name} with email {email} and gender {gender}";
            }

        }

        public class Book
        {
            private string name;
            private Author author;
            private double price;
            private int qty = 0;
            

            public Book(string name, Author author, double price)
            {
                this.name = name;
                this.author = author;
                this.price = price;
            }

            public Book(string name, Author author, double price, int qty)
            {
                this.name = name;
                this.author = author;
                this.price = price;
                this.qty = qty;
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

            public string toString()
            {
                return $"Book name {name} from author {author.getName()} his email {author.getEmail()} gender {author.getGender()} price {price} and quantity {qty}";
               
            }

        }

    }
}

using System;
using System.Collections.Generic;
namespace HW1
{
    class shirt
    {
        public string color, size, image;
        public float price;
        public shirt(string valuecolor, string valuesize, string valueimage, float valueprice)
        {
            color = valuecolor;
            size = valuesize;
            image = valueimage;
            price = valueprice;
        }
        public void sent()
        {
            Console.WriteLine("color : {0}", this.color);
            Console.WriteLine("size : {0}", this.size);
            Console.WriteLine("image : {0}", this.image);
            Console.WriteLine("price : {0}", this.price);
        }
    }
    class user
    {
        public string name, email;
        public user(string valuename, string valueemail)
        {
            name = valuename;
            email = valueemail;
        }
        public void sent()
        {
            Console.WriteLine("name : {0}", this.name);
            Console.WriteLine("email : {0}", this.email);
        }
    }
    class address
    {
        public string street, city, zipcode;
        public address(string valuestreet, string valuecity, string valuezipcode)
        {
            street = valuestreet;
            city = valuecity;
            zipcode = valuezipcode;
        }
        public void sent()
        {
            Console.WriteLine("street : {0}", this.street);
            Console.WriteLine("city : {0}", this.city);
            Console.WriteLine("zipcode : {0}", this.zipcode);
        }
    }
    class shoppingcart
    {
        public void orderTShirt()
        {
            shirt order1 = new shirt("red", "L", "stupidshirt", 500);
            shirt order2 = new shirt("black", "M", "stupidshirt", 750);
            shirt order3 = new shirt("black", "M", "stupidshirt", 625);
            user client = new user("jame watson ", "jame@gmail.com");
            address ad = new address("131/75 phutamonton", "nakornprathom", "10180");
            Console.WriteLine("total cost : {0}", order1.price + order2.price + order3.price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            shirt order1 = new shirt("red", "L", "stupidshirt", 500);
            shirt order2 = new shirt("black", "M", "stupidshirt", 750);
            shirt order3 = new shirt("black", "M", "stupidshirt", 625);
            user client = new user("jame watson ", "jame@gmail.com");
            address ad = new address("131/75 phutamonton", "nakornprathom", "10180");
            order1.sent();
            order2.sent();
            order3.sent();
            client.sent();
            ad.sent();
            Console.WriteLine("total cost : {0}", order1.price + order2.price + order3.price);
        }
    }
}

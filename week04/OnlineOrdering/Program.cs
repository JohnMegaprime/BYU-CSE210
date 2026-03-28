using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Whole Milk (1 Gallon)",9021 ,4.29);
        Product product2 = new Product("Large Grade A Eggs (Dozen)",4410 ,3.49);
        Product product3 = new Product("Banana",1002 ,2.15);
        Product product4 = new Product("Bread",7732 ,5.50);
        Product product5 = new Product("Butter",2281 ,4.99);
        Product product6 = new Product("Almonds",5504 ,7.25);
        Product product7 = new Product("Sparkling Water Pack",1190 ,6.49);
        Product product8 = new Product("Olive Oil",3342 ,12.99);
        Product product9 = new Product("Spinach",8821 ,3.75);
        Product product10 = new Product("Oats",6603 ,3.89);
        
        Address address1 = new Address("4728 Maplewood Avenue", "Springfield", "Illinois","USA");
        Address address2 = new Address("Rua das Palmeiras, 1120", "Joinville", "Santa Catarina","Brazil");

        Customer customer1 = new Customer("John Carmack", address1);
        Customer customer2 = new Customer("Melyssa de Souza", address2);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1, 1);
        order1.AddProduct(product5, 3);
        order1.AddProduct(product2, 1);
        order1.AddProduct(product7, 2);
        order1.AddProduct(product10, 1);

        order1.DisplayPackagingLabel();
        order1.DisplayShippingLabel();
        order1.DisplayTotalPrice();

        Order order2 = new Order(customer2);

        order2.AddProduct(product10, 1);
        order2.AddProduct(product5, 2);
        order2.AddProduct(product3, 4);
        order2.AddProduct(product6, 3);

        order2.DisplayPackagingLabel();
        order2.DisplayShippingLabel();
        order2.DisplayTotalPrice();
        
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address[] addresses =  new Address[2];
        Customer[] customers =  new Customer[2];
        List<Product>[] productsLists = new List<Product>[2];
        Order[] orders = new Order[2];

        //ORDER 1 (USA)
        addresses[0] = new Address("7456 JENKINS AVE", "HESPERIA", "California", "USA");
        customers[0] =  new Customer("Aaron Eustice",addresses[0]);
        productsLists[0] = new List<Product>();
        productsLists[0].Add(new Product("Portable Plug&Play Travel Laptop Monitor","T156",89.99f,2));
        productsLists[0].Add(new Product("DEWALT 20V MAX Impact Driver, Cordless, 3-Speed, Battery and Charger Included","D845",169.00f,1));
        productsLists[0].Add(new Product("Sony WH-1000XM4 Wireless Premium Noise Canceling Overhead Headphones","W104",348.00f,1));
        orders[0] = new Order(customers[0],productsLists[0]);

        //ORDER 2 (NOT USA)
        addresses[1] = new Address("46 Manuel Payno", "Naucalpan de Juarez", "Estado de Mexico", "Mexico");
        customers[1] =  new Customer("Detzani Santiago",addresses[1]);
        productsLists[1] = new List<Product>();
        productsLists[1].Add(new Product("Purple Hard Shell Luggage Set", "A333",149.99f,1));
        productsLists[1].Add(new Product("Roborock S8 Pro Ultra","R0S8",1199.99f,1));
        productsLists[1].Add(new Product("Leebein Electric Spin Scrubber, Cordless Powerful Scrub Brush","L246",39.99f,2));
        productsLists[1].Add(new Product("HOUSE DAY Taupe Velvet Hangers 60 Pack","G630",19.99f,3));
        orders[1] = new Order(customers[1],productsLists[1]);

        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine($"\n-----CUSTOMER N°{i+1} ORDER-----");
            Console.WriteLine($"PACKING LABEL:\n{orders[i].GetPackingLabel()}"); 
            Console.WriteLine($"SHIPPING LABEL\n{orders[i].GetShippingLabel()}");
            Console.WriteLine($"TOTAL COST: ${orders[i].GetTotalCost()}");
        }
    }
}
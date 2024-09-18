namespace PetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create four objects
            Pet p1 = new Pet("Bruce", 3, "energetic pug");
            Pet p2 = new Pet("Simone", 2, "small husky");
            Pet p3 = new Pet("Jason", 4, "stern rotweiller");
            Pet p4 = new Pet("Pompo", 3, "spry doberman");

            //Create List and store objects
            List<Pet> pets = new List<Pet>();
            pets.Add(p1);
            pets.Add(p2);
            pets.Add(p3);
            pets.Add(p4);

            //Try some of the methods on some of the objects
            p3.Train();
            p1.Train();

            //Using a loop, display object information
            foreach(Pet p in pets)
            {
                Console.WriteLine(p.ToString());
            }

            //Inquire for an owner, query objects for owner, display relevant pets
            Console.Write("Please provide an owners name to see their pets: ");
            string ownerInquiry = Console.ReadLine();
            Console.WriteLine($"Here are {ownerInquiry}'s pets: ");
            foreach (Pet p in pets)
            {
                if (p.Owner == ownerInquiry) 
                {
                    Console.WriteLine(p.ToString());
                }
            }


        }
    }
}



List<Guest> guests = new List<Guest>()
{
    new Guest()
    {
      name = "Marilyn Monroe",
      occupation = "entertainer",
      bio = "(1926 - 1962) American actress, singer, model"
    },
    new Guest()
    {
      name = "Abraham Lincoln",
      occupation = "politician",
      bio = "(1809 - 1865) US President during American civil war"
    },
    new Guest()
    {
      name = "Martin Luther King",
      occupation = "activist",
      bio = "(1929 - 1968)  American civil rights campaigner"
    },
    new Guest()
    {
      name = "Rosa Parks",
      occupation = "activist",
      bio = "(1913 - 2005)  American civil rights activist"
    },
    new Guest()
    {
      name = "Peter Sellers",
      occupation = "entertainer",
      bio = "(1925 - 1980) British actor and comedian"
    },
    new Guest()
    {
      name = "Alan Turing",
      occupation = "computer scientist",
      bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
    },
    new Guest()
    {
      name = "Admiral Grace Hopper",
      occupation = "computer scientist",
      bio = "(1906–1992) - developed early compilers = FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
    },
    new Guest()
    {
      name = "Indira Gandhi",
      occupation = "politician",
      bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
    }
};

// Since we want everyone to have an interesting evening, we want to diversify the guests as much as possible. To that end, we don't want people with the same occupation to sit at the same table. Your task is to divide the guests into different tables accordingly.
List<Guest> Table1 = new List<Guest>();
List<Guest> Table2 = new List<Guest>();

//Storing guest's occupation in this list so I can compare/contrast who sits at the tables
List<string> Occupations = new List<string>();

foreach(Guest singleGuest in guests)
{   
    //checking if occupation string is in the occupations list
    if(Occupations.Contains(singleGuest.occupation))
    {
        Table2.Add(singleGuest);
    }
    else
    {
        //if occupation isn't in the list, add the occupation and the guest
        Occupations.Add(singleGuest.occupation);
        Table1.Add(singleGuest);
    }
}

Console.WriteLine("Table 1");
foreach(Guest guest in Table1)
{
    Console.WriteLine($"{guest.name} {guest.occupation} {guest.bio}");
}
Console.WriteLine("Table 2");
foreach(Guest guest in Table2)
{
    Console.WriteLine($"{guest.name} {guest.occupation} {guest.bio}");
}

public class Guest
{
    public string name { get; set; }
    public string occupation { get; set; }
    public string bio { get; set; }
}

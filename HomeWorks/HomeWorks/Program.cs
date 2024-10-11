
using HomeWorks.Animals;
using HomeWorks.Animals.Birds;
using HomeWorks.Animals.Fish;
using HomeWorks.Animals.Mammals.Glires;
using HomeWorks.Animals.Mammals.Harvbivorous;
using HomeWorks.Animals.Mammals.Predators;

var random = new Random();
var animalTypesCount = 7;
var ownersNames = new[] { "John Wick", "Oscar De La Hoya", "Tyson Furry", "Arnold Schwarzenegger", "Angelina Joly", "Tonny Start", "Thor Odinson", "Bruce Benner", "Bruce Lee", "Jackie Chan" };
var animalsNames = new[] { "Tom", "MobyDick", "Bollo", "Lobbo", "Jerry", "Nemo", "Optimus", "Lucky", "Jumper", "Read Line" };
var animalCount = 10;
var animals = new List<Animals>();
for (int i = 0; i < animalCount; i++)
{
    var masterNameIndex = random.Next(ownersNames.Length);
    var masterName = ownersNames[masterNameIndex];

    var animalNameIndex = random.Next(animalsNames.Length);
    var animalName = animalsNames[animalNameIndex];

    animals.Add(new Wolf()
    {
        Name = "Huan the Great",
        Age = 703,
        Master = "Luthien"
    });
    var animalNumber = random.Next(animalTypesCount);
    Animals animal = animalNumber switch
    {
        0 => new Parrot()
        {
            Name = animalName,
            Age = random.Next(1, 17),
            Master = masterName
        },
        1 => new Whale()
        {
            Name = animalName,
            Age = random.Next(1, 17),
            Master = masterName
        },
        2 => new Mouse()
        {
            Name = animalName,
            Age = random.Next(1, 17),
            Master = masterName
        },
        3 => new Cow()
        {
            Name = animalName,
            Age = random.Next(1, 17),
            Master = masterName
        },
        4 => new Dog()
        {
            Name = animalName,
            Age = random.Next(1, 17),
            Master = masterName
        },
        5 => new Wolf()
        {
            Name = animalName,
            Age = random.Next(1, 17),
            Master = masterName
        },
        6 => new Wolf()
        {
            Name = animalName,
            Age = random.Next(1, 17),
            Master = masterName
        },
    };
    animals.Add(animal);
}

for (int i = 0; i < animals.Count - 1; i++)
{
    var a = animals[i];
    Console.WriteLine($"{a.Name}, {a.Master}");
    animals[i].Feed();
}
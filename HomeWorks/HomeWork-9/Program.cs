
using HomeWork_9.Animals.Birds;
using HomeWork_9.Animals.Fish;
using HomeWork_9.Animals.Mammals.Glires;
using HomeWork_9.Animals.Mammals.Harvbivorous;
using HomeWork_9.Animals.Mammals.Predators;

var parrot = new Parrot();
parrot.Age = 7;
parrot.Name = "Mango";
parrot.Host = "Jack Sparrow";
parrot.Feathers = "Yellow and Blue, very nice";
parrot.SaySomething();
parrot.Fly();

var ostrich = new Ostrich();
ostrich.Age = 2;
ostrich.Name = "Ollie";
ostrich.Host = "Farmer Bob";
ostrich.Feathers = "Black&White, very fancy";
ostrich.SaySomething();
ostrich.Run();

var whale = new Whale();
whale.Age = 2000;
whale.Name = "Ollie";
whale.SaySomething();
whale.Swim();
whale.DeepDiving();

var perch = new Perch();
perch.Age = 20;
perch.Name = "Bengamin";
perch.SaySomething();
perch.Swim();
perch.RiverSwimming();

var mouse = new Mouse();
mouse.Age = 12;
mouse.Host = "Ms Jackson";
mouse.Name = "Mikky";
mouse.SaySomething();
mouse.Run();
mouse.Crunch();
mouse.LiveOnEarth();

var cow = new Cow();
cow.Name = "Milka";
cow.SaySomething();

var cat = new Cat();
cat.Name = "Murchik";
cat.Host = "Michel Obama";
cat.Age = 2;
cat.SaySomething();
cat.Hunt();
cat.LyingAndDoNothing();

var wolf = new Wolf();
wolf.Name = "Bollo";
wolf.BandName = "East Wolves";
wolf.SaySomething();
wolf.Hunt();

var dog = new Dog();
dog.Host = "Luthien";
dog.Name = "Huan the Great";
dog.Age = 35;
dog.SaySomething();

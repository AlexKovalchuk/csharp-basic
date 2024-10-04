using HomeWork_8;

var chirpy = new Parrot("Chirpy", "Jack Sparrow");
chirpy.SaySomething();
var mango = new Parrot();
mango.HostName = "John Wick"; 
mango.SaySomething();

var nemo = new Fish("Nemo", "Oliver Twist");
nemo.SaySomething();
var blueWhale = new Fish();
blueWhale.Name = "MobyDick";
blueWhale.HostName = "Manwe";
blueWhale.SaySomething();

var tom = new Cat("Tom", "Bernard Hopkins");
tom.SaySomething();
var lazyCat = new Cat();
lazyCat.Name = "Just Lazy";
lazyCat.HostName = "Benedict Rojers";
lazyCat.SaySomething();

var thunder = new Horse("Thunder", "Quin Victory");
thunder.SaySomething();
var thor = new Horse();
thor.Name = "Thor";
thor.HostName = "Brother Loki";
thor.SaySomething();


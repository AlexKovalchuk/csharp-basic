using HomeWorks;


static List<Product> GenerateProducts()
{
    var random = new Random();
    string[] pTitles = new []{"jacket", "trauses", "t-short", "hat", "cap", "socks", "shorts", "sweter", "jeense", "coat"};
    string[] pCategory = new []{"summer", "demiseason", "winter"};
    List<Product> products = new List<Product>();
    var titleIndex = random.Next(pTitles.Length);
    var title = pTitles[titleIndex];

    var categoryIndex = random.Next(pCategory.Length);
    var category = pCategory[categoryIndex];
    int maxPrice = 5000;
    int numbersAfterDot = 2;
    var price = Math.Round(random.NextDouble() * maxPrice, numbersAfterDot);
    products.Add(new Product(title, category, price));

    return products;
}

Console.WriteLine("Home Work 13 LINQ methods");

List<string> listOfNames = new List<string>
{
    "Abba", "Bobby", "Adam", "Aharon", "Akiva (Akiba)", "Alexander", "Aron", "Arik", "Oren", "Ore", "Arel", "Arele", "Orel", "Arke", "Orke", "Arush", "Orush", "Arushka", "Arushke",
    "Leib", "Leibel", "Leibele", "Leibish", "Leibush", "Lev", "Levke", "Aryeh", "Ari", "Arik", "Artze", "Artzi", "Arke", "Arel",
    "Lavi", "Raphael", "Ehud", "Eitan", "Moshe", "Avigal", "Yael", "Noah"
};

Console.WriteLine("");
Console.WriteLine("---------------1-----------------");
// отримує набір рядків зі словами та фільтрує лише ті,
// які починаються з літери "A". Вивести результат на екран.
List<string> wordsStartsA =
    (from stringItem in listOfNames
        where stringItem[0] == 'A'
        select stringItem).ToList();
foreach (var aWord in wordsStartsA)
{
    Console.WriteLine($"Starts from A: {aWord}");
}

Console.WriteLine("");
Console.WriteLine("---------------2-----------------");
// Створити два масиви цілих чисел різної довжини. Використовуючи LINQ,
// знайти всі значення, які містяться
// в обох масивах та відобразити їх на екран.
List<string> SecondTaskListA = new List<string>
{
    "Abba", "Bobby", "Adam", "Aharon", "Akiva (Akiba)", "Lev", "Levke", "Aryeh", "Ari", "Arik", "Artze", "Artzi", "Arke", "Arel",
    "Lavi", "Raphael", "Ehud", "Eitan", "Moshe", "Avigal", "Yael", "Noah"
};
List<string> SecondTaskListB = new List<string>
{
    "Oren", "Ore", "Arel", "Arele", "Orel", "Arke", "Orke", "Arush", "Orush", "Arushka", "Arushke",
    "Leib", "Leibel", "Leibele", "Leibish", "Leibush", "Lev", "Levke", "Aryeh", "Ari", "Arik", "Artze", "Artzi", "Arke", "Arel",
    "Lavi", "Raphael", "Ehud", "Eitan", "Moshe", "Avigal", "Yael", "Noah"
};
var resultSet2 = SecondTaskListA.Intersect(SecondTaskListB);

foreach (string r in resultSet2)
{
    Console.WriteLine($"Intersected string: {r}");
}

Console.WriteLine("");
Console.WriteLine("---------------3-----------------");
// створює колекцію об'єктів класу Student,
// в яких є поля "Ім'я", "Прізвище" та "Оцінка".
// Використовуючи LINQ, знайти студента з максимальною оцінкою
// та вивести його на екран.

List<Student> students = new List<Student>();
var random = new Random();
for (int i = 0; i < listOfNames.Count; i++)
{
    var nameIndex = random.Next(listOfNames.Count);
    var name = listOfNames[nameIndex];

    var surnameIndex = random.Next(listOfNames.Count);
    var surname = listOfNames[surnameIndex];

    var score = Math.Round(random.NextDouble() * 5, 2);
    students.Add(new Student(name, surname, score));
}

foreach (var st in students)
{
    Console.WriteLine($"Student: {st.Name} {st.Surname}, score = {st.Score}");
}

var bestStudent = students.MaxBy(s => s.Score);
Console.WriteLine($"BEST Student is: {bestStudent?.Name} {bestStudent?.Surname}, score = {bestStudent?.Score}");

Console.WriteLine("");
Console.WriteLine("---------------4-----------------");
// Створити колекцію об'єктів класу Product, в яких є поля "Назва", "Ціна" та "Категорія".
// Використовуючи LINQ, згрупувати продукти за категорією
// та обчислити середню ціну кожної категорії.
string[] pTitles = new []{"jacket", "trauses", "t-short", "hat", "cap", "socks", "shorts", "sweter", "jeense", "coat"};
string[] pCategory = new []{"summer", "demiseason", "winter"};
List<Product> products = new List<Product>();
for (int i = 0; i < listOfNames.Count; i++)
{
    var titleIndex = random.Next(pTitles.Length);
    var title = pTitles[titleIndex];

    var categoryIndex = random.Next(pCategory.Length);
    var category = pCategory[categoryIndex];
    int maxPrice = 100;
    int numbersAfterDot = 2;
    var price = Math.Round(random.NextDouble() * maxPrice, numbersAfterDot);
    products.Add(new Product(title, category, price));
    Console.WriteLine($"{products[i].Title} {products[i].Price}");
}

var groupedProducts =
(
    from product in products
    group product by product.Category
    into categoryGroup
    select new
    {
        Category = categoryGroup.Key,
        AveragePrice =  Math.Round((double)categoryGroup.Average(p => p.Price), 2)
    }
);
foreach(var group in groupedProducts){
    Console.WriteLine($"Category: {group.Category}, Average Price: {group.AveragePrice}");
}

Console.WriteLine("");
Console.WriteLine("---------------5-----------------");
// Створити колекцію об'єктів класу Employee,
// в яких є поля "Ім'я", "Прізвище", "Дата народження" та "Дата працевлаштування".
// Використовуючи LINQ,
// знайти робітників, які працюють в компанії більше 5 років.
List<Employee> employees = new List<Employee>();
for (int i = 0; i < listOfNames.Count; i++)
{
    var employeeIndex = random.Next(SecondTaskListA.Count);
    var name = SecondTaskListA[employeeIndex];

    var surnameIndex = random.Next(SecondTaskListB.Count);
    var surname = SecondTaskListB[surnameIndex];
    DateTime birthday = DateGenerator.GenerateRandomDate(18, 81);
    DateTime employedDate = DateGenerator.GenerateRandomDate(1, 21);

    employees.Add(new Employee(name, surname, birthday, employedDate));
    // Console.WriteLine($"{employees[i].Name} {employees[i].Surname} birthday:{employees[i].Birthday}, employed date: {employees[i].EmployedDate}");
}

DateTime fiveYearsAgo = DateTime.Today.AddYears(-5);
List<Employee> seniorsEmployees =
(
    from employee in employees
    where employee.EmployedDate < fiveYearsAgo
    select employee).ToList();
foreach(var senior in seniorsEmployees){
    Console.WriteLine($"{senior.Name} {senior.Surname} birthday {senior.Birthday.Day}:{senior.Birthday.Month}:{senior.Birthday.Year}, employed date {senior.EmployedDate.Day}:{senior.EmployedDate.Month}:{senior.EmployedDate.Year}");
}

Console.WriteLine("");
Console.WriteLine("---------------6-----------------");
// Створити колекцію об'єктів класу Book, в яких є поля "Назва", "Автор", "Рік видання" та "Жанр".
// Використовуючи LINQ, знайти книги,
// які були видані після 2010 року та належать до жанру "Фантастика".
string[] bookTitles = new[] { "Lord of the Rings 1", "Lord of the Rings 2", "Lord of the Rings 3", "Hobbit", "Baren and Luthien", "Unfinished Tales of Numenor", "Dune 1", "Dune 2", "Dune 3", "Dune 4", "Dune 5", "TIch and pure father", "5 languages of love", "7 skills of extra efficient people", "power of self confident", "path of samurai", "Love of God", "Kalvin biik", "Basic Theology", "War of words", "History of German", "History of England", "History of Ukraine"};
string[] genreList = new[] {"Fantasy", "History", "Non fiction", "Fantastic", "Adventure"};
List<Book> books = new List<Book>();

for (int i = 0; i < listOfNames.Count; i++)
{
    var titleIndex = random.Next(bookTitles.Length);
    var title = bookTitles[titleIndex];

    var genreIndex = random.Next(genreList.Length);
    var genre = genreList[genreIndex];

    var employeeIndex = random.Next(SecondTaskListA.Count);
    var name = SecondTaskListA[employeeIndex];

    var surnameIndex = random.Next(SecondTaskListB.Count);
    var surname = SecondTaskListB[surnameIndex];
    DateTime promotionDate = DateGenerator.GenerateRandomDate(1, 121);
    books.Add(new Book(title, $"{name} {surname}", genre, promotionDate));
    Console.WriteLine($"{books[i].Title} {books[i].Author} {books[i].Genre} {books[i].PromotionDate.Year}");
}

var booksYoungerThan2010 = (
        from book in books
        where book.PromotionDate.Year > 2010
        select book
        ).ToList();
Console.WriteLine("--------Next will be books that are younger than 2010 year-------");
foreach (var book in booksYoungerThan2010)
{
    Console.WriteLine($"{book.Title} {book.Author} {book.Genre} {book.PromotionDate.Year}");

}

Console.WriteLine("");
Console.WriteLine("---------------6-----------------");
// Створити колекцію об'єктів класу Customer,
// в яких є поля "Ім'я", "Прізвище", "Адреса" та "Замовлення".
// Використовуючи LINQ, знайти клієнтів,
// які зробили замовлення на суму більше 1000 грн
// та вивести їх замовлення у вигляді переліку.
List<Customer> customers = new List<Customer>();
for (int i = 0; i < listOfNames.Count; i++)
{
    var titleIndex = random.Next(bookTitles.Length);
    var title = bookTitles[titleIndex];

    var employeeIndex = random.Next(SecondTaskListA.Count);
    var name = SecondTaskListA[employeeIndex];

    var surnameIndex = random.Next(SecondTaskListB.Count);
    var surname = SecondTaskListB[surnameIndex];

    DateTime orderDate = DateGenerator.GenerateRandomDate(0, 3);

    customers.Add(new Customer(name, surname, "some address of the customer", GenerateProducts(), title));
}

foreach (var customer in customers)
{
    Console.WriteLine($"{customer.Name} {customer.Surname} {customer.Address}");
    Console.WriteLine($"Order title = {customer.Order.Title} Order date: {customer.Order.OrderDate} {customer.Order.Title}");
    Console.WriteLine($"TotalPrice: {customer.Order.TotalPrice}");
}

var expensiveOrderPrice = 1000;
var profitableClients = (
    from customer in customers
    where customer.Order.TotalPrice > expensiveOrderPrice
    select customer
).ToList();
Console.WriteLine("------------------profitableClients--------------------");
foreach (var profCustomer in profitableClients)
{
    Console.WriteLine($"{profCustomer.Order.Title} {profCustomer.Order.TotalPrice}");
}

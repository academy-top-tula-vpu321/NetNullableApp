
string? str = null;

PrintUpperString(str);

str = "Hello";
PrintUpperString(str);

int a;
int? number = null;
number = 567;

//number = a;

if (number.HasValue)
    a = number.Value;
else
    a = 0;

if (number is not null)
    a = number.Value;
else
    a = 0;

a = number ?? 0;

Console.WriteLine(a);

//if(number.HasValue)
//    a = number.Value;


User bob = new();

//if(bob is not null)
//    if(bob.Name is not null)
//    {
//        Console.Write($"User name: {bob.Name}");
//        if(bob.Address is not null)
//        {
//            Console.WriteLine($", city: {bob.Address.City}");
//        }
//    }

bob.Name = "Bobby";
bob.Address = new()
{
    City = "Moscow"
};

Console.WriteLine($"User name: {bob?.Name}, city: {bob?.Address?.City}");

//Console.WriteLine($"User name: {bob.Name}, city: {bob.Address.City}");



void PrintUpperString(string? str)
{
    if(str is not null)
        Console.WriteLine(str.ToUpper());
}

class Address
{
    public string City { set; get; } = null!;
}

class User
{
    public string Name { set; get; }
    public Address Address { set; get; }
}
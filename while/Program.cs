//While and foreach loops
Console.WriteLine("Type in a number to see cummulative sum till it.");
try{
    int num = int.Parse(Console.ReadLine());
    int sum = 0;
    int i = 0;
    while(i < num){
        sum += i;
        i++;
    }
    Console.WriteLine("The sum is " + sum);
}
catch{
    Console.WriteLine("Invalid input!");
}

Console.WriteLine("");

Console.WriteLine("The letters a to z");
char letter = 'a';
while(letter <= 'z'){
    Console.WriteLine(letter);
    letter++;
}

Console.WriteLine("");

string[] carModels = {"Honda", "Toyata", "Mercedes"};

foreach(var models in carModels){
    Console.WriteLine(models);
}

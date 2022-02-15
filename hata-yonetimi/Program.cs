string num1;
string num2;

try{
    Console.WriteLine("Num1: ");
    num1 = Console.ReadLine();
    Console.WriteLine("Num2: ");

    num2 = Console.ReadLine();

    int result = Convert.ToInt32(num1) + Convert.ToInt32(num2);
    Console.WriteLine(result);
}
catch(Exception e){
    Console.WriteLine(e.Message.ToString());
}
finally{
    Console.WriteLine("Calculation is done!");
}
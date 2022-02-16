//For loops Example
Console.WriteLine("Type in zero to exit the code!");
try{
    for(;;){
        Console.WriteLine("Number to check if it is prime:");
        string numString = Console.ReadLine();
        int num = Convert.ToInt32(numString);
        if(num == 0)
        {
            Console.WriteLine("Program is terminated!");
            return;
        }
        if(num < 2){
            Console.WriteLine("It is not a prime number!");
            continue;
        }
        else if (num == 2){
            Console.WriteLine("It is a prime number!");
            continue;
        }

        bool isPrime = true;
        for(int i = 2; i < num; i++){
            if(num % i == 0){
                Console.WriteLine("It is not a prime number!");
                isPrime = false;
                break;
            }
        }

        if(isPrime == true)
            Console.WriteLine("It is a prime number!");
    }
}
catch
{
    Console.WriteLine("Invalid value!");
}





//Assignment Operators
int x = 2;
int y = 10;
y /= 1;
y += 2;
y *= 2;
y -= 2;

y |= 2;
y &= 3;
y ^= 4;
y >>= 2;
y <<= 4;

//Arithmetic operators 
y = x + 2;
y = y - 3;
y = y * 2;
y = y / 2;
y = y % x;
y++;
++y;
--y;
y--;

//Logic Operators
bool isSuccess = true;
bool isCompleted = true;

if(isSuccess && isCompleted){
    Console.WriteLine("Perfect");
}

if (isSuccess || isCompleted)
{
    Console.WriteLine("Great");
}

if (isSuccess || !isCompleted)
{
    Console.WriteLine("Fine");
}

//Relational Operators
int a = 3;
int b = 5;

bool result = a > b;
Console.WriteLine(result);

result = a < b;
Console.WriteLine(result);

result = a >= b;
Console.WriteLine(result);

result = a <= b;
Console.WriteLine(result);

result = a == b;
Console.WriteLine(result);

result = a != b;
Console.WriteLine(result);

//Bitwise Operators
x = 5;
y = 10;
int iresult;

iresult = x & y; //And

iresult = x | y; //Or

iresult = x ^ y; //Xor

iresult = ~x;   //Bitwise complement

iresult = x << 2; //Bitwise left shift

iresult = x >> 2; //Bitwise right shift

//Conditional Operator
iresult = x > y ? x : y;

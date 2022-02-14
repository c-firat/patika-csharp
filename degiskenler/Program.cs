// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

byte b = 5;     //1 byte
sbyte ub = 5;   //1 byte

short s = 1;    //2 byte
ushort us = 1;  //2 byte

Int16 i16 = 1;  //2 byte
int i = 1;      //4 byte
Int32 i32 = 1;  //4 byte
Int64 i64 = 1;  //8 byte

uint ui = 1;    //4 byte
long l = 1;     //8 byte
ulong ul = 1;   //8 byte

float f = 1;    //4 byte
double d = 1;   //8 byte
decimal de = 1; //16 byte

char ch = '1';    //1 byte
string str = " "; //dynamic

bool t1 = true;   //1 byte
bool f1 = false;  //1 byte

DateTime dt = DateTime.Now;

Console.WriteLine(dt);

object o1 = "x";
object o2 = 'a';
object o3 = 4;
object o4 = 4.3;

//Implicit Conversion
byte a  = 1;
sbyte b = 4;
short c = 6;

int d = a + b + c;
long h = d;

float i = h;

string e = "some";
char f = 'f';
object g = e + f + d;

//Explicit Conversion
int x = 4;
byte y = (byte)x;

float s = 100.3f;
byte t = (byte)s;

//ToString method
int x1 = 6;
string y1 = x1.ToString();
string z1 = 12.3f.ToString();

//System.Convert
string num1 = 10;
string num2 = 20;
int result;
result = Convert.ToInt32(num1) + Convert.ToInt32(num2);

//Parse
int num1Parsed = Int32.Parse(num1);

//Operators
//Arithmetic Operators
using System;
namespace Arithmetic
{
class DNT
{
 static void Main(string[] args)
 {
 int result;
 int x = 10, y = 5;
 result = (x + y);
 Console.WriteLine("Addition Operator: " + result);
 result = (x - y);
 Console.WriteLine("Subtraction Operator: " + result);
 result = (x * y);
 Console.WriteLine("Multiplication Operator: "+ result);
 result = (x / y);
 Console.WriteLine("Division Operator: " + result);
 result = (x % y);
 Console.WriteLine("Modulo Operator: " + result);
 result = x++;
 Console.WriteLine("Increment operator: " + result);
 result = x--;
 Console.WriteLine("Decrement operator: " + result);
 
 }

}

} */
    
/* //2.Assignment Operators: 
using System;namespace Assignment {
 
class DNT {
// Main Function
static void Main(string[] args)
{
 // initialize variable x
 // using Simple Assignment
 // Operator "="
 int x = 15;
 // it means x = x + 10
 x += 10;
 Console.WriteLine("Add Assignment Operator: " + x);
 // initialize variable x again
 x = 20;
 // it means x = x - 5
 x -= 5;
 Console.WriteLine("Subtract Assignment Operator: " + x);
 // initialize variable x again
 x = 15;
 // it means x = x * 5
 x *= 5;
 Console.WriteLine("Multiply Assignment Operator: " + x);
 // initialize variable x again
 x = 25;
 // it means x = x / 5
 x /= 5;
 Console.WriteLine("Division Assignment Operator: " + x);
 // initialize variable x again
 x = 25;
 // it means x = x % 5
 x %= 5;
 Console.WriteLine("Modulo Assignment Operator: " + x);
 // initialize variable x again
 x = 8;
 // it means x = x << 2
 x <<= 2;
 Console.WriteLine("Left Shift Assignment Operator: " + x);
 // initialize variable x again
 x = 8;
 // it means x = x >> 2
 x >>= 2;
 Console.WriteLine("Right Shift Assignment Operator: " + x);
 // initialize variable x again
 x = 12;
 // it means x = x >> 4
 x &= 4;
 Console.WriteLine("Bitwise AND Assignment Operator: " + x);
 // initialize variable x again
 x = 12;
 // it means x = x >> 4
 x ^= 4;
 Console.WriteLine("Bitwise Exclusive OR Assignment Operator: " + x);
 // initialize variable x again
 x = 12;
 // it means x = x >> 4
 x |= 4;
 Console.WriteLine("Bitwise Inclusive OR Assignment Operator: " + x);
}
}
}
 */

/* //3.Comparison Operators: 
using System;
class Program
{
 static void Main(string[] args)
 {
 int num1 = 10;
 int num2 = 5;
 // Equal to
 bool isEqual = num1 == num2;
 Console.WriteLine($"{num1} == {num2} : {isEqual}");
 // Not equal to
 bool isNotEqual = num1 != num2;
 Console.WriteLine($"{num1} != {num2} : {isNotEqual}");
 // Greater than
 bool isGreater = num1 > num2;
 Console.WriteLine($"{num1} > {num2} : {isGreater}");
 // Less than
 bool isLess = num1 < num2;
 Console.WriteLine($"{num1} < {num2} : {isLess}");
 // Greater than or equal to
 bool isGreaterOrEqual = num1 >= num2;
 Console.WriteLine($"{num1} >= {num2} : {isGreaterOrEqual}");
 // Less than or equal to
 bool isLessOrEqual = num1 <= num2;
 Console.WriteLine($"{num1} <= {num2} : {isLessOrEqual}");
 }
}  */

//4.Logical Operators:
using System;
namespace Logical { 
class DNT { 
// Main Function
static void Main(string[] args)
{
 bool a = true,b = false, result; 
 // AND operator
 result = a && b;
 Console.WriteLine("AND Operator: " + result); 
 // OR operator
 result = a || b;
 Console.WriteLine("OR Operator: " + result);
 // NOT operator
 result = !a;
 Console.WriteLine("NOT Operator: " + result); 
}
}
}
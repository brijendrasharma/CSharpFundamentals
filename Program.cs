// See https://aka.ms/new-console-template for more information
using CSharpFundamentals.concepts;
Console.WriteLine("Hello, World!");
BasicClass basicClass = new BasicClass();
char bchar = basicClass.returnBasicChar();
int bnumber = basicClass.returnBasicNumber();
string bname = basicClass.returnBasicName();
Console.WriteLine($"Called Useless constructor and got char:{bchar}, name:{bname}, number:{bnumber}");

BasicClass basicClassParameterizedConstructor = new BasicClass("Brijendra",7417402,'X');
char bcharpc = basicClassParameterizedConstructor.returnBasicChar();
int bnumberpc = basicClassParameterizedConstructor.returnBasicNumber();
string bnamepc = basicClassParameterizedConstructor.returnBasicName();
Console.WriteLine($"Called Parameterized constructor and got char:{bcharpc}, name:{bnamepc}, number:{bnumberpc}");
// See https://aka.ms/new-console-template for more information
using CSharpFundamentals.concepts;
Console.WriteLine("Hello, World!");

/*BasicClass basicClass = new BasicClass();
char bchar = basicClass.returnBasicChar();
int bnumber = basicClass.returnBasicNumber();
string bname = basicClass.returnBasicName();
Console.WriteLine($"Called Useless constructor and got char:{bchar}, name:{bname}, number:{bnumber}");*/

/*BasicClass basicClassParameterizedConstructor = new BasicClass("Brijendra",7417402,'X');
char bcharpc = basicClassParameterizedConstructor.returnBasicChar();
int bnumberpc = basicClassParameterizedConstructor.returnBasicNumber();
string bnamepc = basicClassParameterizedConstructor.returnBasicName();
Console.WriteLine($"Called Parameterized constructor and got char:{bcharpc}, name:{bnamepc}, number:{bnumberpc}");*/

// Fixed object initializer syntax and property assignment
BasicProperties basicProperties = new BasicProperties() { 
    IsTouchScreen = "Yes",
    LaptopModel="Lenovo ideapad slim 3",
    LaptopOS="windows",
    Processor="i5", 
    RAMCapacity=8, 
    ScreenSize=15, 
    SSDCapacity=512
};
Console.WriteLine($"{nameof(basicProperties.LaptopModel)}: {basicProperties.LaptopModel}");
Console.WriteLine($"{nameof(basicProperties.LaptopOS)}: {basicProperties.LaptopOS}");
Console.WriteLine($"{nameof(basicProperties.SSDCapacity)}:{basicProperties.SSDCapacity}");
Console.WriteLine($"{nameof(basicProperties.IsTouchScreen)}: {basicProperties.IsTouchScreen}");
Console.WriteLine($"{nameof(basicProperties.Processor)}: {basicProperties.Processor}");
Console.WriteLine($"{nameof(basicProperties.RAMCapacity)}: {basicProperties.RAMCapacity}");
Console.WriteLine($"{nameof(basicProperties.LaptopId)}: {basicProperties.LaptopId}");
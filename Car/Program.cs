using Car;

My_car car = new My_car("Honda","Black",2021);


Console.WriteLine("The brand of the car is: " + car._Brand);
Console.WriteLine("The color of the car is: " + car._Colour);
Console.WriteLine("The model of the car is: " + car._Model);

Console.WriteLine();
Console.WriteLine("============================================================================================");
Persona objpersona = new Persona();

objpersona.createPerson("Esteban", 23, "12-06-2000");

Console.WriteLine("Name :"+ objpersona.Name + " Age: "+ objpersona.Age + " DateBirth: "+ objpersona.DateBirth);


Console.ReadLine();
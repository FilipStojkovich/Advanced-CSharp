using Homework11.Helpers;
using Newtonsoft.Json;

string folderPath = @"..\..\..\DogData";
string filePath = folderPath + @"\DogsJson.json";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}


Console.WriteLine("Enter dog name:");
string dogName = Console.ReadLine();

Console.WriteLine("Enter dog age:");
int dogAge = int.Parse(Console.ReadLine());

Console.WriteLine("Enter dog color:");
string dogColor = Console.ReadLine();

Dog dog1 = new Dog()
{
    Name = dogName,
    Age = dogAge,
    Color = dogColor
};

Dog dog2 = new Dog()
{
    Name = "Dzeki",
    Age = 5,
    Color = "Brown"
};

Dog dog3 = new Dog()
{
    Name = "Dzoni",
    Age = 10,
    Color = "Black"
};

string jsonResult1 =  JsonConvert.SerializeObject(dog1);
Console.WriteLine(jsonResult1);

ReaderWriter.WriteFile(filePath, jsonResult1);

string fileContent1 = ReaderWriter.ReadFile(filePath);
Dog deserializedDog1 = JsonConvert.DeserializeObject<Dog>(fileContent1);
Console.WriteLine(deserializedDog1.Name + " " + deserializedDog1.Age + " " + deserializedDog1.Color);

Console.WriteLine("---------Dog 2----------");

string jsonResult2 = JsonConvert.SerializeObject(dog2);
Console.WriteLine(jsonResult2);

ReaderWriter.WriteFile(filePath, jsonResult2);

string fileContent2 = ReaderWriter.ReadFile(filePath);
Dog deserializedDog2 = JsonConvert.DeserializeObject<Dog>(fileContent2);
Console.WriteLine(deserializedDog2.Name + " " + deserializedDog2.Age + " " + deserializedDog2.Color);

Console.WriteLine("---------Dog 3---------");

string jsonResult3 = JsonConvert.SerializeObject(dog3);
Console.WriteLine(jsonResult3);

ReaderWriter.WriteFile(filePath, jsonResult3);

string fileContent3 = ReaderWriter.ReadFile(filePath);
Dog deserializedDog3 = JsonConvert.DeserializeObject<Dog>(fileContent3);
Console.WriteLine(deserializedDog3.Name + " " + deserializedDog3.Age + " " + deserializedDog3.Color);


Console.ReadLine();
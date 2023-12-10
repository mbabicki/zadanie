using NUnit.Framework;
using Newtonsoft.Json;
using System.IO;

using testy;

namespace TestProcject
{
    [TestFixture]
    public class MyFunctionsTests
    {
        private readonly string filePath = "testFile.json";

        [Test]
        public void SumArray_ReturnsCorrectSum()
        {
            
            var myFunctions = new MyFunctions();
            int[] numbers = { 1, 2, 3, 4, 5 };

           
            int result = myFunctions.SumArray(numbers);

            
            Assert.AreEqual(15, result);
        }

        [Test]
        public void SumArray_SerializesAndDeserializesCorrectly()
        {
            
            var myFunctions = new MyFunctions();
            int[] numbers = { 1, 2, 3, 4, 5 };

            
            int resultBeforeSerialization = myFunctions.SumArray(numbers);

            
            string json = JsonConvert.SerializeObject(numbers);
            File.WriteAllText(filePath, json);

            
            string jsonFromFile = File.ReadAllText(filePath);
            int[] numbersFromFile = JsonConvert.DeserializeObject<int[]>(jsonFromFile);
            int resultAfterDeserialization = myFunctions.SumArray(numbersFromFile);

            
            Assert.AreEqual(resultBeforeSerialization, resultAfterDeserialization);
        }

        
    }

}

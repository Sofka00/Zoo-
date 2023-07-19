using System.Xml.Linq;
using Zoo;
namespace ZooTest
{
    public class ZooTest
    {
        [TestCase("Hay",0.2, $"{"Simba"} est")]
        public void EatTest(string food, double count,string expected)
        {   
            Animals slon = new Animals("Simba", "Elephant", "desert",10,new string[1] {"Hay"}, "Mammal", "Auf-Auf",0,5,5);
            
           string actual = slon.Eat(food, count);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void EatTest_WhenCountLessThenZiro_ShuldArgumentExeption()
        {
            Animals slon = new Animals("Simba", "Elephant", "desert", 10, new string[1] { "Hay" }, "Mammal", "Auf-Auf", 0, 5, 5);
            string food = "Fish";
            double count = -1;
            Assert.Throws<ArgumentException>(() => slon.Eat(food, count));
        }


    }
}
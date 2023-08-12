using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using Zoo;
namespace ZooTest
{
    public class ZooTest
    {
        [TestCase("Fish", 0.2, $"{"Simba"} est")]
        public void EatTest(string food, double count, string expected)
        {
            PenguinAnimal penguin = new PenguinAnimal("Simba");
            string actual = penguin.Eat(food, count);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void EatTest_WhenCountLessThenZiro_ShuldArgumentExeption()
        {
            PenguinAnimal slon = new PenguinAnimal("");
            string food = "Fish";
            double count = -1;
            Assert.Throws<ArgumentException>(() => slon.Eat(food, count));
        }
        [TestCase("animal played with Sam")]
        public void PlayTest( string expected)
        {
           PenguinAnimal cat = new PenguinAnimal("Sam");
            string actual = cat.Play(cat);
            Assert.AreEqual(expected, actual);
        }
    }
}

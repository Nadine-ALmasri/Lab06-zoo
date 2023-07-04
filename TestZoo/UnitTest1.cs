using Lab06_zoo;
using Lab06_zoo.classes_lab07;
using Lab06_zoo.Interfaces_lab07;
namespace TestZoo
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void GiraffeTest()
        {
            Giraffe giraffe = new Giraffe { NumberOfLegs = 4 };

            Assert.Equal("Giraffe", giraffe.Name);
            Assert.Equal("herbivorous mammal", giraffe.Type);
            string actual = giraffe.Eat();
            Assert.Equal("The Giraffe is eating.", actual);

        }
        [Fact]
        public void GiraffeEat()
        {
            Giraffe giraffe = new Giraffe { NumberOfLegs = 4 };


            string actual = giraffe.Eat();
            Assert.Equal("The Giraffe is eating.", actual);

        }
        [Fact]
        public void ParrotTest()
        {
            Parrot parrot = new Parrot();
            Assert.Equal("Parrot", parrot.Name);
            Assert.Equal("Birds", parrot.Type);


        }
        [Fact]
        public void CatTest()
        {
            Cat cat = new Cat { NumberOfLegs = 4 };

            Assert.Equal("cat", cat.Name);
            Assert.Equal("Felidae", cat.Type);


        }
        [Fact]
        public void CatMove()
        {
            Cat cat = new Cat { NumberOfLegs = 4 };


            string actual = cat.Move();
            Assert.Equal("The cat is walking.", actual);

        }
        [Fact]
        public void DOGTest()
        {
            Dog dog = new Dog();
            Assert.Equal("dog", dog.Name);
            Assert.Equal("domestic mammal", dog.Type);


        }
        [Fact]
        public void DOGMove()
        {
            Dog dog = new Dog();

            string actual = dog.Move();
            Assert.Equal("The dog is walking.", actual);

        }
        [Fact]
        public void ChickenTest()
        {
            Chicken Che = new Chicken();
            Assert.Equal("Chicken", Che.Name);
            Assert.Equal("DomesticBird", Che.Type);



        }
        [Fact]
        public void ChickenFly()
        {
            Chicken Che = new Chicken();


            string actual = Che.Fly();
            Assert.Equal("The Chicken is cant fly.", actual);


        }

        [Fact]
        public void ParrotMove()
        {
            Parrot parrot = new Parrot();

            string actual = parrot.Move();
            Assert.Equal("The Parrot is flying.", actual);

        }
        [Fact]//// Interface tests for lab 07
        public void Monkey_ImplementsFamilies_Interface()
        {
            // Arrange
            Monkey monkey = new Monkey();
            // Act
            bool implementsInterface = monkey is Living;

            // Assert
            Assert.True(implementsInterface);
        }
        [Fact]
        public void Shark_ImplementsFamilies_Interface()
        {
            // Arrange
            Shark shark = new Shark();

            // Act
            bool implementsInterface = shark is Families;

            // Assert
            Assert.True(implementsInterface);
        }
        [Fact]// test Inheritance 
        public void Monkey_InheritsFrom_Animals()
        {
            // Arrange

            Monkey monkey = new Monkey();
            // Act
            bool inheritsFromAnimals = monkey is Animals;

            // Assert
            Assert.True(inheritsFromAnimals);
        }
        public void Shark_InheritsFrom_Animals()
        {
            // Arrange

            Shark shark = new Shark();
            // Act
            bool inheritsFromAnimals = shark is Animals;

            // Assert
            Assert.True(inheritsFromAnimals);
        }
        [Fact]
        //test Polymorphism
        public void Polymorphism()
        {
            // Arrange
            Animals animal = new Monkey();

            // Act
            string move = animal.Move();

            // Assert
            Assert.Equal("The Monkey is walking.", move);
        }
        [Fact]
        //test Polymorphism
        public void SharkPolymorphism()
        {
            // Arrange
            Animals animal = new Shark();

            // Act
            string eat = animal.Eat();

            // Assert
            Assert.Equal("The Shark is Eating", eat);
        }

    }
}
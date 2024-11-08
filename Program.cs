namespace Object.Oriented.Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Encapsulation
            Console.WriteLine("Encapsulation ...");

            Console.WriteLine("Preparing the random number ...");
            Calculator calculator = new Calculator();
            // As you see, the way of preparing the random number is not important on this layer,
            //it just sends the inputs and expects the output
            //So the body of the function would be hidden and ant important for the caller 
            Console.WriteLine($"output is : {calculator.GetRandomNumber(0, 100)}");

            //******************



            // Inheritance and Polymorphism
            // We try to investigate both concepts together by the below example
            // The Shape is an abstract type which is inherited by the Circle and Square

            Console.WriteLine("Inheritance ...");

            Circle circle = new Circle()
            {
                Name = "Circle" // The name property of the parent is exists for the child because of inheritance
            };
            circle.Draw(); // Beucase of the polymorphsim, the drawing of children is customized for each one.
            Console.WriteLine("Circle shape is initialized and drawn.");

            Square square = new Square()
            {
                Name = "Square" // The name property of the parent is exists for the child because of inheritance
            };
            square.Draw();// Beucase of the polymorphsim, the drawing of children is customized for each one.
            Console.WriteLine("Square shape is initialized and drawn.");


            



        }
    }
}

namespace Task6
{
    public class Task
    {
        private double firstNumber;
        private double secondNumber;
        public double FirstNumber{
            set{
                firstNumber = value;
            }
            get{
                return firstNumber;
            }
        }
         public double SecondNumber{
            set{
                secondNumber = value;
            }
            get{
                return secondNumber;
            }
        }
        public double Add()
        {
            return firstNumber + secondNumber;
        }
        public double Sub()
        {
            return firstNumber - secondNumber;
        }
        public double Multiply()
        {
            return firstNumber * secondNumber;
        }
        public double Divide()
        {
            if(secondNumber == 0){
                return 0.0;
            }
            return firstNumber / secondNumber;
        }
    }
}
using System;

namespace Create_Class
{
    class Cars
    {
        private string _Make;
        private string _Model;
        private int _Year;

        public string Make
        {
            set
            {
                _Make = value;
            }
        }
        public string Model
        {
            set
            {
                _Model = value;
            }
        }
        public int Year
        {
            set
            {
                _Year = value;
            }
        }
        public Cars (string _Make, string _Model, int _Year)
        {
            Make = _Make;
            Model = _Model;
            Year = _Year;
        }
        public string DisplayCar()
        {
            var showmycar = "The car we have created is:\n\n";
            showmycar += $"The Make is: {_Make}\n";
            showmycar += $"The Make is: {_Model}\n";
            showmycar += $"The Make is: {_Year}\n";
            return showmycar;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Cars("Toyota", "Corola", 1986);
            var car2 = new Cars("Missan", "Wingroad", 2004);
            var car3 = new Cars("Mitsubish", "Colt", 2005);
            
            Console.WriteLine(car1.DisplayCar());
            Console.WriteLine(car2.DisplayCar());
            Console.WriteLine(car3.DisplayCar());
        }
    }
}

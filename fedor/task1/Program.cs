namespace task1
{
    internal class Program
    {
        class Car
        {
            

            private int number;
            private string mark;
            private string model;
            private string color;
            private int speed = 0;
            private int currentgear = 0;
            private bool ison = false;
            
            public Car(int number1, string mark1, string model1, string color1)
            {
                number = number1;
                mark = mark1;
                model = model1;
                color = color1;
            }

            public bool getison()
            {
                return ison;
            }
            public int getspeed()
            {
                return speed;
            }

            public int getCurrentgear()
            {
                return currentgear;
            }

            public int getnumber()
            {
                return number;
            }
            public string getmark()
            {
                return mark;
            }
            public string getmodel()
            {
                return model;
            }
            public string getColor()
            {
                return color;
            }
            public void start()
            {
                ison = true;
            }
            public void stop()
            {
                ison = false;
            }
            public void gas()
            {
                if (ison)
                {
                    switch (currentgear)
                    {
                        case -1:
                            if (speed > -30 && speed <= 0)
                            {
                                speed -= 10;
                                break;
                            }
                            speed = -30;
                            break;
                        case 0:
                            stop();
                            break;
                        case 1:
                            if (speed >= 0 && speed < 30)
                            {
                                speed += 10;
                                break;
                            }
                            speed = 30;
                            break;
                        case 2:
                            if (speed >= 20 && speed < 50)
                            {
                                speed += 20;
                                break;
                            }
                            speed = 50;
                            break;
                        case 3:
                            if (speed >= 40 && speed < 70)
                            {
                                speed += 30;
                                break;
                            }
                            speed = 70;
                            break;
                        case 4:
                            if (speed >= 60 && speed < 90)
                            {
                                speed += 40;
                                break;
                            }
                            speed = 90;
                            break;
                        case 5:
                            if (speed >= 80 && speed < 120)
                            {
                                speed += 50;
                                break;
                            }
                            speed = 120;
                            break;
                    }
                }

            }
            public void brake()
            {
                speed -= speed / 8 + 20;
                if (speed < 0)
                {
                    speed = 0;
                }
            }

            public void changeGear(int gear)
            {
                switch (gear)
                {
                    case -1:
                        if (speed >= -30 && speed <= 0)
                        {
                            currentgear = gear;
                            break;
                        }
                        else if (speed > 0)
                        {
                            stop();
                            break;
                        }
                        break;
                    case 0:
                        stop();
                        break;
                    case 1:
                        if (speed >= 0 && speed <= 30)
                        {
                            currentgear = gear;
                            break;
                        }
                        else if (speed < 0 || speed >= 50)
                        {
                            stop();
                            break;
                        }
                        break;
                    case 2:
                        if (speed >= 20 && speed <= 50)
                        {
                            currentgear = gear;
                            break;
                        }
                        else if (speed < 10 && speed >= 70)
                        {
                            stop();
                            break;
                        }
                        break;
                    case 3:
                        if (speed >= 40 && speed <= 70)
                        {
                            currentgear = gear;
                            break;
                        }
                        else if (speed < 30 && speed >= 90)
                        {
                            stop();
                            break;
                        }
                        break;
                    case 4:
                        if (speed >= 60 && speed <= 90)
                        {
                            currentgear = gear;
                            break;
                        }
                        else if (speed < 50 && speed >= 120)
                        {
                            stop();
                            break;
                        }
                        break;
                    case 5:
                        if (speed >= 80 && speed <= 120)
                        {
                            currentgear = gear;
                            break;
                        }
                        else if (speed < 70)
                        {
                            stop();
                            break;
                        }
                        break;
                }
            }
            
            
        }
        static void Main(string[] args)
        {
            bool valid = false;
            Car car1 = new Car(0, "aa", "aaa", "blue");
            Car car2 = new Car(1, "adfga", "fghfbaaa", "green");
            Car car3 = new Car(2, "46564gf", "bvvbbcv", "grey");
            Car car4 = new Car(3, "zxcxz", "w1", "purple");
            Car[] cars = { car1, car2, car3, car4 };
            int selection = 0;
            int action = 1;
            int gearaction = 0;
            while (!valid)
            {
                Console.WriteLine($"choose a car: 0) {car1.getmark()} 1) {car2.getmark()} 2) {car3.getmark()} 3) {car4.getmark()}");
                selection = Convert.ToInt32(Console.ReadLine());
                foreach (var obj in cars)
                {
                    if (selection == obj.getnumber())
                    {
                        valid = true;
                        break;
                    }
                }

            }
            while (action != 0)
            {
                Console.WriteLine($"current state: engine on?: {cars[selection].getison()} mark: {cars[selection].getmark()} model: {cars[selection].getmodel()} color: {cars[selection].getColor()} speed: {cars[selection].getspeed()} current gear: {cars[selection].getCurrentgear()}  current actions: 0) exit 1) gas 2) brake 3)change gear 4) start up 5) stop car");
                action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 0:
                        break;
                    case 1:
                        cars[selection].gas();
                        break;
                    case 2:
                        cars[selection].brake();
                        break;
                    case 3:
                        Console.WriteLine("select gear (-1-5)");
                        gearaction = Convert.ToInt32(Console.ReadLine());
                        switch (gearaction)
                        {
                            case -1:
                                cars[selection].changeGear(-1);
                                break;
                            case 0:
                                cars[selection].changeGear(0);
                                break;
                            case 1:
                                cars[selection].changeGear(1);
                                break;
                            case 2:
                                cars[selection].changeGear(2);
                                break;
                            case 3:
                                cars[selection].changeGear(3);
                                break;
                            case 4:
                                cars[selection].changeGear(4);
                                break;
                            case 5:
                                cars[selection].changeGear(5);
                                break;

                        }
                        break;
                    case 4:
                        cars[selection].start();
                        break;
                    case 5:
                        cars[selection].stop();
                        break;
                }
            }
        }
    }
}
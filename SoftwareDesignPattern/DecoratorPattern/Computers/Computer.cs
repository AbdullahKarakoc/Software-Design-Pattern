using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareDesignPattern.SoftwareDesignPattern.DecoratorPattern.Computers
{
    public class Computer
    {
        
        public void Start()
        {
            Console.WriteLine($"{GetType().Name} is starting");
        }

        public void ShutDown()
        {
            Console.WriteLine($"{GetType().Name} is shutting down");
        }

    }


    public class Laptop: Computer
    {

        public void OpenLid()
        {
            Console.WriteLine($"{GetType().Name}'s Lid is opening");
        }

        public void CloseLid()
        {
            Console.WriteLine($"{GetType().Name}'s lid is closing");
        }

    }


    public class LaptopDecorator: Laptop
    {
        public virtual void OpenLid()
        {
            // do something
            base.OpenLid();
        }

        public virtual void CloseLid()
        {
            base.CloseLid();
            // do something
        }
    }



    public class DellLaptop: LaptopDecorator
    {
        public override void CloseLid()
        {
            base.CloseLid();
            Console.WriteLine("Dell Laptop is sleeping");
        }

        public override void OpenLid()
        {
            Console.WriteLine("Dell Laptop is waking up");
            base.OpenLid();
        }

    }


        public class AppleLaptop: Laptop
    {
        public void OpenLid()
        {
            base.OpenLid();
        }

        public void CloseLid()
        {
            base.CloseLid();
        }
    }









}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace UnityDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            ContainerMagic.RegisterElements(container);

            IBattery battery = container.Resolve<IBattery>();
            Console.WriteLine(battery.SerialNumber());

            Dial dial = container.Resolve<Dial>();
            Console.WriteLine(dial.DialType());

            ITuner tuner = container.Resolve<ITuner>();
            IRadio radio = container.Resolve<IRadio>(new ParameterOverride("radioBattery", battery),
                new ParameterOverride("radioTuner", tuner),
                new ParameterOverride("radioName", "BrokenRadio"));
            radio.Start();

            Console.ReadLine();
        }
    }
}

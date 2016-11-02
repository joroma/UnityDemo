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

            

            ITuner tuner = container.Resolve<ITuner>();
            Console.WriteLine(tuner.SerialNumber());
            //IRadio radio = container.Resolve<IRadio>(new ParameterOverride("radioBattery", battery),
            //    new ParameterOverride("radioTuner", tuner),
            //    new ParameterOverride("radioName", "BrokenRadio"));
            //radio.Start();

            //ISpeaker cheapSpeaker = container.Resolve<ISpeaker>("Cheap");
            //ISpeaker priceySpeaker = container.Resolve<ISpeaker>("Expensive");
            //cheapSpeaker.Start();
            //priceySpeaker.Start();

            Console.ReadLine();
        }
    }
}

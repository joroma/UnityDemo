using Microsoft.Practices.Unity;

namespace UnityDemo
{
    public class ContainerMagic
    {
        public static void RegisterElements(IUnityContainer container)
        {
            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies(),
                WithMappings.FromMatchingInterface,
                WithName.Default,
                WithLifetime.ContainerControlled);

            container.RegisterType<Casing>(new InjectionConstructor("Plastic"));

            //Dial dial = new Dial("Linear");
            //container.RegisterInstance(dial);

            //container.RegisterType<IBattery, Battery>();
            //container.RegisterType<ITuner, Tuner>();

            //container.RegisterType<ISpeaker, CheapSpeaker>("Cheap");
            //container.RegisterType<ISpeaker, PriceySpeaker>("Expensive");

            //var batteryType = typeof(IBattery);
            //var tunerType = typeof(ITuner);
            //container.RegisterType<IRadio, Radio>(new InjectionConstructor(batteryType, tunerType, typeof(string)));
        }
    }
}

namespace DependencyInversionPrinciple
{
    public class Application
    {
        IService service;

        public Application(IServiceFactory serviceFactory) 
        {
            service = serviceFactory.MakeService();
        }

        public void Run()
        {
            Console.WriteLine("Application Running!");
            service.Execute();
        }
    }
}

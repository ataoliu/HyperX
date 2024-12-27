namespace HyperX.Application;
public interface IHelloWorldService
{
    string HelloWorld();
}
public class HelloWorldService : ServiceBase, IHelloWorldService
    {
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
namespace _2.Abstrakcyjnosc
{
    public interface IFirst
    {
    }

    public interface ISecond
    {
    }

    public interface IThird
    {
    }

    public class Hello : IFirst
    {

    }

    public class World : ISecond
    {

    }

    public class HelloWorld : IFirst, ISecond
    {

    }
}

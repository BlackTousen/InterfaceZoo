namespace InterfaceZoo
{
    public interface IWalking
    {
        void Run();
        void Walk();
    }

    public interface ISwimming
    {
        int MaximumDepth { get; }
        void Swim();
    }

    public interface IFlying
    {
        void Fly();
    }
}
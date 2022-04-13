namespace Patterns.Command.ComplexCommandImplementation
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
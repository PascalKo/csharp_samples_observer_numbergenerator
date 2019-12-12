namespace NumberGenerator.Logic
{
    public interface IObservable
    {
        delegate void NextNumberHandler(int number);

        NextNumberHandler NumberHandler { get; set; }

    }
}
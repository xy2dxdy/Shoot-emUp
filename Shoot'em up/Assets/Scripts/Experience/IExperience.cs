public interface IExperience
{
    int Current { get; /*protected set;*/ }
    void Increase(int value);
    void Decrease(int value);
    void Reload(int value);
}

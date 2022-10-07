namespace Tree
{
    public interface ITreeNode<out T>
    {
        T Left { get; }
        T Right { get; }
    }
}
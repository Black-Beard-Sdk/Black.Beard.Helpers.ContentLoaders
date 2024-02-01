namespace Bb.MultiCsv
{
    public interface IVisitor<T>
    {

        T Visit(Block block);

    }


}

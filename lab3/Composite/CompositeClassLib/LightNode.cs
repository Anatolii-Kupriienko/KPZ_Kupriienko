namespace CompositeClassLib
{
    public abstract class LightNode
    {
        public virtual void Add(LightNode node)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(LightNode node)
        {
            throw new NotImplementedException();
        }

        public virtual void Display()
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }        
    }
}
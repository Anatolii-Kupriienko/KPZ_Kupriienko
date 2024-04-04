namespace DecoratorClassLib
{
    public abstract class DecoratedArtifact : Artifact
    {
        protected Artifact _artifact;

        public DecoratedArtifact(Artifact artifact)
        {
            _artifact = artifact;
        }

        public void SetArtifact(Artifact artifact)
        {
            _artifact = artifact;
        }

        public override string Use()
        {
            if (_artifact != null)
                return _artifact.Use();
            else
                return base.Use();
        }
    }
}
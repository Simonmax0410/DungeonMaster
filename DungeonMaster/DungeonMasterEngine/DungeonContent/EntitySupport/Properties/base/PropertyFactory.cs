namespace DungeonMasterEngine.DungeonContent.EntitySupport.Properties.@base
{
    public class PropertyFactory<TProperty> : IPropertyFactory where TProperty: IProperty 
    {
        public static PropertyFactory<TProperty> Instance { get; } = new PropertyFactory<TProperty>();

        private PropertyFactory()
        { }
    }
}
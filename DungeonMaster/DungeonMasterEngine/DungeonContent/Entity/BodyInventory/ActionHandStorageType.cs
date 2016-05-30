using DungeonMasterEngine.DungeonContent.Entity.BodyInventory.@base;

namespace DungeonMasterEngine.DungeonContent.Entity.BodyInventory
{
    internal class ActionHandStorageType : IStorageType
    {
        public int Size { get; } = 1;

        public static ActionHandStorageType Instance { get; } = new ActionHandStorageType();

        private ActionHandStorageType() { }
    }
}
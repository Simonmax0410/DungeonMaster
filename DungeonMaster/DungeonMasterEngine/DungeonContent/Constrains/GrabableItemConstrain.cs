﻿using DungeonMasterEngine.DungeonContent.Items;
using DungeonMasterEngine.DungeonContent.Items.GrabableItems;
using DungeonMasterEngine.DungeonContent.Items.GrabableItems.Factories;
using DungeonMasterEngine.Interfaces;

namespace DungeonMasterEngine.DungeonContent.Constrains
{
    public class GrabableItemConstrain : IConstrain
    {
        public IGrabableItemFactoryBase DataIndex { get; }

        /// <summary>
        /// Constraion accespts all grabable items with other DataIndex than specifed
        /// </summary>
        public bool InvertConstraion { get; }

        public GrabableItemConstrain(IGrabableItemFactoryBase data, bool invertConstraion )
        {
            DataIndex = data;
            InvertConstraion = invertConstraion;
        }

        public bool IsAcceptable(object item)
        {
            if (item == null)
                return false;
            var i = item as GrabableItem;
            return i?.Factory == DataIndex ^ InvertConstraion;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {DataIndex}";
        }
    }
}
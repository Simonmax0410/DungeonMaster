﻿using System;
using DungeonMasterParser.Tiles;

namespace DungeonMasterParser
{
    public class StairsTile : Tile
    {
        //Bit 3: Orientation
            //'0' West - East
            //'1' North - South

        public Orientation Orientation { get; set; }

        //Bit 2: Direction
            //'0' Down
            //'1' Up
        public VerticalDirection Direction { get; set; }

        //Bit 1 - 0: Unused

        public override T GetTile<T>(ITileCreator<T> t)
        {
            return t.GetTile(this);
        }


    }
}
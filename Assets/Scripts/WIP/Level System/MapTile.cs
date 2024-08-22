using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MapTileType {
    None,
    Blank,
    Barrier
}

public class MapTile
{
    public MapTileType type;
    public bool isFilled;
    public bool hasStar;
    public bool hasMark;

    public MapTile(MapTileType _type, bool _isFilled, bool _hasStar, bool _hasMark) {
        type = _type;
        isFilled = _isFilled;
        hasStar = _hasStar;
        hasMark = _hasMark;
    }
}

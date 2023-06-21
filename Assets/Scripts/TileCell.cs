using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCell : MonoBehaviour
{
    public Vector2 coordinates { get; set; }
    public Tile    tile        { get; set; }

    public bool empty       => tile == null;
    public bool occupied    => tile != null;

}

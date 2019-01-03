using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManage : MonoBehaviour {

    public Tilemap DarkMap;
    public Tilemap BlurMap;
    public Tilemap BackgroundMap;

    public Tile DarkTile;
    public Tile BlurTile;

    // Use this for initialization
	void Start ()
    {
        DarkMap.origin = BlurMap.origin = BackgroundMap.origin;
        DarkMap.size = BlurMap.size = BackgroundMap.size;

        foreach (Vector3Int p in DarkMap.cellBounds.allPositionsWithin)
        {
            DarkMap.SetTile(p, DarkTile);
        }

        foreach (Vector3Int p in BlurMap.cellBounds.allPositionsWithin)
        {
            BlurMap.SetTile(p, BlurTile);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

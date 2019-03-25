using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class levelGen : MonoBehaviour {

    public GameObject defaultTile; // tile to be generated
    public int widthGen; // how many tiles to generate
    public int heightGen;
    public float widthMultiplier; // distance between tiles
    public float heightMultiplier;
    public Tilemap tilemap;
    public TileBase grass;
    public TileBase dirt;
    public GameObject player;




    // Use this for initialization
    void Start () {
        int[,] map = GenerateArray(widthGen, heightGen);
        RenderMap(map, tilemap, grass, dirt);
        Instantiate(player, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static int[,] GenerateArray(int width, int height)
    {
        
        int[,] map = new int[width, height];
        for (int x = 0; x < map.GetUpperBound(0); x++)
        {
            for (int y = 0; y < map.GetUpperBound(1); y++)
            {
                int number = Random.Range(0, 2);
                print(number);
                if (number > 0)
                {
                    map[x, y] = 1;
                }
                else
                {
                    map[x, y] = 0;
                }
            }
        }
        return map;
    }

    public static void RenderMap(int[,] map, Tilemap tilemap, TileBase grass, TileBase dirt)
    {
        //Clear the map (ensures we dont overlap)
        tilemap.ClearAllTiles();
        //Loop through the width of the map
        for (int x = 0; x < map.GetUpperBound(0); x++)
        {
            //Loop through the height of the map
            for (int y = 0; y < map.GetUpperBound(1); y++)
            {
                // 1 = tile, 0 = no tile
                if (map[x, y] == 1)
                {
                    tilemap.SetTile(new Vector3Int(x, y, 0), grass);
                }
                else if(map[x, y] == 0)
                {
                    tilemap.SetTile(new Vector3Int(x, y, 0), dirt);
                }
            }
        }
    }
}

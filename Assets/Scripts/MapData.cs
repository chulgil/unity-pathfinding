using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MapData : MonoBehaviour {
    public int width = 10;
    public int height = 5;

    public TextAsset textAsset;

    public List<string> GetTextFromFile(TextAsset tAsset)
    {
        List<string> lines = new List<string>();

        if(tAsset != null)
        {
            string textData = tAsset.text;
            string[] delimiters = { "\r\n", "\n"};
            lines.AddRange(textData.Split(delimiters, System.StringSplitOptions.None));
        }
        else
        {
            Debug.LogWarning("MAPDATA GetTextFromFile Error: invalid TextAsset");
        }

        return lines;
    }

    public List<string> GetTextFromFile()
    {
        return GetTextFromFile(textAsset);
    }
    
    public int[,] MakeMap()
    {
        int[,] map = new int[width, height];
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                map[x, y] = 0;
            }
        }

        map[1, 0] = 1;
        map[1, 1] = 1;
        map[1, 2] = 1;
        map[3, 2] = 1;
        map[3, 3] = 1;
        map[3, 4] = 1;
        map[4, 2] = 1;
        map[5, 1] = 1;
        map[5, 2] = 1;
        map[6, 2] = 1;
        map[6, 3] = 1;
        map[8, 0] = 1;
        map[8, 1] = 1;
        map[8, 2] = 1;
        map[8, 4] = 1;

        return map;
    }
}
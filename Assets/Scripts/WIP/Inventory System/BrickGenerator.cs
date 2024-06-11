using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickStorage {
    /*
     * Vector2Int size{字母编号}{序号} = new({默认摆放方式占行数}, {...占列数});
     * string[] brick{字母编号}{序号} = new string[{...占行数}]{
     *     "{表示有无积木的01字符串}",
     *     ...
     *     "{...}",
     * };
     */

    // e.g.
    Vector2Int sizeA1 = new(1, 1);
    string[] brickA1 = new string[1]{
        "1",
    };

    Vector2Int sizeB1 = new(1, 2);
    string[] brickB1 = new string[1]{
        "11",
    };

    Vector2Int sizeC1 = new(1, 3);
    string[] brickC1 = new string[1]{
        "111",
    };

    Vector2Int sizeC2 = new(2, 2);
    string[] brickC2 = new string[2]{
        "01",
        "11",
    };

    Vector2Int sizeD1 = new(2, 2);
    string[] brickD1 = new string[2]{
        "11",
        "11",
    };

    Vector2Int sizeD2 = new(2, 3);
    string[] brickD2 = new string[2]{
        "001",
        "111",
    };

    // TODO
    public List<Brick> GetBrickListFromSize(int size) {
        List<Brick> list = new();
        switch(size) {
            case 1:
                // list.Add(Brick.Gen(sizeA1, brickA1));
                break;
            case 2:
                // list.Add(Brick.Gen(sizeB1, brickB1));
                break;
            case 3:
                // list.Add(Brick.Gen(sizeC1, brickC1));
                break;
            case 4:
                // list.Add(Brick.Gen(sizeD1, brickD1));
                break;
            case 5:
                // list.Add(Brick.Gen(sizeE1, brickE1));
                // list.Add(Brick.Gen(sizeE2, brickE2));
                // list.Add(Brick.Gen(sizeE3, brickE3));
                break;
            case 6:
                // list.Add(Brick.Gen(sizeF1, brickF1));
                break;
            default:
                Debug.LogError($"Getting brick list with invalid size!");
                break;
        }
        return list;
    }

    public Brick GetRandomBrickFromSize(int size) {
        List<Brick> list = GetBrickListFromSize(size);
        int pos = Random.Range(0, list.Count);
        return list[pos];
    }

    public Brick GetBrickFromIdentity(int size, int id) {
        List<Brick> list = GetBrickListFromSize(size);
        int pos = id - 1;
        return list[pos];
    }
}

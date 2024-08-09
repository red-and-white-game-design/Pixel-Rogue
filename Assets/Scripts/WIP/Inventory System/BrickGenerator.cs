using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BrickStorage {
    /*
     * static Vector2Int size{字母编号}{序号} = new({默认摆放方式占行数}, {...占列数});
     * static string[] brick{字母编号}{序号} = new string[{...占行数}]{
     *     "{表示有无积木的01字符串}",
     *     ...
     *     "{...}",
     * };
     */

    // 1个方块
    static Vector2Int sizeA1 = new(1, 1);
    static string[] brickA1 = new string[1]{
        "1",
    };

    // 2个方块
    static Vector2Int sizeB1 = new(1, 2);
    static string[] brickB1 = new string[1]{
        "11",
    };

    // 3个方块
    static Vector2Int sizeC1 = new(1, 3);
    static string[] brickC1 = new string[1]{
        "111",
    };

    static Vector2Int sizeC2 = new(2, 2);
    static string[] brickC2 = new string[2]{
        "01",
        "11",
    };

    // 4个方块
    static Vector2Int sizeD1 = new(1, 4);
    static string[] brickD1 = new string[1]{
        "1111",
    };

    static Vector2Int sizeD2 = new(2, 3);
    static string[] brickD2 = new string[2]{
        "100",
        "111",
    };

    static Vector2Int sizeD3 = new(2, 3);
    static string[] brickD3 = new string[2]{
        "001",
        "111",
    };

    static Vector2Int sizeD4 = new(2, 3);
    static string[] brickD4 = new string[2]{
        "110",
        "011",
    };

    static Vector2Int sizeD5 = new(2, 3);
    static string[] brickD5 = new string[2]{
        "011",
        "110",
    };

    static Vector2Int sizeD6 = new(2, 3);
    static string[] brickD6 = new string[2]{
        "010",
        "111",
    };

    static Vector2Int sizeD7 = new(2, 2);
    static string[] brickD7 = new string[2]{
        "11",
        "11",
    };

    // 5个方块
    static Vector2Int sizeE1 = new(1, 5);
    static string[] brickE1 = new string[1]{
        "11111",
    };

    static Vector2Int sizeE2 = new(3, 3);
    static string[] brickE2 = new string[3]{
        "010",
        "111",
        "010",
    };

    static Vector2Int sizeE3 = new(2, 4);
    static string[] brickE3 = new string[2]{
        "1000",
        "1111",
    };

    static Vector2Int sizeE4 = new(2, 4);
    static string[] brickE4 = new string[2]{
        "0001",
        "1111",
    };

    static Vector2Int sizeE5 = new(2, 4);
    static string[] brickE5 = new string[2]{
        "0010",
        "1111",
    };

    static Vector2Int sizeE6 = new(2, 4);
    static string[] brickE6 = new string[2]{
        "0100",
        "1111",
    };

    static Vector2Int sizeE7 = new(3, 3);
    static string[] brickE7 = new string[3]{
        "011",
        "010",
        "110",
    };

    static Vector2Int sizeE8 = new(3, 3);
    static string[] brickE8 = new string[3]{
        "110",
        "010",
        "011",
    };

    static Vector2Int sizeE9 = new(2, 3);
    static string[] brickE9 = new string[2]{
        "101",
        "111",
    };

    static Vector2Int sizeE10 = new(3, 3);
    static string[] brickE10 = new string[3]{
        "010",
        "010",
        "111",
    };

    static Vector2Int sizeE11 = new(2, 3);
    static string[] brickE11 = new string[2]{
        "011",
        "111",
    };

    static Vector2Int sizeE12 = new(2, 3);
    static string[] brickE12 = new string[2]{
        "110",
        "111",
    };

    static Vector2Int sizeE13 = new(2, 4);
    static string[] brickE13 = new string[2]{
        "1110",
        "0011",
    };

    static Vector2Int sizeE14 = new(2, 4);
    static string[] brickE14 = new string[2]{
        "0111",
        "1100",
    };

    static Vector2Int sizeE15 = new(3, 3);
    static string[] brickE15 = new string[3]{
        "001",
        "011",
        "110",
    };

    static Vector2Int sizeE16 = new(3, 3);
    static string[] brickE16 = new string[3]{
        "001",
        "001",
        "111",
    };

    static Vector2Int sizeE17 = new(3, 3);
    static string[] brickE17 = new string[3]{
        "110",
        "011",
        "010",
    };

    static Vector2Int sizeE18 = new(3, 3);
    static string[] brickE18 = new string[3]{
        "011",
        "110",
        "010",
    };

    static Vector2Int sizeF1 = new(3, 3);
    static string[] brickF1 = new string[3]{
        "001",
        "011",
        "111",
    };

    static Vector2Int sizeF2 = new(3, 4);
    static string[] brickF2 = new string[3]{
        "0100",
        "1111",
        "0100",
    };


    public static List<Brick> GetBrickListFromSize(int size) {
        List<Brick> list = new();
        switch (size) {
            case 1:
                list.Add(Brick.Gen(sizeA1, brickA1));
                break;
            case 2:
                list.Add(Brick.Gen(sizeB1, brickB1));
                break;
            case 3:
                list.Add(Brick.Gen(sizeC1, brickC1));
                list.Add(Brick.Gen(sizeC2, brickC2));
                break;
            case 4:
                list.Add(Brick.Gen(sizeD1, brickD1));
                list.Add(Brick.Gen(sizeD2, brickD2));
                list.Add(Brick.Gen(sizeD3, brickD3));
                list.Add(Brick.Gen(sizeD4, brickD4));
                list.Add(Brick.Gen(sizeD5, brickD5));
                list.Add(Brick.Gen(sizeD6, brickD6));
                list.Add(Brick.Gen(sizeD7, brickD7));
                break;
            case 5:
                list.Add(Brick.Gen(sizeE1, brickE1));
                list.Add(Brick.Gen(sizeE2, brickE2));
                list.Add(Brick.Gen(sizeE3, brickE3));
                list.Add(Brick.Gen(sizeE4, brickE4));
                list.Add(Brick.Gen(sizeE5, brickE5));
                list.Add(Brick.Gen(sizeE6, brickE6));
                list.Add(Brick.Gen(sizeE7, brickE7));
                list.Add(Brick.Gen(sizeE8, brickE8));
                list.Add(Brick.Gen(sizeE9, brickE9));
                list.Add(Brick.Gen(sizeE10, brickE10));
                list.Add(Brick.Gen(sizeE11, brickE11));
                list.Add(Brick.Gen(sizeE12, brickE12));
                list.Add(Brick.Gen(sizeE13, brickE13));
                list.Add(Brick.Gen(sizeE14, brickE14));
                list.Add(Brick.Gen(sizeE15, brickE15));
                list.Add(Brick.Gen(sizeE16, brickE16));
                list.Add(Brick.Gen(sizeE17, brickE17));
                list.Add(Brick.Gen(sizeE18, brickE18));
                break;
            case 6:
                list.Add(Brick.Gen(sizeF1, brickF1));
                list.Add(Brick.Gen(sizeF2, brickF2));
                break;
            default:
                Debug.LogError($"Getting brick list with invalid size!");
                break;
        }
        return list;
    }

    public static Brick GetRandomBrickFromSize(int size) {
        List<Brick> list = GetBrickListFromSize(size);
        int pos = Random.Range(0, list.Count);
        return list[pos];
    }

    public static Brick GetBrickFromIdentity(int size, int id) {
        List<Brick> list = GetBrickListFromSize(size);
        int pos = id - 1;
        return list[pos];
    }
}

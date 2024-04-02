using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPool
{
    public static Vector2Int[] size = new Vector2Int[3] {
        new Vector2Int(9, 9),
        new Vector2Int(9, 9),
        new Vector2Int(9, 9),
    };

    public static string[][] map = new string[3][] {
        new string[9] {
            "111111111",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "111111111",
        },
        new string[9] {
            "111111111",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "111111111",
        },
        new string[9] {
            "111111111",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "122222221",
            "111111111",
        },
    };

    public static string[][] star = new string[3][] {
        new string[9] {
            "000000000",
            "011100010",
            "011000000",
            "010000000",
            "000000000",
            "000000010",
            "000000110",
            "010001110",
            "000000000",
        },
        new string[9] {
            "000000000",
            "000000100",
            "000001110",
            "000000100",
            "000000000",
            "001000100",
            "011101110",
            "001000100",
            "000000000",
        },
        new string[9] {
            "000000000",
            "000111000",
            "000000000",
            "010000010",
            "010000010",
            "001000100",
            "011000110",
            "001000100",
            "000000000",
        },
    };

    public static string[][] target = new string[3][] {
        new string[9] {
            "000000000",
            "000000100",
            "000001000",
            "000010000",
            "001111100",
            "000010000",
            "000100000",
            "001000000",
            "000000000",
        },
        new string[9] {
            "000000000",
            "011100000",
            "011010000",
            "000100000",
            "001011100",
            "000011000",
            "000010000",
            "000000000",
            "000000000",
        },
        new string[9] {
            "000000000",
            "010000010",
            "001010100",
            "000101000",
            "000101000",
            "000101000",
            "000010000",
            "000010000",
            "000000000",
        },
    };
}

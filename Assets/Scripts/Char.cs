using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char {
    public static int ToInt(char c) {
        if ('0' <= c && c <= '9') {
            return c - '0';
        }
        if ('A' <= c && c <= 'F') {
            return c - 'A' + 10;
        }
        if ('a' <= c && c <= 'f') {
            return c - 'a' + 36;
        }
        Debug.LogError($"Invalid char value '{c}'.");
        return 0;
    }
    public static bool ToBool(char c) {
        if ('0' <= c && c <= '1') {
            return c == '1';
        }
        Debug.LogError($"Invalid char value '{c}'.");
        return false;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteRepo : MonoBehaviour
{
    public Sprite Air;
    public Sprite Barrier;
    public Sprite Plane;
    public Sprite Block;

    public static SpriteRepo instance;

    void Awake() {
        if (instance == null) {
            instance = this;
        }
    }
}

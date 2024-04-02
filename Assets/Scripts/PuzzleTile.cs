using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BlockType {
    Air = 0,
    Barrier = 1,
    Plane = 2
}

public class PuzzleTile : MonoBehaviour
{
    public BlockType type;
    public GameObject BlockGO;
    public GameObject TargetGO;
    public GameObject StarGO;
    public SpriteController BlockSprite;
    public SpriteController TargetSprite;
    public SpriteController StarSprite;

    SpriteRenderer sprite;
    public bool hasStar;
    public bool hasTarget;
    [SerializeField] bool isFilled;
    [SerializeField] bool previewing;
    [SerializeField] bool flipPreviewing;
    bool rayHitted;
    bool flipRayHitted;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        rayHitted = false;
        InitSprite();
    }

    void InitSprite() {
        switch (type) {
            case BlockType.Air:
                sprite.sprite = SpriteRepo.instance.Air;
                break;
            case BlockType.Barrier:
                sprite.sprite = SpriteRepo.instance.Barrier;
                break;
            case BlockType.Plane:
                sprite.sprite = SpriteRepo.instance.Plane;
                break;
        }
    }

    void Update()
    {
        ActivateSprite();
        RenderColor();
    }

    void ActivateSprite() {
        BlockGO.SetActive(isFilled);
        if (type == BlockType.Plane) {
            TargetGO.SetActive(hasTarget ^ flipPreviewing);
        }
        StarGO.SetActive(hasStar);
    }

    private void LateUpdate() {
        if (rayHitted) {
            previewing = true;
        } else {
            previewing = false;
        }
        rayHitted = false;
        if (flipRayHitted) {
            flipPreviewing = true;
        } else {
            flipPreviewing = false;
        }
        flipRayHitted = false;
    }

    public void Hitted(bool isFlip) {
        if (!isFlip) {
            rayHitted = true;
        } else {
            flipRayHitted = true;
        }
    }

    void RenderColor() {
        if (previewing) {
            switch (type) {
                case BlockType.Barrier:
                    sprite.color = Color.red;
                    break;
                case BlockType.Plane:
                    if (isFilled) {
                        sprite.color = Color.red;
                        BlockSprite.SetColor(Color.red);
                    } else {
                        sprite.color = Color.green;
                    }
                    break;
            }
        } else {
            sprite.color = Color.white;
            if (isFilled) {
                BlockSprite.SetColor(Color.white);
            }
            if (hasTarget ^ flipPreviewing) {
                TargetSprite.SetColor(isFilled ? Color.green : Color.red);
            }
            if (hasStar) {
                StarSprite.SetColor(Color.white);
            }
        }
    }

    public bool CanPlace() {
        switch (type) {
            case BlockType.Barrier:
                return false;
            case BlockType.Plane:
                if (isFilled) {
                    return false;
                } else {
                    return true;
                }
        }
        return false;
    }

    public bool CanFlip() {
        switch (type) {
            case BlockType.Barrier:
                return false;
            case BlockType.Plane:
                return true;
        }
        return false;
    }

    public void Place() {
        switch (type) {
            case BlockType.Barrier:
                break;
            case BlockType.Plane:
                if (isFilled) {
                    break;
                } else {
                    isFilled = true;
                    break;
                }
        }
    }

    public void Flip() {
        switch (type) {
            case BlockType.Barrier:
                break;
            case BlockType.Plane:
                hasTarget = !hasTarget;
                break;
        }
    }

    public bool Check() {
        switch (type) {
            case BlockType.Barrier:
                return true;
            case BlockType.Plane:
                if (hasTarget) {
                    return isFilled;
                } else {
                    return true;
                }
        }

        return true;
    }

    public int GetScore() {
        int res = 0;
        if (hasStar && isFilled) {
            res++;
        }
        Debug.Log($"Point {res}");
        return res;
    }
}

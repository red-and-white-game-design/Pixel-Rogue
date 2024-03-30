using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisTile : MonoBehaviour
{
    public LayerMask mask;
    public bool isFlip;

    void Start()
    {
        
    }

    RaycastHit2D RayCast() {
        return Physics2D.Raycast(transform.position, Vector2.zero, 10, mask);
    }

    void Update()
    {
        var hit = RayCast();
        if (hit) {
            var tile = hit.collider.GetComponent<PuzzleTile>();
            tile.Hitted(isFlip);
        }
    }

    public bool CanPlace() {
        var hit = RayCast();
        if (hit) {
            var tile = hit.collider.GetComponent<PuzzleTile>();
            return tile.CanPlace();
        } else {
            return false;
        }
    }

    public bool CanFlip() {
        var hit = RayCast();
        if (hit) {
            var tile = hit.collider.GetComponent<PuzzleTile>();
            return tile.CanFlip();
        } else {
            return false;
        }
    }

    public void Place() {
        var hit = RayCast();
        if (hit) {
            var tile = hit.collider.GetComponent<PuzzleTile>();
            tile.Place();
        }
    }

    public void Flip() {
        var hit = RayCast();
        if (hit) {
            var tile = hit.collider.GetComponent<PuzzleTile>();
            tile.Flip();
        }
    }

    private void OnDrawGizmos() {
        Gizmos.DrawRay(transform.position, Vector3.back);
    }
}

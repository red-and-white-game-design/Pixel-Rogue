using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseEventManager : MonoBehaviour
{
    public static MouseEventManager instance;

    public GameObject TetrisFollowGO;
    public GameObject TetrisRayCastGO;
    public GameObject TetrisFlipFollowGO;
    public GameObject TetrisFlipRayCastGO;

    public Transform currentButton;
    public Transform currentFlipButton;

    bool selecting;
    bool dragging;
    bool flipSelecting;
    bool flipDragging;

    GameObject TetrisCursor;
    GameObject TetrisPreview;

    int currentOrder = -1;

    void Start()
    {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    void Update() {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;
        Vector3 screenPos = Camera.main.ScreenToWorldPoint(mousePos);
        Transform hit = Physics2D.Raycast(screenPos, Vector2.zero).transform;

        if (Input.GetMouseButtonDown(0)) {
            if (hit != null && hit.tag == "Button" && currentButton == null) {
                currentButton = hit.transform;
                currentOrder = currentButton.GetComponent<TetrisButton>().order;
                if (!Inventory.instance.CanUse(currentOrder)) {
                    currentButton = null;
                    currentOrder = -1;
                }
            }
            if (selecting) {
                if (PlaceTetris()) {
                    Inventory.instance.Use(currentOrder);
                }
                selecting = false;
            }
        }
        if (Input.GetMouseButton(0)) {
            if (currentButton != null) {
                if (hit == null || hit.transform != currentButton) {
                    SelectTetris(currentButton.GetComponent<TetrisButton>().tetris);
                    dragging = true;
                    currentButton = null;
                }
            }
        }
        if (Input.GetMouseButtonUp(0)) {
            if (currentButton != null) {
                if (hit && hit.transform == currentButton) {
                    SelectTetris(currentButton.GetComponent<TetrisButton>().tetris);
                    selecting = true;
                    currentButton = null;
                }
            }
            if (dragging) {
                if (PlaceTetris()) {
                    Inventory.instance.Use(currentOrder);
                }
                dragging = false;
            }
        }

        if (dragging || selecting) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                TetrisCursor.transform.Rotate(0, 0, -90f);
                TetrisPreview.transform.Rotate(0, 0, -90f);
            }
        }

        if (Input.GetMouseButtonDown(0)) {
            if (hit != null && hit.tag == "FlipButton" && currentFlipButton == null) {
                currentFlipButton = hit.transform;
                if (!Inventory.instance.CanUseFlip()) {
                    currentFlipButton = null;
                }
            }
            if (flipSelecting) {
                if (PlaceFlip()) {
                    Inventory.instance.UseFlip();
                }
                flipSelecting = false;
            }
        }
        if (Input.GetMouseButton(0)) {
            if (currentFlipButton != null) {
                if (hit == null || hit.transform != currentFlipButton) {
                    SelectFlipTetris(currentFlipButton.GetComponent<FlipButton>().tetris);
                    flipDragging = true;
                    currentFlipButton = null;
                }
            }
        }
        if (Input.GetMouseButtonUp(0)) {
            if (currentFlipButton != null) {
                if (hit && hit.transform == currentFlipButton) {
                    SelectFlipTetris(currentFlipButton.GetComponent<FlipButton>().tetris);
                    flipSelecting = true;
                    currentFlipButton = null;
                }
            }
            if (flipDragging) {
                if (PlaceFlip()) {
                    Inventory.instance.UseFlip();
                }
                flipDragging = false;
            }
        }
    }

    private void OnDrawGizmos() {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;
        Vector3 screenPos = Camera.main.ScreenToWorldPoint(mousePos);
        Gizmos.DrawRay(screenPos, Vector3.back);

    }

    public void SelectTetris(Tetris tetris) {
        TetrisCursor = InstantiateNewFollowBlock(tetris);
        TetrisPreview = InstantiateNewTetrisRayCastGO(tetris);
    }

    public void SelectFlipTetris(Tetris tetris) {
        TetrisCursor = InstantiateNewFollowFlip();
        TetrisPreview = InstantiateNewTetrisFlipRayCastGO(tetris);
    }

    public bool PlaceTetris() {
        Destroy(TetrisCursor);
        Destroy(TetrisPreview);
        return TetrisPreview.GetComponent<TetrisPrefab>().PlaceTetris();
    }

    public bool PlaceFlip() {
        Destroy(TetrisCursor);
        Destroy(TetrisPreview);
        return TetrisPreview.GetComponent<TetrisPrefab>().PlaceFlip();
    }

    public GameObject InstantiateNewFollowBlock(Tetris tetris) {
        var obj = Instantiate(TetrisFollowGO, new Vector3(), new Quaternion());
        obj.GetComponent<TetrisPrefab>().Init(tetris, true);
        return obj;
    }

    public GameObject InstantiateNewFollowFlip() {
        var obj = Instantiate(TetrisFlipFollowGO, new Vector3(), new Quaternion());
        return obj;
    }

    public GameObject InstantiateNewTetrisRayCastGO(Tetris tetris) {
        var obj = Instantiate(TetrisRayCastGO, new Vector3(), new Quaternion());
        obj.GetComponent<TetrisPrefab>().Init(tetris, false);
        return obj;
    }

    public GameObject InstantiateNewTetrisFlipRayCastGO(Tetris tetris) {
        var obj = Instantiate(TetrisFlipRayCastGO, new Vector3(), new Quaternion());
        obj.GetComponent<TetrisPrefab>().Init(tetris, false);
        return obj;
    }
}

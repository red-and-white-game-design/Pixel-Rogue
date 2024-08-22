using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBlockButton : MonoBehaviour {
    public int id;

    private BrickUIGenerate brickUIGenerate;
    private Button button;

    void Start() {
        brickUIGenerate = GetComponent<BrickUIGenerate>();
        button = GetComponent<Button>();
    }

    public void Init() {
        if (id < FormulationManager.instance.formulation.Count) {
            brickUIGenerate.Clear();
            brickUIGenerate.brickSize = FormulationManager.instance.formulation[id].size;
            brickUIGenerate.brickID = FormulationManager.instance.formulation[id].id;
            brickUIGenerate.Trigger();
            button.interactable = true;
        } else {
            brickUIGenerate.Clear();
            button.interactable = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormulationManager : MonoBehaviour {
    public static FormulationManager instance;

    public List<BrickID> formulation = new();

    private void Awake() {
        instance = this;
    }
}

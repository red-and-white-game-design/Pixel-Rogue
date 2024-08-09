using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickGenerate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BrickUIGenerate>().Trigger();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

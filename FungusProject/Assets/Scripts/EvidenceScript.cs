using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class EvidenceScript : MonoBehaviour
{
    public Flowchart MyFlowchart;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        Debug.Log("Evidence Clicked!");
        MyFlowchart.ExecuteBlock("Evidence1Clicked");
        List<Variable> VariableList = MyFlowchart.Variables;
        foreach (Variable var in VariableList) {
            if (var.name == "AP") {
                Debug.Log("AP Found!");
                
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

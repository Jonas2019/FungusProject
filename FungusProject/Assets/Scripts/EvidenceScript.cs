using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class EvidenceScript : MonoBehaviour
{
    public int PointCost;
    public Flowchart MyFlowchart;
    public string EvidenceDescription;
    private int APPts = -999;
    private bool Clicked = false; //this bool checks if this clickable has been clicked before.
    void Start()
    {
        
    }
    private void OnMouseDown()
    {        
        APPts = MyFlowchart.GetIntegerVariable("AP");
        Debug.Log("Right now AP is: " + APPts);
        MyFlowchart.SetStringVariable("EviSay",EvidenceDescription);
        if (Clicked)
        {
            MyFlowchart.ExecuteBlock("Evidence1Clicked");
        }
        else
        {
            if (APPts >= PointCost)
            {
                APPts -= PointCost;
                MyFlowchart.SetIntegerVariable("AP",APPts);
                Clicked = true;
                MyFlowchart.ExecuteBlock("Evidence1Clicked");
                //if has not been clicked, we need to subtract its PointCosts from the AP points we have.

            }
            else //cost exceeding AP points
            {
                    MyFlowchart.SetStringVariable("EviSay", "You don't have enough AP points to see this evidence");
                    MyFlowchart.ExecuteBlock("Evidence1Clicked");
            }
        }

    }
    


    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Decide : MonoBehaviour
{
    public Flowchart flowchart;

    void Start()
    {
        bool BPois = Random.Range(0, 2) == 1;
        bool CMed = Random.Range(0, 2) == 1;
        Debug.Log(BPois);
        Debug.Log(CMed);
        flowchart.SetBooleanVariable("BPoison",BPois);
        flowchart.SetBooleanVariable("CMed",CMed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DecideEnding()
    {
        bool BPois =  flowchart.GetBooleanVariable("BPoison");
        bool CMed = flowchart.GetBooleanVariable("CMed");
        bool AAtack = flowchart.GetBooleanVariable("AAttack");
        bool DuelFail = flowchart.GetBooleanVariable("DuelFail");
        if (BPois)
        {
            if (CMed)
            {
                if ((DuelFail)&&(AAtack)) { Debug.Log("A击杀"); }
                else {
                    Debug.Log("D击杀");
                }

            }
            else
            {
                if (AAtack) 
                {
                    if (DuelFail)
                    {
                        Debug.Log("A击杀");
                    }
                    else { Debug.Log("B击杀"); }
                }
                else { //A未击伤
                    Debug.Log("D击杀");
                }
            }
        }
        else {// BPois is false
            if (CMed)
            {
                if (AAtack)
                {
                    Debug.Log("C击杀");
                }
                else
                {
                    Debug.Log("B击杀");
                }
            }
            else {//Cmed is false
                if ((DuelFail) && (AAtack)) { Debug.Log("A击杀"); }
                else
                {
                    Debug.Log("D击杀");
                }
            }

        }

    }

}

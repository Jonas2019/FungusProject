using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class FungusControl : MonoBehaviour
{
    public Flowchart MyFlowchart;
    // Start is called before the first frame update
    public ControlAudio MyAudio;
    void Start()
    {
        var blocks = MyFlowchart.GetComponents<Block>();

        foreach (Block block in blocks) {
            //Debug.Log(block.CommandList.Count);
                //block.CommandList[0].BroadcastMessage("Hi");
            }


    }




    // Update is called once per frame

}

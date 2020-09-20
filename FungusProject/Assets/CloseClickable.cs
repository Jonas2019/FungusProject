using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CloseClickable : MonoBehaviour
{
    public Fungus.Flowchart flowchart;
    public string BlockName;

    private void OnMouseDown()
    {
        flowchart.ExecuteBlock(BlockName);
    }

}

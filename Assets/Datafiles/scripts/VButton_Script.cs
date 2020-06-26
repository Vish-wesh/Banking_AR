using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VButton_Script : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject cube, cubeGo;
    VirtualButtonBehaviour vrb;
    void IVirtualButtonEventHandler.OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.SetActive(false);
        cubeGo.SetActive(true);
    }

    void IVirtualButtonEventHandler.OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.SetActive(true);
        cubeGo.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterEventHandler(this);
        cube.SetActive(true);
        cubeGo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

}



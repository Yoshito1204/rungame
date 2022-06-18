using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material colorA;
    public Material colorB;
    public Material colorC;
    public Material colorD;
    public Material colorE;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeBlack()
    {
        GetComponent<Renderer>().material.color = colorA.color;
    }

    public void ChangeBlue()
    {
        GetComponent<Renderer>().material.color = colorB.color;
    }

    public void ChangeGreen()
    {
        GetComponent<Renderer>().material.color = colorC.color;
    }

    public void ChangeRed()
    {
        GetComponent<Renderer>().material.color = colorD.color;
    }

    public void ChangeYellow()
    {
        GetComponent<Renderer>().material.color = colorE.color;
    }
}

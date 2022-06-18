using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelGenerator : MonoBehaviour
{

    public GameObject[] panel;
    
   
    // Start is called before the first frame update
    void Start()
    {
        
        /* int r = Random.Range(0, panel.Length);
         Instantiate(panel[r], new Vector3(0, 0, 0), transform.rotation);*/
        GeneratePanel();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject GeneratePanel()
    {
        GameObject Findgamaover = GameObject.FindGameObjectWithTag("GameOver");
        Vector3 tmp = Findgamaover.transform.position;
        int r = Random.Range(0, panel.Length);
        
            GameObject Panel = Instantiate(panel[r], tmp, transform.rotation);
            Debug.Log(r);
            return Panel;
       
    }

   /* public void FindPanel()
    {
       GameObject Findgamaover = GameObject.FindGameObjectWithTag("GameOver");
        Vector3 tmp = Findgamaover.transform.position;
    }*/
}

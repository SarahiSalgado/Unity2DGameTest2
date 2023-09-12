using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableScript : MonoBehaviour
{
    public int myNumber = 30;
    public int Total;


    // Start is called before the first frame update
    void Start()
    {
        Total = myNumber - 5;

        Debug.Log(Total);

        Debug.Log(6 + 5);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

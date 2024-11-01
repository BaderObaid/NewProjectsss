using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTable : MonoBehaviour
{
    // Start is called before the first frame update
int Multiply(int a, int b)
    {
        return a * b;
    }
    void Start()
    {
int S = 5; 
for (int Y = 1; Y <= 10; Y++)
{
    int result = Multiply(S,Y);
    Debug.Log($"{S} x {Y} = {result}");
}


    }

    
        
    
}

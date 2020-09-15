using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbahWarnaCylinder : MonoBehaviour
{
   public void Cyan(){
        GetComponent<Renderer>().material.color = Color.cyan;
    }
    public void Gray(){
        GetComponent<Renderer>().material.color = Color.gray;
    }
    public void Magenta(){
        GetComponent<Renderer>().material.color = Color.magenta;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbahWarnaSphere : MonoBehaviour
{
   public void Putih(){
        GetComponent<Renderer>().material.color = Color.white;
    }
    public void kuning(){
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    public void Hijau(){
        GetComponent<Renderer>().material.color = Color.green;
    }
}

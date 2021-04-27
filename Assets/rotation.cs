using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class rotation : MonoBehaviour
{
   
   public float speed;




    private void Update()
    {
        transform.Rotate(0f, 90*Time.deltaTime*speed, 0f);
    }
}

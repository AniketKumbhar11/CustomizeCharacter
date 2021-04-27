using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.UI;

public class dicst : MonoBehaviour
{
    public int[] UniqueArray;
    private Animator aim;
    int m;
    public List<int> lisst;
    public AudioSource Audio;
    public AudioClip Clip;

    public float Vertical,Horizontal;




    void Start()
    {
            
  
    }




    private void Update()
    {
        Movement();
        InputBtn();
    }

    private void InputBtn()
    {

    }

    void Movement()
    {


        if(Input.GetKeyDown(KeyCode.W))
            Vertical =1;
        if (Input.GetKeyUp(KeyCode.W))
            Vertical = 0;



        if (Input.GetKeyDown(KeyCode.S))
            Vertical = -1;
        if (Input.GetKeyUp(KeyCode.S))
            Vertical = 0;


        if (Input.GetKeyDown(KeyCode.A))
            Horizontal = -1;
        if (Input.GetKeyUp(KeyCode.A))
            Horizontal = 0;


        if (Input.GetKeyDown(KeyCode.D))
            Horizontal = 1;
        if (Input.GetKeyUp(KeyCode.D))
            Horizontal = 0;
    }
}

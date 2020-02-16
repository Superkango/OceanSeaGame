using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject menu;
    public Animator animator; 
    
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        Time.timeScale = 1;
            //Lo mismo que menu.active = false
        animator.SetTrigger("BotonPlay");
  
    }
   
}

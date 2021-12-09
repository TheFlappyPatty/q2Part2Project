using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour
{
    public bool pausemenuopen;
    public GameObject menu;
    public GameObject Settingsmenu;
    public void Start()
    {
        Time.timeScale = 1;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(pausemenuopen == true)
            {
                pausemenuopen = false;
                closepausemenu();
            }else if(pausemenuopen == false)
            {
                Openpausemenu();
                pausemenuopen = true;
            }
        }
    }
    public void Openpausemenu()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
    }
    public void closepausemenu()
    {
        menu.SetActive(false);
        pausemenuopen = false;
        Time.timeScale = 1;
    }



}

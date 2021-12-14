using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanSpawn : MonoBehaviour
{

    private Vector2 position1;
    private Vector2 position2;
    public GameObject Beancan1;
    public GameObject Beancan2;
    public GameObject Beancan3;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            if(i == 1)
            {
                Destroy(Beancan1); 
            }
            if (i == 2)
            {
                Destroy(Beancan2);
            }
            if (i == 3)
            {
                Destroy(Beancan3);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

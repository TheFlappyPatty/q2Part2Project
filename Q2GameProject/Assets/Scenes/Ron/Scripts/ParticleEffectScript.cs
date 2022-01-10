using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class ParticleEffectScript : MonoBehaviour
{
    public GameObject partical;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        partical.SetActive(false);

    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        partical.SetActive(true);
    }
}

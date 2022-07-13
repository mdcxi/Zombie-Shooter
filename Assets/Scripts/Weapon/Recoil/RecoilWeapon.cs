using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoilWeapon : MonoBehaviour
{

    public GameObject gun;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(StartRecoil());
        }
    }

    IEnumerator StartRecoil()
    {
        gun.GetComponent<Animator>().Play("Piston");
        yield return new WaitForSeconds(0.2f);
        gun.GetComponent<Animator>().Play("New State");

    }
}

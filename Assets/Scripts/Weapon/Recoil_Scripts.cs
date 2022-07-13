using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoi : MonoBehaviour
{

    public GameObject gun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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

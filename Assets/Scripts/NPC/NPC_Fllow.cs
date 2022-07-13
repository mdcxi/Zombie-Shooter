using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_Fllow : MonoBehaviour
{
    public GameObject ThePlayer;
    public float TargetDistance;
    public float AllowDistance = 5;
    public float FollowSpeed;
    public RaycastHit Shot;
    public GameObject TheNPC;

    private void Update()
    {
        transform.LookAt(ThePlayer.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            if (TargetDistance >= AllowDistance)
            {
                FollowSpeed = 0.1f;
                TheNPC.GetComponent<Animator>().Play("running");
                transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, FollowSpeed);
            } else
            {
                FollowSpeed = 0;
                TheNPC.GetComponent<Animator>().Play("idle");
            } 
        } 
    }
}

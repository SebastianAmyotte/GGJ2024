using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperBehavior : MonoBehaviour {
    private HingeJoint[] hinges;
    void Start()
    {
        Collider[] bumpers = GetComponentsInChildren<BoxCollider>();
        hinges = GetComponentsInChildren<HingeJoint>();
        MeshCollider mesh = GetComponent<MeshCollider>();
        Physics.IgnoreCollision(bumpers[0], bumpers[1]);
        Physics.IgnoreCollision(mesh, bumpers[0]);
        Physics.IgnoreCollision(mesh, bumpers[1]);
    }
    private void OnCollisionEnter(Collision collision)
    {
        hinges[0].useMotor = true;
        hinges[1].useMotor = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        hinges[0].useMotor = false;
        hinges[1].useMotor = false;
    }
}


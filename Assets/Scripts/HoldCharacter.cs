using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldCharacter : MonoBehaviour {

    private void OnTriggerEnter(Collider c)
    {
        c.transform.parent = gameObject.transform;
    }

    private void OnTriggerExit(Collider c)
    {
        c.transform.parent = null;
    }
}

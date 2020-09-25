using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        RagdollBehavior ragdoll = other.gameObject.GetComponentInParent<RagdollBehavior>();
        if (ragdoll != null)
            ragdoll.ragdollEnabled = true;
    }
}

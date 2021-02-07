using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log(other + " entered the Damage trigger");
        RubyController controller = other.GetComponent<RubyController>();
        if (controller)
        {
            controller.ChangeHealth(-1);
        }
    }
}

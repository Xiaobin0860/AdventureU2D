using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectiable : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other + " entered the trigger");
        RubyController controller = other.GetComponent<RubyController>();
        if (controller)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
        }
    }
}

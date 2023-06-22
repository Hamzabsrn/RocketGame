using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Floor
{
    public class StartFloorController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player != null)
            {
                Destroy(this.gameObject,3f);
            }
        }

    }
}

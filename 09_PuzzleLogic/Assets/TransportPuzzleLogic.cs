using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransportPuzzleLogic : MonoBehaviour
{
    int specialDoorCounter = 0;
    public Transform exitDoor;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "door") {
            specialDoorCounter++;

            if (specialDoorCounter == 3) {
                transform.position = exitDoor.transform.position;
            }
        }

    }

}

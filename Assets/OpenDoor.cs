using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class OpenDoor : MonoBehaviour
{
    public Transform door;

    private void Start()
    {
        door = gameObject.GetComponent<Transform>();
    }

    public void openDoor()
    {
        door.position = new Vector3(5.54f, -2.55f, -0.54f);
    }
    public void closeDoor()
    {
        door.position = new Vector3(5.54f, 1.75f, -0.54f);
    }
}

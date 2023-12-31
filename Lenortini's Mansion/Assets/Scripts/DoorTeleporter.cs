using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTeleporter : MonoBehaviour
{
    public Transform playerTransform;
    public Transform inSpawn;
    public Transform outSpawn;

    bool isIn = false;

    void TeleportPlayer()
    {
        Debug.Log(inSpawn);
        if(!isIn) playerTransform.position = inSpawn.position;
        else playerTransform.position = outSpawn.position;
        Debug.Log(isIn? "Going Out" : "Going In");

        isIn = !isIn;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCOl : MonoBehaviour
{
    public PlayerMovement pm;
    void OnCollisionEnter(Collision colllisionInfo)
    {
        if (colllisionInfo.collider.tag == "Enemy")
        {
            pm.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

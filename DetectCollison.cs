using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollison : MonoBehaviour
{
    public Material[] MaterialList;
    public Text displayText;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
       rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    private void OnCollisionEnter(Collision col)
    {
        // Checks if the player ball has collided with the wall.
        if (col.gameObject.name == "Player")
        {
            displayText.text = "Ouch!";
            rend.sharedMaterial = MaterialList[0];
        }
    }
    // It is called when the ball moves away from the wall
    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            rend.sharedMaterial = MaterialList[1];
            displayText.text = "Keep Rolling...";
        }
    }
}

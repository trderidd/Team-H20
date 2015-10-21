using UnityEngine;
using System;

public class CountBox : MonoBehaviour
{
    int particlesFinished = 0;

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("entered box");

        particlesFinished++;

        if (particlesFinished >= 100)
        {
            Debug.Log("completion");//level complete message
            Application.LoadLevel("level2"); //can use index later when we have more levels
        }

        //Destroy(col.gameObject);

    }

    void OnTriggerExit2D(Collider2D thing)
    {
        Debug.Log("exited box");


    }
	private GUIStyle guiStyle = new GUIStyle();
	void OnGUI()
	{
		guiStyle.fontSize =50;
		GUILayout.Label(particlesFinished.ToString() + "/100% Complete", guiStyle);
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraSc : MonoBehaviour {

    public int wybor = 0;
    public GameObject[] obiekty;

	void Update () {
        for (int i = 0; i < obiekty.Length; i++)
        {
            if (i == wybor)
            {
                obiekty[i].gameObject.SetActive(true);
            }
            else {
                obiekty[i].gameObject.SetActive(false);
            }
        }
	}

    public void DokonanieWyboru(int i)
    {
        wybor = i;
    }
}

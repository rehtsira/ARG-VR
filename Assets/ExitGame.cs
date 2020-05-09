using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Start is called before the first frame update
   public void doquit()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}

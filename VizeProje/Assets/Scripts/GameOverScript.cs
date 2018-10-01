using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {
    public void YenidenOyna()
    {
        Application.LoadLevel(1);
    }
    public void OyundanCik()
    {
        Application.Quit();
    }
}

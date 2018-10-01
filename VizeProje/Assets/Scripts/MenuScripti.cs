using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScripti : MonoBehaviour {
    public void OyunaBasla()
    {
        Application.LoadLevel(1);
    }
    public void OyunuKapat()
    {
        Application.Quit();
    }
}

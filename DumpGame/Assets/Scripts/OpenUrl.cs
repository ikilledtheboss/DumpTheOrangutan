using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
	public void OpenSite()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=bFnI25Pu19k&feature=youtu.be");
    }
}

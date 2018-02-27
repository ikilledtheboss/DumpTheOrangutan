using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayClick : MonoBehaviour {

    public GameObject Covfefe1, Covfefe2, Covfefe3, Phone, Curtain1, Curtain2;
    public SpriteRenderer PhoneSR;
    public Sprite Phone0, Phone2, Phone3, Phone4;
    public int Progress;
    public bool C1, C2, C3, Win;
    public float T;
    public string StageScene;

	void Start ()
    {
        StageScene = "StageScene";
        Progress = 1;
        Win = false;
        PhoneSR = Phone.GetComponent<SpriteRenderer>();
        C1 = Covfefe1.GetComponent<Covfefe1Click>().Clicked;
        C2 = Covfefe3.GetComponent<Covfefe3Click>().Clicked;
        C3 = Covfefe2.GetComponent<Covfefe2Click>().Clicked;
        T = 6;
        Curtain1.GetComponent<UpFlag>().enabled = true;
    }
	
	void Update ()
    {
        switch (Progress)
        {
            case (1):
                if (C1 == true)
                {
                    Progress = 2;
                    PhoneSR.sprite = Phone2;
                }
                else if (C2 == true || C3 == true)
                {
                    Progress = 0;
                    PhoneSR.sprite = Phone0;
                    Win = false;
                }
                C1 = Covfefe1.GetComponent<Covfefe1Click>().Clicked;
                C2 = Covfefe3.GetComponent<Covfefe3Click>().Clicked;
                C3 = Covfefe2.GetComponent<Covfefe2Click>().Clicked;
                break;

            case (2):
                if (C2 == true)
                {
                    Progress = 3;
                    PhoneSR.sprite = Phone3;
                }
                else if (C3 == true)
                {
                    Progress = 0;
                    PhoneSR.sprite = Phone0;
                    Win = false;
                }
                C1 = Covfefe1.GetComponent<Covfefe1Click>().Clicked;
                C2 = Covfefe3.GetComponent<Covfefe3Click>().Clicked;
                C3 = Covfefe2.GetComponent<Covfefe2Click>().Clicked;
                break;

            case (3):
                if (C3 == true)
                {
                    Progress = 4;
                    PhoneSR.sprite = Phone4;
                    Win = true;
                }
                C1 = Covfefe1.GetComponent<Covfefe1Click>().Clicked;
                C2 = Covfefe3.GetComponent<Covfefe3Click>().Clicked;
                C3 = Covfefe2.GetComponent<Covfefe2Click>().Clicked;
                break;

            default:
                break;
        }
        if (T < 0)
        {
            SceneManager.LoadScene(StageScene);
        }
        else
        {
            T = T - Time.deltaTime;
        }
    }
}


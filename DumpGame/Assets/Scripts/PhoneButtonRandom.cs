using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneButtonRandom : MonoBehaviour
{

    public GameObject Current;
    public SpriteRenderer CurrentSR;
    public Sprite Co, Vf, Efe;
    public int Rvalue;

    void Start ()
    {
        CurrentSR = Current.GetComponent<SpriteRenderer>();
        if (CurrentSR.sprite == Co)
        { 
            Rvalue = Random.Range(0, 4);
            switch (Rvalue)
            {
                case (0):
                    transform.position = new Vector3(8.67f, 4.7f, 0.2f);
                    break;
                case (1):
                    transform.position = new Vector3(-8.8f, 3.43f, 0.2f);
                    break;
                case (2):
                    transform.position = new Vector3(-5.93f, -0.31f, 0.2f);
                    break;
                case (3):
                    transform.position = new Vector3(-2.78f, -5.44f, 0.2f);
                    break;
                default:
                    break;
            }
        }

        else if (CurrentSR.sprite == Vf)
        { 
            Rvalue = Random.Range(0, 4);
            switch (Rvalue)
            {
                case (0):
                    transform.position = new Vector3(10.68f, 2.35f, 0.2f);
                    break;
                case (1):
                    transform.position = new Vector3(-5.66f, 6.02f, 0.2f);
                    break;
                case (2):
                    transform.position = new Vector3(-11.93f, 0.02f, 0.2f);
                    break;
                case (3):
                    transform.position = new Vector3(-12.13f, -3.91f, 0.2f);
                    break;
                default:
                    break;
             }
        }

        else
        { 
            Rvalue = Random.Range(0,4);
            switch (Rvalue)
            {
                case (0):
                    transform.position = new Vector3(10.11f, -.34f, 0.2f);
                    break;
                case (1):
                    transform.position = new Vector3(-11.89f, 6.19f, 0.2f);
                    break;
                case (2):
                    transform.position = new Vector3(0.11f, 6.39f, 0.2f);
                    break;
                case (3):
                    transform.position = new Vector3(-8.88f, -6.68f, 0.2f);
                    break;
                default:
                    break;
            }
        }
    }
}

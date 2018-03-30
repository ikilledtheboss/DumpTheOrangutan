using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomBrick : MonoBehaviour
{

    public GameObject Current;
    public string BrickName, r1, r2, r3 ,r4;
    public int Rvalue;

    void Start()
    {
        r1 = "rock1";
        r2 = "rock2";
        r3 = "rock3";
        r4 = "rock4";

        BrickName = Current.name;
        if (BrickName == r1)
        {
            Rvalue = Random.Range(0, 3);
            switch (Rvalue)
            {
                case (0):
                    transform.position = new Vector3(-1.96f, -3.04f, -1.2f);
                    break;
                case (1):
                    transform.position = new Vector3(-5.19f, -3.04f, -1.2f);
                    break;
                case (2):
                    transform.position = new Vector3(-2.05f, 0f, -1.2f);
                    break;
                default:
                    break;
            }
        }

        else if (BrickName == r2)
        {
            Rvalue = Random.Range(0, 3);
            switch (Rvalue)
            {
                case (0):
                    transform.position = new Vector3(-2.55f, 2.3f, -1.2f);
                    break;
                case (1):
                    transform.position = new Vector3(-0.91f, 2.3f, -1.2f);
                    break;
                case (2):
                    transform.position = new Vector3(0.74f, 2.3f, -1.2f);
                    break;
                default:
                    break;
            }
        }

        else if (BrickName == r3)
        {
            Rvalue = Random.Range(0, 3);
            switch (Rvalue)
            {
                case (0):
                    transform.position = new Vector3(-6.05f, 2.3f, -1.2f);
                    break;
                case (1):
                    transform.position = new Vector3(2.33f, 2.3f, -1.2f);
                    break;
                case (2):
                    transform.position = new Vector3(7.54f, 2.3f, -1.2f);
                    break;
                default:
                    break;
            }
        }
        else if (BrickName == r4)
        {
            Rvalue = Random.Range(0, 3);
            switch (Rvalue)
            {
                case (0):
                    transform.position = new Vector3(-7.85f, 2.3f, -1.2f);
                    break;
                case (1):
                    transform.position = new Vector3(-4.26f, 2.3f, -1.2f);
                    break;
                case (2):
                    transform.position = new Vector3(3.89f, 2.3f, -1.2f);
                    break;
                default:
                    break;
            }
        }
        else
        {
             transform.position = new Vector3(0f, 0f, -1.2f);
        }
    }
}

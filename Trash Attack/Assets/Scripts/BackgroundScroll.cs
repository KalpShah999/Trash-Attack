using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScroll : MonoBehaviour {

    public Vector3  originalPosition;
    public int speed;
    public float NumberofSeconds;
    public GameObject B1;
    public GameObject B2;
    public GameObject B3;
    public GameObject B4;
    public GameObject B5;
    public Text B1Text;
    public Text B2Text;
    public Text B3Text;
    public Text B4Text;
    public Text B5Text;
    private float Running = 1;

    void Awake ()
    {
        originalPosition = transform.position;
	}
	
	void Update ()
    {
        transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        if (Running == 1)
        {
            StartCoroutine(Reset());
        }
	}

    public void ToB1()
    {
        transform.position = originalPosition;
        B1.SetActive(true);
        B2.SetActive(false);
        B3.SetActive(false);
        B4.SetActive(false);
        B5.SetActive(false);
        B1Text.color = Color.white;
        B2Text.color = Color.black;
        B3Text.color = Color.black;
        B4Text.color = Color.black;
        B5Text.color = Color.black;
        StartCoroutine(Reset());
    }

    public void ToB2()
    {
        transform.position = originalPosition;
        B1.SetActive(false);
        B2.SetActive(true);
        B3.SetActive(false);
        B4.SetActive(false);
        B5.SetActive(false);
        B1Text.color = Color.black;
        B2Text.color = Color.white;
        B3Text.color = Color.black;
        B4Text.color = Color.black;
        B5Text.color = Color.black;
        StartCoroutine(Reset());
    }

    public void ToB3()
    {
        transform.position = originalPosition;
        B1.SetActive(false);
        B2.SetActive(false);
        B3.SetActive(true);
        B4.SetActive(false);
        B5.SetActive(false);
        B1Text.color = Color.black;
        B2Text.color = Color.black;
        B3Text.color = Color.white;
        B4Text.color = Color.black;
        B5Text.color = Color.black;
        StartCoroutine(Reset());
    }
    
    public void ToB4()
    {
        transform.position = originalPosition;
        B1.SetActive(false);
        B2.SetActive(false);
        B3.SetActive(false);
        B4.SetActive(true);
        B5.SetActive(false);
        B1Text.color = Color.black;
        B2Text.color = Color.black;
        B3Text.color = Color.black;
        B4Text.color = Color.white;
        B5Text.color = Color.black;
        StartCoroutine(Reset());
    }

    public void ToB5()
    {
        transform.position = originalPosition;
        B1.SetActive(false);
        B2.SetActive(false);
        B3.SetActive(false);
        B4.SetActive(false);
        B5.SetActive(true);
        B1Text.color = Color.black;
        B2Text.color = Color.black;
        B3Text.color = Color.black;
        B4Text.color = Color.black;
        B5Text.color = Color.white;
        StartCoroutine(Reset());
    }

    IEnumerator Reset ()
    {
        Running = 0;
        yield return new WaitForSeconds(NumberofSeconds);
        transform.position = originalPosition;
        Running = 1;
    }
}

//32, 22.73, 21.62
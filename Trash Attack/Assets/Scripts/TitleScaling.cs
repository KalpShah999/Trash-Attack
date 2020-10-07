using System.Collections;
using UnityEngine;

public class TitleScaling : MonoBehaviour {

    public float speed;
    public float NumberofSeconds;
    private float Running = 1;
    private Vector3 OriginalScale;

    void Start ()
    {
        OriginalScale = new Vector3(0.8125f, 0.8125f, 0.8125f);
        transform.localScale = OriginalScale;
	}

    private void OnDisable()
    {
        transform.localScale = OriginalScale;
    }

    void Update ()
    {
        if (Running == 1)
        {
            transform.localScale += new Vector3(speed, speed, 0.0f);
            if (Running == 1)
            {
                StartCoroutine(Scale());
            }
        }

        if (Running == 0)
        {
            transform.localScale += new Vector3(-speed, -speed, 0.0f);
            if (Running == 0)
            {
                StartCoroutine(ReScale());
            }
        }
    }

    IEnumerator Scale()
    {
        yield return new WaitForSeconds(NumberofSeconds);
        Running = 0;
    }

    IEnumerator ReScale()
    {
        yield return new WaitForSeconds(NumberofSeconds);
        Running = 1;
    }
}

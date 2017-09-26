using UnityEngine;
using System.Collections;

public class quake : MonoBehaviour {

    public float speed;
    public float amplitude;
    Vector3 posInicial;
    Vector3 oscilatorio;
    Vector3 trepidatorio;
    public bool esOscilatorio;
    public bool temblar;

	// Use this for initialization
	void Start () {

        speed = 0.0f;
        amplitude = 2.0f;
        posInicial = transform.position;
        esOscilatorio = true;
        }
	
	// Update is called once per frame
	void FixedUpdate () {

        trepidatorio = posInicial + new Vector3(0.0f, amplitude * Mathf.Sin(speed*Time.time), 0.0f);
        oscilatorio = posInicial +new Vector3(amplitude * Mathf.Sin(speed * Time.time), 0.5f * amplitude * Mathf.Sin(speed * Time.time), amplitude * Mathf.Sin(speed * Mathf.PI* Time.time));

        if (temblar)
        {

            if (!esOscilatorio)
            {
                speed = 10.0f;
                transform.position = trepidatorio;
            }
            else
            {
                speed = 2.0f;
                transform.position = oscilatorio;
            }
        }
        else {
            transform.position = Vector3.zero;
        }


        Debug.Log(transform.position);


    }
}

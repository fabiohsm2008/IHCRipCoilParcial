using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEffect : MonoBehaviour
{
    public AudioClip Sound = null;
    protected Transform Posicion = null;
    private float volumen = 1.0f;
    private Vector3 mypos;

    // Start is called before the first frame update
    void Start()
    {
        Posicion = transform;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject ajaja = GameObject.Find("platform_player");
        PlatformController aja = ajaja.GetComponent<PlatformController>();
        mypos = aja.playerPos;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (Sound)
        {
            //     AudioSource.PlayClipAtPoint(Sound, Posicion.position, volumen);
            AudioSource.PlayClipAtPoint(Sound, mypos, volumen);
        }
    }

}

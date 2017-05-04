using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public GameObject Bullet_prefab;
	public float bulletimpulse;
	public AudioClip fart;


	private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

	void Awake () {
    
        source = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () { 
		if(Input.GetButtonDown("Fire1"))
		{
			float vol = Random.Range (volLowRange, volHighRange);
            source.PlayOneShot(fart,vol);
			Camera cam = Camera.main;
			GameObject thebullet = (GameObject)Instantiate(Bullet_prefab, cam.transform.position, cam.transform.rotation);
			thebullet.GetComponent<Rigidbody>().AddForce( cam.transform.forward * bulletimpulse, ForceMode.Impulse);
		}
	}
}

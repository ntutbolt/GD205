using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour{

    public static AudioClip Move, Die, Coll, Vic;
    static AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {
        Move = Resources.Load<AudioClip> ("Movement");
        Die = Resources.Load<AudioClip> ("Death");
        Coll = Resources.Load<AudioClip>("Collect");
        Vic = Resources.Load<AudioClip> ("Win");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound (string clip)
    {
        switch (clip) {
            case "Movement":
                audioSrc.PlayOneShot(Move);
                break;
            case "Death":
                audioSrc.PlayOneShot(Die);
                break;
            case "Collect":
                audioSrc.PlayOneShot(Coll);
                break;
            case "Win":
                audioSrc.PlayOneShot(Vic);
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//initialize an array source whenever a key is pressed down?
//get key down stores a single frame that its tapped
//get key is called every frame the key is pressed

public class PlayAudio : MonoBehaviour {

    public AudioClip clipC;
    public AudioClip clipCsh;
    public AudioClip clipD;
    public AudioClip clipDsh;
    public AudioClip clipE;
    public AudioClip clipF;
    public AudioClip clipFsh;
    public AudioClip clipG;
    public AudioClip clipGsh;
    public AudioClip clipA;
    public AudioClip clipAsh;
    public AudioClip clipB;
    public AudioClip clipChi;
    public AudioClip clipCshhi;
    public AudioClip clipDhi;
    public AudioClip clipDshhi;
    public AudioClip clipEhi;
    public AudioClip clipFhi;

    AudioSource[] audioArray;
    AudioClip[] clipArray;

    public void Awake()
    {
      

        audioArray = new AudioSource[18]; 

        clipArray = new AudioClip[] { clipC, clipCsh, clipD, clipDsh,
        clipE, clipF, clipFsh, clipG, clipGsh, clipA, clipAsh, clipB,
        clipChi, clipCshhi, clipDhi, clipDshhi, clipEhi, clipFhi};

        for (int i = 0; i < 18; i++)
        {
            audioArray[i] = CreateSource(clipArray[i]);
        }
    }

    public AudioSource CreateSource(AudioClip clip)
    {
        AudioSource newAudio = gameObject.AddComponent<AudioSource>();
        newAudio.clip = clip;
        return newAudio;
    }

public void Update()
    {
        
        //float halfstep = 12;

        bool[] activeChannels = new bool[18];

        activeChannels[0] = Input.GetKeyDown("a"); //C
        activeChannels[1] = Input.GetKeyDown("w"); //C#
        activeChannels[2] = Input.GetKeyDown("s"); //D
        activeChannels[3] = Input.GetKeyDown("e"); //
        activeChannels[4] = Input.GetKeyDown("d"); //C
        activeChannels[5] = Input.GetKeyDown("f"); //C
        activeChannels[6] = Input.GetKeyDown("t"); //C
        activeChannels[7] = Input.GetKeyDown("g"); //C
        activeChannels[8] = Input.GetKeyDown("y"); //C
        activeChannels[9] = Input.GetKeyDown("h"); //C
        activeChannels[10] = Input.GetKeyDown("u"); //C
        activeChannels[11] = Input.GetKeyDown("j"); //C
        activeChannels[12] = Input.GetKeyDown("k"); //C
        activeChannels[13] = Input.GetKeyDown("o"); //C
        activeChannels[14] = Input.GetKeyDown("l"); //C
        activeChannels[15] = Input.GetKeyDown("p"); //C
        activeChannels[16] = Input.GetKeyDown(";"); //C
        activeChannels[17] = Input.GetKeyDown("'"); //C

        ArrayList toPlay = new ArrayList();

        for (int i = 0; i < 18; i++)
        {

            if (activeChannels[i]) {
                //AudioClip hitClip = clipArray[i];
                toPlay.Add(i);
            } else
            {
                //audioArray[i].Stop();
            }


        }

        foreach (int i in toPlay) {
            audioArray[i].Play();
        }

    }
}

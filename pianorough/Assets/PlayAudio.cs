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

    int[] delayArray;
    bool[] incrementDelay;

    bool[] activeChannels;
    bool[] inactiveChannels;
    public bool[] currentlyPlaying;

    public void Awake()
    {

        activeChannels = new bool[18];
        inactiveChannels = new bool[18];
        currentlyPlaying = new bool[18];

        audioArray = new AudioSource[18]; 

        clipArray = new AudioClip[] { clipC, clipCsh, clipD, clipDsh,
        clipE, clipF, clipFsh, clipG, clipGsh, clipA, clipAsh, clipB,
        clipChi, clipCshhi, clipDhi, clipDshhi, clipEhi, clipFhi};

        delayArray = new int[18];
        incrementDelay = new bool[18];

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

        activeChannels[0] = Input.GetKeyDown("a"); //C
        activeChannels[1] = Input.GetKeyDown("w"); //C#
        activeChannels[2] = Input.GetKeyDown("s"); //D
        activeChannels[3] = Input.GetKeyDown("e"); //
        activeChannels[4] = Input.GetKeyDown("d"); //C
        activeChannels[5] = Input.GetKeyDown("f"); //C
        activeChannels[6] = Input.GetKeyDown("t"); //C
        activeChannels[7] = Input.GetKeyDown("g"); //C test
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

        inactiveChannels[0] = Input.GetKeyUp("a"); //C
        inactiveChannels[1] = Input.GetKeyUp("w"); //C#
        inactiveChannels[2] = Input.GetKeyUp("s"); //D
        inactiveChannels[3] = Input.GetKeyUp("e"); //
        inactiveChannels[4] = Input.GetKeyUp("d"); //C
        inactiveChannels[5] = Input.GetKeyUp("f"); //C
        inactiveChannels[6] = Input.GetKeyUp("t"); //C
        inactiveChannels[7] = Input.GetKeyUp("g"); //C
        inactiveChannels[8] = Input.GetKeyUp("y"); //C
        inactiveChannels[9] = Input.GetKeyUp("h"); //C
        inactiveChannels[10] = Input.GetKeyUp("u"); //C
        inactiveChannels[11] = Input.GetKeyUp("j"); //C
        inactiveChannels[12] = Input.GetKeyUp("k"); //C
        inactiveChannels[13] = Input.GetKeyUp("o"); //C
        inactiveChannels[14] = Input.GetKeyUp("l"); //C
        inactiveChannels[15] = Input.GetKeyUp("p"); //C
        inactiveChannels[16] = Input.GetKeyUp(";"); //C
        inactiveChannels[17] = Input.GetKeyUp("'"); //C

        ArrayList toPlay = new ArrayList();
        ArrayList toStop = new ArrayList();

        for (int i = 0; i < 18; i++)
        {

            if (activeChannels[i]) {
                toPlay.Add(i);
            } 

            if (inactiveChannels[i])
            {
                toStop.Add(i);
            }
        }

        foreach (int i in toPlay) {
            delayArray[i] = 0;
            incrementDelay[i] = false;
            audioArray[i].Play();
            currentlyPlaying[i] = true;
        }

        foreach (int i in toStop)
        {
            incrementDelay[i] = true;
        }

        for (int i = 0; i < 18; i++)
        {
            if (incrementDelay[i])
            {
                delayArray[i]++;
            }

            if (delayArray[i] == 15)
            {
                audioArray[i].Stop();
                currentlyPlaying[i] = false;
            }
        }

    }
}

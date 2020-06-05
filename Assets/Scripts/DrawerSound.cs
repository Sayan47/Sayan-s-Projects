using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerSound : MonoBehaviour
{
    public AudioSource do_AudioSource;
    public AudioSource dc_AudioSource;
    bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnEnable()
    {
        GetComponent<VRActionHarness>().OnActionTrigger += ToggleAudio;
    }
    virtual protected void ToggleAudio()
    {
        if (!flag)
        {
            do_AudioSource.Play();
            flag = true;
        }
        else
        {
            dc_AudioSource.Play();
            flag = false;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class PlayerGrab : MonoBehaviour
{
    public GameObject tab;
    public GameObject myHand;
    public GameObject temp_obj;
    public Camera myCamera;
    public bool flag = false;

    void OnEnable()
    {
        if (flag == false)
        {
            GetComponent<VRActionHarness>().OnActionTrigger += Grab;
        }
        
    }

    void OnDisable()
    {
    }
    void Update()
    {
        if (flag == true)
        {
            temp_obj.transform.position = myHand.transform.position;
        }

    }
    void Grab()
    {
        Rigidbody tabRigidBody = tab.GetComponent<Rigidbody>();
        if (flag == false)
        {
            //tab.transform.position =new Vector3(myCamera.transform.position.x + 4.6329f, myCamera.transform.position.y - 2.5884f, myCamera.transform.position.z -2.20524f);
            tabRigidBody.isKinematic = true;
            tab.transform.SetParent(myHand.transform);
            tab.transform.localPosition = myHand.transform.localPosition;
            temp_obj.transform.position = myHand.transform.position;
            tab.transform.SetParent(temp_obj.transform);
            flag = true;
        }
        else
        {
            tab.transform.position = new Vector3(20f, 13f, -4.1f);
            tabRigidBody.isKinematic = false;
            flag = false;
        }
        
    }
    
}

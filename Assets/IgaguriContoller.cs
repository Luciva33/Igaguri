using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IgaguriContoller : MonoBehaviour
{
    FixedJoint fj = null;
    // Start is called before the first frame update
    public void shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other)
    {
        // GetComponent<Rigidbody>().isKinematic = true;
        if (this.fj == null)
        {
            this.fj = this.gameObject.AddComponent<FixedJoint>();
            this.fj.connectedBody = other.gameObject.GetComponent<Rigidbody>();
            this.fj.breakForce = 1300f; //300以上の力が加わると壊れる
            this.fj.breakTorque = 1300f;

        }
        GetComponent<ParticleSystem>().Play();
    }

    void Start()
    {
        Application.targetFrameRate = 60;
        //shoot(new Vector3(0, 200, 2000));
    }

    // Update is called once per frame
    void Update()
    {

    }
}

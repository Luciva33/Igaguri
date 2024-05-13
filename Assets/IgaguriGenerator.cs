using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IgaguriGenerator : MonoBehaviour
{
    public GameObject IgaguriPrefab;
    GameObject igaguri;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            igaguri = Instantiate(IgaguriPrefab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;


            //normalizedでベクトルを1にしている
            igaguri.GetComponent<IgaguriContoller>().shoot(worldDir.normalized * 2000);

            // int shoot = Random.Range(-300, 300);
            // int shoot2 = Random.Range(-200, 700);
            // igaguri.GetComponent<IgaguriContoller>().shoot(new Vector3(0, 200, 2000));
            // igaguri.GetComponent<IgaguriContoller>().shoot(new Vector3(shoot, shoot2, 2000));
        }
        if (transform.position.x < -30f)
        {
            Destroy(igaguri);
        }
    }
}

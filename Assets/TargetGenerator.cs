using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    public GameObject targetPrefab;
    GameObject go;
    class Targets
    {
        public Vector3 pos;
        public Vector3 localScale;
        public Targets(Vector3 pos, Vector3 localScale)
        {
            this.pos = pos;
            this.localScale = localScale;
        }
    }
    List<Targets> targetList = new List<Targets>();
    float span = 6.0f;
    float delta = 0;

    void Start()
    {
        targetList.Add(new Targets(new Vector3(-10f, 0, 10f), new Vector3(1f, 1, 1)));
        targetList.Add(new Targets(new Vector3(0f, 0, 10f), new Vector3(1f, 1f, 1f)));
        targetList.Add(new Targets(new Vector3(10f, 0, 10f), new Vector3(1f, 1f, 1f)));

        for (int i = 0; i < targetList.Count; i++)
        {

            go = Instantiate(targetPrefab);
            go.transform.position = targetList[i].pos;
            go.transform.localScale = targetList[i].localScale;

        }

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            go = Instantiate(targetPrefab);
            go.transform.position = new Vector3(30f, 0, 10f);
            go.transform.localScale = new Vector3(1f, 1, 1);

        }
    }

}

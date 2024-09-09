using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public GameObject gameobject1;
    public GameObject gameobject2;
    public GameObject gameobject3;
    public GameObject gameobject4;
    public GameObject gameobject5;
    public GameObject chicken;
    public GameObject lion;
    public GameObject penguin;
    public GameObject dog;
    public GameObject cat;
    public Transform transformp;
    public int change;
    public List<GameObject> nk;
    public List<GameObject> nd;
    public List<int> mylist = new List<int> { 0, 1, 2, 3, 4 };
    // Start is called before the first frame update
    void Start()
    {
        nk.Add(gameobject1);
        nk.Add(gameobject2);
        nk.Add(gameobject3);
        nk.Add(gameobject4);
        nk.Add(gameobject5);
        nd.Add(chicken);
        nd.Add(lion);
        nd.Add(penguin);
        nd.Add(dog);
        nd.Add(cat);
        Shuffle(mylist);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && change < 5)
        {
            GameObject launched = Instantiate(nk[mylist[change]], transform.position, transform.rotation);
            launched.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 1100f, 0));
            Destroy(nd[mylist[change]]);
            change++;
        }
    }

    void Shuffle<var>(List<var> list)
    {
        for (int i =0; i < list.Count - 1; i++){
            var temp = list[i];
            int rand = Random.Range(i, list.Count);
            list[i] = list[rand];
            list[rand] = temp;
        }
    }




}

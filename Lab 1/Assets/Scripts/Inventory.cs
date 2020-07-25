using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    LinkedList<int> my_list = new LinkedList<int>();


    // Start is called before the first frame update
    void Start()
    {
        
        my_list.AddLast(1);
        my_list.AddAfter(my_list.First, 2);
        my_list.AddLast(3);

        foreach (int i in my_list)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Bomb")
        {
            my_list.AddFirst(1);
            Destroy(gameObject);
            Debug.Log("In slot 1");
        }

        if (gameObject.tag == "Potion" && my_list.AddFirst(1) != null)
        {
            my_list.AddAfter(my_list.First, 2);
            Destroy(gameObject);
            Debug.Log("In slot 2");
        }


        if (gameObject.tag == "Ammo" && my_list.AddFirst(1) != null && my_list.AddAfter(my_list.First, 2) != null)
        {
            my_list.AddLast(3);
            Destroy(gameObject);
            Debug.Log("In slot 3");
        }
    }
}


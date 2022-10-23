using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    //private bool collected = false;
    private Inventory INV = new Inventory();

    public void Collect()
    {
        //INV.Add(gameObject.tag);


        switch(gameObject.name)
        {
            case "mango":
                break;
            case "apple":
                break;
            case "chocolate":
                break;
            case "jam":
                break;
            case "banana":
                break;
            default:
                break;
        }

        //gameObject.SetActive(false);

        Destroy(this.gameObject);

        ////toggle in and out of cart
        //if (collected == false)
        //{
        //  collected = true;
        //  transform.localScale += new Vector3(3, 3, 3);
        //}
        //else if (collected == true)
        //{
        //    collected = false;
        //    transform.localScale -= new Vector3(3, 3, 3)
        //}
    }
}

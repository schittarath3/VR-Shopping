using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    private bool collected = false;

    public void Collect()
    {
        //toggle in and out of cart
        if(collected == false)
        {
            collected = true;
            this.transform.localScale += new Vector3(3, 3, 3);
            //Call inventory class to add to it
            //send tag
        }
        else if(collected == true)
        {
            collected = false;
            this.transform.localScale -= new Vector3(3, 3, 3);
            //
        }
    }
}

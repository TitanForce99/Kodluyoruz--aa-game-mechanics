using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ganeending : MonoBehaviour
{
    public GameObject cember;
        public GameObject spawnloc;
    

   
    
    public void End()
    {
        cember.GetComponent<Buyuk�emberDonme>().enabled = false;
        spawnloc.GetComponent<stickspawner>().enabled = false;
       
    }
}

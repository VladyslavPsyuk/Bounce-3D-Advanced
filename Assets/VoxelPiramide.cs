using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxelPiramide : MonoBehaviour
{
   
    void Start()
    {
        int maxHight = 10;

        for (int height =0; height < maxHight; height++)
        {
            int length = maxHight - height;
            for (int x = -length; x<=length; x++)
            {
                for (int z = -length; z <=length; z++)
                {
                    if (Mathf.Abs(x) == length || Mathf.Abs(z) == length)
                        VoxelTools.MakeCube(x, height, z);
                }
            }
        }
    }

 
}

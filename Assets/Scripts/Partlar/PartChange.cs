using System.Collections;
using System.Collections.Generic;
//using UnityEditorInternal;
using UnityEngine;

public class PartChange : MonoBehaviour
{
    public GameObject hell;
    public GameObject heaven;
    public GameObject beach;

    int right = 0;
    int left = 0; 
    void Start()
    {
        heaven.SetActive(false);
        hell.SetActive(false);
        beach.SetActive(true);
    }

    
    void Update()
    {
        if (right == 0)
        {
            beach.SetActive(true);
            heaven.SetActive(false);
            hell.SetActive(false);
        }
        else if (right > 0)
        {
            if (right == 1)
            {
                beach.SetActive(false);
                heaven.SetActive(true);
                hell.SetActive(false);
            }
            else if (right == 2)
            {
                beach.SetActive(false);
                heaven.SetActive(false);
                hell.SetActive(true);
            }
            else if (right == 3)
            {
                beach.SetActive(true);
                heaven.SetActive(false);
                hell.SetActive(false);
                right = 0;
                left = 0;
            }
        }
        else if (right < 0)
        {
            if (left == 1)
            {
                beach.SetActive(false);
                heaven.SetActive(false);
                hell.SetActive(true);
            }
            else if (left == 2)
            {
                beach.SetActive(false);
                heaven.SetActive(true);
                hell.SetActive(false);
            }
            else if (left == 3)
            {
                beach.SetActive(true);
                heaven.SetActive(false);
                hell.SetActive(false);
                right = 0;
                left = 0;
            }
        }
        
    }

    public void GoRightButton()
    {
        right++;
        left--;
    }

    public void GoLeftButton()
    {
        right--;
        left++;
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NIceGuyNot : MonoBehaviour
{
    public TextMeshProUGUI GameOver;
    void OnTriggerStay2D(Collider2D other)
    {
        
        GameOver.gameObject.SetActive(true);
        
    }
    }

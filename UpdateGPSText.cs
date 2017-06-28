using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGPSText : MonoBehaviour
{
    public Text coordinates;

    private void update()
    {
    	coordinates.text = "Lat:" + GPS.Instance.latitude.ToString() + "   Lon:" + GPS.Instance.longitude.ToString();     
    }

}

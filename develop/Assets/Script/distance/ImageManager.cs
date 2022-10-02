using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageManager : MonoBehaviour
{
    public List<GameObject> cards; // Make a list of Cards


    GameObject picked = null;

    void Start()
    {
        Generator();
    }
    
    public void Generator()
    {
        picked.SetActive(false); // Deactivate Other GameObjects
        picked = cards[Random.Range(0, cards.Count)]; // Get a random Card from the list of Card
        picked.SetActive(true);  // Activate only Randomly generated card

    }

}


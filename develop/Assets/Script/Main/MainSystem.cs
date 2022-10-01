using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSystem : MonoBehaviour
{
    public static int category;
    // 1. pulsating star - cepheid
    // 2. cataclysmic - supernova 1a / 2
    // 3. cataclysmic - dwarf nova
    // 4. eclipsing binary
    // 5. rotating variable -  Ellipsoidal star
    // 6. normal star

    public static int mission;
    // 1. quiz
    // 2. simulator
    // 3. distance

    public static bool is_placing;
    public static int target_star;
    public static GameObject moving_target = null;

    public static float delta_time;
    public static bool delta_time_change;

    // Start is called before the first frame update
    void Awake()
    {
        category = 1;
        delta_time = 0.5f;
        delta_time_change = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

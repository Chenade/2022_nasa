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

    public static float time_rate;
    public static bool delta_time_change;

    public static int[ , ] status = { {2, 1, 1}, {2, 1, 1}, {2, 1, 1}, {2, 1, 0}, {2, 1, 0}, {2, 1, 0} };
    // 0: not support
    // 1: unavailable
    // 2: available

    public static int[] collected = {0, 0, 0, 0, 0, 0};
    
    public static int current_id;
    public static bool is_mission;

    void Awake()
    {
        category = 1;
        time_rate = 5f;
        delta_time_change = false;
        // MainSystem.collected[0] = 2;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

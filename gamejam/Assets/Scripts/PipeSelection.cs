﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is the thing that drives which pipes are available for a player to choose from. You have one of these per player.
public class PipeSelection : MonoBehaviour
{
    // Choose from these:
    public GameObject[]  pipePrefabs;

    // Picked with the choice1 button, choice2 button, etc. private so you don't edit it in the editor by accident.
    private GameObject[] choice = new GameObject[4];

    public GameObject getChoice(int choiceIndex)
    {
        return choice[choiceIndex];
    }

    public void newChoice(int choiceIndex)
    {
        choice[choiceIndex] = pipePrefabs[random.Next(0, pipePrefabs.Length - 1)];
    }

    private System.Random random;

    // So that we use the same random selection for both players. 
    //private static int s_randomSeed = new System.Random().Next();
    private static int s_randomSeed = 2; //use a fixed value while debugging.

    // Use this for initialization
    void Start ()
    {
        if (pipePrefabs.Length == 0)
            throw new UnityException("Missing pipe selection prefabs!");

        random = new System.Random(s_randomSeed);

        for (int i = 0; i < 4; i++)
        {
            newChoice(i);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {

    }
}
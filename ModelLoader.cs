using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelLoader : MonoBehaviour {

    public List<ModelLoad> modelLoad;


	// Use this for initialization
	void Start () {
        modelLoad = new List<ModelLoad>();

        modelLoad.AddRange(LoadHealthPotions("ModelLoad.json"));

    }

    private List<Pickup> LoadHealthPotions(string PickupPath)
    {
        string Path = Application.dataPath + "/Scripts/Pickups/" + PickupPath;
        string[] MapData = FileIOHelper.FileDataToArray(Path);
        string JSONString = string.Join("", MapData);

        List<Pickup> output = new List<Pickup>();
        output.Add(JsonUtility.FromJson<Pickup>(JSONString));

        return output;
    }
}

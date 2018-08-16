using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class Inven : MonoBehaviour
{

    [Serializable]
    public class Item
    {
        public List<string> Friend = new List<string>();
        public List<string> Emotion = new List<string>();
        public List<string> Thing = new List<string>();
        public List<string> Food = new List<string>();
        public List<string> Cloth = new List<string>();
        public List<string> Natural = new List<string>();
        public List<string> Behavior = new List<string>();
    }
    
    // Data save
    public void BinarySerialize(Item it, string filePath) //바이너리로 아이템 클래스를 저장한다는 건가?
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(filePath, FileMode.Create);
        formatter.Serialize(stream, it);
        stream.Close();
    }

    // Data load
    public Item BinaryDeserialize(string filePath)
    {
        Item it = new Item();

        // Put first datas
        if (!File.Exists(filePath)) //파일이 존재하지 않는걸 어떻게 알지? 폴더 위치로?
        {
            putFriend("라이언");
            putThing("TV");
            putEmotion("컴플렉스");
            putFood("물");
        }

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(filePath, FileMode.Open);
        it = (Item)formatter.Deserialize(stream);
        stream.Close();

        return it;
    }

    Item realItem = new Item();
    string realPath;

    // Game start
    void Awake()
    {

        realPath = Application.persistentDataPath + "/Inven.bin"; //저장경로 지정방식?

        // Load data first
        realItem = BinaryDeserialize(realPath);

        // Set multi touch false
        Input.multiTouchEnabled = false;

    }

    // Get friend list
    public List<string> getFriend()
    {
        return realItem.Friend;
    }

    // Get emotion list
    public List<string> getEmotion()
    {
        return realItem.Emotion;
    }

    // Get emotion list
    public List<string> getThing()
    {
        return realItem.Thing;
    }

    // Get emotion list
    public List<string> getFood()
    {
        return realItem.Food;
    }

    // Get emotion list
    public List<string> getCloth()
    {
        return realItem.Cloth;
    }

    // Get emotion list
    public List<string> getNatural()
    {
        return realItem.Natural;
    }

    // Get emotion list
    public List<string> getBehavior()
    {
        return realItem.Behavior;
    }

    // Push Friend in inventory
    public void putFriend(string itName)
    {
        realItem.Friend.Add(itName);

        // Save data
        BinarySerialize(realItem, realPath);
    }

    // Push Friend in inventory
    public void putEmotion(string itName)
    {
        realItem.Emotion.Add(itName);
        // Save data
        BinarySerialize(realItem, realPath);
    }

    // Push Friend in inventory
    public void putThing(string itName)
    {
        realItem.Thing.Add(itName);

        // Save data
        BinarySerialize(realItem, realPath);
    }

    // Push Friend in inventory
    public void putFood(string itName)
    {
        realItem.Food.Add(itName);

        // Save data
        BinarySerialize(realItem, realPath);
    }

    // Push Friend in inventory
    public void putCloth(string itName)
    {
        realItem.Cloth.Add(itName);

        // Save data
        BinarySerialize(realItem, realPath);
    }

    // Push Friend in inventory
    public void putNatural(string itName)
    {
        realItem.Natural.Add(itName);

        // Save data
        BinarySerialize(realItem, realPath);
    }

    // Push Friend in inventory
    public void putBehavior(string itName)
    {
        realItem.Behavior   .Add(itName);

        // Save data
        BinarySerialize(realItem, realPath);
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Good : MonoBehaviour {

    [Serializable]
    public class Goods
    {
        public DateTime startTime;
        public int money;
    }

    // Data save with binary
    public void BinarySerialize(Goods it, string filePath)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(filePath, FileMode.Create);
        formatter.Serialize(stream, it);
        stream.Close();
    }

    // Load binary data
    public Goods BinaryDeserialize(string filePath)
    {
        Goods it = new Goods();

        // Put first datas
        if (!File.Exists(filePath))
        {
            // Set first time data
            saveTime(DateTime.Now.AddMinutes(-20));
            
            // Set first money data
            saveMoney(0);
        }

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(filePath, FileMode.Open);
        it = (Goods)formatter.Deserialize(stream);
        stream.Close();

        return it;
    }

    string realPath;
    Goods realGoods = new Goods();

    // Set data path and load data from path
    public void initiate()
    {

        // Set data path from application's path
        realPath = Application.persistentDataPath + "/good.bin";

        // Load data first
        realGoods = BinaryDeserialize(realPath);

        // Set multi touch false
        Input.multiTouchEnabled = false;

    }

    // Get int type time's minute
    public DateTime getTime()
    {
        // Get goods object from bin file
        realGoods = BinaryDeserialize(realPath);
        
        // Return time from data
        return realGoods.startTime;
    }

    // Get int type money
    public int getMoney()
    {
        // Get goods object from bin file
        realGoods = BinaryDeserialize(realPath);

        // Return money from data
        return realGoods.money;
    }

    // Save current time to bin file
    public void saveTime(DateTime currentTime)
    {
        // Update time data
        realGoods.startTime = currentTime;
        
        // Update bin file
        BinarySerialize(realGoods, realPath);
    }

    // Save current money to bin file
    public void saveMoney(int currentMoney)
    {
        // Update money data
        realGoods.money += currentMoney;

        // Update bin file
        BinarySerialize(realGoods, realPath);
    }
    
    // Minus money by draw
    public void useMoney()
    {
        // Minus current money
        realGoods.money -= 3;

        // Update bin file
        BinarySerialize(realGoods, realPath);
    }
    
}

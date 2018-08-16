using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class BinaryData : MonoBehaviour {

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

    public void BinarySerialize<T>(T t, string filePath)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(filePath, FileMode.Create);
        formatter.Serialize(stream, t);
        stream.Close();
    }

    public T BinaryDesrialize<T>(string filePath)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(filePath, FileMode.Open);
        T t = (T)formatter.Deserialize(stream);
        stream.Close();

        return t;
    }
    
    void Start()
    {
        string realPath = Application.persistentDataPath + "/draw.bin";

        Item all = new Item();

        all.Friend.Add("라이언");
        all.Friend.Add("무지");
        all.Friend.Add("콘");
        all.Friend.Add("어피치");
        all.Friend.Add("튜브");
        all.Friend.Add("제이지");
        all.Friend.Add("네오");
        all.Friend.Add("프로도");

        all.Emotion.Add("컴플렉스");
        all.Emotion.Add("호기심");
        all.Emotion.Add("행복");
        all.Emotion.Add("즐거움");
        all.Emotion.Add("자신감");
        all.Emotion.Add("신비로움");   
        all.Emotion.Add("사랑");
        all.Emotion.Add("욕구");
        all.Emotion.Add("고독");
        all.Emotion.Add("분노");
        
        all.Thing.Add("TV");
        all.Thing.Add("돈");
        all.Thing.Add("황금");

        all.Food.Add("치즈볼");
        all.Food.Add("물");
        all.Food.Add("복숭아");
        all.Food.Add("술");

        all.Cloth.Add("토끼옷");
        all.Cloth.Add("오리발");
        all.Cloth.Add("선글라스");
        all.Cloth.Add("단발머리 가발");
        all.Cloth.Add("왕관");

        all.Natural.Add("나무");
        all.Natural.Add("호수");
        all.Natural.Add("유전자");
        all.Natural.Add("미생물");
        all.Natural.Add("불");
        all.Natural.Add("태양");
        all.Natural.Add("생명");
        all.Natural.Add("악어");

        all.Behavior.Add("힙합");
        all.Behavior.Add("쇼핑");
        all.Behavior.Add("장난");

        BinarySerialize<Item>(all, realPath);

        Item result = BinaryDesrialize<Item>(realPath);

        showList(result.Friend, "Friend");
        showList(result.Emotion, "Emotion");
        showList(result.Thing, "Thing");
        showList(result.Food, "Food");
        showList(result.Cloth, "Cloth");
        showList(result.Natural, "Natural");
        showList(result.Behavior, "Behavior");

    }

    /// <summary>
    /// List 이름과 내용을 콘솔로 출력합니다.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list">출력할 List</param>
    public void showList<T>(List<T> list, string tag = "")
    {

        for(int i = 0; i < list.Count; i++)
        {
            Debug.Log(tag + ": " + list[i]);
        }

    }

}

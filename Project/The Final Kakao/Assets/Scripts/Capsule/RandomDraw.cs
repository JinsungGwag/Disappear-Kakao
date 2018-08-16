using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDraw : Inven {
    
    public struct ItemThema
    {
        public string Name;
        public string Thema;
    }

    public struct ItemExplain
    {
        public string Name;
        public string Explain;
    }

    // Draw item list
    public List<ItemThema> TempItemList = new List<ItemThema>();

    // All item list
    public string[] AllEmotions = { "컴플렉스", "호기심", "행복", "즐거움", "자신감", "신비로움", "사랑", "욕구", "고독", "분노" };
    public string[] AllThings = { "TV", "돈", "황금", "프렌즈 시티", "황금 콘" };
    public string[] AllFoods = { "치즈볼", "물", "복숭아", "술" };
    public string[] AllClothes = { "토끼옷", "오리발", "선글라스", "단발머리 가발", "왕관" };
    public string[] AllNaturals = { "복숭아", "나무", "호수", "유전자", "미생물", "불", "태양", "생명", "악어" };
    public string[] AllBehaviors = { "힙합", "쇼핑", "장난" };

    public Element[] AllElements;

    // Load all elements list
    public void Start()
    {
        AllElements = Resources.LoadAll<Element>("Elements/");
    }

    // Add draw list that remains
    public void AddList(string TempThema, List<string> InvenList, string[] AllList)
    {
        // If have all items in thema
        if (InvenList.Count >= AllList.Length) return;
        
        // Search items that don't exist in inven list
        for(int i = 0; i < AllList.Length; i++)
        {
            // If current searching item is in inven list
            if (InvenList.Contains(AllList[i])) continue;
            
            // Else add current item in draw list
            ItemThema TempItem = new ItemThema
            {
                Name = AllList[i],
                Thema = TempThema
            };

            TempItemList.Add(TempItem);
        }
    }

    // Random draw in draw item list
    public ItemExplain RandomDrawItem()
    {
        // Update inven list
        Awake();

        // Clear draw item list
        TempItemList.Clear();

        // Add items not exist in inven list
        AddList("Emotion", getEmotion(), AllEmotions);
        AddList("Thing", getThing(), AllThings);
        AddList("Food", getFood(), AllFoods);
        AddList("Cloth", getCloth(), AllClothes);
        AddList("Natural", getNatural(), AllNaturals);
        AddList("Behavior", getBehavior(), AllBehaviors);

        // Make item explain object
        ItemExplain TempItem = new ItemExplain
        {
            Name = "클리어",
            Explain = "다 모으셨어요. 수고했어요!"
        };

        // If not full items
        if(TempItemList.Count > 0)
        {
            // Set random item
            int ItemIndex = Random.Range(0, TempItemList.Count);

            // Put item in inven binary file
            switch (TempItemList[ItemIndex].Thema)
            {
                case "Emotion":
                    putEmotion(TempItemList[ItemIndex].Name);
                    break;

                case "Thing":
                    putThing(TempItemList[ItemIndex].Name);
                    break;

                case "Food":
                    putFood(TempItemList[ItemIndex].Name);
                    break;

                case "Cloth":
                    putCloth(TempItemList[ItemIndex].Name);
                    break;

                case "Natural":
                    putNatural(TempItemList[ItemIndex].Name);
                    break;

                case "Behavior":
                    putBehavior(TempItemList[ItemIndex].Name);
                    break;

                default:
                    break;
            }

            // Search item in element list
            for (int i = 0; i < AllElements.Length; i++)
            {
                if (AllElements[i].name != TempItemList[ItemIndex].Name) continue;

                // Set item information
                TempItem.Name = AllElements[i].name;
                TempItem.Explain = AllElements[i].description;
            }
        }

        return TempItem;
    }
    
}
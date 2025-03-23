using Fungus;
using UnityEngine;
using UnityEngine.UI;

public class ItemInventory : MonoBehaviour
{
    [SerializeField]
    private Transform ItemCanvas = null;

    [SerializeField]
    private GameObject ButtonPrefab = null;

    [SerializeField]
    private Fungus.StringCollection m_collection = null;


    private void Start()
    {
    }
    void Update()
    {
        
    }

    private void DisPlayInventory()
    {
        //if (m_collection == null)
        //{
        //    return;
        //}
        //for (int i = 1; i <= m_collection.Count; i++)
        //{
        //    var instance = Instantiate(ButtonPrefab, ItemCanvas);
        //    Text text = instance.GetComponentInChildren<Text>();
        //    string str = m_collection.Get(i).ToString();
        //}
    }
}

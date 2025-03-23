using Fungus;
using UnityEngine;

public class ItemGet : MonoBehaviour
{
    [SerializeField] private Flowchart m_flowChart;
    private string m_ItemVariable = "ItemValue";

    public enum ItemName
    {
        TestItem,
        TestItem2,
        TestItem3,
        ItemCount
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// ランダムなアイテムを選び取得
    /// </summary>
    void SetRandomItem()
    {
        int randomItem = Random.Range(0, (int)ItemName.ItemCount);
        ItemName name = (ItemName)randomItem;
        string ItemValue = name.ToString();
        m_flowChart.SetStringVariable(m_ItemVariable, ItemValue);
    }
}

using Fungus;
using UnityEngine;

public class PlaceChartStatus : MonoBehaviour
{
    [SerializeField]
    private PlaceData.Pattern m_placePettern = new PlaceData.Pattern();

    [SerializeField]
    private CharacterData.Pattern m_charaPettern = new CharacterData.Pattern();

    private FlowChartSelector m_selector = null;

    void Start()
    {
        //ディクショナリーに自身を登録
        m_selector = FindObjectOfType<FlowChartSelector>();
        Flowchart flowchart = GetComponent<Flowchart>();
        m_selector.RegisterPlacechart(m_placePettern, m_charaPettern, flowchart);
    }
}

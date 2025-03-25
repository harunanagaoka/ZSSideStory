using Fungus;
using UnityEngine;

public class GreetingChartStatus : MonoBehaviour
{
    [SerializeField]
    private CharacterData.Pattern m_charaPettern = new CharacterData.Pattern();

    private FlowChartSelector m_selector = null;

    void Start()
    {
        //ディクショナリーに自身を登録
        m_selector = FindObjectOfType<FlowChartSelector>();
        Flowchart flowchart = GetComponent<Flowchart>();
        m_selector.RegistGreetingChart(m_charaPettern, flowchart);
    }
}

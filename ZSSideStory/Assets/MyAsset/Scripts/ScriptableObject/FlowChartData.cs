using UnityEngine;
using Fungus;

[System.Serializable]
public class FlowChartData
{
    [SerializeField]
    private PlaceData.Pattern m_placePettern = new PlaceData.Pattern();

    [SerializeField]
    private CharacterData.Pattern m_charaPettern = new CharacterData.Pattern();

}

[CreateAssetMenu(fileName = "FlowChartTable", menuName = "Table/FlowChartTable")]
public class FlowChartTable : ScriptableObject
{
    public FlowChartData[] flowDataList;
}


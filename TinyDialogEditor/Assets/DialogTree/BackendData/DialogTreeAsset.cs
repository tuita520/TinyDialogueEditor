using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TreeDataAsset", menuName = "Tree Asset", order = 1)]
public class DialogTreeAsset : ScriptableObject
{
    [SerializeField] List<DialogTreeElement> m_TreeElements = new List<DialogTreeElement>();

    public List<DialogTreeElement> treeElements
    {
        get { return m_TreeElements; }
        set { m_TreeElements = value; }
    }

    void Awake()
    {
        if (m_TreeElements.Count == 0)
        {
            DialogTreeElement dialogTreeElement = new DialogTreeElement("Root", -1, 0);
            m_TreeElements.Add(dialogTreeElement);
        }
    }
}

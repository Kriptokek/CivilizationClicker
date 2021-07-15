using System.Collections.Generic;
using strange.extensions.mediation.impl;
using UnityEngine;

public class StageView : View
{
    [SerializeField] private List<SubStageItem> _subStageItems;
    private List<GameObject> _subStages;

    public List<SubStageItem> SubStageItems => _subStageItems;

    public Object[] SubStages => Resources.
        LoadAll("SubStages", typeof(SubStageStorage));
    
    protected override void OnEnable()
    {
        base.OnEnable();
        _subStages = new List<GameObject>();
        
        for (int i = 0; i < SubStages.Length; i++)
        {
            var subStage = (SubStageStorage) SubStages[i];
            var subStageObject = Instantiate(subStage.SubStagePrefab);
            
            _subStages.Add(subStageObject);
            _subStages[i].SetActive(i == 0);

            _subStageItems[i].Initialize(subStage.Number, subStage.ButtonSprite);
            _subStageItems[i].ButtonClicked += SubStageOpen;
        }
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        for (int i = 0; i < SubStages.Length; i++)
        {
            _subStages[i].SetActive(true);
            _subStageItems[i].ButtonClicked -= SubStageOpen;
        }
        
        _subStages.Clear();
    }

    private void SubStageOpen(int subStageToOpenId)
    {
        for (int i = 0; i < _subStages.Count; i++)
        {
            _subStages[i].SetActive(i == subStageToOpenId);
        }
    }
}

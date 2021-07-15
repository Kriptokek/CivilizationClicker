using System.Collections;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class SubSectionController : ViewController<SubSectionView>
{
    private Coroutine _coroutine;

    private void Start()
    {
        View.jSignalInstantiate.AddListener(ElementInstantiate);
    }

    private void OnEnable()
    {
        _coroutine = StartCoroutine(ItemGenerator());
    }

    private void OnDisable()
    {
        StopCoroutine(_coroutine);
        _coroutine = null;
    }

    private IEnumerator ItemGenerator()
    {
        while (true)
        {
            var randomOffset = new Vector3(
                Random.Range(0, View.InstantiateOffset), 
                Random.Range(0, View.InstantiateOffset), 
                Random.Range(0, View.InstantiateOffset));
            
            ElementInstantiate(View.CurrentMaxElement, Vector3.zero + randomOffset);
            
            var time = View.InstantiateTime;
            while (time > 0)
            {
                yield return null;
                time -= Time.deltaTime;
            }
        }
    }

    private void ElementInstantiate(int number, Vector3 position)
    {
        var needElement = View.Elements.FirstOrDefault(e => e.Number == number);
        ClickableController item = Instantiate(View.Item, position, Quaternion.identity, View.Background);
        item.gameObject.SetActive(true);
        
        if (needElement != null)
        {
            item.View.Initialize(needElement.Sprite, needElement.Number,
                needElement.GoldProductivity, needElement.NativeProductivity, needElement.NativeCurrencies); 
        }
    }
}

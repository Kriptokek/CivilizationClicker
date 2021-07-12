using System.Collections;
using UnityEngine;

public class GameStageController : ViewController<GameStageView>
{
    private Coroutine _coroutine;
    
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
            Instantiate(View.Item, View.Background.transform); 
            
            var time = View.InstantiateTime;
            while (time > 0)
            {
                yield return null;
                time -= Time.deltaTime;
            }
        }
    }
}

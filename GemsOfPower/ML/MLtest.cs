using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Barracuda;
using TMPro;

public class MLtest : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField inputValue; 
    [SerializeField]
    private TMP_Text outputPrediction;
    [SerializeField]
    private NNModel Dristmodel;
    private Model runtimeModel;
    private IWorker worker;
    private string outputLayerName;


    // Start is called before the first frame update
    void Start()
    {
        runtimeModel = ModelLoader.Load(Dristmodel);
        worker = WorkerFactory.CreateWorker(WorkerFactory.Type.Auto, runtimeModel);
        outputLayerName = runtimeModel.outputs[runtimeModel.outputs.Count - 1];
        

    }
    public void Predict()
    {
        float numberInput;

        if (float.TryParse(inputValue.text, out numberInput))
        {
            using Tensor inputTensor = new Tensor(1,1);

            inputTensor[0] = numberInput;
            worker.Execute(inputTensor);

            Tensor outputTensor = worker.PeekOutput(outputLayerName);

            outputPrediction.text = outputTensor[0].ToString();
        }
        

    }

    public void OnDestroy()
    {
        worker?.Dispose();
    }

    
    
}

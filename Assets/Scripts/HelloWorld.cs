using System.Collections;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private string wholeNumbers = "Tüm liste ";
    private string dividendToTwo = "İkiye bölünenler";
    private string dividendToThree = "Üçe bölünenler";
    private string dividendToFour = "Dörde bölünenler";
    private string dividendToFive = "Beşe bölünenler";
    
    private ArrayList wholeNumbersList = new ArrayList();
    
    void Start()
    {
        FindDividers(1,15);
    }
    
    private void FindDividers(int firstNumber, int secondNumber)
    {
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            wholeNumbersList.Add(i);
            wholeNumbers += " " + i;

            if (i % 2 == 0)
                dividendToTwo += " " + i;
            
            if (i % 3 == 0)
                dividendToThree += " " + i;
            
            if (i % 4 == 0)
                dividendToFour += " " + i;
            
            if (i % 5 == 0)
                dividendToFive += " " + i;
        }
        
        Debug.Log(wholeNumbers);
        Debug.Log(dividendToTwo);
        Debug.Log(dividendToThree);
        Debug.Log(dividendToFour);
        Debug.Log(dividendToFive);
    }
}

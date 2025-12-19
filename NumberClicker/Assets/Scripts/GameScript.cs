using UnityEngine;
using UnityEngine.UI;
using System;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;

public class GameScript : MonoBehaviour
{
    [SerializeField] Text numberText, Multx2Text, Multx3Text, Multx4Text, CBButtonAmountText, CBButtonCostText, CBButtonMultText, CB2AmountText, CB2CostText, CB2MultText, CB3AmountText, CB3CostText, CB3MultText, CB4AmountText, CB4CostText, CB4MultText, CB5AmountText, CB5CostText, CB5MultText, CB6AmountText, CB6CostText, CB6MultText, CB7AmountText, CB7CostText, CB7MultText, CB8AmountText, CB8CostText, CB8MultText, CB9AmountText, CB9CostText, CB9MultText, CB10AmountText, CB10CostText, CB10MultText, CB11AmountText, CB11CostText, CB11MultText, CB12AmountText, CB12CostText, CB12MultText;
    [SerializeField] double costScaler = 1.2, multAdd = 1, number = 0, npc = 1, CBButtonAmount = 0, CBButtonCost = 20, CBButtonMult = 1, CB2Amount = 0, CB2Cost = 300, CB2Mult = 1, CB3Amount = 0, CB3Cost = 1000000, CB3Mult = 1, CB4Amount = 0, CB4Cost = 1000000000, CB4Mult = 1, CB5Amount = 0, CB5Cost = 1E15, CB5Mult = 1, CB6Amount = 0, CB6Cost = 1E21, CB6Mult = 1, CB7Amount = 0, CB7Cost = 1E24, CB7Mult = 1, CB8Amount = 0, CB8Cost = 1E27, CB8Mult = 1, CB9Amount = 0, CB9Cost = 1E33, CB9Mult = 1, CB10Amount = 0, CB10Cost = 1E36, CB10Mult = 1, CB11Amount = 0, CB11Cost = 1E39, CB11Mult = 1, CB12Amount = 0, CB12Cost = 1E42, CB12Mult = 1;
    [SerializeField] GameObject CBButton, Multx2Button, Multx3Button, Multx4Button, CB2Obj, CB3Obj, CB4Obj, CB5Obj, CB6Obj, CB7Obj, CB8Obj, CB9Obj, CB10Obj, CB11Obj, CB12Obj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CBButton.SetActive(false);
        CB2Obj.SetActive(false);
        CB3Obj.SetActive(false);
        CB4Obj.SetActive(false);
        CB5Obj.SetActive(false);
        CB6Obj.SetActive(false);
        CB7Obj.SetActive(false);
        CB8Obj.SetActive(false);
        CB9Obj.SetActive(false);
        CB10Obj.SetActive(false);
        CB11Obj.SetActive(false);
        CB12Obj.SetActive(false);
        Multx2Button.SetActive(false);
        Multx2Text.text = "1E12";
        Multx3Button.SetActive(false);
        Multx3Text.text = "1E30";
        Multx4Button.SetActive(false);
        Multx4Text.text = "1E45";
        CB5Cost = 1E15;
    }

    // Update is called once per frame
    void Update()
    {
        numberText.text = toSN(number);
        CBButtonAmountText.text = toSN(CBButtonAmount);
        CBButtonCostText.text = toSN(CBButtonCost);
        CBButtonMultText.text = toSN(CBButtonMult);

        CB2AmountText.text = toSN(CB2Amount);
        CB2CostText.text = toSN(CB2Cost);
        CB2MultText.text = toSN(CB2Mult);

        CB3AmountText.text = toSN(CB3Amount);
        CB3CostText.text = toSN(CB3Cost);
        CB3MultText.text = toSN(CB3Mult);

        CB4AmountText.text = toSN(CB4Amount);
        CB4CostText.text = toSN(CB4Cost);
        CB4MultText.text = toSN(CB4Mult);

        CB5AmountText.text = toSN(CB5Amount);
        CB5CostText.text = toSN(CB5Cost);
        CB5MultText.text = toSN(CB5Mult);

        CB6AmountText.text = toSN(CB6Amount);
        CB6CostText.text = toSN(CB6Cost);
        CB6MultText.text = toSN(CB6Mult);
        
        CB7AmountText.text = toSN(CB7Amount);
        CB7CostText.text = toSN(CB7Cost);
        CB7MultText.text = toSN(CB7Mult);

        CB8AmountText.text = toSN(CB8Amount);
        CB8CostText.text = toSN(CB8Cost);
        CB8MultText.text = toSN(CB8Mult);

        CB9AmountText.text = toSN(CB9Amount);
        CB9CostText.text = toSN(CB9Cost);
        CB9MultText.text = toSN(CB9Mult);

        CB10AmountText.text = toSN(CB10Amount);
        CB10CostText.text = toSN(CB10Cost);
        CB10MultText.text = toSN(CB10Mult);

        CB11AmountText.text = toSN(CB11Amount);
        CB11CostText.text = toSN(CB11Cost);
        CB11MultText.text = toSN(CB11Mult);
        
        CB12AmountText.text = toSN(CB12Amount);
        CB12CostText.text = toSN(CB12Cost);
        CB12MultText.text = toSN(CB12Mult);

        if(CB5Amount == 0){
            CB5Cost = 1E15;
        }
        if(CB7Amount == 0){
            CB7Cost = 1E24;
        }
        if(CB7Amount == 0){
            CB7Cost = 1E27;
        }
        if(CB8Amount == 0){
            CB8Cost = 1E30;
        }

        if(number >= 15 || CBButtonAmount > 0){
            CBButton.SetActive(true);
        }
        if(number >= 250 || CB2Amount > 0){
            CB2Obj.SetActive(true);
        }
        if(number >= 750000 || CB3Amount > 0){
            CB3Obj.SetActive(true);
        }
        if(number >= 750000000 || CB4Amount > 0){
            CB4Obj.SetActive(true);
        }
        if(number >= 10000000000 || CB4Amount > 0){
            Multx2Button.SetActive(true);
        }
        if(number >= 1E29 || CB8Amount > 0){
            Multx3Button.SetActive(true);
        }
        if(number >= 1E44 ){
            Multx4Button.SetActive(true);
        }
        if(number >= 100000000000000 || CB5Amount > 0){
            CB5Obj.SetActive(true);
        }
        if(number >= 1E20 || CB6Amount > 0){
            CB6Obj.SetActive(true);
        }
        if(number >= 1E23 || CB7Amount > 0){
            CB7Obj.SetActive(true);
        }
        if(number >= 1E26 || CB8Amount > 0){
            CB8Obj.SetActive(true);
        }
        if(number >= 1E32 || CB9Amount > 0){
            CB9Obj.SetActive(true);
        }
        if(number >= 1E35 || CB10Amount > 0){
            CB10Obj.SetActive(true);
        }
        if(number >= 1E38 || CB11Amount > 0){
            CB11Obj.SetActive(true);
        }
        if(number >= 1E41 || CB12Amount > 0){
            CB12Obj.SetActive(true);
        }

        if(CBButtonAmount > 0){
            number += CBButtonAmount * Time.deltaTime;
        }
        if(CB2Amount > 0){
            CBButtonAmount += CB2Amount * CBButtonMult * Time.deltaTime;
        }
        if(CB3Amount > 0){
            CB2Amount += CB3Amount * CB2Mult * Time.deltaTime;
        }
        if(CB4Amount > 0){
            CB3Amount += CB4Amount * CB3Mult * Time.deltaTime;
        }
        if(CB5Amount > 0){
            CB4Amount += CB5Amount * CB4Mult * Time.deltaTime;
        }
        if(CB6Amount > 0){
            CB5Amount += CB6Amount * CB5Mult * Time.deltaTime;
        }
        if(CB7Amount > 0){
            CB6Amount += CB7Amount * CB6Mult * Time.deltaTime;
        }
        if(CB8Amount > 0){
            CB7Amount += CB8Amount * CB7Mult * Time.deltaTime;
        }
        if(CB9Amount > 0){
            CB8Amount += CB9Amount * CB8Mult * Time.deltaTime;
        }
        if(CB10Amount > 0){
            CB9Amount += CB10Amount * CB9Mult * Time.deltaTime;
        }
        if(CB11Amount > 0){
            CB10Amount += CB11Amount * CB10Mult * Time.deltaTime;
        }
        if(CB12Amount > 0){
            CB11Amount += CB12Amount * CB11Mult * Time.deltaTime;
        }

    }

    public void click(){
        number += npc;
    }
    public void CBclick(){
        if(number >= CBButtonCost){
            number -= CBButtonCost;
            CBButtonCost *= costScaler;
            CBButtonAmount += 1;
            if(CBButtonAmount >= 11){
                CBButtonMult += multAdd;
            }
        }
    }
    public void MaxCBClick(){
        while(number >= CBButtonCost){
            CBclick();
            if(number < CBButtonCost){
                break;
            }
        }
    }

    public void CB2Click(){
        if(number >= CB2Cost){
            number -= CB2Cost;
            CB2Cost *= costScaler;
            CB2Amount += 1;
            if(CB2Amount >= 11){
                CB2Mult += multAdd;
            }
        }
    }
    public void MaxCB2Click(){
        while(number >= CB2Cost){
            CB2Click();
            if(number < CB2Cost){
                break;
            }
        }
    }

    public void CB3Click(){
        if(number >= CB3Cost){
            number -= CB3Cost;
            CB3Cost *= costScaler;
            CB3Amount += 1;
            if(CB3Amount >= 11){
                CB3Mult += multAdd;
            }
        }
    }
    public void MaxCB3Click(){
        while(number >= CB3Cost){
            CB3Click();
            if(number < CB3Cost){
                break;
            }
        }
    }

    public void CB4Click(){
        if(number >= CB4Cost){
            number -= CB4Cost;
            CB4Cost *= costScaler;
            CB4Amount += 1;
            if(CB4Amount >= 11){
                CB4Mult += multAdd;
            }
        }
    }
    public void MaxCB4Click(){
        while(number >= CB4Cost){
            CB4Click();
            if(number < CB4Cost){
                break;
            }
        }
    }

    public void CB5Click(){
        if(number >= CB5Cost){
            number -= CB5Cost;
            CB5Cost *= costScaler;
            CB5Amount += 1;
            if(CB5Amount >= 11){
                CB5Mult += multAdd;
            }
        }
    }
    public void MaxCB5Click(){
        while(number >= CB5Cost){
            CB5Click();
            if(number < CB5Cost){
                break;
            }
        }
    }

    public void CB6Click(){
        if(number >= CB6Cost){
            number -= CB6Cost;
            CB6Cost *= costScaler;
            CB6Amount += 1;
            if(CB6Amount >= 11){
                CB6Mult += multAdd;
            }
        }
    }
    public void MaxCB6Click(){
        while(number >= CB6Cost){
            CB6Click();
            if(number < CB6Cost){
                break;
            }
        }
    }

    public void CB7Click(){
        if(number >= CB7Cost){
            number -= CB7Cost;
            CB7Cost *= costScaler;
            CB7Amount += 1;
            if(CB7Amount >= 11){
                CB7Mult += multAdd;
            }
        }
    }
    public void MaxCB7Click(){
        while(number >= CB7Cost){
            CB7Click();
            if(number < CB7Cost){
                break;
            }
        }
    }

    public void CB8Click(){
        if(number >= CB8Cost){
            number -= CB8Cost;
            CB8Cost *= costScaler;
            CB8Amount += 1;
            if(CB8Amount >= 11){
                CB8Mult += multAdd;
            }
        }
    }
    public void MaxCB8Click(){
        while(number >= CB8Cost){
            CB8Click();
            if(number < CB8Cost){
                break;
            }
        }
    }

    public void CB9Click(){
        if(number >= CB9Cost){
            number -= CB9Cost;
            CB9Cost *= costScaler;
            CB9Amount += 1;
            if(CB9Amount >= 11){
                CB9Mult += multAdd;
            }
        }
    }
    public void MaxCB9Click(){
        while(number >= CB9Cost){
            CB9Click();
            if(number < CB9Cost){
                break;
            }
        }
    }

    public void CB10Click(){
        if(number >= CB10Cost){
            number -= CB10Cost;
            CB10Cost *= costScaler;
            CB10Amount += 1;
            if(CB10Amount >= 11){
                CB10Mult += multAdd;
            }
        }
    }
    public void MaxCB10Click(){
        while(number >= CB10Cost){
            CB10Click();
            if(number < CB10Cost){
                break;
            }
        }
    }

    public void CB11Click(){
        if(number >= CB11Cost){
            number -= CB11Cost;
            CB11Cost *= costScaler;
            CB11Amount += 1;
            if(CB11Amount >= 11){
                CB11Mult += multAdd;
            }
        }
    }
    public void MaxCB11Click(){
        while(number >= CB11Cost){
            CB11Click();
            if(number < CB11Cost){
                break;
            }
        }
    }

    public void CB12Click(){
        if(number >= CB12Cost){
            number -= CB12Cost;
            CB12Cost *= costScaler;
            CB12Amount += 1;
            if(CB12Amount >= 11){
                CB12Mult += multAdd;
            }
        }
    }
    public void MaxCB12Click(){
        while(number >= CB12Cost){
            CB12Click();
            if(number < CB12Cost){
                break;
            }
        }
    }

    public void Multx2Buy(){
        if(number >= 1000000000000){
            number -= 1000000000000;
            Multx2Text.text = "Bought";
            multAdd *= 2;
        }
    }
    public void Multx3Buy(){
        if(number >= 1E30){
            number -= 1E30;
            Multx3Text.text = "Bought";
            multAdd *= 3;

            CBButtonMult *= 1.5;
            CB2Mult *= 1.5;
            CB3Mult *= 1.5;
            CB4Mult *= 1.5;
            CB5Mult *= 1.5;
            CB6Mult *= 1.5;
            CB7Mult *= 1.5;
            CB8Mult *= 1.5;
        }
    }
    public void Multx4Buy(){
        if(number >= 1E45){
            number -= 1E45;
            Multx4Text.text = "Bought";
            multAdd *= 4;

            CBButtonMult *= 2;
            CB2Mult *= 2;
            CB3Mult *= 2;
            CB4Mult *= 2;
            CB5Mult *= 2;
            CB6Mult *= 2;
            CB7Mult *= 2;
            CB8Mult *= 2;
            CB9Mult *= 2;
            CB10Mult *= 2;
            CB11Mult *= 2;
            CB12Mult *= 2;
        }
    }

    public string toSN(double input) {
            if (input < 1E+300) {
                string number = input.ToString("F1");

            if (input > 9999999999.99) {
                int exponent = (int)Math.Floor(safeLog(input, 10));
                double mantissa = input / Math.Pow(10, exponent);
                return mantissa.ToString("F6") + "E" + exponent; // Keep 6 decimal digits
             } else {
                return number;
                }
         }

         return input.ToString();
        }

    double safeLog(double x, double b)
    {
    return x > 0 ? Math.Log(x, b) : 0;
    }
}

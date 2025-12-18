using UnityEngine;
using UnityEngine.UI;
using System;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;

public class GameScript : MonoBehaviour
{
    [SerializeField] Text numberText, Multx2Text, CBButtonAmountText, CBButtonCostText, CBButtonMultText, CB2AmountText, CB2CostText, CB2MultText, CB3AmountText, CB3CostText, CB3MultText, CB4AmountText, CB4CostText, CB4MultText;
    [SerializeField] double costScaler = 1.2, multAdd = 1, number = 0, npc = 1, CBButtonAmount = 0, CBButtonCost = 20, CBButtonMult = 1, CB2Amount = 0, CB2Cost = 300, CB2Mult = 1, CB3Amount = 0, CB3Cost = 1000000, CB3Mult = 1, CB4Amount = 0, CB4Cost = 1000000000, CB4Mult = 1;
    [SerializeField] GameObject CBButton, Multx2Button, CB2Obj, CB3Obj, CB4Obj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CBButton.SetActive(false);
        CB2Obj.SetActive(false);
        CB3Obj.SetActive(false);
        CB4Obj.SetActive(false);
        Multx2Button.SetActive(false);
        Multx2Text.text = "1E12";
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

    public void Multx2Buy(){
        if(number >= 1000000000000){
            number -= 1000000000000;
            Multx2Text.text = "Bought";
            multAdd *= 2;
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

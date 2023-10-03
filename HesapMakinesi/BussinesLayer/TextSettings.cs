using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using HesapMakinesi;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using Entity;
using System.Security.Cryptography;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Globalization;

namespace HesapMakinesi
{

    public class TextSettings:HistoryData,IText
    {
     
        Process pr = new Process();
        public string tempProcess;
        public string[] labelsonis = new string[2];
        public string[] labelFormBracket = new string[2];
        public string[] labelBracket = new string[2];
        public int equalControl = 1, processControl = 0, commaControl = 0, bracketControl = 1, numberControl = 0, bracketCounter = 1, processValue = 0, rootControl;
        public double numberOne, numberTwo, tempNumber;


     
        public string[] processFonk(string lbProcess, string labelValue)
        {
            //İşlem yaptırma Komutları
            string value = "";
            string[] islemDizi = new string[2];


            try
            {
                if (equalControl == 0)
                {
                    if (processControl == 0)
                    {
                        bracketCounter = 0;
                        if (rootControl == 0)
                        {
                            numberTwo = Convert.ToDouble(labelValue);
                            lbProcess += numberTwo;
                        }

                        switch (processValue)
                        {
                            case 1:
                                value = pr.Sum(numberOne, numberTwo).ToString();
                                break;
                            case 2:
                                value = pr.Extraction(numberOne, numberTwo).ToString();
                                break;
                            case 3:
                                value = pr.Impact(numberOne, numberTwo).ToString();
                                break;
                            case 4:
                                if (numberTwo == 0)
                                {
                                    value = "Sıfıra Bölünemez";
                                }
                                else
                                {
                                    value = pr.Divide(numberOne, numberTwo).ToString();
                                }

                                break;
                            case 5:
                                if (numberTwo == 0)
                                {
                                    labelValue = "0 a göre mod alınamaz";
                                }
                                else
                                {
                                    value = pr.Mod(numberOne, numberTwo).ToString();
                                }

                                break;
                            case 6:
                                value = pr.Exponentiation(numberOne, numberTwo).ToString();
                                break;
                            case 7:
                                value = pr.Root(numberOne).ToString();
                                break;
                            default:
                                break;

                        }
                        processControl = 1;
                        equalControl = 1;
                        rootControl = 0;
                        numberControl = 0;

                    }
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            islemDizi[0] = value;
            islemDizi[1] = lbProcess;
            return islemDizi;

        }

      
        public string LabelText(string textNumber, string lbname, Button btComma)
        {

            //iki rakamın yanyana yazılmasını sağlar

            try
            {
                if (numberControl == 0)
                {

                    // labelname = a;
                    lbname = textNumber;
                    numberControl = 1;
                }
                else
                {

                    if (commaControl == 2)
                    {
                        commaControl++;
                        btComma.Enabled = true;
                    }

                    lbname += textNumber;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

            return lbname;

        }




        

        public string btComma_Click(string labelname, Button btComma)
        {
            try
            {
                if (numberControl != 0)
                {
                    if (commaControl == 1)
                    {
                        btComma.Enabled = false;
                    }
                    else if (commaControl == 3)
                    {
                        labelname += ",";
                        commaControl = 1;
                    }
                    else if (commaControl == 0)
                    {
                        labelname += ",";
                        commaControl = 1;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            //Virgül yazım kontrolu




            return labelname;
        }
        public string[] btDel_Click(string labelValue, string labelProcess, Button btComma)
        {
            //Silme Komutları
            try
            {
                commaControl = 2;
                labelValue = "";
                labelProcess = "";
                labelsonis[0] = labelValue; labelsonis[1] = labelProcess;
                btComma.Enabled = true;
                processControl = 0;
                bracketCounter = 1;

            }
            catch (Exception)
            {
                MessageBox.Show("Geçersiz İslem");
            }
            return labelsonis;
        }

        public string[] bracketProcess(string labelValue, string labelProcess)
        {

            //Parantez Yazdırma Komutu
            try
            {
                if (bracketCounter == 0)
                {
                    tempNumber = Convert.ToDouble(labelValue);
                    tempProcess = labelProcess;
                    labelProcess = $"({labelProcess})";
                    labelValue = "";
                    bracketControl = 0;
                    processControl = 0;
                    labelBracket[0] = labelValue; labelBracket[1] = labelProcess;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Geçersiz İşlem");
            }
            return labelBracket;

        }

        public string[] processText(string labelProcess, string labelValue, string process, int Counter2Value)
        {

            //İşlem yazdırma Komutu

            if (bracketControl == 0)
            {

                numberOne = tempNumber;
                bracketControl = 1;
                labelProcess = "(" + (tempProcess) + ")" + process;
                processValue = Counter2Value;
                labelValue = "";
                processControl = 0;
                commaControl = 2;
                equalControl = 0;




            }


            else
            {
                try
                {
                    if (rootControl == 0)
                    {
                        numberOne = Convert.ToDouble(labelValue);
                        labelProcess = numberOne + process;
                        processValue = Counter2Value;
                        labelValue = "";
                        processControl = 0;
                        commaControl = 2;
                        equalControl = 0;
                    }
                    else
                    {
                        numberOne = Convert.ToDouble(labelValue);
                        labelProcess = process + numberOne;
                        processValue = Counter2Value;
                        labelValue = "";
                        processControl = 0;
                        commaControl = 2;
                        equalControl = 0;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            string[] toplaDizi = new string[3];
            toplaDizi[0] = labelValue;
            toplaDizi[1] = labelProcess;

            return toplaDizi;
        }


        public object DelDatas(object deldata)
        {
        
            deldata = DelData(deldata);


            return deldata;
        }
        public object BringDatas(object bringdata)
        {
            bringdata = BringData(bringdata);
            return bringdata;
        }
        public void SelectDatas(int Seldata)
        {
            SelectData(Seldata);
        }
        public object FindDatas(object finddata, string textId)
        {
            if (textId.Length > 0)
            {
                finddata = FindData(finddata, textId);
            }

            return finddata;
        }
        public void SaveDatas(string lbValue, string lbProcces)
        {
            SaveData(lbValue, lbProcces);
        }
        public void Key_Press(object sender, KeyPressEventArgs e, Label lbValue, Label lbProcess, Button btComma)
        {
            string[] processSeries;
            switch (e.KeyChar)
            {
                case '1':
                    lbValue.Text = LabelText("1", lbValue.Text, btComma);
                    break;
                case '2':
                    lbValue.Text = LabelText("2", lbValue.Text, btComma);
                    break;
                case '3':
                    lbValue.Text = LabelText("3", lbValue.Text, btComma);
                    break;
                case '4':
                    lbValue.Text = LabelText("4", lbValue.Text, btComma);
                    break;
                case '5':
                    lbValue.Text = LabelText("5", lbValue.Text, btComma);
                    break;
                case '6':
                    lbValue.Text = LabelText("6", lbValue.Text, btComma);
                    break;
                case '7':
                    lbValue.Text = LabelText("7", lbValue.Text, btComma);
                    break;
                case '8':
                    lbValue.Text = LabelText("8", lbValue.Text, btComma);
                    break;
                case '9':
                    lbValue.Text = LabelText("9", lbValue.Text, btComma);
                    break;
                case '0':
                    lbValue.Text = LabelText("0", lbValue.Text, btComma);
                    break;
                case (char)Keys.Back:
                    try
                    {
                        if (lbValue.Text.Length > 0)
                        {
                            lbValue.Text = lbValue.Text.Substring(0, lbValue.Text.Length - 1);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case ',':
                    try
                    {
                        lbValue.Text = btComma_Click(lbValue.Text, btComma);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case '+':
                    lbProcess.Focus();
                    processSeries = processText(lbProcess.Text, lbValue.Text, "+", 1);
                    lbValue.Text = processSeries[0];
                    lbProcess.Text = processSeries[1];
                    break;
                case '-':
                    lbProcess.Focus();
                    processSeries = processText(lbProcess.Text, lbValue.Text, "-", 2);
                    lbValue.Text = processSeries[0];
                    lbProcess.Text = processSeries[1];
                    break;
                case '*':
                    lbProcess.Focus();
                    processSeries = processText(lbProcess.Text, lbValue.Text, "*", 3);
                    lbValue.Text = processSeries[0];
                    lbProcess.Text = processSeries[1];
                    break;
                case '/':
                    lbProcess.Focus();
                    processSeries = processText(lbProcess.Text, lbValue.Text, "/", 4);
                    lbValue.Text = processSeries[0];
                    lbProcess.Text = processSeries[1];
                    break;
                case '%':
                    lbProcess.Focus();
                    processSeries = processText(lbProcess.Text, lbValue.Text, "%", 5);
                    lbValue.Text = processSeries[0];
                    lbProcess.Text = processSeries[1];
                    break;
                case '^':
                    lbProcess.Focus();
                    processSeries = processText(lbProcess.Text, lbValue.Text, "^", 6);
                    lbValue.Text = processSeries[0];
                    lbProcess.Text = processSeries[1];
                    break;
                case (char)Keys.Enter:

                    if (equalControl == 0)
                    {

                        string[] esitdizi = processFonk(lbProcess.Text, lbValue.Text);
                        lbValue.Text = esitdizi[0];
                        lbProcess.Text = esitdizi[1];
                        SaveData(lbValue.Text, lbProcess.Text);
                    }
                    break;
                case 'k':
                    rootControl = 1;
                    processSeries = processText(lbProcess.Text, lbValue.Text, "√", 7);
                    lbValue.Text = processSeries[0];
                    lbProcess.Text = processSeries[1];
                    break;


                default:
                    break;
            }
        }


    }
}

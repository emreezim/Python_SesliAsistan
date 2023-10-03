using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HesapMakinesi;
using Entity;
namespace HesapMakinesi
{
    
    public class Process
    {
       
        double value = 0;
        
        public  double Sum(double numberOne,double numberTwo){
            value = numberOne + numberTwo;
            return value;
       }
        public  double Extraction(double numberOne, double numberTwo)
        {
            value = numberOne - numberTwo;
            return value;
        }
        public double Divide(double numberOne, double numberTwo)
        {
            value = numberOne / numberTwo;
            return value;
        }
        public double Impact(double numberOne, double numberTwo)
        {
            value = numberOne * numberTwo;
            return value;
        }
        public double Mod(double numberOne, double numberTwo)
        {
            value = numberOne % numberTwo;
            return value    ;
        }
        public double Exponentiation(double numberOne, double numberTwo) {
            value = Math.Pow(numberOne, numberTwo);
            return value;
        }
        public  double Root(double numberOne) {
            value = Math.Sqrt(numberOne);
            return value;
        }
        public  string btMark_Fonk(string labelname) {
            try
            {
                double tempNumber = Convert.ToDouble(labelname);

                if (tempNumber > 0)
                {
                    labelname = "-" + tempNumber;
                }
                else if (tempNumber < 0)
                {
                    labelname = Math.Abs(tempNumber).ToString();
                }

               
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata:"+e.Message);

            }
            return labelname;
        }
       
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Entity
{
   
        public interface IData
        {
           object BringData(object bringData);
           void SaveData(string lbValue, string lbProcces);
            object DelData(object deldata);
            void SelectData(object selectdata);
            object FindData(object findata, string textId);
        }

        public interface IProcces
        {
            double Sum(double numberOne, double numberTwo);
            double Extraction(double numberOne, double numberTwo);
            double Divide(double numberOne, double numberTwo);
            double Impact(double numberOne, double numberTwo);
            double Mod(double numberOne, double numberTwo);
            double Exponentiation(double numberOne, double numberTwo);
            double Root(double numberOne);
            string btMark_Fonk(string labelname);
        }

     public interface IText {
     string[] processFonk(string lbProcess, string labelValue);
        string LabelText(string textNumber, string lbname, Button btComma);
        string btComma_Click(string labelname, Button btComma);
        string[] btDel_Click(string labelValue, string labelProcess, Button btComma);
        string[] bracketProcess(string labelValue, string labelProcess);
        string[] processText(string labelProcess, string labelValue, string process, int Counter2Value);
        object DelDatas(object deldata);
        object BringDatas(object bringdata);
        void SelectDatas(int Seldata);
        object FindDatas(object finddata, string textId);
        void SaveDatas(string lbValue, string lbProcces);
        void Key_Press(object sender, KeyPressEventArgs e, Label lbValue, Label lbProcess, Button btComma);


    }
    }
   

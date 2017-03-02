using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asm;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Vsionorm()
        {
            string[] text = new string[10];
            text[0] = "ld r1,#10";
            text[1] = "ld r0,#1";
            text[2] = "ld r2,#15";
            text[3] = "metka m1";
            text[4] = "sub r2,r0";
            text[5] = "add r1,r0";
            text[6] = "brgz metka1,r2";
            text[7]="";
            text[8]="";
            text[9]="";
            AsmCl tre = new AsmCl();
            var x = tre.runCode(text, 10);
            byte[] registr = {1,25,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            
            CollectionAssert.AreEquivalent(registr, x);
        }
        [TestMethod]
        public void djigurda()
        {
            string[] text = new string[10];
            text[0] = "ld r1,#dfjdfjsdbf";
            text[1] = "ld r0,#dnjfdjf";
            text[2] = "ld r2,#15";
            text[3] = "metka m10";
            text[4] = "sub r2,r0";
            text[5] = "add r1,r0";
            text[6] = "brgz metka1,r2";
            text[7] = "";
            text[8] = "";
            text[9] = "";
            AsmCl tre1 = new AsmCl();
            var x = tre1.runCode(text, 10);
            byte[] registr = { 1, 25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            CollectionAssert.AreEquivalent(registr, x);
        }
    }
}

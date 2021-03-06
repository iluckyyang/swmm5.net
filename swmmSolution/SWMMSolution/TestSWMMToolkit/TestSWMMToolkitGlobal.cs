﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWMMToolkitWrapper;

namespace TestSWMMToolkit
{
    [TestClass]
    public class TestSWMMToolkitGlobal
    {
        string f1 = "Afshar.inp";
        string f2 = "Afshar.rpt";
        string f3 = "Afshar.out";

        [TestMethod]
        public void TestMethodOpen()
        {
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);

            Assert.AreEqual(0, error);

        }

        [TestMethod]
        public void TestMethodRun()
        {
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Run(f1, f2, f3);

            Assert.AreEqual(0, error);

        }

        [TestMethod]
        public void TestMethodClose()
        {
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);
            error = toolkitSWMM.Close();

            Assert.AreEqual(0, error);

        }
        [TestMethod]
        public void TestMethodGetNodeType()
        {
            int index = 3;
            int Ntype = 1;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);
            error = toolkitSWMM.Start(0);
            error = toolkitSWMM.GetNodeType(index, ref Ntype);

            Assert.AreEqual(0, error);

        }
        [TestMethod]
        public void TestMethodCountObjects()
        {
            int typePipe = 3;
            int typeNodes = 2;
            int countPipes = 0;
            int countNodes = 0;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);
            error = toolkitSWMM.Start(0);
            error = toolkitSWMM.CountObjects(typePipe, ref countPipes);
            error = toolkitSWMM.CountObjects(typeNodes, ref countNodes);

            Assert.AreEqual(0, error);
            Assert.AreEqual(21, countPipes);

        }

        [TestMethod]
        public void TestMethodGetObjectId()
        {
            int type = 3;
            int index = 2;
            string id = "";

            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);
            error = toolkitSWMM.Start(0);

            try
            {
                error = toolkitSWMM.GetObjectId(type, index, ref id);
            }
            catch (Exception myEx)
            {

            }

            Assert.AreEqual(0, error);


        }


        [TestMethod]
        public void TestMethodGetLinkType()
        {
            int Ltype = 3;
            int index = 2;


            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);
            error = toolkitSWMM.Start(0);
            error = toolkitSWMM.GetNodeType(index, ref Ltype);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodGetLinkConnections()
        {

            int index = 4;
            int Node1 = 5;
            int Node2 = 4;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);
            error = toolkitSWMM.Start(0);
            error = toolkitSWMM.GetLinkConnections(index, ref Node1, ref Node2);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodGetNodeParam()
        {

            int index = 3;
            int Param = 1;
            double value = 4;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);
            error = toolkitSWMM.Start(0);
            error = toolkitSWMM.GetNodeParam(index, Param, ref value);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodSetNodeParam()
        {

            int index = 3;
            int Param = 1;
            double value = 1;

            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);

            error = toolkitSWMM.SetNodeParam(index, Param, value);

            Assert.AreEqual(0, error);
        }


        [TestMethod]
        public void TestMethodGetLinkParam()
        {

            int index = 1;
            int Param = 1;
            double value = 2;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);
            error = toolkitSWMM.Start(0);
            error = toolkitSWMM.GetLinkParam(index, Param, ref value);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodSetLinkParam()
        {

            int index = 1;
            int Param = 3;
            double value = 1;
            double elapsedTime = 1;

            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);
            error = toolkitSWMM.Start(0);
            error = toolkitSWMM.Step(ref elapsedTime);

            error = toolkitSWMM.SetLinkParam(index, Param, value);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodGetSubcatchParam()
        {

            int index = 1;
            int Param = 1;
            double value = 2;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);
            //error = toolkitSWMM.Start(0);
            error = toolkitSWMM.GetSubcatchParam(index, Param, ref value);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodGetNodeResult()
        {

            int index = 1;
            int type = 1;
            double result = 2;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);
            error = toolkitSWMM.Start(0);
            error = toolkitSWMM.GetNodeResult(index, type, ref result);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodGetLinkResult()
        {

            int index = 1;
            int type = 1;
            double result = 2;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);
            error = toolkitSWMM.Start(0);
            error = toolkitSWMM.GetLinkResult(index, type, ref result);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodGetSubcatchResult()
        {

            int index = 1;
            int type = 1;
            double result = 2;
            double elapsedTime = 1;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);
            error = toolkitSWMM.Start(0);
            error = toolkitSWMM.Step(ref elapsedTime);
            error = toolkitSWMM.GetSubcatchResult(index, type, ref result);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodSetLinkSetting()
        {

            int index = 1;
            double setting = 1;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);

            error = toolkitSWMM.SetLinkSetting(index, setting);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodGetSimulationUnit()
        {

            int type = 1;
            int value = 1;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);

            error = toolkitSWMM.GetSimulationUnit(type, ref value);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodGetSimulationAnalysisSetting()
        {

            int type = 1;
            int value = 1;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);

            error = toolkitSWMM.GetSimulationAnalysisSetting(type, ref value);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodGetSimulationParam()
        {

            int type = 1;
            double value = 1;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);

            error = toolkitSWMM.GetSimulationParam(type, ref value);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodGetSubcatchOutConnection()
        {

            int type = 1;
            int index = 1;
            int Index = 2;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);

            error = toolkitSWMM.GetSubcatchOutConnection(index, ref type, ref Index);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodSetSubcatchParam()
        {

            int index = 1;
            int Param = 1;
            double value = 2;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);

            error = toolkitSWMM.SetSubcatchParam(index, Param, value);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodSetNodeInflow()
        {

            int index = 1;
            double flowrate = 2;
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);
            //error = toolkitSWMM.Start(0);
            error = toolkitSWMM.Run(f1, f2, f3);

            error = toolkitSWMM.SetNodeInflow(index, flowrate);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodGetLinkDirection()
        {

            int index = 1;
            string value = "";

            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);

            error = toolkitSWMM.GetLinkDirection(index, ref value);

            Assert.AreEqual(0, error);

        }

        [TestMethod]
        public void TestMethodGetSimulationDateTime()
        {

            int timetype = 1;
            string dtimestr = "";

            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);

            error = toolkitSWMM.GetSimulationDateTime(timetype, ref dtimestr);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodSetSimulationDateTime()
        {

            int timetype = 1;
            string dtimestr = "";

            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);

            error = toolkitSWMM.SetSimulationDateTime(timetype, ref dtimestr);

            Assert.AreEqual(0, error);
        }

        [TestMethod]
        public void TestMethodGetCurrentDateTimeStr()
        {

            //int timetype = 1;
            string dtimestr = "";

            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);

            error = toolkitSWMM.GetCurrentDateTimeStr(ref dtimestr);

            Assert.AreEqual(0, error);
        }

    }

}

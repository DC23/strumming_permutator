using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strumming_Permutator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strumming_Permutator.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void _4beats_1subdiv_0skip()
        {
            Assert.AreEqual("1 2 3 4", Form1.GenerateSequence(4, 1));
        }

        [TestMethod]
        public void _4beats_2subdiv_0skip()
        {
            Assert.AreEqual("1 + 2 + 3 + 4 +", Form1.GenerateSequence(4, 2));
        }

        [TestMethod]
        public void _4beats_3subdiv_0skip()
        {
            Assert.AreEqual("1 + a 2 + a 3 + a 4 + a", Form1.GenerateSequence(4, 3));
        }

        [TestMethod]
        public void _4beats_4subdiv_0skip()
        {
            Assert.AreEqual("1 e + a 2 e + a 3 e + a 4 e + a", Form1.GenerateSequence(4, 4));
        }

        [TestMethod()]
        public void _3beats_1subdiv_0skip()
        {
            Assert.AreEqual("1 2 3", Form1.GenerateSequence(3, 1));
        }

        [TestMethod]
        public void _3beats_2subdiv_0skip()
        {
            Assert.AreEqual("1 + 2 + 3 +", Form1.GenerateSequence(3, 2));
        }

        [TestMethod]
        public void _3beats_3subdiv_0skip()
        {
            Assert.AreEqual("1 + a 2 + a 3 + a", Form1.GenerateSequence(3, 3));
        }

        [TestMethod]
        public void _3beats_4subdiv_0skip()
        {
            Assert.AreEqual("1 e + a 2 e + a 3 e + a", Form1.GenerateSequence(3, 4));
        }

        [TestMethod()]
        public void _6beats_1subdiv_0skip()
        {
            Assert.AreEqual("1 2 3 4 5 6", Form1.GenerateSequence(6, 1));
        }

        [TestMethod]
        public void _6beats_2subdiv_0skip()
        {
            Assert.AreEqual("1 + 2 + 3 + 4 + 5 + 6 +", Form1.GenerateSequence(6, 2));
        }


    }
}
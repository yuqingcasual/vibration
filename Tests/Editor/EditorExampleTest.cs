using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using YuQingCasual.Vibration;

namespace YuQingCasual.Vibration.Tests{
    public class EditorExampleTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void Test1()
        {
			Debug.Log(Vibration.AndroidVersion);
            Assert.AreEqual(Vibration.AndroidVersion, 0);
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator Test2()
        {
			// Debug.Log(Vibration.AndroidVersion);
            // Assert.AreEqual(Vibration.AndroidVersion, 0);
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
/**
 *              ______--------___
 *             /|             / |
 *  o___________|_\__________/__|
 * ]|___     |  |=   ||  =|___  |"
 * //   \\    |  |____||_///   \\|"
 * |  X  |\--------------/|  X  |\"
 *  \___/ 2019CakePHPbaker \___/  
 * 
 *
 *
 *@author Rolando<rgarro@gmail.com>
 */
namespace Tests
{
    public class birraEnLaGuacimaTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void birraEnLaGuacimaTestSimplePasses()
        {
            //GameObject tObj = new GameObject();
            //BatComputer b = tObj.addComponent<BatComputer>();//new BatComputer();
            BatComputer b = new BatComputer();
            //Debug.Log(b);
            Assert.That(b.is_testable, Is.EqualTo(true));
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        //[UnityTest]
       /* public IEnumerator birraEnLaGuacimaTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }*/
    }
}

using AmVinDecoderLib.Repositories;
using AmVinDecoderLib.VinComponents.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using vin = AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.UnitTest.Data
{
    [TestClass]
    public class Steering
    {
        [TestMethod]
        public void Lookup_A_ReturnsExpectedValues()
        {
            var result = SteeringRepository.Lookup('A');
            TestValues(result, SteeringPosition.RHD.ToString());
        }

        [TestMethod]
        public void Lookup_B_ReturnsExpectedValues()
        {
            var result = SteeringRepository.Lookup('B');
            TestValues(result, SteeringPosition.LHD.ToString());
        }

        [TestMethod]
        public void Lookup_C_ReturnsExpectedValues()
        {
            var result = SteeringRepository.Lookup('C');
            TestValues(result, SteeringPosition.RHD.ToString());
        }

        [TestMethod]
        public void Lookup_D_ReturnsExpectedValues()
        {
            var result = SteeringRepository.Lookup('D');
            TestValues(result, SteeringPosition.LHD.ToString());
        }

        [TestMethod]
        public void Lookup_E_ReturnsExpectedValues()
        {
            var result = SteeringRepository.Lookup('E');
            TestValues(result, SteeringPosition.RHD.ToString());
        }

        [TestMethod]
        public void Lookup_F_ReturnsExpectedValues()
        {
            var result = SteeringRepository.Lookup('F');
            TestValues(result, SteeringPosition.LHD.ToString());
        }

        [TestMethod]
        public void Lookup_J_ReturnsExpectedValues()
        {
            var result = SteeringRepository.Lookup('J');
            TestValues(result, SteeringPosition.RHD.ToString());
        }

        [TestMethod]
        public void Lookup_K_ReturnsExpectedValues()
        {
            var result = SteeringRepository.Lookup('K');
            TestValues(result, SteeringPosition.LHD.ToString());
        }

        [TestMethod]
        public void Lookup_L_ReturnsExpectedValues()
        {
            var result = SteeringRepository.Lookup('L');
            TestValues(result, SteeringPosition.RHD.ToString());
        }

        [TestMethod]
        public void Lookup_M_ReturnsExpectedValues()
        {
            var result = SteeringRepository.Lookup('M');
            TestValues(result, SteeringPosition.LHD.ToString());
        }

        private void TestValues(vin.Steering actual, string expectedText)
        {
            Assert.IsNotNull(actual);

            Assert.AreEqual(expectedText, actual.Text);
        }
    }
}

using CylinderProject.Models;

namespace CylinderTest
{
    public class UnitTest1
    {
        [Fact]
        public void IsValidConstructor()
        {
            Cylinder cylinder = new Cylinder(10, 20);
            Assert.Equal(10, cylinder.Radius);
            Assert.Equal(20, cylinder.Height);
        }

        [Fact]
        public void ThrowsException() 
        {
            Assert.Throws<ArgumentException>(() => new Cylinder(-10,1));
            Assert.Throws<ArgumentException>(() => new Cylinder(1,-10));
            Assert.Throws<ArgumentException>(() => new Cylinder(0,0));
        }

        [Fact]
        public void AreMethodsCorrect()
        {
            Cylinder cylinder = new Cylinder(10, 20);
            Assert.Equal(Math.PI * Math.Pow(10,2) * 20, cylinder.GetVolume());
            Assert.Equal(2 * Math.PI * Math.Pow(10, 2) + 2 * Math.PI * 10 * 20, cylinder.GetSurfaceArea());
        }

        [Fact]
        public void isResizeValid()
        {
            Cylinder cylinder = new Cylinder(10, 20);
            cylinder.Resize(20, 40);
            Assert.Equal(20, cylinder.Radius);
            Assert.Equal(40, cylinder.Height);

            Assert.Throws<ArgumentException>(() => cylinder.Resize(0, -5) );
            Assert.Throws<ArgumentException>(() => cylinder.Resize(-5,0) );
            Assert.Throws<ArgumentException>(() => cylinder.Resize(0,0) );
        }

        [Fact]
        public void CheckNull()
        {
            Cylinder cylinder = new Cylinder(10, 20);
            Assert.NotNull( cylinder );
        }

        [Fact]
        public void IsRadiusInRange()
        {
            Cylinder cylinder = new Cylinder(10, 20);
            Assert.InRange(cylinder.Radius, 1, 100);
        }
    }
}
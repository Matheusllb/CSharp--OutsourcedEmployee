using System.Text;

namespace OutSourcedEmployee
{
    public class OutsourcedEmployee : Employee
    {
        public double AdditionalCharger { get; protected set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharger) : base(name, hours, valuePerHour)
        {
            AdditionalCharger = additionalCharger;
        }

        public override double Payment()
        {
            return Hours * ValuePerHour + AdditionalCharger * 1.1;
        }

    }
}

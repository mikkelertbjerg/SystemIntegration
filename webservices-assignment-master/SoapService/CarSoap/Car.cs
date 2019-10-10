using System.Runtime.Serialization;
using System.Web.UI.WebControls;
using CarSoap.ServiceReference1;

namespace CarSoap
{
    [DataContract(Name = "CarType")]
    public enum CarType
    {
        [EnumMember]
        A,
        [EnumMember]
        B,
        [EnumMember]
        C,
        [EnumMember]
        D,
        [EnumMember]
        E,
        [EnumMember]
        F
    }
    [DataContract]
    public class Car
    {
        ServiceReference1.IService1 a = new Service1Client();
        public Car(string licensePlate, CarType type)
        {
            LicensePlate = licensePlate;
            Type = type;
            
        }

        [DataMember]
        public string LicensePlate { get; set; }
        [DataMember]
        public CarType Type { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        bool AddAdmin(admin u);

        [OperationContract]
        bool AddAdvertiser(Advertiser ad);

        [OperationContract]
        bool AddOffer(offer u);

        [OperationContract]
        bool AddRecepie(Recepie u);

        [OperationContract]
        Recepie getRandomRecepie();

        [OperationContract]
        List<Recepie> searchByIngredients(String i);

        [OperationContract]
        List<Recepie> searchByCategory(String c);

        [OperationContract]
        List<Recepie> searchBynutritions(String n);

        [OperationContract]
        bool AddUser(string name, string email, string password, string phone);

        [OperationContract]
        DietPlan generatDietplan();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

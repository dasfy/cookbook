using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

	[OperationContract]
	List<string> GetIngred();

	[OperationContract]
	List<string> GetMeasure();

	[OperationContract]
	List<string> GetAutor();

	[OperationContract]
	List<string> GetKitchen();

	[OperationContract]
	List<string> GetHowto();

	[OperationContract]
	List<string> Test();

	[OperationContract]
	void AddRecept(string name, string autor, string kitchen, string howto, string category, string description, string calories,
						   string ingred1, int measurec1, string measure1, string ingred2 = "", int measurec2 = -1, string measure2 = "",
						   string ingred3 = "", int measurec3 = -1, string measure3 = "", string ingred4 = "", int measurec4 = -1, string measure4 = "",
						   string ingred5 = "", int measurec5 = -1, string measure5 = "");
}

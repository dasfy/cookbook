﻿using System;
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
	void AddRecept();
}

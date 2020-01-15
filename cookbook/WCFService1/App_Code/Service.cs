﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	DB db = new DB();

	public List<string> GetIngred()
	{
		return db.GetIngreds();
	}

	public List<string> GetMeasure()
	{
		return db.GetMeasures();
	}

	public List<string> GetAutor()
	{
		return db.GetAutors();
	}
}

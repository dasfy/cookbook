using System;
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

	public List<string> GetKitchen()
	{
		return db.GetKitchens();
	}

	public List<string> GetHowto()
	{
		return db.GetHowtos();
	}

	public List<string> Test()
	{
		return db.Tests();
	}

	public void AddRecept(string name, string autor, string kitchen, string howto, string category, string description, string calories,
						   string ingred1, int measurec1, string measure1, string ingred2 = "", int measurec2 = -1, string measure2 = "",
						   string ingred3 = "", int measurec3 = -1, string measure3 = "", string ingred4 = "", int measurec4 = -1, string measure4 = "",
						   string ingred5 = "", int measurec5 = -1, string measure5 = "")
	{
		db.AddRecepts(name, autor, kitchen, howto, category, description, calories, ingred1, measurec1, measure1,
						ingred2, measurec2, measure2, ingred3, measurec3, measure3, ingred4, measurec4, measure4,
						ingred5, measurec5, measure5);
	}
}

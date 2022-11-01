using System;
using System.Linq;
using System.Collection.Generic;
using System.Text;
using System.Threading.Tasks;
namespace{
	interface Employee()
	{
		void CalculateSalary1();
		void Allowances1();
	}
	class Manager:Employee{
		
		double Salary,PetrolAllo,FoodAllo,OtherAllo;
		double GrossSalary=Salary+PetrolAllo+FoodAllo+OtherAllo;
		public override Allowances1()
		{
			Console.WriteLine("Enter Salary Datails:");
			this.Salary=Convert.ToDouble(Console.ReadLine());
			this.PetrolAllo=Convert.ToDouble(Console.ReadLine());
			this.FoodAllo=Convert.ToDouble(Console.ReadLine());
			this.OtherAllo=Convert.ToDouble(Console.ReadLine());
			this.GrossSalary=Convert.ToDouble(Console.ReadLine());
		}
		
		public override CalculateSalary1()
		{
			Console.WriteLine("Salary Details are:")
			Console.WriteLine("Salary:"+this.Salary);
			Console.WriteLine("Petrol Allowances:"+this.PetrolAllo);
			Console.WriteLine("Food Allowances:"+this.FoodAllo);
			Console.WriteLine("Other Allowances:"+this.OtherAllo);
			Console.WriteLine("Gross Salary:"+this.GrossSalary);
			
			}
	}
	class MarketingExe:Manager
	{
				double KelometerTravel;
		double TourAllow=KelometerTravel*5;
		double TelephoneAllow=1000.00;
	public void Allowances()
	{
		Console.WriteLine("MarketingExe Detail:")
		Console.WriteLine("Enter KelometerTravel");
		this.KilometerTravel=Convert.ToDouble(Console.ReadLine());
		this.TourAllow=Convert.ToDouble(Console.ReadLine());
		this.TelephoneAllow=Convert.ToDouble(Console.ReadLine());
	}
	public void Calculate()
	{
		Console.WriteLine("Allowances Details:")
		Console.WriteLine("Distance Travel per Kilometer:"+this.KilometerTravel);
		Console.WriteLine("Tour Allowances:"+this.TourAllow);
		Console.WriteLine("Telephone Allowances:"+this.TelephoneAllow);
		
	}
	}
     Class AllowancesDetails{
		static void Main(string[] args){
			MarketingExe M1=new MaerketingExe();
			M1.Allowances1();
			M1.CalculateSalary1();
			M1.Allowances();
			M1.Calculate();
			Console.ReadLine();
		} 
		 
	 }
}
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collection.Generics;

namespace LitwareSoltion{
	class Emlpoyee{
		int EmpNo;
		string EmpName;
		int EmpSalary;
		 
		 public void Info()
		 {
			 Console.WriteLine("Enter the Emp Details");
			 this.EmpNo=Convert.ToInt32(Console.ReadLine());
			 this.EmpName=Console.ReadLine();
			 this.EmpSalary=Convert.ToInt(Console.ReadLine()); 
		 }
		 public void DispalyData()
		 {
			 Console.WriteLine("Employee Details:")
			 Console.WriteLine("Employee Name:"+ this.EmpName);
			 console.WriteLine("Employee no:"+ this.EmpNo);
			 Console.WriteLine("Emlpoyee Salary:"+ this.EmpSalary);
		 }

}
    public class Salary:Employee
	{
		
        double HRA;
	    double DA;
	    double TA;
	    double TDS;
	    double NetSalary;
		double GrossSalary;
	 
	 public void SalaryInfo()
	 {
		 if(Salary<5000){
		Console.WriteLine"HRA:"+ 0.1*Salary);
		HRA=Convert.ToDouble(Console.ReadLine());
		Console.ReadLine("DA:"+0.05*Salary);
		DA=Convert.TODouble(Console.ReadLine());
		Console.WriteLine("TA:"+0.15*Salary);
		TA=Convert.Todouble(Console.Readline());
		Console.WriteLine("Gross Salary:"+ Salary+HRA+TA+DA);
         GrossSalary=Convert.ToDouble(Console.ReadLine());
		 Console.WriteLine("PF:"+0.1*GrossSalary);
		 PF=Convert.ToDouble(Console.Read());
		 Console.WriteLine("TDS:"+GrossSalary*0.18);
		 TDS=Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Net Salary:"+GrossSalary-(PF+TDS))
        NetSalary=Convert.ToDouble(Console.ReadLine());		 
		 }
		 else if(Salary<1000)
		 {
			 
		Console.WriteLine"HRA:"+ 015*Salary);
		HRA=Convert.ToDouble(Console.ReadLine());
		Console.ReadLine("DA:"+0.1*Salary);
		DA=Convert.TODouble(Console.ReadLine());
		Console.WriteLine("TA:"+0.2*Salary);
		TA=Convert.Todouble(Console.Readline());
		Console.WriteLine("Gross Salary:"+ Salary+HRA+TA+DA);
         GrossSalary=Convert.ToDouble(Console.ReadLine());
		 Console.WriteLine("PF:"+0.1*GrossSalary);
		 PF=Convert.ToDouble(Console.Read());
		 Console.WriteLine("TDS:"+GrossSalary*0.18);
		 TDS=Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Net Salary:"+GrossSalary-(PF+TDS))
        NetSalary=Convert.ToDouble(Console.ReadLine());		 
		 }
		 else if(Salary<15000)
		 {
			 if(Salary<15000){
		Console.WriteLine"HRA:"+ 0.2*Salary);
		HRA=Convert.ToDouble(Console.ReadLine());
		Console.ReadLine("DA:"+0.15*Salary);
		DA=Convert.TODouble(Console.ReadLine());
		Console.WriteLine("TA:"+0.25*Salary);
		TA=Convert.Todouble(Console.Readline());
		Console.WriteLine("Gross Salary:"+ Salary+HRA+TA+DA);
         GrossSalary=Convert.ToDouble(Console.ReadLine());
		 Console.WriteLine("PF:"+0.1*GrossSalary);
		 PF=Convert.ToDouble(Console.Read());
		 Console.WriteLine("TDS:"+GrossSalary*0.18);
		 TDS=Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Net Salary:"+GrossSalary-(PF+TDS))
        NetSalary=Convert.ToDouble(Console.ReadLine());		 
		 }
		 else if(Salary<20000)
		 {
			
		Console.WriteLine"HRA:"+ 0.25*Salary);
		HRA=Convert.ToDouble(Console.ReadLine());
		Console.ReadLine("DA:"+0.2*Salary);
		DA=Convert.TODouble(Console.ReadLine());
		Console.WriteLine("TA:"+0.3*Salary);
		TA=Convert.Todouble(Console.Readline());
		Console.WriteLine("Gross Salary:"+ Salary+HRA+TA+DA);
         GrossSalary=Convert.ToDouble(Console.ReadLine());
		 Console.WriteLine("PF:"+0.1*GrossSalary);
		 PF=Convert.ToDouble(Console.Read());
		 Console.WriteLine("TDS:"+GrossSalary*0.18);
		 TDS=Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Net Salary:"+GrossSalary-(PF+TDS))
        NetSalary=Convert.ToDouble(Console.ReadLine());		 
		 }
		 else if(Salary>=20000)
		 {
			
		Console.WriteLine"HRA:"+ 0.3*Salary);
		HRA=Convert.ToDouble(Console.ReadLine());
		Console.ReadLine("DA:"+0.25*Salary);
		DA=Convert.TODouble(Console.ReadLine());
		Console.WriteLine("TA:"+0.35*Salary);
		TA=Convert.Todouble(Console.Readline());
		Console.WriteLine("Gross Salary:"+ Salary+HRA+TA+DA);
         GrossSalary=Convert.ToDouble(Console.ReadLine());
		 Console.WriteLine("PF:"+0.1*GrossSalary);
		 PF=Convert.ToDouble(Console.Read());
		 Console.WriteLine("TDS:"+GrossSalary*0.18);
		 TDS=Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Net Salary:"+GrossSalary-(PF+TDS))
        NetSalary=Convert.ToDouble(Console.ReadLine());		 
		 }
	 }
	
		
		}
		public Class INFORMATION
		{
			static void Main(String[] args){
				Salary S1 = new Salary();
             s1.Info();
             s1.DisplayData();
             s1.SalaryInfo();
             Console.Readline();			 
			}
				}		
    
}

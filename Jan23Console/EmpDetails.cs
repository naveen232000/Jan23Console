using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan23Console
{
    public class EmpDetails
    {
       
        public static void DisplayEmp() {
            try {
                using (EmployeeEntities1 myData = new EmployeeEntities1())
                {
                    List<EmployeeDetail> emp = myData.EmployeeDetails.ToList();
                    //Console.WriteLine("Enter employee id :");
                    //int n=int.Parse(Console.ReadLine());
                    foreach (EmployeeDetail ed in emp)
                    {

                       // if (ed.empId == n){
                            Console.WriteLine($"{ed.empId}\t{ed.empName}\t{ed.salary}\t{ed.city}\t{ed.SysNum}");
                        //}

                    }
                }
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Bank ATM";
            string bankImage = @"
                            ..]OOoo\`.                   
                        ..]OO/`*****[OoO].               
                    .,]OO/`,]]*]*],]]]]*[OoO].           
                .,/OO/`*****@@=\^=\^=\`*****,\oO]..      
              =Oo`ooOOOOOOOOOOOOOOOOOOOOOOOOOOoo^,\O     
                =[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[`       
                 =ooooO@@@Ooooo@@@@oOoOo@@@@ooooO        
                  .,O@@@@@@.\O@@@@@^=O@@@@@@^,O@         
                  .*O@@@@@@.=O@@@@@^=O@@@@@@^*O@         
                  .*O@@@@@@.=O@@@@@^=O@@@@@@^*O@         
                  .*O@@@@@@.=O@@@@@^=O@@@@@@^*O@         
                  .*O@@@@@@.=O@@@@@^=O@@@@@@^*O@         
                  .*O@@@@@@./O@@@@@^=O@@@@@@^*O@         
                  *oO@@@@@^*oO@@@@@^=OO@@@@@*=O@^        
                 ********************************.       
               .[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[..     
              ......,[[[[[[[[[[[[[[[[[[[[[[[[`*.....     
            ";
            Console.WriteLine(bankImage);
            Console.WriteLine("Welcome to the bank.\n"+
                              "New User: 0\n"+
                              "Login: 1");
            var inputOperation = Convert.ToByte(Console.ReadLine());

            var operation = new UserOperation();

            switch (inputOperation)
            {
                case 0:
                    operation.UserCreate();
                    break;
                case 1:
                    operation.UserLogin();
                    break;
                default:
                    break;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Permission_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add 4 users with none permissions (Admin, operator, manager,senior)
            User operatorUser = new User("operator");
            User SeniorUser = new User("senior");
            User managerUser = new User("manager");
            User adminUser = new User("admin");
            /**
             * 
             * Add read permission to operatorUser look at line 25 to line 31
             * Add read, write, execute permissions to manager
             * Add read, write permissions to senior
             * Add full permission(read,write,execution) to admin
             */
            operatorUser.AddPermission(Permissions.Read);
            if(operatorUser.HasPermission(Permissions.Read))
                Console.WriteLine("Operator has read permission");
            else
                Console.WriteLine("Operator does not have read permission");

            managerUser.multiplyPermission(Permissions.Read, Permissions.Write);
            managerUser.AddPermission(Permissions.Execute);

            SeniorUser.multiplyPermission(Permissions.Read, Permissions.Write);

            adminUser.multiplyPermission(Permissions.Read, Permissions.Write);
            adminUser.AddPermission(Permissions.Execute);

            SeniorUser.RemovePermission(Permissions.Write);

            SeniorUser.RemovePermission(Permissions.Write);

            Console.WriteLine($"Does Senior have write: {SeniorUser.HasPermission(Permissions.Write)}");
            Console.WriteLine($"Does Manager have execute: {managerUser.HasPermission(Permissions.Execute)}");

            Permissions full = Permissions.Read | Permissions.Write | Permissions.Execute;
            Console.WriteLine($"Admin has full permissions: {adminUser.HasPermission(full)}");

            /**
             * Look at tasks description in lab3.1 and complete the remaining tasks
             */
            
            


        }
    }
}

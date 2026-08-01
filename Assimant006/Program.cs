namespace Assimant006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01(a)
            // Copying a struct (Value type ) creates complete,independent copy of the Data
            //Modifying a new Copy is Created on the stack
            #endregion

            #region Question01(b)
            //copying a Class (Refreence Type) refer to the same object in the heap
            //Modifying in the object through one variable will affect the other
            #endregion

            #region Question02(a)
            //Problems Is:
            //Public Fields Exposure:
            //1:The struct uses ⁠public fields⁠(⁠Description⁠, ⁠Weight⁠, ⁠DeliveryFee⁠) instead of 
            //properties, exposing internal data directly to the outside code.
            //2:No Data Validation:
            //   There is no way to validate the data, allowing invalid or logical errors like negative values 
            //    for ⁠Weight⁠ or ⁠DeliveryFee⁠.
            //3:loss of  Access Control:
            //   It loss control over read/write permissions (For Example:preventing external code from modifying
            //   values after creation or making fields read-only).
            #endregion

            #region Question02(b)
            // 1:Enables data validation
            ///The public properties it provides us with parts called { get,set} we can write a condition
            //inside it like(for) to reject any incorrect data such as negative values for weight or fess,
            // for example
            //2:Controlled Access permissions
            // properties it lets us control who does what for example we use(get,private set) To make
            //The data readable from outside but modifiable only from within the struct it self.
            // 3:Data protection$ Encapsolution
            //Making variable private hides internal data from direct modification from outside the code
            //forcing anyone interacting with them to go through protected properties first.
            #endregion

            #region part02(1)
            //DeliveryAddress add01 = new DeliveryAddress()
            //{
            //    city = "cairo",
            //    street = "Elhram",
            //    buildingNumber = 50
            //};

            //DeliveryAddress add02 = new DeliveryAddress()
            //{
            //    city = "tanta",
            //    street = "taha elhkeem",
            //    buildingNumber = 30
            //};
            //Console.WriteLine("Before change====");
            //Console.WriteLine(add01);
            //Console.WriteLine(add02);
            //add02 = add01;
            //Console.WriteLine("After  change======");
            //Console.WriteLine(add01);
            //Console.WriteLine(add02);
            #endregion

            
          
            



        


        }
    }
}

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
        }
    }
}

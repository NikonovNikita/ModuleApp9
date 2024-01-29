using System.Data;
using Task1;
class Program
{
    static void Main(string[] args)
    {
        Exception[] exceptions =
        {
            new MyException("Произошло непредвиденное исключение"),
            new ArgumentException(),
            new ArgumentNullException(),
            new ArgumentOutOfRangeException(),
            new TimeoutException()
        };

        foreach (var exception in exceptions)
        {
            try
            {
                throw exception;
            }
            catch (Exception ex) when (ex is MyException)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) when (ex is ArgumentException)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) when (ex is ArgumentNullException)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) when (ex is ArgumentOutOfRangeException)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) when (ex is TimeoutException)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}

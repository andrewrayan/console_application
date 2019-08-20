using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleappliation
{
    class Practise
    {
        public string stringValue = @"7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
        public int MaxSeries()
        {
            List<int> productList =new List<int>();
            for(int i = 0; i < stringValue.Length; i++)
            {
                var count = (i + 4) >= stringValue.Length? stringValue.Length : i + 4;
                var product = 1;
                for(int j = i; j < count; j++)
                {
                    int val = int.Parse(stringValue[j].ToString());
                    product *= val;
                }
                productList.Add(product);
            }
            return productList.Max();
        }

        public int SmallestMultiple()
        {
            int number = 20;
            
            while (true)
            {
                bool isTrue = true;
                for(int i = 1; i <= 20; i++)
                {
                    if (number % i != 0)
                    {
                        isTrue = false;
                        break;
                    }
                }
                if (isTrue)
                {
                    return number;
                }
                else
                {
                    number += 10;
                }
                
            }
        }

        public List<int> SumOfPrime(int count)
        {
            List<int> listOfPrime = new List<int>();
            int countOfPrime = 0;
            int number = 1;
            while (countOfPrime != count)
            {
                if (CheckIfPrime(number))
                {
                    listOfPrime.Add(number);
                    countOfPrime++;
                }
                number++;
            }
            return listOfPrime;
        }

        public bool CheckIfPrime(int number)
        {
            bool isPrime = true;
            if (number > 1)
            {
                for(int i = 2; i < number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                return isPrime;
            }
            else
            {
                return false;
            }
        }

        public void PrimeList(List<int> list)
        {
            foreach(int val in list)
            {
                Console.WriteLine(val);
            }
        }

        public void MissingInteger(int[] list)
        {
            int start = list[0];
            for(int i = 0; i < list.Length; i++)
            {

                int number = i + start;
                if (list[i] != number)
                {
                    Console.WriteLine(number);
                    break;
                }
            }
        }

        public void MinimumDistance(int[] arr,int num1,int num2)
        {
            int min_number = arr.Length;
            for(int i = 0; i < arr.Length-1; i++)
            {
                for(int j = i + 1;j< arr.Length; j++)
                {
                    if((arr[i]==num1 && arr[j]==num2) || (arr[j] == num1 && arr[i] == num2) && min_number > (j - i))
                    {
                        min_number = j - i;
                    }
                }
            }
            Console.WriteLine(min_number);
        }

        public void ArrayInLeader(int[] arr)
        {
            ArrayList list = new ArrayList();
            for(int i = 0; i < arr.Length - 1; i++)
            {
                bool isGreater = true;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        isGreater = false;
                        break;
                    }
                }
                if (isGreater)
                {
                    list.Add(arr[i]);
                }
            }

            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }

        public void MajorityElement(int[] arr)
        {
            if (arr.Length > 0)
            {
                for(int i = 0; i < arr.Length - 1; i++)
                {
                    int count = 1;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                    if (count > (arr.Length / 2))
                    {
                        Console.WriteLine("{0} is the majority element", arr[i]);
                        break;
                    }
                }
            }
        }

        public bool Palindrome(string input)
        {

            int i,j, count = input.Length;
                for (i = 0, j = count - 1; i < count / 2; i++, j--)
                {
                    if (input[i] != input[j])
                    {
                        return false;
                    }
                }
            return true;
        }

        public string Triangle(int row)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i< row; i++)
            {
                for(int first = row-1; first >= 0; first--)
                {
                    if (first <= i)
                    {
                        sb.Append("*");
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }
                for (int second = 0; second < i; second++)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }

        public void PascalTriangle(int row)
        {

        }
    }
}

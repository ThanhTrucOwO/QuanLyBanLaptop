using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Number
    {
        
        public static bool isNumber(string s)
        {
            try
            {
                if(int.Parse(s) <0)
                    return false;
            }catch(Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool isFloat(string s)
        {
            try
            {
                if (float.Parse(s) < 0)
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static int MaxNumber(List<int> listInt)
        {
            int max = 0;
            if (listInt.Count != 0)
                max = listInt[0];
            for(int i = 1; i < listInt.Count; i++)
            {
                if(listInt[i] > max)
                {
                    max = listInt[i];
                }
            }
            return max;
        }
        public static string changeMoney(string total)
        {
            
            string totalR = "";
            if(total.Length < 3)
                return total;
            for (int i = total.Length - 1; i > 1;)
            {
                string temp = total.Substring(i - 2, 3);

                temp = "," + temp;
                totalR = temp + totalR;
                i = i - 3;
            }
            int coutD = total.Length % 3;
            if (coutD >0)
            {
                totalR = total.Substring(0, coutD) + totalR;
            }
            else
            {
                totalR = totalR.Substring(1);
            }
            return totalR;
        }
    }
}

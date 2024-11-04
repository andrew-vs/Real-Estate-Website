using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillowLibrary
{
    public class Validate
    {
        public Boolean ValidateAgentInput(ArrayList input)
        {

            for(int i = 0; i < input.Count; i++)
            {
                if (input[i].ToString() == "")
                {
                    return false;
                }
            }

            return true;
        }

        public string ValidateNumbers(List<string> inputs)
        {
            ArrayList result = new ArrayList();
            string returnString = "";
            for (int i = 0; i < inputs.Count; i++)
            {
                if (double.TryParse(inputs[i].ToString(), out double parsed))
                {
                    // The value can be converted to a double

                }
                else
                {
                    // The value is not a valid double
                    result.Add(inputs[i]);

                }


            }
            if (result.Count == 1)
            {
                return result[0].ToString() + " is not a valid number";
            }
            else if (result.Count > 1)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (i == result.Count - 1)
                    {
                        returnString += "and " + result[i].ToString();
                    }
                    else
                    {
                        returnString += result[i].ToString() + ", ";
                    }

                }
                return returnString += " are not valid numbers";
            }
            else
            {
                return "";
            }
        }
        public Boolean ValidateHomeInputs(List<string> inputs)
        {
            Boolean ok = true;
            for (int i = 0; i < inputs.Count; i++)
            {
                if (inputs[i] == "" || inputs[i] == "Select")
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

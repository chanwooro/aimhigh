using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Data;

 
namespace QnA
{
    class Calculator
    {

        public static string displayResult;
        private static string equation;
        public string DisplaySubstitue(string contentData, List<MainStaff.VariableData> listVariables)
        {
            displayResult = contentData;
            
            foreach (var listComponents in listVariables)
            {
                //User 들이 문재 만들때 variable declare 를 {x} 이런식으로 하게 할꺼다
                
                string variableChecker = "{" + listComponents.variable + "}";
                if (displayResult.Contains(variableChecker))
                {

                    //Replacing variable in user entered text by using regex
                    string displayRandom = listComponents.variable + "=" + (listComponents.value).ToString("0.###");

                    Regex rgx = new Regex(variableChecker);
                    displayResult = rgx.Replace(displayResult, displayRandom);
              

                }



            }
            
            return displayResult;
        }

        public List<MainStaff.VariableData> getQuestionWithRandomNumbers(string q)
        {
            List<MainStaff.VariableData> dataCollection = new List<MainStaff.VariableData>();
            Regex rgx = new Regex("^[0-9]+$");
            if (q != "")
            {                
                //Start: x=3~6 y=5
                // str[0] = "x=3~6" | str[1] = "y=5"                
                q = q.Replace(" ", String.Empty);
                string[] str = q.Split(',');
                foreach (var item in str)
                {
                    if (item.Contains('='))
                    {
                        
                        double randomNumber = 0;
                        Random random = new Random();
                        //str[0] 같은 경우 data[0] = "x" | data[1] = "3~6"
                        string[] data = item.Split('=');


                        if (data[1].Contains("~"))
                        {
                            try
                            {
                                double[] randomRange = data[1].Split('~').Select(double.Parse).ToArray();
                                double randomMin = randomRange[0];
                                double randomMax = randomRange[1];
                                randomNumber = randomMin + random.NextDouble() * (randomMax - randomMin);
                                double generatedNumber = Math.Round(randomNumber, 3);
                                //Random generated double
                                dataCollection.Add(new MainStaff.VariableData(data[0], generatedNumber));
                            }
                            catch
                            {


                            }

                        }
                        else if (rgx.IsMatch(data[1]))
                        {
                            double generatedNumber = double.Parse(data[1]);
                            dataCollection.Add(new MainStaff.VariableData(data[0], generatedNumber));
                        }
                    }
                }
                return dataCollection;
            }
            else
            {
                return dataCollection;
            }
        }

        private string replaceKeyword(string eq, string keyword, string value)
        {
            string equation = eq;
            Console.WriteLine("Keyword:" + keyword + ".");
            Console.WriteLine("Replacement:" + value + ".");
            if (equation.Contains(keyword + "+")) equation = equation.Replace(keyword + "+", value + "+");
            if (equation.Contains(keyword + "-")) equation = equation.Replace(keyword + "-", value + "-");
            if (equation.Contains(keyword + "/")) equation = equation.Replace(keyword + "/", value + "/");
            if (equation.Contains(keyword + "*")) equation = equation.Replace(keyword + "*", value + "*");
            if (equation.Contains("+" + keyword)) equation = equation.Replace("+" + keyword, "+" + value);
            if (equation.Contains("-" + keyword)) equation = equation.Replace("-" + keyword, "-" + value);
            if (equation.Contains("*" + keyword)) equation = equation.Replace("*" + keyword, "*" + value);
            if (equation.Contains("/" + keyword)) equation = equation.Replace("/" + keyword, "/" + value);
            if (equation.Contains("(" + keyword)) equation = equation.Replace("(" + keyword, "(" + value);
            if (equation.Contains(keyword + ")")) equation = equation.Replace(keyword + ")", value + ")");
            else equation = equation.Replace(keyword, value);
            Console.WriteLine("Final equation: " + equation);
            return equation;
        }

        public string getAnswer(string eq, List<MainStaff.VariableData> listVariables)
        {   
            equation = eq.Replace(" ", String.Empty); // cos(5)+6*7
            equation = ConverterTrig(equation); // To allow sin in both upper and lower cases
            foreach (var data in listVariables)
            {
                equation = replaceKeyword(equation, data.variable.ToString(), data.value.ToString("0.###"));
            }
            
            if (equation.Contains("COS") || equation.Contains("SIN") || equation.Contains("TAN"))
            {                
                equation = trigometry(equation);

            }
            if (equation.Contains("POW"))
            {
                equation = PowerSolver(equation);
            }
            // double generatedNumber = Math.Round(randomNumber, 3);
            Console.WriteLine("EQUATION :" + equation);
            string result = new DataTable().Compute(equation, null).ToString();
            double doubleResult = double.Parse(result, CultureInfo.InvariantCulture);
            doubleResult = Math.Round(doubleResult, 3);
            Console.WriteLine("result :"+ doubleResult);
            return doubleResult.ToString("0.###");            
        }

        private string ConverterTrig(string x){
            string eq = x;
            string[] trig = new string[] { "sin", "cos", "tan", "pow" };
            if (eq.Contains("cos") || eq.Contains("sin") || eq.Contains("tan") || eq.Contains("pow"))
            {
                foreach (var small in trig)
                {
                    string upper = small.ToUpper();
                    eq = eq.Replace(small, upper);

                }

            }
           
            return eq;
        }

        public string trigometry(string eq)
        {
            string x = eq;
            Console.WriteLine("what is x?" + x);
            while (x.Contains("SIN") || x.Contains("COS") || x.Contains("TAN"))
            {
                if (x.Contains("SIN"))
                {
                    x = replaceTrigInside(x, "SIN(");
                }
               
                if (x.Contains("COS"))
                {
                    x = replaceTrigInside(x, "COS(");
                }
                if (x.Contains("TAN"))
                {
                    x = replaceTrigInside(x, "TAN(");
                }
                while (x.Contains("POW"))
                {
                    x = PowerSolver(x);

                }
                
            }
            return x;
        }


        private static string replaceTrigInside(string input, string Trigfunction)
        {
            string eq = input;
            Console.WriteLine("Function triggered: " + Trigfunction);
            int firstOccurence = input.IndexOf(Trigfunction);
            if (firstOccurence == -1) return ""; // if SIN is not found
            int count = 1;
            int finalIndex = 0;
            for (int i = firstOccurence + 4; i < input.Length; i++)
            {
                if (input.Substring(i, 1) == "(") count++;
                else if (input.Substring(i, 1) == ")") count--;
                if (count == 0)
                {
                    finalIndex = i;
                    break;
                }
            }

            if (count > 0)
            {
                // Bracket number not matching. Must give a error box to user to tell them you are fucked.
                Console.WriteLine("Brackets are not closed properly");
                return "";
            }

            string frag = input.Substring(firstOccurence + 4, finalIndex - (firstOccurence + 4));
            Console.WriteLine("frag :" + frag);
            if (frag.Contains("POW"))
            {
                while (frag.Contains("POW"))
                {
                    frag = PowerSolver(frag);
                    eq = eq.Replace(input.Substring(firstOccurence + 4, finalIndex - (firstOccurence + 4)), frag);
                    Console.WriteLine("equation: " + eq);
                    finalIndex = frag.Length + firstOccurence + 4;
                }
                Console.WriteLine("output :" + frag);

            }

            Console.WriteLine("First: " + firstOccurence.ToString() + " Last: " + finalIndex.ToString());
            Console.WriteLine("WRITE EQU :"+eq.Substring(firstOccurence + 4, finalIndex - (firstOccurence + 4)));
            string result = new DataTable().Compute(eq.Substring(firstOccurence + 4, finalIndex - (firstOccurence + 4)), null).ToString();
            double doubleResult = double.Parse(result, CultureInfo.InvariantCulture);
            if (Trigfunction.Contains("SIN")) doubleResult = Math.Round(Math.Sin(doubleResult), 3);
            if (Trigfunction.Contains("COS")) doubleResult = Math.Round(Math.Cos(doubleResult), 3);
            if (Trigfunction.Contains("TAN")) doubleResult = Math.Round(Math.Tan(doubleResult), 3);
            return eq.Replace(Trigfunction + eq.Substring(firstOccurence + 4, finalIndex - (firstOccurence + 4)) + ")", doubleResult.ToString());

        }

        private static string PowerSolver(string input)
        {
            string eq = input;
            int firstOccurence = input.IndexOf("POW(");
            if (firstOccurence == -1) return ""; // if SIN is not found
            int count = 1;
            int finalIndex = 0;
            for (int i = firstOccurence + 4; i < input.Length; i++)
            {
                if (input.Substring(i, 1) == "(") count++;
                else if (input.Substring(i, 1) == ")") count--;
                if (count == 0)
                {
                    finalIndex = i;
                    break;
                }
            }
            if (count > 0)
            {
                // Bracket number not matching. Must give a error box to user to tell them you are fucked.
                Console.WriteLine("Brackets are not closed properly");
                return "";
            }

            string frag = input.Substring(firstOccurence + 4, finalIndex - (firstOccurence + 4));
            Console.WriteLine("INPUT SUBSTRING :" + input.Substring(firstOccurence + 4, finalIndex - (firstOccurence + 4)));
            if (frag.Contains("SIN") || frag.Contains("COS") || frag.Contains("TAN"))
            {
                while (frag.Contains("SIN") || frag.Contains("COS") || frag.Contains("TAN"))
                {
                    if (frag.Contains("SIN"))
                    {
                        frag = replaceTrigInside(frag, "SIN(");
                    }
                    Console.WriteLine("POW(SIN) :" + frag);
                    if (frag.Contains("COS"))
                    {
                        frag = replaceTrigInside(frag, "COS(");
                    }
                    Console.WriteLine("POW(SIN) :" + frag);
                    if (frag.Contains("TAN"))
                    {
                        frag = replaceTrigInside(frag, "TAN(");
                    }
                    Console.WriteLine("EQ SUB :" + eq.Substring(firstOccurence + 4, finalIndex - (firstOccurence + 4)));
                    eq = eq.Replace(eq.Substring(firstOccurence + 4, finalIndex - (firstOccurence + 4)), frag);
                    Console.WriteLine("POW(SIN) :" + frag);

                }


            }
            else if (input.Substring(firstOccurence + 4, finalIndex - (firstOccurence + 4)).Contains("POW"))
            {
                while (frag.Contains("POW"))
                {
                    frag = PowerSolver(frag);
                    eq = eq.Replace(eq.Substring(firstOccurence + 4, finalIndex - (firstOccurence + 4)), frag);
                    finalIndex = frag.Length + firstOccurence + 4;
                    Console.WriteLine("Frag :" + frag);
                    Console.WriteLine("equation: " + eq);
                }


            }
            string contents = eq.Substring(firstOccurence + 4, finalIndex - (firstOccurence + 4));
            string[] list = contents.Split(',');
            Console.WriteLine("LIST 0 :" + list[0]);
            Console.WriteLine("LIST 0 :" + list[1]);
            list[0] = new DataTable().Compute(list[0], null).ToString();
            list[1] = new DataTable().Compute(list[1], null).ToString();
            double number = Math.Round(double.Parse(list[0], CultureInfo.InvariantCulture), 3);
            double power = Math.Round(double.Parse(list[1], CultureInfo.InvariantCulture), 3);
            string value = Math.Pow(number, power).ToString("0.###");
            Console.WriteLine(value);

            Console.WriteLine(eq.Substring(firstOccurence + 4, finalIndex - (firstOccurence + 4)));


            return eq.Replace("POW(" + eq.Substring(firstOccurence + 4, finalIndex - (firstOccurence + 4)) + ")", value);
        }
      

        public struct Trigometry
        {

            public string type { get; private set; }
            public string value { get; private set; }

            public Trigometry(string x, string y)
                : this()
            {


                type = x;
                value = y;

            }



        }
        public struct VariableData
        {

            public string variable { get; private set; }
            public double value { get; private set; }

            public VariableData(string x, double y)
                : this()
            {


                variable = x;
                value = y;

            }



        }
        

    }
}

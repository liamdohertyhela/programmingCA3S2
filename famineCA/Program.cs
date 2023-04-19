using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace famineCA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int type = 0;

            //do
            //{

            //    Console.WriteLine("Type \n 1.Ship Report\n 2.Occupation Report \n 3.Age Report \n 4.Exit");
            //    type = int.Parse(Console.ReadLine());

            //    if(type == 1)
            //    { }
            //    else if(type == 2)
            //    {

            //    }
            //    else if(type==3)
            //    {

            //    }
            //    else if (type == 4)
            //    {
            //        //exit part
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect number entered please try again or press 4 to exit");
            //    }








            //}
            //while (type != 4);

            //occupationReport();

           ReadTwo();



        }//end of main
        static void ReadTwo()//displays file (mainly for testing purposes)
        {
            FileStream fs = new FileStream("faminefile.csv", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            //read first line

            string recordIn = sr.ReadLine();
            
            string[] fields = new string[9];//reps how many parts are in the array 3 here as it is Number, name, result

            int sum = 0;
            int count = 0;

            while (recordIn != null)
            {
                fields = recordIn.Split(',');

                //Console.WriteLine($"{fields[0]}\t {fields[1]}\t{fields[2]}\t{fields[3]}\t{fields[4]}\t{fields[5]}\t{fields[6]}\t{fields[7]}\t{fields[8]}\t{fields[9]}");

                //sum += int.Parse(fields[9]);

                count++;


                recordIn = sr.ReadLine();
            }
            //Console.WriteLine($"Average {avg}");
            sr.Close();
        }//end of method 1
        static void shipReport()
        {
            FileStream fs = new FileStream("faminefile.csv", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            


        }//end of method 2

        static void occupationReport()//find number of people in occupations
        {
            int spinsters = 0;
            int labourer = 0;
            int immigrant = 0;
            int cultivator = 0;
            int matron = 0;
            int dressmaker = 0;
            int child = 0;
            int fisherman = 0;
            int maid = 0;
            int smith = 0;
            int baker = 0;
            int none = 0;
            int tanner = 0;
            int infant = 0;
            int carperenter = 0;
            int driver = 0;
            int student = 0;
            int clerk = 0;
            int na = 0;
            int saddler = 0;
            int unknown = 0;



            FileStream fs = new FileStream("faminefile.csv", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int counter = 0;
            string[] fields = new string[9];//reps how many parts are in the array 3 here as it is Number, name, result
            string recordIn = sr.ReadLine();

            while (counter<=10)
            {
                string job;




                fields = recordIn.Split(',');
                job = fields[0];

                Console.WriteLine(fields[0]);



                if (job == "Spinster")
                {
                    spinsters = spinsters + 1;

                    
                }
                else if (job == "Laborer (Ital. 'operaia') or Workman/Woman")
                {
                    labourer = labourer + 1;
                }
                else if (job == "Immigrant")
                {
                    immigrant = immigrant + 1;
                }
                else if (job == "Cultivator or Farmer")
                {
                    cultivator = cultivator + 1;
                }
                else if (job == "Matron")
                {
                    matron = matron + 1;
                }
                else if (job == "Dressmaker")
                {
                    dressmaker = dressmaker + 1;
                }
                else if (job == "Child")
                {
                    child = child + 1;
                }
                else if (job == "Fisher Man")
                {
                    fisherman = fisherman + 1;
                }
                else if (job == "Chamber Maid or Maid or Servant")
                {
                    maid = maid + 1;
                }
                else if (job == "Smith")
                {
                    smith = smith + 1;
                }
                else if (job == "Baker or Macaroni Maker")
                {
                    baker = baker + 1;
                }
                else if (job == "None")
                {
                    none = none + 1;
                }
                else if (job == "Tanner or Gerber")
                {
                    tanner = tanner + 1;
                }
                else if (job == "Infant")
                {
                    infant = infant + 1;
                }
                else if (job == "Carpenter")
                {
                    carperenter = carperenter + 1;
                }
                else if (job == "Coachman/Coach Driver or Driver")
                {
                    driver = driver + 1;
                }
                else if (job == "Student")
                {
                    student=student + 1;
                }
                else if(job == "Clerk")
                {
                    clerk = clerk + 1;
                }
                else if (job == "Undefined Code")
                {
                    na = na + 1;
                }
                else if(job == "Saddler")
                {
                    saddler=saddler + 1;
                }
                else
                {
                    unknown=unknown + 1;
                }

                

                counter++;
            }
            Console.WriteLine(spinsters);

            sr.Close();
            



        }//end of method 3



    }
}
namespace CA3S2
{
    internal class Program
    {
        public static int amountOfPassengers=0;
        public static int passengersMary = 0;
        static void Main(string[] args)
        {
            shipfile[] mainShipFile;
            mainShipFile = readShip();

            names(mainShipFile);
            
            age(mainShipFile);

           


            //Console.WriteLine(mainShipFile[7].ManifestNum);//this how you sccces specific section

            int type = 0;

            

            

            do
            {

                Console.WriteLine("Type \n 1.Ship Report\n 2.Occupation Report \n 3.Age Report \n 4.Exit");
                type = int.Parse(Console.ReadLine());

                if (type == 1)//This prints the details of thje ship and the names 
                { 
                    
                }
                else if (type == 2)
                {
                    occupation(mainShipFile);//works fully
                }
                else if (type == 3)
                {

                }
                else if (type == 4)
                {
                    //exit part
                }
                else
                {
                    Console.WriteLine("Incorrect number entered please try again or press 4 to exit");
                }








            }
            while (type != 4);





        }
        static shipfile[] readShip()
        {

            shipfile[] myShipFile = new shipfile[500];

            FileStream fs = new FileStream("faminefile.csv", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);



            string recordIn = sr.ReadLine();

            string[] fields = new string[9];//reps how many parts are in the array 3 here as it is Number, name, result


            int i = 0;


            //reads and stores passger data in the class object if i want to check something i can now use the class object
            while (recordIn != null)
            {
                fields = recordIn.Split(',');

                //Console.WriteLine($"{fields[0]}\t {fields[1]}\t{fields[2]}\t{fields[3]}\t{fields[4]}\t{fields[5]}\t{fields[6]}\t{fields[7]}\t{fields[8]}\t{fields[9]}");


                

                shipfile passenger = new shipfile(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5], fields[6], fields[7], fields[8], fields[9]);

                myShipFile[i] = passenger;


                //Console.WriteLine($"{myShipFile[i].ManifestNum}");
                

                i++;


                recordIn = sr.ReadLine();
            }
            sr.Close();


            amountOfPassengers = i;


            shipfile[] nonEmptyShipFile= new shipfile[i];//creates a new file because last one has a load of empty variables
            
            for(int j = 0; j < i; j++)//this goes through each lin up until it hits i amount of lines aka how many entrys there are and fills the new file
            {
                nonEmptyShipFile[j] = myShipFile[j];

            }

            return nonEmptyShipFile;

        }
        static void names(shipfile[] mainShipFile)
        {
            
            shipfile[] maryShip = new shipfile[amountOfPassengers];
            shipfile[] lincShip = new shipfile[amountOfPassengers];
            shipfile[] clareShip = new shipfile[amountOfPassengers];
            shipfile[] dispatchShip = new shipfile[amountOfPassengers];

            for (int k = 0; k < amountOfPassengers; k++)//can use myShipFile.Length instead of amont
            {
                if (mainShipFile[k].ManifestNum == "MARY HARRINGTON  187  07-06-1848  102")
                {

                    maryShip[k] = mainShipFile[k];
                    //Console.WriteLine($"First Name {maryShip[k].PassengerFirstName} : Last Name {maryShip[k].PassengerSurname}");

                    //Console.WriteLine($"{maryShip[k].ManifestNum} :leaving from {maryShip[k]}");//this is top line of q we can use this somewhere else if really needed

                    passengersMary = k;
                    //Console.WriteLine(maryShip[k].PassengerSurname);

                }
                else if (mainShipFile[k].ManifestNum == "LINCOLN 187 02-05-1849 071")
                {


                    lincShip[k] = mainShipFile[k];
                    //Console.WriteLine($"First Name {lincShip[k].PassengerFirstName}");
                }
                else if (mainShipFile[k].ManifestNum == "CLARE 187 06-06-1849 123")
                {
                    clareShip[k] = mainShipFile[k];
                }
                else if (mainShipFile[k].ManifestNum == "DISPATCH 187 06-26-1851 049")
                {
                    dispatchShip[k] = mainShipFile[k];
                }

            }//end of for
            string entry;
            Console.WriteLine("Enter ship you want to check:");
            entry = Console.ReadLine();


            if (entry == "MARY HARRINGTON  187  07-06-1848  102")
            {
                Console.WriteLine("help");
                for (int k = 0; k < amountOfPassengers; k++)
                {
                    Console.WriteLine($"First Name {maryShip[k].PassengerFirstName} : Last Name {maryShip[k].PassengerSurname}");

                }
            }

            //Console.WriteLine($"{fields[1]}   {fields[0]}");//could possibly use this and just find the int to end at but 
            //starting at the otehrs would need to be taking their number away from the number of total
        }//end of method

        static void occupation(shipfile[] mainShipFiles)
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


            
            

            int counter = 0;
            

            for(int k = 0; k < amountOfPassengers; k++)
            { 
              

                if (mainShipFiles[k].Occupation == "Spinster")
                {
                    spinsters = spinsters + 1;


                }
                else if (mainShipFiles[k].Occupation == "Laborer (Ital. 'operaia') or Workman/Woman")
                {
                    labourer = labourer + 1;
                }
                else if (mainShipFiles[k].Occupation == "Immigrant")
                {
                    immigrant = immigrant + 1;
                }
                else if (mainShipFiles[k].Occupation == "Cultivator or Farmer")
                {
                    cultivator = cultivator + 1;
                }
                else if (mainShipFiles[k].Occupation == "Matron")
                {
                    matron = matron + 1;
                }
                else if (mainShipFiles[k].Occupation == "Dressmaker")
                {
                    dressmaker = dressmaker + 1;
                }
                else if (mainShipFiles[k].Occupation == "Child")
                {
                    child = child + 1;
                }
                else if (mainShipFiles[k].Occupation == "Fisher Man")
                {
                    fisherman = fisherman + 1;
                }
                else if (mainShipFiles[k].Occupation == "Chamber Maid or Maid or Servant")
                {
                    maid = maid + 1;
                }
                else if (mainShipFiles[k].Occupation == "Smith")
                {
                    smith = smith + 1;
                }
                else if (mainShipFiles[k].Occupation == "Baker or Macaroni Maker")
                {
                    baker = baker + 1;
                }
                else if (mainShipFiles[k].Occupation == "None")
                {
                    none = none + 1;
                }
                else if (mainShipFiles[k].Occupation == "Tanner or Gerber")
                {
                    tanner = tanner + 1;
                }
                else if (mainShipFiles[k].Occupation == "Infant")
                {
                    infant = infant + 1;
                }
                else if (mainShipFiles[k].Occupation == "Carpenter")
                {
                    carperenter = carperenter + 1;
                }
                else if (mainShipFiles[k].Occupation == "Coachman/Coach Driver or Driver")
                {
                    driver = driver + 1;
                }
                else if (mainShipFiles[k].Occupation == "Student")
                {
                    student = student + 1;
                }
                else if (mainShipFiles[k].Occupation == "Clerk")
                {
                    clerk = clerk + 1;
                }
                else if (mainShipFiles[k].Occupation == "Undefined Code")
                {
                    na = na + 1;
                }
                else if (mainShipFiles[k].Occupation == "Saddler")
                {
                    saddler = saddler + 1;
                }
                else
                {
                    unknown = unknown + 1;
                }



                counter++;
                
            }

            //printing of each job 
            Console.WriteLine($"Spinsters:{spinsters}");
            Console.WriteLine($"Labourers:{labourer}");
            Console.WriteLine($"Immigrant:{immigrant}");
            Console.WriteLine($"Farmer:{cultivator}");
            Console.WriteLine($"Matron:{matron}");
            Console.WriteLine($"Dressmakers:{dressmaker}");
            Console.WriteLine($"Fisherman:{fisherman}");
            Console.WriteLine($"Maid:{maid}");
            Console.WriteLine($"Baker:{baker}");
            Console.WriteLine($"Tanner:{tanner}");
            Console.WriteLine($"Carpenter:{carperenter}");
            Console.WriteLine($"Driver:{driver}");
            Console.WriteLine($"Student:{student}");
            Console.WriteLine($"Clerk:{clerk}");
            Console.WriteLine($"Saddler:{saddler}");
            Console.WriteLine($"Undefined:{unknown}");
            Console.WriteLine($"None:{none}");
            Console.WriteLine($"Unknown:{unknown}");
            Console.WriteLine($"Infant:{infant}");
            Console.WriteLine($"Child:{child}");





        }
        static void age(shipfile[] mainShipFiles)
        {


            int infants = 0;
            int children = 0;
            int teen=0;
            int youngAdult = 0;
            int adult = 0;
            int olderAdult = 0;
            int unknown = 0;

            for (int k = 0; k < amountOfPassengers; k++)
            {
                //if (mainShipFiles[k].Age<= 0)





                        //need to ask how to get rid of the age part and deal with the strings of infant and unknown 
                        //otherwise bruteforce it the same as  the occupation method

            }



        }//end of method
    }
    
}
/*Name: Liam Doherty
 *Student No: S00235065
 *Student Email: S00235065@atu.ie
 *Github link: https://github.com/liamdohertyhela/programmingCA3S2
 *Date: 21/04/23
 *Desc: A file that reads in and sorts differnt values and reports from a famine boat csv file
 * Finds Names,ages and occupations of passengers on board
 */


namespace CA3S2
{
    internal class Program
    {
        public static int amountOfPassengers=0;
        public static int passengersMary = 0;
        static void Main(string[] args)
        {
            shipfile[] mainShipFile;
            shipfile[] shipFileRead;
            mainShipFile = readShip();

            

            int type = 0;
            try
            {



                do
                {

                    Console.WriteLine("Type \n 1.Ship Report\n 2.Occupation Report \n 3.Age Report \n 4.Exit");
                    type = int.Parse(Console.ReadLine());

                    if (type == 1)//This prints the details of the ship and the names 
                    {
                        string entry = "";
                        Console.WriteLine("Enter ship you want to check:");
                        entry = Console.ReadLine();//gets name of ship for method to search

                        shipFileRead = names(mainShipFile, entry);

                        

                    }
                    else if (type == 2)
                    {
                        occupation(mainShipFile);//checks occupation
                    }
                    else if (type == 3)
                    {
                        age(mainShipFile);//checks ages
                    }
                    else if (type == 4)
                    {
                        //exit 
                    }
                    else
                    {
                        Console.WriteLine("Incorrect number entered please try again or press 4 to exit");
                    }








                }
                while (type != 4);
            }
            catch (Exception e)
            {
                Console.WriteLine($"This program crashed because {e.Message}");
            }




        }
        static shipfile[] readShip()
        {
            

                shipfile[] myShipFile = new shipfile[500];

                FileStream fs = new FileStream("faminefile.csv", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);



                string recordIn = sr.ReadLine();

                string[] fields = new string[9];//reps how many parts are in the array 3 here as it is Number, name, result


                int i = 0;

                sr.ReadLine();
                //reads and stores passger data in the class object if i want to check something i can now use the class object
                while (recordIn != null)
                {
                    fields = recordIn.Split(',');

                    shipfile passenger = new shipfile(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5], fields[6], fields[7], fields[8], fields[9]);

                    myShipFile[i] = passenger;

                    i++;

                    recordIn = sr.ReadLine();
                }
                sr.Close();


                amountOfPassengers = i;


                shipfile[] nonEmptyShipFile = new shipfile[i];//creates a new file because last one has a load of empty variables

                for (int j = 0; j < i; j++)//this goes through each line up until it hits i amount of lines aka how many entrys there are and fills the new file
                {
                    nonEmptyShipFile[j] = myShipFile[j];
                }

                return nonEmptyShipFile;
            

        }


        static shipfile[] names(shipfile[] mainShipFile,string shipName)
        {

            shipfile[] tempShip = new shipfile[amountOfPassengers];

            //this prints out the top header of the selected ship
            if (shipName== "CLARE 187 06-06-1849 123")
            {
                Console.WriteLine("");
                Console.WriteLine($"{mainShipFile[177].ManifestNum} leaving from {mainShipFile[177].PassengerPort} Arrived:{mainShipFile[177].Date} with 123 Passengers");
                Console.WriteLine("");
            }
            else if(shipName== "MARY HARRINGTON  187  07-06-1848  102")
            {
                Console.WriteLine("");
                Console.WriteLine($"{mainShipFile[32].ManifestNum} leaving from {mainShipFile[32].PassengerPort} Arrived:{mainShipFile[32].Date} with 102 Passengers");
                Console.WriteLine("");
            }
            else if (shipName == "LINCOLN 187 02-05-1849 071")
            {
                Console.WriteLine("");
                Console.WriteLine($"{mainShipFile[125].ManifestNum} leaving from {mainShipFile[125].PassengerPort} Arrived:{mainShipFile[125].Date} with 71 Passengers");
                Console.WriteLine("");
            }
            else if (shipName == "DISPATCH 187 06-26-1851 049")
            {
                Console.WriteLine("");
                Console.WriteLine($"{mainShipFile[315].ManifestNum} leaving from {mainShipFile[315].PassengerPort} Arrived:{mainShipFile[315].Date} with 49 Passengers");
                Console.WriteLine("");
            }


            //this prints out the list of passegegrs
            for (int k = 0; k < amountOfPassengers; k++)
                {
                    if (mainShipFile[k].ManifestNum == shipName)
                    {

                        tempShip[k] = mainShipFile[k];//takes the specific ship's list

                    
                        Console.WriteLine($"First Name {tempShip[k].PassengerFirstName} : Last Name {tempShip[k].PassengerSurname}");
                        Console.WriteLine("");
                    
                        passengersMary = k;
                    

                    }
                

                }//end of for

                return tempShip;

            


            

            
            
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
              
                //this if finds how many people are in a selected job
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
            Console.WriteLine("");
            Console.WriteLine("Occupation   Amount");
            Console.WriteLine("");
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
            Console.WriteLine("");





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


            try
            {

                for (int k = 1; k < amountOfPassengers; k++)
                {

                    //making an if to pull the unknonws and infants out 1st then array for the rest


                    string[] age = new string[amountOfPassengers];
                    int[] ageNumber = new int[amountOfPassengers];
                    age = mainShipFiles[k].Age.Split(' ');

                    
                    //sorts and removes non int ages
                    if (age[0] == "Infant")
                    {
                        infants++;
                    }
                    else if (age[0] == "Unknown")
                    {
                        unknown++;
                    }
                    else if (age[0] == "age")
                    {

                        int age2 = 0;

                        
                        age2 = int.Parse(age[1]);
                        
                        if (age2 <= 0)
                        {
                            infants++;

                        }
                        else if (age2 > 0 && age2 <= 12)
                        {
                            children++;
                        }
                        else if (age2 > 12 && age2 <= 19)
                        {

                            teen++;
                        }
                        else if (age2 > 19 && age2 <= 29)
                        {
                            youngAdult++;
                        }
                        else if (age2 >= 30 && age2 < 50)
                        {
                            adult++;
                        }
                        else if (age2 >= 50)
                        {
                            olderAdult++;
                        }
                        else
                        {
                            unknown++;
                        }


                    }





                }

                Console.WriteLine("");
                Console.WriteLine("Age Group      Amount");
                Console.WriteLine("");
                Console.WriteLine($"Infants <0 : {infants}");
                Console.WriteLine($"Children 1-12  : {children}");
                Console.WriteLine($"Teenagers 13-19  : {teen}");
                Console.WriteLine($"Young Adults 20-29  : {youngAdult}");
                Console.WriteLine($"Adults 30+ : {adult}");
                Console.WriteLine($"Older Adult 50+  : {olderAdult}");
                Console.WriteLine($"Unknown  : {unknown}");
                Console.WriteLine("");





            }
            catch(Exception e)
            {
                Console.WriteLine($"This program crashed because {e.Message}");
            }
           

        }//end of method
    }
    
}
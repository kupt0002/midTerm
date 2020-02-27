using System;
using System.Collections.Generic;

namespace MidtermSolution
{
    class Registration
    {
        public static int MaxNumOfWeeklyHours = 12;
        
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome! The maximum weely hours you can register is {0}", MaxNumOfWeeklyHours);

            List<Course> availableCourses = Course.AvailableCourses;
            List<Course> registeredCourses = new List<Course>();
            int countRegisteredCourses = 0; // counting number of registered corses starting from 0. It will be index in new list of registered courses.
            int userAddedHours = 0; // counting hours of registered courses
            bool finish = false;
            do
            {
                System.Console.WriteLine("\nThe following courses are availabe for you to register:\n");

                //Display available courses as required in the test sheet.


                   for (int i = 0; i < availableCourses.Count; i++) // for loop to display available courses

                    {

                    Course availCourse = availableCourses[i] as Course;

                    Console.Write(i + ". {0} - weekly hours: {1} \n", availCourse.Title, availCourse.WeeklyHours);
                    
                    }

                try
                {
                    System.Console.Write("\nEnter the course you want to register (0 - {0}). Enter -1 to finish: ", availableCourses.Count-1);
                    int userSelection = int.Parse(System.Console.ReadLine());

                    //Process the user's selection as required in the test sheet. 
  
                    // check if user does not to contunue, then loop breaks
                    if (userSelection == -1)

                    {
                        finish = true; // braking loop from line #19
                    }

                    // check is amount of registered hours plus hours selected are less or equal of total weekly hours
                    else if (userAddedHours + availableCourses[userSelection].WeeklyHours <= MaxNumOfWeeklyHours) 
                    {
                        registeredCourses.Add(availableCourses[userSelection]); // adding registered course to new list
                        Console.Write("\nYou just registered {0}\n", registeredCourses[countRegisteredCourses].Title);
                        userAddedHours += registeredCourses[countRegisteredCourses].WeeklyHours;// adding selected hours to total hours of user
                        
                        // this check if total user's registered hours are less then maximum to display message
                        if (userAddedHours < MaxNumOfWeeklyHours) 

                        { 
                        Console.Write("You can register {0} more hours\n", (MaxNumOfWeeklyHours - userAddedHours));
                        countRegisteredCourses++;
                        availableCourses.RemoveAt(userSelection);
                        }
                        // this check if total user's registered hours are equal to maximum to display message
                        else if (userAddedHours == MaxNumOfWeeklyHours)
                        {
                            Console.Write("\nYou have registered for your maximum hours\n");
                            finish = true; // braking loop from line #19
                        }

                    }


                    else
                    {
                        Console.Write("\nYou can not select that course, you will exceed the max weekly hours\n");
                        Console.Write("You can register {0} more hours\n", (MaxNumOfWeeklyHours - userAddedHours));
                    }

                }

                catch (Exception)
                {
                    System.Console.WriteLine("\nInvalid Selection, Try again!\n");
                }

            } while (!finish);

            System.Console.WriteLine("\nYou have selected the following courses: \n");

            //Display the information about the user's selections as required in the test sheet.

            for (int i = 0; i < registeredCourses.Count; i++)

            {

                Course regCourse = registeredCourses[i] as Course;

                Console.Write(i + ". {0} - weekly hours: {1} \n", regCourse.Title, regCourse.WeeklyHours);

            }

            System.Console.Write("\n\nPress Enter to Finish");
            System.Console.ReadLine();
        }
    }
}

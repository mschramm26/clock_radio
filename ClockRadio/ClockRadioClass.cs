using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class ClockRadioClass
    {
        private string currentTime = "10:30 AM";
        private string currentAlarmState = "OFF";
        //private bool currentAlarmState = false;
        private string currentAlarmTime = "12:00 PM";
        private string currentRadioStation = "99.1 FM";

        public void alarmClockFunction()
        {
            Console.WriteLine("Welcome to the alarm clock!");
            Console.WriteLine("The current time is: " + currentTime + "\nThe alarm is currently: " + currentAlarmState + "\nThe alarm is currently set to: " + currentAlarmTime + "\nThe current radio station is: " + currentRadioStation + "\n\nTo change the time, enter T.\nTo change the current state of the alarm, enter S.\nTo change the alarm time, press A.\nTo change the radio station, enter R.\nTo exit the program, enter E.\n");
            string userInputToChangeSomething = Console.ReadLine();

            bool booleanForWhileLoop = true;
            while (booleanForWhileLoop)
            {
                switch (userInputToChangeSomething)
                {
                    case "T":
                        ChangeTime();
                        break;
                    case "S":
                        ChangeAlarmState();
                        break;
                    case "A":
                        ChangeAlarmTime();
                        break;
                    case "R":
                        ChangeRadioStation();
                        break;
                    case "E":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter valid input.\n");
                        break;
                }
                Console.WriteLine("The current time is: " + currentTime + "\nThe alarm is currently: " + currentAlarmState + "\nThe alarm is currently set to: " + currentAlarmTime + "\nThe current radio station is: " + currentRadioStation + "\n\nTo change the time, enter T.\nTo change the current state of the alarm, enter S.\nTo change the alarm time, enter A.\nTo change the radio station, enter R.\nTo exit the program, enter E.\n");
                userInputToChangeSomething = Console.ReadLine();
            }
            Console.ReadLine();
            return;
        }
        private void ChangeTime()
        {
            Console.WriteLine("The current time is " + currentTime + ". Please enter a new time.");
            currentTime = Console.ReadLine();
            Console.WriteLine("\n");
        }

        private void ChangeAlarmState()
        {
            Console.WriteLine("The current state of the alarm is " + currentAlarmState + ". Please enter a new state of the alarm.");

            //currentAlarmState

            currentAlarmState = Console.ReadLine();
            Console.WriteLine("\n");
        }

        private void ChangeAlarmTime()
        {
            Console.WriteLine("The alarm is currently set to " + currentAlarmTime + ". Please enter a new alarm time.");
            currentAlarmTime = Console.ReadLine();
            Console.WriteLine("\n");
        }

        private void ChangeRadioStation()
        {
            Console.WriteLine("The radio is currently set to " + currentRadioStation + ". Please enter a new radio station.");
            currentRadioStation = Console.ReadLine();
            Console.WriteLine("\n");
        }


    }
}

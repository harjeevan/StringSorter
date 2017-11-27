using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorter
{

    class InstanceCounter
    {
        char[] setArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '_' }; // the total list of characters to search for, global variable as used in 2 routines
        

        public int[] charCount(String input)
        {
            char[] inputAsArray = input.ToCharArray(); // convert string to char array
            bool hasBeenFound = false;  // a boolean to check whether the character has been found
            int[] countArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // init array for counting the instances of the letters in the array (in order of a,b,c...)
            for (int a = 0; a < inputAsArray.Length; a++)   //for loop to go through the entire length of the input string
            {
                for (int b = 0; b < setArray.Length && hasBeenFound == false; b++) // for loop to check through setArray for which character has been found. Including the hasBeenFound boolean allows for the program to switch over to the next character as soon as it has been found, preventing unecessary loops.
                {
                    if (inputAsArray[a] == setArray[b]) //if the character at the location 'a' in the input string array meets the character in the global setArray above at location 'b' 
                    {
                        countArray[b] += 1; // as countArray is to contain number of instances of a character, in the order of setArray, when a character is matched, the corresponding counter must increase by 1.
                        hasBeenFound = true; // boolean set to true so no unnecessary recursions are taken
                    }
                }
                hasBeenFound = false;   // after loop, the boolean is reset.
            }
            return countArray;     //return array once all characters have been counted.
        }

        public int[] intArraySort(int[] unsortedIntArray)
        {
            int[] sortedIntArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //blank array for sorted values
            int highestVal = 0;     //set initial location of highest value found as 0
            int currentHighest=0;   //set highest value found as 0
            for (int a=0; a<sortedIntArray.Length; a++) //for loop to run entire length of sortedIntArray
            {
                for (int b = 0; b < unsortedIntArray.Length; b++)   //for loop to run for entire length of unsortedIntArray
                    if (unsortedIntArray[b] > highestVal)           //if the value of the unsortedIntArray at location 'b' is higher than highestVal
                    {
                        currentHighest = b;                         //set currentHighest as location of the for loop.
                        highestVal = unsortedIntArray[b];           //set highestVal as the value of unsortedIntArray at 'b', as this repeats, the value becomes the highest in the array
                    }
                sortedIntArray[a] = currentHighest;                 // for each iteration of the first for loop, the location of the highest value is set 
                unsortedIntArray[currentHighest] = 0;               //change the value for the highest in the array to 0, so the next highest will be chosen next.
                currentHighest = 0;                                 //current highest is changed back to 0 to reset for the first for loop
                highestVal = 0;                                     //highestVal is changed back to 0 to reset for the next for loop
            }
            return sortedIntArray;
        }

        public char[] intToChar(int[] intarray)
        {
            char[] sortedArray = { 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' }; //setting random values
            for (int a = 0; a<sortedArray.Length;a++)   //run through a for loop of the length of the sortedArray
            {
                sortedArray[a] = setArray[intarray[a]]; //convert the array into characters from integers in the sequence
            }
            return sortedArray;
        }
        public string charArrayToString(char[] charArray, char blockChar)   //takes input as char array and a char to be split from
        {
            string charArrayAsString = new string(charArray);               //convert char array into string
            string[] splitString = charArrayAsString.Split(blockChar);      //split string by the blocked char
            return splitString[0];                                          //returns the first part of the split string
        }
    }
}

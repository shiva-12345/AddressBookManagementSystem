﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    public class AddressBook
    {
        public static void contactDetails(string bookName)
        {
            Contact person = new Contact();

            Console.WriteLine("Enter All Details Like: ");
            Console.WriteLine("Enter First_Name: ");
            person.first_name = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            person.last_name = Console.ReadLine();
            Console.WriteLine("Enter Addree :");
            person.address = Console.ReadLine();
            Console.WriteLine("Enter City Name:");
            person.city = Console.ReadLine();
            Console.WriteLine("Enter State Name:");
            person.state = Console.ReadLine();
            Console.WriteLine("Enter pin Number:");
            person.zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number:");
            person.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            person.email = Console.ReadLine();

            addRecord(Program.addressBookStore[bookName], bookName, person);


        }

        public static void addRecord(List<Contact> book, string bookName, Contact newRecord)
        {
            book.Add(newRecord);
            Console.WriteLine("Record added to address book " + bookName);
            Console.WriteLine("Your Data :\n" + newRecord.toString());
            Console.WriteLine();

        }
        // initialize book if not present allready
        public static void addBook(string bookName)
        {
            if (!Program.addressBookStore.ContainsKey(bookName))
            {
                Program.addressBookStore.Add(bookName, new List<Contact>());
            }

            contactDetails(bookName);
        }

        public static void editRecordUsingFisrtName(string bookToEdit, string recordNameToEdit)
        {

            if (Program.addressBookStore.ContainsKey(bookToEdit))
            {
                List<Contact> book = Program.addressBookStore[bookToEdit];
                foreach (Contact record in book)
                {
                    if (book.Contains(record))
                    {
                        if (record.first_name.Equals(recordNameToEdit))
                        {

                            Console.WriteLine("Select Which Data You Want To Update \n1.First_Name \n2.Last_Name \n3.Address" +
                                               "\n4.City \n5.State \n6.Zip \n7.PhoneNumber \n8.Email");
                            string selection = Console.ReadLine();
                            string newData;
                            switch (selection)
                            {
                                case "1":
                                    Console.WriteLine("Enter First_Name");
                                    newData = Console.ReadLine();
                                    record.first_name = newData;
                                    Console.WriteLine("Your Updated  Records :\n" + record.toString());
                                    Console.WriteLine();
                                    break;
                                case "2":
                                    Console.WriteLine("Enter Last_Name");
                                    newData = Console.ReadLine();
                                    record.last_name = newData;
                                    Console.WriteLine("Your Updated  Records :\n" + record.toString());
                                    Console.WriteLine();
                                    break;
                                case "3":
                                    Console.WriteLine("Enter Address");
                                    newData = Console.ReadLine();
                                    record.address = newData;
                                    Console.WriteLine("Your Updated  Records :\n" + record.toString());
                                    Console.WriteLine();
                                    break;
                                case "4":
                                    Console.WriteLine("Enter City");
                                    newData = Console.ReadLine();
                                    record.city = newData;
                                    Console.WriteLine("Your Updated  Records :\n" + record.toString());
                                    Console.WriteLine();
                                    break;
                                case "5":
                                    Console.WriteLine("Enter State");
                                    newData = Console.ReadLine();
                                    record.state = newData;
                                    Console.WriteLine("Your Updated  Records :\n" + record.toString());
                                    Console.WriteLine();
                                    break;
                                case "6":
                                    Console.WriteLine("Enter Zip");
                                    newData = Console.ReadLine();
                                    record.zip = newData;
                                    Console.WriteLine("Your Updated  Records :\n" + record.toString());
                                    Console.WriteLine();
                                    break;
                                case "7":
                                    Console.WriteLine("Enter PhoneNumber");
                                    newData = Console.ReadLine();
                                    record.phoneNumber = newData;
                                    Console.WriteLine("Your Updated  Records :\n" + record.toString());
                                    Console.WriteLine();
                                    break;
                                case "8":
                                    Console.WriteLine("Enter Email");
                                    newData = Console.ReadLine();
                                    record.email = newData;
                                    Console.WriteLine("Your Updated  Records :\n" + record.toString());
                                    Console.WriteLine();
                                    break;
                                default:
                                    Console.WriteLine("Invalid Selection Input");
                                    break;
                            }
                            break;
                        }
                        {
                            Console.WriteLine("First_Name: " + record.first_name + " not Exist");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No Such BookAddress Found");
            }
        }

        public static void deleteRecord(String nameOfRecordToDelete, String bookThatHasRecord)
        {
            if (Program.addressBookStore.ContainsKey(bookThatHasRecord))
            {
                List<Contact> book = Program.addressBookStore[bookThatHasRecord];
                if (Program.addressBookStore.ContainsKey(bookThatHasRecord))
                {
                    foreach (Contact record in book)
                    {
                        if (record.first_name.Equals(nameOfRecordToDelete))
                        {
                            book.Remove(record);
                            Console.WriteLine("Your Record Deleted :");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Your Record not found!");
                            break;
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine(bookThatHasRecord + " Book Not Found !");
            }


        }


    }
}
using Microsoft.Azure.Devices.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    public class Main
    {
        ToolClass t = new ToolClass();
        public void run()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine("Options:");
                Console.WriteLine("1: Create Kreds");
                Console.WriteLine("2: Display Kredse");
                Console.WriteLine("3: Delete Kreds");
                Console.WriteLine("4: Create Aktivitet");
                Console.WriteLine("5: Display Aktiviteter");
                Console.WriteLine("6: Delete Aktivitet");

                Console.WriteLine();
                string choice = Console.ReadLine();

                const string optionCreateKreds = "1";
                const string optionDisplayKreds = "2";
                const string optionDeleteKreds = "3";
                const string optionCreateAktivitet = "4";
                const string optionDisplayAktivitet = "5";
                const string optionDeleteAktivitet = "6";

                if (choice == optionDisplayKreds)
                {
                    Console.Clear();
                    t.displayKredse();

                    Console.WriteLine("Press any key to Continue");
                    Console.ReadKey();

                    continue;
                }
                if (choice == optionDisplayAktivitet)
                {
                    Console.Clear();
                    t.displayAktiviteter();

                    Console.WriteLine("Press any key to Continue");
                    Console.ReadKey();

                    continue;
                }
                if (choice == optionDeleteKreds)
                {
                    Console.Clear();
                    t.displayKredse();
                    Console.WriteLine("Which Kreds do you want to delete? (ENTIRE ID)");
                    string id = Console.ReadLine();
                    
                    t.SletKreds(id);

                    Console.WriteLine("Press any key to Continue");
                    Console.ReadKey();

                    continue;
                }
                if (choice == optionDeleteAktivitet)
                {
                    Console.Clear();
                    t.displayAktiviteter();
                    Console.WriteLine("Which Aktivitet do you want to delete? (ENTIRE ID)");
                    string id = Console.ReadLine();

                    t.SletAktivitet(id);

                    Console.WriteLine("Press any key to Continue");
                    Console.ReadKey();

                    continue;
                }

                if (choice == optionCreateKreds)
                {
                    int i = 0;
                    Console.Clear();
                    Console.WriteLine("What is the ID of the kreds? (Please use all caps)");
                    string id = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("What is the name of the kreds?");
                    string navn = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("What is the adress of the kreds? (Please type the entire adress)");
                    string adresse = Console.ReadLine();

                    Console.Clear();

                    while (i == 0)
                    {
                        Console.WriteLine("What is the amount of participants?");
                        string priceStr = Console.ReadLine();
                        int antalDeltagere;
                        if (int.TryParse(priceStr, out antalDeltagere))
                            if (antalDeltagere > 0)
                            {
                                t.AddKreds(id, navn, adresse, antalDeltagere);
                                i++;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"Illegal Amount, try again.");
                            }
                    }
                    Console.Clear();
                    Console.WriteLine($"New Kreds {navn} created.");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    continue;
                }

                if (choice == optionCreateAktivitet)
                {
                    int i = 0;
                    Console.Clear();
                    Console.WriteLine("What is the ID of the Aktivitet? (Please use all caps)");
                    string id = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("What is the name of the Aktivitet?");
                    string navn = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("What is the Day of the Aktivitet? (TYPE FULL DAY NAME IN ENGLISH PLEASE (ex. Monday))");
                    string dag = Console.ReadLine();

                    Console.Clear();

                    while (i == 0)
                    {
                        Console.WriteLine("What is the start time (HOUR)?");
                        string startHrsStr = Console.ReadLine();
                        int startHrs = 0;
                        if (int.TryParse(startHrsStr, out startHrs))
                            if (startHrs > 0)
                            {
                                Console.Clear();
                                Console.WriteLine("What is the start time (MINUTE)?");
                                string startMinStr = Console.ReadLine();
                                int startMin;
                                if (int.TryParse(startMinStr, out startMin))
                                    if (startMin > 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("What is the end time (HOUR)?");
                                        string SlutHrsStr = Console.ReadLine();
                                        int SlutHrs;
                                        if (int.TryParse(SlutHrsStr, out SlutHrs))
                                            if (SlutHrs > startHrs)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("What is the End time (MINUTE)?");
                                                string SlutMinStr = Console.ReadLine();
                                                int SlutMin;
                                                if (int.TryParse(SlutMinStr, out SlutMin))
                                                    if (SlutMin > 0)
                                                    {
                                                        DayOfWeek day;
                                                        Enum.TryParse<DayOfWeek>(dag, out day);
                                                        t.AddAktivitet(id, navn, day, startHrs, startMin, SlutHrs, SlutMin);

                                                        i++;
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine($"Illegal Amount, try again.");
                                                    }
                                            } else if ( SlutHrs == startHrs)
                                            {
                                                Console.WriteLine("What is the End time (MINUTE)?");
                                                string SlutMinStr = Console.ReadLine();
                                                int SlutMin;
                                                if (int.TryParse(SlutMinStr, out SlutMin))
                                                    if (SlutMin > startMin)
                                                    {
                                                        i++;
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine($"Illegal Amount, try again.");
                                                    }
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine($"Illegal Amount, try again.");
                                            }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"Illegal Amount, try again.");
                                    }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"Illegal Amount, try again.");
                            }
                    }
                    Console.Clear();
                    Console.WriteLine($"New Aktivitet: {navn} created.");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    continue;
                }

            }
        }
        public Main()
        {
            run();
        }
    }
}

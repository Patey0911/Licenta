﻿using Firebase.Auth;
using Prediction;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Reactive.Subjects;
using System.Text.RegularExpressions;
using Xamarin.Essentials;


//var CircuitsList = await CircuitRepository2023.GetAllCircuits();
//var Drivers = await DriverRepository.GetAllDrivers();
//List<DriverModel> DriverSortedList = null;
//List<DriverModel> LastRaceClassification = null;
//float AvgPilot, AvgPos;
//int LastYearPos, PosQuali = 0;

//CircuitModel NextRace = null;
//CircuitModel Race1 = null;
//CircuitModel Race2 = null;
//CircuitModel Race3 = null;
//CircuitModel Race4 = null;
//CircuitModel Race5 = null;

//string LastRacePlace1 = null;
//string LastRacePlace2 = null;
//string LastRacePlace3 = null;
//string LastRacePlace4 = null;
//string LastRacePlace5 = null;
//string LastRacePlace6 = null;
//string LastRacePlace7 = null;
//string LastRacePlace8 = null;
//string LastRacePlace9 = null;
//string LastRacePlace10 = null;
//string LastRacePlace11 = null;
//string LastRacePlace12 = null;
//string LastRacePlace13 = null;
//string LastRacePlace14 = null;
//string LastRacePlace15 = null;
//string LastRacePlace16 = null;
//string LastRacePlace17 = null;
//string LastRacePlace18 = null;
//string LastRacePlace19 = null;
//string LastRacePlace20 = null;


//foreach (CircuitModel c in CircuitsList)
//{
//    string NoMonth = ReturnMonth(c.Date);
//    string resultString = Regex.Match(c.Date, @"\d+").Value;

//    if (NoMonth.Length != 2)
//    {
//        NoMonth = "0" + NoMonth;
//    }

//    if (resultString.Length != 2)
//    {
//        resultString = "0" + resultString;
//    }

//    DateTime DateGp;
//    DateTime.TryParseExact(resultString + "/" + NoMonth + "/2023", "dd/MM/yyyy", null, DateTimeStyles.None, out DateGp);

//    c.DateGP = DateGp;
//}

////Avg Pos from the last 5 races
//await Last5Races();

//var Circuit2022 = await CircuitRepository2022.GetByName(NextRace.CircuitName);
//if (Circuit2022 != null)
//{
//    Console.WriteLine(Circuit2022.ToString());

//    foreach (var driver in DriverSortedList)
//    {
//        if (Circuit2022.Place1 == driver.No) LastYearPos = 1;
//        else if (Circuit2022.Place2 == driver.No) LastYearPos = 2;
//        else if (Circuit2022.Place3 == driver.No) LastYearPos = 3;
//        else if (Circuit2022.Place4 == driver.No) LastYearPos = 4;
//        else if (Circuit2022.Place5 == driver.No) LastYearPos = 5;
//        else if (Circuit2022.Place6 == driver.No) LastYearPos = 6;
//        else if (Circuit2022.Place7 == driver.No) LastYearPos = 7;
//        else if (Circuit2022.Place8 == driver.No) LastYearPos = 8;
//        else if (Circuit2022.Place9 == driver.No) LastYearPos = 9;
//        else if (Circuit2022.Place10 == driver.No) LastYearPos = 10;
//        else if (Circuit2022.Place11 == driver.No) LastYearPos = 11;
//        else if (Circuit2022.Place12 == driver.No) LastYearPos = 12;
//        else if (Circuit2022.Place13 == driver.No) LastYearPos = 13;
//        else if (Circuit2022.Place14 == driver.No) LastYearPos = 14;
//        else if (Circuit2022.Place15 == driver.No) LastYearPos = 15;
//        else if (Circuit2022.Place16 == driver.No) LastYearPos = 16;
//        else if (Circuit2022.Place17 == driver.No) LastYearPos = 17;
//        else if (Circuit2022.Place18 == driver.No) LastYearPos = 18;
//        else if (Circuit2022.Place19 == driver.No) LastYearPos = 19;
//        else if (Circuit2022.Place20 == driver.No) LastYearPos = 20;
//        else
//            LastYearPos = 25;//because that pilot who doesn't compete on this circuit before, doesn't know it



//        if (NextRace.Qualifying1 == "")
//            //before qualifying
//            AvgPos = (float)((float)(driver.AvgPlace5Races) * 0.5 + float.Parse(driver.Position) * 0.2 + LastYearPos * 0.3);
//        else
//        {
//            if (NextRace.Qualifying1 == driver.No) PosQuali = 1;
//            else if (NextRace.Qualifying2 == driver.No) PosQuali = 2;
//            else if (NextRace.Qualifying3 == driver.No) PosQuali = 3;
//            else if (NextRace.Qualifying4 == driver.No) PosQuali = 4;
//            else if (NextRace.Qualifying5 == driver.No) PosQuali = 5;
//            else if (NextRace.Qualifying6 == driver.No) PosQuali = 6;
//            else if (NextRace.Qualifying7 == driver.No) PosQuali = 7;
//            else if (NextRace.Qualifying8 == driver.No) PosQuali = 8;
//            else if (NextRace.Qualifying9 == driver.No) PosQuali = 9;
//            else if (NextRace.Qualifying10 == driver.No) PosQuali = 10;
//            else if (NextRace.Qualifying11 == driver.No) PosQuali = 11;
//            else if (NextRace.Qualifying12 == driver.No) PosQuali = 12;
//            else if (NextRace.Qualifying13 == driver.No) PosQuali = 13;
//            else if (NextRace.Qualifying14 == driver.No) PosQuali = 14;
//            else if (NextRace.Qualifying15 == driver.No) PosQuali = 15;
//            else if (NextRace.Qualifying16 == driver.No) PosQuali = 16;
//            else if (NextRace.Qualifying17 == driver.No) PosQuali = 17;
//            else if (NextRace.Qualifying18 == driver.No) PosQuali = 18;
//            else if (NextRace.Qualifying19 == driver.No) PosQuali = 19;
//            else if (NextRace.Qualifying20 == driver.No) PosQuali = 20;

//            AvgPos = (float)((float)PosQuali * 0.4 + (float)(driver.AvgPlace5Races) * 0.3 + float.Parse(driver.Position) * 0.1 + LastYearPos * 0.2);
//        }
//        driver.AvgPlace = AvgPos;
//    }
//}
//else
//{
//    foreach (var driver in DriverSortedList)
//    {
//        if (NextRace.Qualifying1 == "")
//            //before qualifying
//            AvgPos = (float)((float)(driver.AvgPlace5Races) * 0.65 + float.Parse(driver.Position) * 0.35);
//        else
//        {
//            if (NextRace.Qualifying1 == driver.No) PosQuali = 1;
//            else if (NextRace.Qualifying2 == driver.No) PosQuali = 2;
//            else if (NextRace.Qualifying3 == driver.No) PosQuali = 3;
//            else if (NextRace.Qualifying4 == driver.No) PosQuali = 4;
//            else if (NextRace.Qualifying5 == driver.No) PosQuali = 5;
//            else if (NextRace.Qualifying6 == driver.No) PosQuali = 6;
//            else if (NextRace.Qualifying7 == driver.No) PosQuali = 7;
//            else if (NextRace.Qualifying8 == driver.No) PosQuali = 8;
//            else if (NextRace.Qualifying9 == driver.No) PosQuali = 9;
//            else if (NextRace.Qualifying10 == driver.No) PosQuali = 10;
//            else if (NextRace.Qualifying11 == driver.No) PosQuali = 11;
//            else if (NextRace.Qualifying12 == driver.No) PosQuali = 12;
//            else if (NextRace.Qualifying13 == driver.No) PosQuali = 13;
//            else if (NextRace.Qualifying14 == driver.No) PosQuali = 14;
//            else if (NextRace.Qualifying15 == driver.No) PosQuali = 15;
//            else if (NextRace.Qualifying16 == driver.No) PosQuali = 16;
//            else if (NextRace.Qualifying17 == driver.No) PosQuali = 17;
//            else if (NextRace.Qualifying18 == driver.No) PosQuali = 18;
//            else if (NextRace.Qualifying19 == driver.No) PosQuali = 19;
//            else if (NextRace.Qualifying20 == driver.No) PosQuali = 20;

//            AvgPos = (float)((float)PosQuali * 0.4 + (float)(driver.AvgPlace5Races) * 0.4 + float.Parse(driver.Position) * 0.2);
//        }
//        driver.AvgPlace = AvgPos;
//    }
//}

//DriverSortedList = DriverSortedList.OrderBy(o => o.AvgPlace).ToList();

//int i = -1;
//List<int> RemoveList = new List<int>();
//foreach (var d in DriverSortedList)
//{
//    i++;
//    if (d.LastName == "De Vries" || d.LastName == "Lawson")
//        RemoveList.Add(i);
//}
//RemoveList.Reverse();
//foreach (var remove in RemoveList)
//{
//    DriverSortedList.RemoveAt(remove);
//}

//foreach (var d in DriverSortedList)
//    Console.WriteLine(d.LastName + " " + d.AvgPlace);

//var place1 = DriverSortedList[0].LastName;
//var place2 = DriverSortedList[1].LastName;
//var place3 = DriverSortedList[2].LastName;
//var place4 = DriverSortedList[3].LastName;
//var place5 = DriverSortedList[4].LastName;
//var place6 = DriverSortedList[5].LastName;
//var place7 = DriverSortedList[6].LastName;
//var place8 = DriverSortedList[7].LastName;
//var place9 = DriverSortedList[8].LastName;
//var place10 = DriverSortedList[9].LastName;
//var place11 = DriverSortedList[10].LastName;
//var place12 = DriverSortedList[11].LastName;
//var place13 = DriverSortedList[12].LastName;
//var place14 = DriverSortedList[13].LastName;
//var place15 = DriverSortedList[14].LastName;
//var place16 = DriverSortedList[15].LastName;
//var place17 = DriverSortedList[16].LastName;
//var place18 = DriverSortedList[17].LastName;
//var place19 = DriverSortedList[18].LastName;
//var place20 = DriverSortedList[19].LastName;

//var CircuitResult = new CircuitModel(NextRace.CircuitLength, NextRace.CircuitName, NextRace.Date, NextRace.FastestLap, NextRace.FirstGP, NextRace.FutureRace, NextRace.LapRecord, NextRace.NoLaps, place1, place2, place3, place4, place5, place6, place7, place8, place9, place10, place11, place12, place13, place14, place15, place16, place17, place18, place19, place20, NextRace.Qualifying1, NextRace.Qualifying2, NextRace.Qualifying3, NextRace.Qualifying4, NextRace.Qualifying5, NextRace.Qualifying6, NextRace.Qualifying7, NextRace.Qualifying8, NextRace.Qualifying9, NextRace.Qualifying10, NextRace.Qualifying11, NextRace.Qualifying12, NextRace.Qualifying13, NextRace.Qualifying14, NextRace.Qualifying15, NextRace.Qualifying16, NextRace.Qualifying17, NextRace.Qualifying18, NextRace.Qualifying19, NextRace.Qualifying20, NextRace.RaceDistance, NextRace.Sprint1, NextRace.Sprint2, NextRace.Sprint3, NextRace.Sprint4, NextRace.Sprint5, NextRace.Sprint6, NextRace.Sprint7, NextRace.Sprint8, NextRace.Sprint9, NextRace.Sprint10, NextRace.Sprint11, NextRace.Sprint12, NextRace.Sprint13, NextRace.Sprint14, NextRace.Sprint15, NextRace.Sprint16, NextRace.Sprint17, NextRace.Sprint18, NextRace.Sprint19, NextRace.Sprint20, NextRace.SprintQualifying1, NextRace.SprintQualifying2, NextRace.SprintQualifying3, NextRace.SprintQualifying4, NextRace.SprintQualifying5, NextRace.SprintQualifying6, NextRace.SprintQualifying7, NextRace.SprintQualifying8, NextRace.SprintQualifying9, NextRace.SprintQualifying10, NextRace.SprintQualifying11, NextRace.SprintQualifying12, NextRace.SprintQualifying13, NextRace.SprintQualifying14, NextRace.SprintQualifying15, NextRace.SprintQualifying16, NextRace.SprintQualifying17, NextRace.SprintQualifying18, NextRace.SprintQualifying19, NextRace.SprintQualifying20, NextRace.SprintRace);

//await CircuitRepository2023.Save(NextRace.CircuitName, CircuitResult);

//await sendmail();

//async Task Last5Races()
//{
//    //Calculate Avg Pos from the last 5 Races

//    Race1 = null;
//    List<CircuitModel> CircuitsSortedList = CircuitsList.OrderByDescending(o => o.DateGP).ToList();
//    foreach (CircuitModel c in CircuitsSortedList)
//        if (c.FutureRace == "1")
//            NextRace = c;
//        else
//        {
//            if (Race1 == null)
//            {
//                Race1 = c;
//            }
//            else if (Race2 == null)
//            {
//                Race2 = c;
//            }
//            else if (Race3 == null)
//            {
//                Race3 = c;
//            }
//            else if (Race4 == null)
//            {
//                Race4 = c;
//            }
//            else
//            {
//                Race5 = c;
//                break;
//            }
//        }

//    Console.WriteLine(Race1.CircuitName);
//    Console.WriteLine(Race2.CircuitName);
//    Console.WriteLine(Race3.CircuitName);
//    Console.WriteLine(Race4.CircuitName);
//    Console.WriteLine(Race5.CircuitName);
//    Console.WriteLine(NextRace.CircuitName);

//    //Race1
//    var pilot = await DriverRepository.GetByNo(Race1.Place1);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "1"; LastRacePlace1 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place2);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "2"; LastRacePlace2 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place3);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "3"; LastRacePlace3 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place4);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "4"; LastRacePlace4 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place5);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "5"; LastRacePlace5 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place6);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "6"; LastRacePlace6 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place7);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "7"; LastRacePlace7 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place8);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "8"; LastRacePlace8 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place9);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "9"; LastRacePlace9 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place10);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "10"; LastRacePlace10 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place11);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "11"; LastRacePlace11 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place12);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "12"; LastRacePlace12 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place13);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "13"; LastRacePlace13 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place14);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "14"; LastRacePlace14 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place15);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "15"; LastRacePlace15 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place16);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "16"; LastRacePlace16 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place17);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "17"; LastRacePlace17 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place18);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "18"; LastRacePlace18 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place19);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "19"; LastRacePlace19 = pilot.FirstName + " " + pilot.LastName;

//    pilot = await DriverRepository.GetByNo(Race1.Place20);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race1 = "20"; LastRacePlace20 = pilot.FirstName + " " + pilot.LastName;

//    foreach (var p in Drivers)
//        if (p.Race1 == "0")
//            p.Race1 = "25";


//    //Race 2
//    pilot = await DriverRepository.GetByNo(Race2.Place1);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "1";

//    pilot = await DriverRepository.GetByNo(Race2.Place2);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "2";

//    pilot = await DriverRepository.GetByNo(Race2.Place3);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "3";

//    pilot = await DriverRepository.GetByNo(Race2.Place4);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "4";

//    pilot = await DriverRepository.GetByNo(Race2.Place5);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "5";

//    pilot = await DriverRepository.GetByNo(Race2.Place6);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "6";

//    pilot = await DriverRepository.GetByNo(Race2.Place7);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "7";

//    pilot = await DriverRepository.GetByNo(Race2.Place8);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "8";

//    pilot = await DriverRepository.GetByNo(Race2.Place9);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "9";

//    pilot = await DriverRepository.GetByNo(Race2.Place10);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "10";

//    pilot = await DriverRepository.GetByNo(Race2.Place11);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "11";

//    pilot = await DriverRepository.GetByNo(Race2.Place12);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "12";

//    pilot = await DriverRepository.GetByNo(Race2.Place13);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "13";

//    pilot = await DriverRepository.GetByNo(Race2.Place14);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "14";

//    pilot = await DriverRepository.GetByNo(Race2.Place15);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "15";

//    pilot = await DriverRepository.GetByNo(Race2.Place16);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "16";

//    pilot = await DriverRepository.GetByNo(Race2.Place17);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "17";

//    pilot = await DriverRepository.GetByNo(Race2.Place18);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "18";

//    pilot = await DriverRepository.GetByNo(Race2.Place19);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "19";

//    pilot = await DriverRepository.GetByNo(Race2.Place20);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race2 = "20";

//    foreach (var p in Drivers)
//        if (p.Race2 == "0")
//            p.Race2 = "25";

//    //Race3
//    pilot = await DriverRepository.GetByNo(Race3.Place1);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "1";

//    pilot = await DriverRepository.GetByNo(Race3.Place2);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "2";

//    pilot = await DriverRepository.GetByNo(Race3.Place3);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "3";

//    pilot = await DriverRepository.GetByNo(Race3.Place4);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "4";

//    pilot = await DriverRepository.GetByNo(Race3.Place5);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "5";

//    pilot = await DriverRepository.GetByNo(Race3.Place6);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "6";

//    pilot = await DriverRepository.GetByNo(Race3.Place7);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "7";

//    pilot = await DriverRepository.GetByNo(Race3.Place8);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "8";

//    pilot = await DriverRepository.GetByNo(Race3.Place9);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "9";

//    pilot = await DriverRepository.GetByNo(Race3.Place10);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "10";

//    pilot = await DriverRepository.GetByNo(Race3.Place11);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "11";

//    pilot = await DriverRepository.GetByNo(Race3.Place12);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "12";

//    pilot = await DriverRepository.GetByNo(Race3.Place13);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "13";

//    pilot = await DriverRepository.GetByNo(Race3.Place14);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "14";

//    pilot = await DriverRepository.GetByNo(Race3.Place15);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "15";

//    pilot = await DriverRepository.GetByNo(Race3.Place16);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "16";

//    pilot = await DriverRepository.GetByNo(Race3.Place17);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "17";

//    pilot = await DriverRepository.GetByNo(Race3.Place18);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "18";

//    pilot = await DriverRepository.GetByNo(Race3.Place19);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "19";

//    pilot = await DriverRepository.GetByNo(Race3.Place20);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race3 = "20";

//    foreach (var p in Drivers)
//        if (p.Race3 == "0")
//            p.Race3 = "25";

//    //Race4
//    pilot = await DriverRepository.GetByNo(Race4.Place1);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "1";

//    pilot = await DriverRepository.GetByNo(Race4.Place2);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "2";

//    pilot = await DriverRepository.GetByNo(Race4.Place3);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "3";

//    pilot = await DriverRepository.GetByNo(Race4.Place4);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "4";

//    pilot = await DriverRepository.GetByNo(Race4.Place5);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "5";

//    pilot = await DriverRepository.GetByNo(Race4.Place6);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "6";

//    pilot = await DriverRepository.GetByNo(Race4.Place7);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "7";

//    pilot = await DriverRepository.GetByNo(Race4.Place8);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "8";

//    pilot = await DriverRepository.GetByNo(Race4.Place9);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "9";

//    pilot = await DriverRepository.GetByNo(Race4.Place10);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "10";

//    pilot = await DriverRepository.GetByNo(Race4.Place11);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "11";

//    pilot = await DriverRepository.GetByNo(Race4.Place12);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "12";

//    pilot = await DriverRepository.GetByNo(Race4.Place13);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "13";

//    pilot = await DriverRepository.GetByNo(Race4.Place14);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "14";

//    pilot = await DriverRepository.GetByNo(Race4.Place15);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "15";

//    pilot = await DriverRepository.GetByNo(Race4.Place16);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "16";

//    pilot = await DriverRepository.GetByNo(Race4.Place17);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "17";

//    pilot = await DriverRepository.GetByNo(Race4.Place18);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "18";

//    pilot = await DriverRepository.GetByNo(Race4.Place19);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "19";

//    pilot = await DriverRepository.GetByNo(Race4.Place20);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race4 = "20";

//    foreach (var p in Drivers)
//        if (p.Race4 == "0")
//            p.Race4 = "25";

//    //Race5
//    pilot = await DriverRepository.GetByNo(Race5.Place1);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "1";

//    pilot = await DriverRepository.GetByNo(Race5.Place2);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "2";

//    pilot = await DriverRepository.GetByNo(Race5.Place3);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "3";

//    pilot = await DriverRepository.GetByNo(Race5.Place4);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "4";

//    pilot = await DriverRepository.GetByNo(Race5.Place5);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "5";

//    pilot = await DriverRepository.GetByNo(Race5.Place6);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "6";

//    pilot = await DriverRepository.GetByNo(Race5.Place7);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "7";

//    pilot = await DriverRepository.GetByNo(Race5.Place8);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "8";

//    pilot = await DriverRepository.GetByNo(Race5.Place9);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "9";

//    pilot = await DriverRepository.GetByNo(Race5.Place10);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "10";

//    pilot = await DriverRepository.GetByNo(Race5.Place11);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "11";

//    pilot = await DriverRepository.GetByNo(Race5.Place12);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "12";

//    pilot = await DriverRepository.GetByNo(Race5.Place13);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "13";

//    pilot = await DriverRepository.GetByNo(Race5.Place14);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "14";

//    pilot = await DriverRepository.GetByNo(Race5.Place15);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "15";

//    pilot = await DriverRepository.GetByNo(Race5.Place16);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "16";

//    pilot = await DriverRepository.GetByNo(Race5.Place17);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "17";

//    pilot = await DriverRepository.GetByNo(Race5.Place18);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "18";

//    pilot = await DriverRepository.GetByNo(Race5.Place19);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "19";

//    pilot = await DriverRepository.GetByNo(Race5.Place20);
//    foreach (var p in Drivers) if (p.No == pilot.No) p.Race5 = "20";

//    foreach (var p in Drivers)
//        if (p.Race5 == "0")
//            p.Race5 = "25";

//    foreach (var driver in Drivers)
//    {
//        AvgPilot = DriverRepository.AvgPosLast5Races(driver);
//        driver.AvgPlace5Races = AvgPilot;
//    }

//    DriverSortedList = Drivers.OrderBy(o => o.AvgPlace).ToList();
//}

//string ReturnMonth(string month)
//{
//    string NoMonth;
//    if (month.Contains("Mar"))
//        NoMonth = "3";
//    else if (month.Contains("Apr"))
//        NoMonth = "4";
//    else if (month.Contains("May"))
//        NoMonth = "5";
//    else if (month.Contains("Jun"))
//        NoMonth = "6";
//    else if (month.Contains("Jul"))
//        NoMonth = "7";
//    else if (month.Contains("Aug"))
//        NoMonth = "8";
//    else if (month.Contains("Sep"))
//        NoMonth = "9";
//    else if (month.Contains("Oct"))
//        NoMonth = "10";
//    else
//        NoMonth = "11";
//    return NoMonth;
//}

//async Task sendmail()
//{
//    var Users = await UserRepository.GetAllUsers();
//    var Teams = await TeamRepository.GetAllTeams();
//    Drivers = await DriverRepository.GetAllDrivers();

//    Drivers = Drivers.OrderByDescending(o => int.Parse(o.PointsSeason)).ToList();
//    Teams = Teams.OrderByDescending(o => int.Parse(o.Points)).ToList();

//    string fromEmail = "f1mobileappmail@gmail.com";
//    string password = "iyyg ukeq jejy accm";
//    int index = 1;
//    string copyfirstname = null;
//    /*
//    string messagetosenddriversstanding = "DRIVERS Standings" + System.Environment.NewLine;
//    string messagetosendteamsstanding = "TEAMS Standings" + System.Environment.NewLine;
//    string subject = Race1.CircuitName.ToUpper() + " Results";
//    string messagetosendlastrace = subject + System.Environment.NewLine + "1." + LastRacePlace1 + System.Environment.NewLine + "2." + LastRacePlace2 + System.Environment.NewLine + "3." + LastRacePlace3 + System.Environment.NewLine + "4." + LastRacePlace4 + System.Environment.NewLine + "5." + LastRacePlace5 + System.Environment.NewLine + "6." + LastRacePlace6 + System.Environment.NewLine + "7." + LastRacePlace7 + System.Environment.NewLine + "8." + LastRacePlace8 + System.Environment.NewLine + "9." + LastRacePlace9 + System.Environment.NewLine + "10." + LastRacePlace10 + System.Environment.NewLine + "11." + LastRacePlace11 + System.Environment.NewLine + "12." + LastRacePlace12 + System.Environment.NewLine + "13." + LastRacePlace13 + System.Environment.NewLine + "14." + LastRacePlace14 + System.Environment.NewLine + "15." + LastRacePlace15 + System.Environment.NewLine + "16." + LastRacePlace16 + System.Environment.NewLine + "17." + LastRacePlace17 + System.Environment.NewLine + "18." + LastRacePlace18 + System.Environment.NewLine + "19." + LastRacePlace19 + System.Environment.NewLine + "20." + LastRacePlace20 + System.Environment.NewLine + System.Environment.NewLine;

//    foreach (var d in Drivers)
//    {
//        messagetosenddriversstanding = messagetosenddriversstanding + index + ". " + d.FirstName + " " + d.LastName + " " + d.PointsSeason + System.Environment.NewLine;
//        index++;
//    }
//    messagetosenddriversstanding = messagetosenddriversstanding + System.Environment.NewLine + System.Environment.NewLine;

//    index = 1;
//    foreach (var team in Teams)
//    {
//        messagetosendteamsstanding = messagetosendteamsstanding + index + ". " + team.Team + " " + team.Points + System.Environment.NewLine;
//        index++;
//    }
//    messagetosendteamsstanding = messagetosendteamsstanding + System.Environment.NewLine + System.Environment.NewLine;

//    var copymessagetosendlastrace = messagetosendlastrace;
//    var copymessagetosenddriversstanding = messagetosenddriversstanding;
//    var copymessagetosendteamsstanding = messagetosendteamsstanding;

//    foreach (var user in Users)
//    {
//        using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
//        {
//            client.Port = 587;
//            client.Credentials = new NetworkCredential(fromEmail, password);
//            client.EnableSsl = true;

//            using (MailMessage message = new MailMessage())
//            {
//                message.From = new MailAddress(fromEmail);
//                message.To.Add(user.Email);
//                message.Subject = subject;

//                messagetosenddriversstanding = copymessagetosenddriversstanding;
//                messagetosendlastrace = copymessagetosendlastrace;
//                messagetosendteamsstanding = copymessagetosendteamsstanding;

//                foreach (var driver in DriverSortedList)
//                {
//                    if (driver.LastName == user.FavoriteDriver)
//                        copyfirstname = driver.FirstName;
//                }

//                messagetosenddriversstanding = messagetosenddriversstanding.Replace(user.FavoriteDriver, user.FavoriteDriver.ToUpper());
//                messagetosenddriversstanding = messagetosenddriversstanding.Replace(copyfirstname, copyfirstname.ToUpper());
//                messagetosendlastrace = messagetosendlastrace.Replace(user.FavoriteDriver, user.FavoriteDriver.ToUpper());
//                messagetosendlastrace = messagetosendlastrace.Replace(copyfirstname, copyfirstname.ToUpper());
//                messagetosendteamsstanding = messagetosendteamsstanding.Replace(user.FavoriteTeam, user.FavoriteTeam.ToUpper());

//                message.Body = messagetosendlastrace + messagetosenddriversstanding + messagetosendteamsstanding;

//                try
//                {
//                    client.Send(message);
//                    Console.WriteLine("Email trimis cu succes la " + user.Email);
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine("Eroare la trimiterea emailului: " + ex.Message);
//                }
//            }
//        }
//    }
//    */
var Users = await UserRepository.GetAllUsers();
var Teams = await TeamRepository.GetAllTeams();
var Drivers = await DriverRepository.GetAllDrivers();

Drivers = Drivers.OrderByDescending(o => int.Parse(o.PointsSeason)).ToList();
Teams = Teams.OrderByDescending(o => int.Parse(o.Points)).ToList();

using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
    {
    string fromEmail = "f1mobileappmail@gmail.com";
    string password = "iyyg ukeq jejy accm";
    client.Port = 587;
        client.Credentials = new NetworkCredential(fromEmail, password);
        client.EnableSsl = true;

        using (MailMessage message = new MailMessage())
        {
            message.From = new MailAddress(fromEmail);
            message.To.Add("mihalybogdanmatei@yahoo.com");
            message.Subject = "dasd";
            string colordriver2 = ChangeBackroundColorTeams(Drivers[1].Team);
            string htmlBody = @"
            <html>
                <head>
                    <style>
                        @import url(""https://fonts.googleapis.com/css2?family=Titillium+Web&display=swap"");

                            body,
                            html {
                              font-family: ""Titillium Web"", sans-serif;
                              padding: 0;
                              margin: 0;
                              box-sizing: border-box;
                              background-color: #f8f9fa;
                            }

                            /* VARIABLES */

                            :root {
                                  --alfaromeo-color: #C92D4B;
                                  --redbull-color: #065fab;
                                  --ferrari-color: #dc0000;
                                  --hover-color: #38383f;
                                  --mclaren-color: #ff8700;
                                  --racing-point-color: #f596c8;
                                  --renault-color: #fff500;
                            }

                            .table-container {
                              width: 60%;
                              min-width: 600px;
                              /* border: 1px solid black; */
                              margin: 100px auto;
                            }

                            .table-container th {
                              display: none;
                            }

                            .table-container tr {
                              display: flex;
                              padding: 0;
                              border-radius: 10px;
                              border: 1px solid #ccc;
                              transition: 0.3s;
                              cursor: pointer;
                            }

                            .table-container tr.table-content {
                              justify-content: space-between;
                              padding: 0;
                            }

                            .table-container tr.table-content td {
                              margin: 0 20px 0 10px;
                              font-size: 1.4rem;
                              text-align: center;
                              padding: 10px;
                            }

                            .table-container tr.table-content td .position {
                              border-right: 5px solid var(--mercedes-color);
                              padding-right: 10px;
                              font-size: 1.4rem;
                              font-weight: bold;
                            }

                            .table-container tr.table-content td .driver-name {
                              margin-left: 10px;
                            }

                            .table-container tr.table-content td .driver-surname {
                              font-weight: bolder;
                              text-transform: uppercase;
                            }

                            .table-container tr.table-content td .team {
                              font-size: 1rem;
                              color: #666;
                              margin-left: 10px;
                            }

                            .table-container tr.table-content td .points {
                              background-color: #ccc;
                              border-radius: 50px;
                              font-size: 1.1rem;
                              padding: 0 10px;
                            }

                            .table-container tr.table-content td i {
                              margin-left: 20px;
                              color: #e10600;
                              font-size: 18px;
                            }

                            /* HOVER */

                            .table-container tr:hover {
                              background-color: var(--hover-color);
                              color: #ffffff;
                            }

                            .table-container tr:hover .points {
                              color: black;
                            }

                            /* DRIVER 2 */

                            .table-container .table-content.driver2 .position {
                              border-right: 5px solid var(--colordriver2);
                            }

                            /* DRIVER 4 */

                            .table-container .table-content.driver4 .position {
                              border-right: 5px solid 0db;
                            }

                            /* DRIVER 5 */

                            .table-container .table-content.driver5 .position {
                              border-right: 5px solid var(--ferrari-color);
                            }

                            /* DRIVER 6 */

                            .table-container .table-content.driver6 .position {
                              border-right: 5px solid var(--mclaren-color);
                            }

                            /* DRIVER 7 */

                            .table-container .table-content.driver7 .position {
                              border-right: 5px solid var(--racing-point-color);
                            }

                            /* DRIVER 8 */

                            .table-container .table-content.driver8 .position {
                              border-right: 5px solid var(--renault-color);
                            }

                            /* DRIVER 9 */

                            .table-container .table-content.driver9 .position {
                              border-right: 5px solid var(--racing-point-color);
                            }

                            /* DRIVER 10 WITH EXTRA MARGIN/PADDING TO COMPENSATE EXTRA DIGIT */

                            .table-container .table-content.driver10 .position {
                              border-right: 5px solid var(--renault-color);
                              padding-right: 7px;
                            }

                            .table-container .table-content.driver10 td {
                              margin-left: 0;
                            }
                    </style>
                </head>
               <body>
                 <script>
                    // JavaScript pentru a actualiza culoarea
                    const colordriver2 = #ffcc00; // Culoarea dorită

                    // Setăm variabila CSS cu culoarea actualizată
                    document.documentElement.style.setProperty('--colordriver2', colordriver2);
                  </script>
                <table class=""table-container"">
                  <tr class=""table-content driver1"">
                    <td>
                      <span class=""position"">1</span>
                      <span class=""driver-name"">Lewis</span>
                      <span class=""driver-surname"">Hamilton</span>
                      <span class=""team"">Mercedes</span>
                    </td>
                    <td>
                      <span class=""points"">157 PTS</span
                      ><i class=""fas fa-chevron-right""></i>
                    </td>
                  </tr>
                  <tr class=""table-content driver2"">
                    <td>
                      <span class=""position"">2</span>
                      <span class=""driver-name"">Max</span>
                      <span class=""driver-surname"">Verstappen</span>
                      <span class=""team"">Red Bull Racing</span>
                    </td>
                    <td>
                      <span class=""points"">110 PTS</span
                      ><i class=""fas fa-chevron-right""></i>
                    </td>
                  </tr>
                  <tr class=""table-content driver3"">
                    <td>
                      <span class=""position"">3</span>
                      <span class=""driver-name"">Valtteri</span>
                      <span class=""driver-surname"">Bottas</span>
                      <span class=""team"">Mercedes</span>
                    </td>
                    <td>
                      <span class=""points"">107 PTS</span
                      ><i class=""fas fa-chevron-right""></i>
                    </td>
                  </tr>
                  <tr class=""table-content driver4"">
                    <td>
                      <span class=""position"">4</span>
                      <span class=""driver-name"">Alexander</span>
                      <span class=""driver-surname"">Albon</span>
                      <span class=""team"">Red Bull Racing</span>
                    </td>
                    <td>
                      <span class=""points"">48 PTS</span><i class=""fas fa-chevron-right""></i>
                    </td>
                  </tr>
                  <tr class=""table-content driver5"">
                    <td>
                      <span class=""position"">5</span>
                      <span class=""driver-name"">Charles</span>
                      <span class=""driver-surname"">Leclerc</span>
                      <span class=""team"">Ferrari</span>
                    </td>
                    <td>
                      <span class=""points"">45 PTS</span><i class=""fas fa-chevron-right""></i>
                    </td>
                  </tr>
                  <tr class=""table-content driver6"">
                    <td>
                      <span class=""position"">6</span>
                      <span class=""driver-name"">Lando</span>
                      <span class=""driver-surname"">Norris</span>
                      <span class=""team"">McLaren</span>
                    </td>
                    <td>
                      <span class=""points"">45 PTS</span><i class=""fas fa-chevron-right""></i>
                    </td>
                  </tr>
                  <tr class=""table-content driver7"">
                    <td>
                      <span class=""position"">7</span>
                      <span class=""driver-name"">Lance</span>
                      <span class=""driver-surname"">Stroll</span>
                      <span class=""team"">Racing Point</span>
                    </td>
                    <td>
                      <span class=""points"">42 PTS</span><i class=""fas fa-chevron-right""></i>
                    </td>
                  </tr>
                  <tr class=""table-content driver8"">
                    <td>
                      <span class=""position"">8</span>
                      <span class=""driver-name"">Daniel</span>
                      <span class=""driver-surname"">Ricciardo</span>
                      <span class=""team"">Renault</span>
                    </td>
                    <td>
                      <span class=""points"">33 PTS</span><i class=""fas fa-chevron-right""></i>
                    </td>
                  </tr>
                  <tr class=""table-content driver9"">
                    <td>
                      <span class=""position"">9</span>
                      <span class=""driver-name"">Sergio</span>
                      <span class=""driver-surname"">Perez</span>
                      <span class=""team"">Racing Point</span>
                    </td>
                    <td>
                      <span class=""points"">33 PTS</span><i class=""fas fa-chevron-right""></i>
                    </td>
                  </tr>
                  <tr class=""table-content driver10"">
                    <td>
                      <span class=""position"">10</span>
                      <span class=""driver-name"">Esteban</span>
                      <span class=""driver-surname"">Ocon</span>
                      <span class=""team"">Renault</span>
                    </td>
                    <td>
                      <span class=""points"">26 PTS</span><i class=""fas fa-chevron-right""></i>
                    </td>
                  </tr>
                </table>


              </body>
            </html>
        ";
            message.Body = htmlBody;
            message.IsBodyHtml = true;

            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);
            message.AlternateViews.Add(htmlView);


            try
            {
                client.Send(message);
                Console.WriteLine("Email trimis cu succes la ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la trimiterea emailului: " + ex.Message);
            }
        }
    }

string ChangeBackroundColorTeams(string Team)
{
    switch (Team)
    {
        case "Alfa Romeo":
            return "#C92D4B";
        case "AlphaTauri":
            return "#5E8FAA";
        case "Alpine":
            return "#2293D1";
        case "Aston Martin":
            return "#358C75";
        case "Ferrari":
            return "#F91536";
        case "Haas F1 Team":
            return "#B6BABD";
        case "McLaren":
            return "#F58020";
        case "Mercedes":
            return "#6CD3BF";
        case "Red Bull Racing":
            return "#3671C6";
        case "Williams":
            return "#37BEDD";
        default:
            return "#FFFFFF";
    }
}
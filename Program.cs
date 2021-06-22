using System;
using exerctry.Entities;
using exerctry.Entities.Exceptions;


namespace exerctry
{
    class Program
    {
        static void Main(string[] args)
        {
            try{

            System.Console.WriteLine("Room number:");
            int roomnumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());


            Reservation reservation = new Reservation(roomnumber, checkin, checkout);
            System.Console.WriteLine("Reservertion:" + reservation);

            System.Console.WriteLine();

            System.Console.WriteLine("Enter data to update the reservation:");

            System.Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            checkin = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            checkout = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDate(checkin, checkout);
            System.Console.WriteLine("Reservertion:" + reservation);

            }
            catch(DomainException e){


                System.Console.WriteLine("Error" + e.Message);




            }
            catch(FormatException e){


                System.Console.WriteLine("error" +e.Message);
            }




        }
    }










}





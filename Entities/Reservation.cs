using System;
using exerctry.Entities.Exceptions;




namespace exerctry.Entities
{
    public class Reservation
    {
        
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime ChechOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime chechOut)
        {
            if (chechOut <= checkIn)
            {
                throw new DomainException("Errorna Reervation: check-out date must be after check-in");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            ChechOut = chechOut;

        }
        public int Duration(){

            TimeSpan durartion = ChechOut.Subtract(CheckIn);
            return(int)durartion.TotalDays;




        }


        public void UpdateDate(DateTime checkIn, DateTime chechOut)
        {

            DateTime now = DateTime.Now;
            if (checkIn < now || chechOut < now)
            {

               throw new DomainException( "Error in Reervation date for update must be future dates");

            }
            if (chechOut <= checkIn)
            {
                throw new DomainException("Errorna Reervation: check-out date must be after check-in");
            }

            CheckIn = checkIn;
            ChechOut = chechOut;
           


            
        }
        public override string ToString()
        {
            return "Romm"
            + RoomNumber
            + ", Check-in: "
            + CheckIn.ToString("dd/MM/yyyy")
            + ", Check-out: "
            + ", "
            + Duration()
            + "Nigths";
        }

    }
}


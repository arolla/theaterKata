﻿namespace TheaterReservation.Data;

public class Seat
{

    private String seatId;
    private String status; // FREE, OCCUPIED

    public Seat(String seatId, String status)
    {
        this.seatId = seatId;
        this.status = status;
    }

    public String getSeatId()
    {
        return seatId;
    }

    public void setSeatId(String seatId)
    {
        this.seatId = seatId;
    }

    public String getStatus()
    {
        return status;
    }

    public void setStatus(String status)
    {
        this.status = status;
    }
        
    public override String ToString()
    {
        return "Seat{" +
               "seatId='" + seatId + '\'' +
               ", status='" + status + '\'' +
               '}';
    }
}
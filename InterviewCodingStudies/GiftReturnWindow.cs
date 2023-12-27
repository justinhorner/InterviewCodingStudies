using System;

namespace InterviewCodingStudies;

/**
 * You have some gifts you want to return. Gifts bought in December
 * have a 90-day return window, and all other gifts have a 30-day
 * return window. Given a gift's buy date, write a function that
 * prints the last day you can return the gift. You can choose how
 * dates should be formatted!
 * 
 *  https://buttondown.email/cassidoo/archive/in-seed-time-learn-in-harvest-teach-in-winter/
 *
 * Example:
 * > returnGift('Dec 25, 2023')
 * > "Mar 23, 2024"
 */

public class GiftReturnWindow
{
    public string GetGiftReturnWindow(string strPurchaseDate)
    {
        var purchaseDate = DateTime.Parse(strPurchaseDate);
        
        // set the return date, subtracting one day (assuming
        // [based on example] we will lose a day between purchase day 
        // and gift giving day) from the return day value
        var lastReturnDate = purchaseDate.Month == 12 
            ? purchaseDate.AddDays(89) 
            : purchaseDate.AddDays(29);

        return lastReturnDate.ToString("MMM d, yyyy");
    }
}
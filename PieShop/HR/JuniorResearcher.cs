﻿namespace PieShop.HR
{
    public class JuniorResearcher : Researcher
    {
        public JuniorResearcher(
            string firstName,
            string lastName,
            string email, 
            DateTime birthDay,
            double? hourlyRate) : base(firstName, lastName, email, birthDay, hourlyRate)
        {
        }
    }
}

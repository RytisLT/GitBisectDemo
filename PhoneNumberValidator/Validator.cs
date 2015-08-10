﻿namespace PhoneNumberValidator
{
    public class Validator
    {
        public bool IsNumberValid(string phoneNumber)
        {
            foreach (var c in phoneNumber)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
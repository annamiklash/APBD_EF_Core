using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text.RegularExpressions;
using APBD_11.Models.Requests;

namespace APBD_11.Models
{
    public class ValidationHelper
    {
        
        private const string ID_DIGIT_REGEX = "^[0-9]+$";
        private const string NAME_REGEX = "^[A-Z][-a-zA-Z]+$";
        private const string DATE_REGEX = @"^\s*(3[01]|[12][0-9]|0?[1-9])\.(1[012]|0?[1-9])\.((?:19|20)\d{2})\s*$";
 
        public static List<Error> ValidateAddDoctorRequest(AddDoctorRequest doctorRequest)
        {
            var errors = new List<Error>();

            if (!IsIdValid(doctorRequest.IdDoctor ))
            {
                errors.Add(
                    new Error("IdDoctor", doctorRequest.IdDoctor.ToString(),
                        "Invalid id format. Expected digits, Got: " + doctorRequest.IdDoctor));
             }

            if (!IsFirstNameValid(doctorRequest.FirstName))
            {
                errors.Add(
                    new Error("FirstName", doctorRequest.FirstName,
                        "Invalid First Name format. Expected format: " + NAME_REGEX + "; Got: " +
                        doctorRequest.FirstName));
            }

            if (!IsLastNameValid(doctorRequest.LastName))
            {
                errors.Add(
                    new Error("LastName", doctorRequest.LastName, "Invalid First Name format. Expected Format: " + NAME_REGEX +"; Got: " + doctorRequest.LastName));
            }

            if (!IsEmailValid(doctorRequest.Email))
            {
                errors.Add(
                    new Error("Email", doctorRequest.Email, "Invalid Email format. Got: " + doctorRequest.LastName));
            }
            return errors;
        }

        public static List<Error> ValidateModifyDoctorRequest(ModifyDoctorRequest doctorRequest)
        {
            var errors = new List<Error>();

            if (!IsIdValid(doctorRequest.IdDoctor))
            {
                errors.Add(
                    new Error("IdDoctor", doctorRequest.IdDoctor.ToString(),
                        "Invalid id format. Expected digits, Got: " + doctorRequest.IdDoctor));
            }

            if (doctorRequest.FirstName != null)
            {
                if (!IsFirstNameValid(doctorRequest.FirstName))
                {
                    errors.Add(
                        new Error("FirstName", doctorRequest.FirstName,
                            "Invalid First Name format. Expected format: " + NAME_REGEX + "; Got: " +
                            doctorRequest.FirstName));
                }
            }

            if (doctorRequest.LastName != null)
            {
                if (!IsLastNameValid(doctorRequest.LastName))
                {
                    errors.Add(
                        new Error("LastName", doctorRequest.LastName, "Invalid First Name format. Expected Format: " + NAME_REGEX +"; Got: " + doctorRequest.LastName));
                }
            }

            if (doctorRequest.Email != null)
            {
                if (!IsEmailValid(doctorRequest.Email))
                {
                    errors.Add(
                        new Error("Email", doctorRequest.Email, "Invalid Email format. Got: " + doctorRequest.LastName));
                }
            }
            if (string.IsNullOrEmpty(doctorRequest.FirstName) && string.IsNullOrEmpty(doctorRequest
                                                                  .LastName)
                                                              && string.IsNullOrEmpty(doctorRequest
                                                                  .Email))
            {
                errors.Add(new Error("multiple fields", doctorRequest.ToString(), "Nothing to update"));
            }

            return errors;
        }

        private static bool IsEmailValid(string doctorRequestEmail)
        {
            try
            {
                MailAddress m = new MailAddress(doctorRequestEmail);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private static bool IsLastNameValid(string doctorRequestLastName)
        {
            return Regex.IsMatch(doctorRequestLastName, NAME_REGEX);
        }

        private static bool IsFirstNameValid(string doctorRequestFirstName)
        {
            return Regex.IsMatch(doctorRequestFirstName, NAME_REGEX);
        }

        private static bool IsIdValid(string id)
        {
            return Regex.IsMatch(id, ID_DIGIT_REGEX);
        }
    }
}
﻿namespace Feature.FormsExtentions.XDb.Model
{
    public class ServiceContact : XDbContact, IServiceContact
    {
        public ServiceContact()
        {
        }

        public ServiceContact(string address)
        {
            Email = address;
        }
    }
}
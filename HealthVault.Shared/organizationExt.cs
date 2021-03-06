﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using HealthVault.Entity.Model;
using HealthVault.Shared.System.Extensions;
using System.Collections.Generic;

namespace HealthVault.Shared.ParamsConverter
{
    public partial class organizationConverter
    {
        public static organization ConvertParams(string Identifier, string active, string type,
                           string address_city, string address_state, string partOf)
        {
            organization NewObj = new organization();

            // Convert Identifier
            if (false == string.IsNullOrEmpty(Identifier))
                NewObj.identifier = int.Parse(Identifier);

            // Convert addressCity
            if (false == string.IsNullOrEmpty(address_city))
            {
                short temp;
                if (false == short.TryParse(address_city, out temp))
                    throw new ArgumentOutOfRangeException("address_city");
                else
                    NewObj.address_city = temp;
            }

            // Convert address_state
            if (false == string.IsNullOrEmpty(address_state))
            {
                short temp;
                if (false == short.TryParse(address_state, out temp))
                    throw new ArgumentOutOfRangeException("address_state");
                else
                    NewObj.address_state = temp;
            }

            // Convert type
            if (false == string.IsNullOrEmpty(type))
            {
                short temp;
                if (false == short.TryParse(type, out temp))
                    throw new ArgumentOutOfRangeException("type");
                else
                    NewObj.type = temp;
            }

            // Convert partof
            if (false == string.IsNullOrEmpty(partOf))
                NewObj.partOf = int.Parse(partOf);

            return NewObj;
        }
    }
}
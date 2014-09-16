/*
Copyright   : Copyright Jeevan Technologies
File Name   : IIncomeGatewayRepository.cs 
Description : Business Logic for Income Gateway
Author      : Saravanan N.
Created Date : 16th April, 2014.

 * Modification History:
-------------------------
 * 28Apr2014 Sathish chnaged PersistIncomeGateway method to return user data id
 * 29May2014 Ashok Kumar changed return type from Tuple to IncomeDTO for PersistIncomeGateway
 */

using System;
using JTL.Tax1040.BusinessObject;

namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Containts methods definition for IncomeGatewayRepository
    /// </summary>
    public interface IIncomeGatewayRepository
    {
        //Tuple<bool, bool, bool, bool, string, bool> GetIncomeGatewayData(long userId, long userDataId);
        IncomeDTO GetIncomeGatewayData(long userId, long userDataId);
        long PersistIncomeGateway(long userId, long userDataId, Tuple<bool, bool, bool, bool> incomeGatewayCheckBoxStatus);
    }
}

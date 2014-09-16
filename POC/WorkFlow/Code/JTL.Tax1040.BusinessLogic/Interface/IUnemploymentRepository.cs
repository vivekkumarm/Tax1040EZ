/*
Copyright   : Copyright Jeevan Technologies
File Name   : IUnemploymentRepository.cs 
Description : Business Logic Interface for Unemployment
Author      : Vivek
Created Date : 7 Apr 2014

 * Modification History:
------------------------
 * Saravanan N - 10th April, 2014 - DeleteAndPersist1099G param list altered.
 * Sathish N  - 28Apr2014 Changed CreateAndPersist1099G method to return user data id and form1099g ID
 * Sathish N  - 02May2014 Changed persist method to use TaxReturnData BO and Removed error message list in persist and delete 
 * Saravanan N - 6th May, 2014 - GetAll Unemployment Compensation entries.
 * Saravanan N - 7th May, 2014 - FormId param removed from DeleteAndPersistUnemployment and GetUnemploymentById
 * Saravanan N - 8th May, 2014 - FilingStatus param added in GetUnemploymentById()
 */

using System.Collections.Generic;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.BusinessObject;
using System;

namespace JTL.Tax1040.BusinessLogic
{
    /// <summary>
    /// Interface for unemployment repository.
    /// </summary>
    public interface IUnemploymentRepository
    {
        #region Interface Methods
        //Saravanan N - 8th April, 2014 - Create and Persist Form1099G.
        dynamic CreateAndPersistUnemployment(long userId, TaxReturnData taxReturnData);

        //Saravanan N - 8th April, 2014 - Delete and Persist Form1099G.
        void DeleteAndPersistUnemployment(UserDTO userDTO);

        //Saravanan N - 6th May, 2014 - GetAll Unemployment Compensation entries.
        Tuple<List<Form1099G>, IEnumerable<ErrorMessage>, double?> GetAllUnemployment(UserDTO userDTO);

        //Saravanan N - 6th May, 2014 - Get Unemployment based on Id.
        Tuple<Form1099G, string, string, FilingStatus> GetUnemploymentById(UserDTO userDTO);
        #endregion
    }
}

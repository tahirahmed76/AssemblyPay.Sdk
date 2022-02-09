/*
 * Assembly API
 *
 * Assembly (formely PromisePay) is a powerful payments engine custom-built for platforms and marketplaces.
 *
 * The version of the OpenAPI document: 2.0
 * Contact: support@assemblypayments.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing CardAccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CardAccountsApiTests : IDisposable
    {
        private CardAccountsApi instance;

        public CardAccountsApiTests()
        {
            instance = new CardAccountsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CardAccountsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CardAccountsApi
            //Assert.IsType<CardAccountsApi>(instance);
        }

        /// <summary>
        /// Test CreateCardAccount
        /// </summary>
        [Fact]
        public void CreateCardAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CardAccountRequestBody cardAccountRequestBody = null;
            //var response = instance.CreateCardAccount(cardAccountRequestBody);
            //Assert.IsType<CardAccount>(response);
        }

        /// <summary>
        /// Test RedactCardAccount
        /// </summary>
        [Fact]
        public void RedactCardAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.RedactCardAccount(id);
            //Assert.IsType<CardAccountDeletion>(response);
        }

        /// <summary>
        /// Test ShowCardAccount
        /// </summary>
        [Fact]
        public void ShowCardAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowCardAccount(id);
            //Assert.IsType<CardAccount>(response);
        }

        /// <summary>
        /// Test ShowCardAccountUser
        /// </summary>
        [Fact]
        public void ShowCardAccountUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowCardAccountUser(id);
            //Assert.IsType<SingleUser>(response);
        }

        /// <summary>
        /// Test VerifyCard
        /// </summary>
        [Fact]
        public void VerifyCardTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //CardAccountVerifyRequestBody cardAccountVerifyRequestBody = null;
            //var response = instance.VerifyCard(id, cardAccountVerifyRequestBody);
            //Assert.IsType<CardAccount>(response);
        }
    }
}
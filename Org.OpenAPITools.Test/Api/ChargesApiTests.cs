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
using Xunit;
using AssemblyPay.Sdk.Api;
// uncomment below to import models
//using AssemblyPay.Sdk.Model;

namespace AssemblyPay.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing ChargesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ChargesApiTests : IDisposable
    {
        private ChargesApi instance;

        public ChargesApiTests()
        {
            instance = new ChargesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ChargesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ChargesApi
            //Assert.IsType<ChargesApi>(instance);
        }

        /// <summary>
        /// Test CreateCharge
        /// </summary>
        [Fact]
        public void CreateChargeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ChargeRequestBody chargeRequestBody = null;
            //var response = instance.CreateCharge(chargeRequestBody);
            //Assert.IsType<SingleCharge>(response);
        }

        /// <summary>
        /// Test ListCharges
        /// </summary>
        [Fact]
        public void ListChargesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ListCharges(limit, offset);
            //Assert.IsType<Charges>(response);
        }

        /// <summary>
        /// Test ShowCharge
        /// </summary>
        [Fact]
        public void ShowChargeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowCharge(id);
            //Assert.IsType<SingleCharge>(response);
        }

        /// <summary>
        /// Test ShowChargeBuyer
        /// </summary>
        [Fact]
        public void ShowChargeBuyerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowChargeBuyer(id);
            //Assert.IsType<SingleUser>(response);
        }

        /// <summary>
        /// Test ShowChargeStatus
        /// </summary>
        [Fact]
        public void ShowChargeStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowChargeStatus(id);
            //Assert.IsType<SingleChargeStatus>(response);
        }
    }
}

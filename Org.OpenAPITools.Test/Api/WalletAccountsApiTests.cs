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
    ///  Class for testing WalletAccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WalletAccountsApiTests : IDisposable
    {
        private WalletAccountsApi instance;

        public WalletAccountsApiTests()
        {
            instance = new WalletAccountsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WalletAccountsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WalletAccountsApi
            //Assert.IsType<WalletAccountsApi>(instance);
        }

        /// <summary>
        /// Test BillPayment
        /// </summary>
        [Fact]
        public void BillPaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //BillPaymentRequestBody billPaymentRequestBody = null;
            //var response = instance.BillPayment(id, billPaymentRequestBody);
            //Assert.IsType<SingleDisbursement>(response);
        }

        /// <summary>
        /// Test ShowWalletAccount
        /// </summary>
        [Fact]
        public void ShowWalletAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowWalletAccount(id);
            //Assert.IsType<WalletAccount>(response);
        }

        /// <summary>
        /// Test ShowWalletAccountNBPAYDetails
        /// </summary>
        [Fact]
        public void ShowWalletAccountNBPAYDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowWalletAccountNBPAYDetails(id);
            //Assert.IsType<WalletAccountBpayDetails>(response);
        }

        /// <summary>
        /// Test ShowWalletAccountNPPDetails
        /// </summary>
        [Fact]
        public void ShowWalletAccountNPPDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowWalletAccountNPPDetails(id);
            //Assert.IsType<WalletAccountNppDetails>(response);
        }

        /// <summary>
        /// Test ShowWalletAccountUser
        /// </summary>
        [Fact]
        public void ShowWalletAccountUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowWalletAccountUser(id);
            //Assert.IsType<SingleUser>(response);
        }

        /// <summary>
        /// Test WithdrawFunds
        /// </summary>
        [Fact]
        public void WithdrawFundsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //WithdrawRequestBody withdrawRequestBody = null;
            //var response = instance.WithdrawFunds(id, withdrawRequestBody);
            //Assert.IsType<SingleDisbursement>(response);
        }
    }
}

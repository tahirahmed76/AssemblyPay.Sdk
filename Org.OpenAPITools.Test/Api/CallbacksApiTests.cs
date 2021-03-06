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
    ///  Class for testing CallbacksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CallbacksApiTests : IDisposable
    {
        private CallbacksApi instance;

        public CallbacksApiTests()
        {
            instance = new CallbacksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CallbacksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CallbacksApi
            //Assert.IsType<CallbacksApi>(instance);
        }

        /// <summary>
        /// Test CreateCallback
        /// </summary>
        [Fact]
        public void CreateCallbackTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CallbackRequestBody callbackRequestBody = null;
            //var response = instance.CreateCallback(callbackRequestBody);
            //Assert.IsType<SingleCallback>(response);
        }

        /// <summary>
        /// Test DeleteCallback
        /// </summary>
        [Fact]
        public void DeleteCallbackTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DeleteCallback(id);
            //Assert.IsType<CallbackDeletion>(response);
        }

        /// <summary>
        /// Test ListCallbackResponse
        /// </summary>
        [Fact]
        public void ListCallbackResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ListCallbackResponse(id, limit, offset);
            //Assert.IsType<ListCallbackResponses>(response);
        }

        /// <summary>
        /// Test ListCallbacks
        /// </summary>
        [Fact]
        public void ListCallbacksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //int? offset = null;
            //string filter = null;
            //var response = instance.ListCallbacks(limit, offset, filter);
            //Assert.IsType<Callbacks>(response);
        }

        /// <summary>
        /// Test ShowCallback
        /// </summary>
        [Fact]
        public void ShowCallbackTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowCallback(id);
            //Assert.IsType<SingleCallback>(response);
        }

        /// <summary>
        /// Test ShowCallbackResponse
        /// </summary>
        [Fact]
        public void ShowCallbackResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string callbackId = null;
            //string id = null;
            //var response = instance.ShowCallbackResponse(callbackId, id);
            //Assert.IsType<SingleCallbackResponse>(response);
        }

        /// <summary>
        /// Test UpdateCallback
        /// </summary>
        [Fact]
        public void UpdateCallbackTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //CallbackRequestBody callbackRequestBody = null;
            //var response = instance.UpdateCallback(id, callbackRequestBody);
            //Assert.IsType<SingleCallback>(response);
        }
    }
}

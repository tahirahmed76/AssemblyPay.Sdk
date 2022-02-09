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
    ///  Class for testing ItemsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ItemsApiTests : IDisposable
    {
        private ItemsApi instance;

        public ItemsApiTests()
        {
            instance = new ItemsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ItemsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ItemsApi
            //Assert.IsType<ItemsApi>(instance);
        }

        /// <summary>
        /// Test CreateItem
        /// </summary>
        [Fact]
        public void CreateItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemRequestBody itemRequestBody = null;
            //var response = instance.CreateItem(itemRequestBody);
            //Assert.IsType<SingleItem>(response);
        }

        /// <summary>
        /// Test DeleteItem
        /// </summary>
        [Fact]
        public void DeleteItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DeleteItem(id);
            //Assert.IsType<SingleItem>(response);
        }

        /// <summary>
        /// Test ListItemBatchTransactions
        /// </summary>
        [Fact]
        public void ListItemBatchTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ListItemBatchTransactions(id);
            //Assert.IsType<ListBatchTransactions>(response);
        }

        /// <summary>
        /// Test ListItemTransactions
        /// </summary>
        [Fact]
        public void ListItemTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ListItemTransactions(id);
            //Assert.IsType<Transactions>(response);
        }

        /// <summary>
        /// Test ListItems
        /// </summary>
        [Fact]
        public void ListItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //int? offset = null;
            //int? limit = null;
            //string createdBefore = null;
            //string createdAfter = null;
            //var response = instance.ListItems(search, offset, limit, createdBefore, createdAfter);
            //Assert.IsType<Items>(response);
        }

        /// <summary>
        /// Test ShowItem
        /// </summary>
        [Fact]
        public void ShowItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowItem(id);
            //Assert.IsType<SingleItem>(response);
        }

        /// <summary>
        /// Test ShowItemBuyer
        /// </summary>
        [Fact]
        public void ShowItemBuyerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowItemBuyer(id);
            //Assert.IsType<SingleUser>(response);
        }

        /// <summary>
        /// Test ShowItemFees
        /// </summary>
        [Fact]
        public void ShowItemFeesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowItemFees(id);
            //Assert.IsType<Fees>(response);
        }

        /// <summary>
        /// Test ShowItemSeller
        /// </summary>
        [Fact]
        public void ShowItemSellerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowItemSeller(id);
            //Assert.IsType<SingleUser>(response);
        }

        /// <summary>
        /// Test ShowItemStatus
        /// </summary>
        [Fact]
        public void ShowItemStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowItemStatus(id);
            //Assert.IsType<SingleStatus>(response);
        }

        /// <summary>
        /// Test ShowItemWireDetails
        /// </summary>
        [Fact]
        public void ShowItemWireDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowItemWireDetails(id);
            //Assert.IsType<SingleWireDetailsWithId>(response);
        }

        /// <summary>
        /// Test UpdateItem
        /// </summary>
        [Fact]
        public void UpdateItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //UpdateItemRequestBody updateItemRequestBody = null;
            //var response = instance.UpdateItem(id, updateItemRequestBody);
            //Assert.IsType<SingleItem>(response);
        }
    }
}
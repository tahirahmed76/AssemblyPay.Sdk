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
    ///  Class for testing CompaniesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CompaniesApiTests : IDisposable
    {
        private CompaniesApi instance;

        public CompaniesApiTests()
        {
            instance = new CompaniesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CompaniesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CompaniesApi
            //Assert.IsType<CompaniesApi>(instance);
        }

        /// <summary>
        /// Test CreateCompany
        /// </summary>
        [Fact]
        public void CreateCompanyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CompanyRequestBody companyRequestBody = null;
            //var response = instance.CreateCompany(companyRequestBody);
            //Assert.IsType<SingleCompany>(response);
        }

        /// <summary>
        /// Test ListCompanies
        /// </summary>
        [Fact]
        public void ListCompaniesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ListCompanies(limit, offset);
            //Assert.IsType<SimpleCompanies>(response);
        }

        /// <summary>
        /// Test ShowCompany
        /// </summary>
        [Fact]
        public void ShowCompanyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ShowCompany(id);
            //Assert.IsType<SingleCompany>(response);
        }

        /// <summary>
        /// Test UpdateCompany
        /// </summary>
        [Fact]
        public void UpdateCompanyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //CompanyRequestBody companyRequestBody = null;
            //var response = instance.UpdateCompany(id, companyRequestBody);
            //Assert.IsType<SingleCompany>(response);
        }
    }
}
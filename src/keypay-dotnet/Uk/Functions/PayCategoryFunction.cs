using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.PayCategory;

namespace KeyPayV2.Uk.Functions
{
    public interface IPayCategoryFunction
    {
        List<UkPayCategoryModel> ListPayCategories(int businessId, ListPayCategoriesQueryModel request, ODataQuery oDataQuery = null);
        Task<List<UkPayCategoryModel>> ListPayCategoriesAsync(int businessId, ListPayCategoriesQueryModel request, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        List<UkPayCategoryModel> ListPayCategories(int businessId, ODataQuery oDataQuery = null);
        Task<List<UkPayCategoryModel>> ListPayCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default);
        UkPayCategoryModel CreatePayCategory(int businessId, UkPayCategoryModel payCategory);
        Task<UkPayCategoryModel> CreatePayCategoryAsync(int businessId, UkPayCategoryModel payCategory, CancellationToken cancellationToken = default);
        UkPayCategoryModel GetPayCategoryById(int businessId, int id);
        Task<UkPayCategoryModel> GetPayCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        UkPayCategoryModel UpdatePayCategory(int businessId, int id, UkPayCategoryModel payCategory);
        Task<UkPayCategoryModel> UpdatePayCategoryAsync(int businessId, int id, UkPayCategoryModel payCategory, CancellationToken cancellationToken = default);
        void DeletePayCategory(int businessId, int id);
        Task DeletePayCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void MarkPayCategoryInactive(int businessId, int id);
        Task MarkPayCategoryInactiveAsync(int businessId, int id, CancellationToken cancellationToken = default);
        void ReactivatePayCategory(int businessId, int id, ReactivatePayCategoryApiRequest request);
        Task ReactivatePayCategoryAsync(int businessId, int id, ReactivatePayCategoryApiRequest request, CancellationToken cancellationToken = default);
    }
    public class PayCategoryFunction : BaseFunction, IPayCategoryFunction
    {
        public PayCategoryFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Pay Categories
        /// </summary>
        /// <remarks>
        /// Lists the pay categories for the business. Inactive pay categories are excluded unless includeInactive is true.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<UkPayCategoryModel> ListPayCategories(int businessId, ListPayCategoriesQueryModel request, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkPayCategoryModel>>($"/business/{businessId}/paycategory{ToQueryString("query=" + request.Query, "includeInactive=" + request.IncludeInactive)}{ODataQuery.ToQueryString(oDataQuery, "&")}", Method.Get);
        }

        /// <summary>
        /// List Pay Categories
        /// </summary>
        /// <remarks>
        /// Lists the pay categories for the business. Inactive pay categories are excluded unless includeInactive is true.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<UkPayCategoryModel>> ListPayCategoriesAsync(int businessId, ListPayCategoriesQueryModel request, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkPayCategoryModel>>($"/business/{businessId}/paycategory{ToQueryString("query=" + request.Query, "includeInactive=" + request.IncludeInactive)}{ODataQuery.ToQueryString(oDataQuery, "&")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Pay Categories
        /// </summary>
        /// <remarks>
        /// Lists the pay categories for the business. Inactive pay categories are excluded unless includeInactive is true.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<UkPayCategoryModel> ListPayCategories(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<UkPayCategoryModel>>($"/business/{businessId}/paycategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Pay Categories
        /// </summary>
        /// <remarks>
        /// Lists the pay categories for the business. Inactive pay categories are excluded unless includeInactive is true.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<UkPayCategoryModel>> ListPayCategoriesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkPayCategoryModel>>($"/business/{businessId}/paycategory{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Pay Category
        /// </summary>
        /// <remarks>
        /// Creates a new pay category for the business.
        /// </remarks>
        public UkPayCategoryModel CreatePayCategory(int businessId, UkPayCategoryModel payCategory)
        {
            return ApiRequest<UkPayCategoryModel,UkPayCategoryModel>($"/business/{businessId}/paycategory", payCategory, Method.Post);
        }

        /// <summary>
        /// Create Pay Category
        /// </summary>
        /// <remarks>
        /// Creates a new pay category for the business.
        /// </remarks>
        public Task<UkPayCategoryModel> CreatePayCategoryAsync(int businessId, UkPayCategoryModel payCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkPayCategoryModel,UkPayCategoryModel>($"/business/{businessId}/paycategory", payCategory, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Pay Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay category with the specified ID.
        /// </remarks>
        public UkPayCategoryModel GetPayCategoryById(int businessId, int id)
        {
            return ApiRequest<UkPayCategoryModel>($"/business/{businessId}/paycategory/{id}", Method.Get);
        }

        /// <summary>
        /// Get Pay Category by ID
        /// </summary>
        /// <remarks>
        /// Gets the pay category with the specified ID.
        /// </remarks>
        public Task<UkPayCategoryModel> GetPayCategoryByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkPayCategoryModel>($"/business/{businessId}/paycategory/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Pay Category
        /// </summary>
        /// <remarks>
        /// Updates the pay category with the specified ID.
        /// </remarks>
        public UkPayCategoryModel UpdatePayCategory(int businessId, int id, UkPayCategoryModel payCategory)
        {
            return ApiRequest<UkPayCategoryModel,UkPayCategoryModel>($"/business/{businessId}/paycategory/{id}", payCategory, Method.Put);
        }

        /// <summary>
        /// Update Pay Category
        /// </summary>
        /// <remarks>
        /// Updates the pay category with the specified ID.
        /// </remarks>
        public Task<UkPayCategoryModel> UpdatePayCategoryAsync(int businessId, int id, UkPayCategoryModel payCategory, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkPayCategoryModel,UkPayCategoryModel>($"/business/{businessId}/paycategory/{id}", payCategory, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Pay Category
        /// </summary>
        /// <remarks>
        /// Deletes the pay category with the specified ID.
        /// </remarks>
        public void DeletePayCategory(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/paycategory/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Pay Category
        /// </summary>
        /// <remarks>
        /// Deletes the pay category with the specified ID.
        /// </remarks>
        public Task DeletePayCategoryAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paycategory/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Mark Pay Category Inactive
        /// </summary>
        /// <remarks>
        /// Marks the pay category, and every one of its linked pay categories, as inactive.
        /// Rejected with an explanatory message if the pay category is still referenced elsewhere.
        /// </remarks>
        public void MarkPayCategoryInactive(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/paycategory/{id}/inactivate", Method.Post);
        }

        /// <summary>
        /// Mark Pay Category Inactive
        /// </summary>
        /// <remarks>
        /// Marks the pay category, and every one of its linked pay categories, as inactive.
        /// Rejected with an explanatory message if the pay category is still referenced elsewhere.
        /// </remarks>
        public Task MarkPayCategoryInactiveAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paycategory/{id}/inactivate", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Reactivate Pay Category
        /// </summary>
        /// <remarks>
        /// Reactivates the pay category, optionally cascading to its linked pay categories.
        /// </remarks>
        public void ReactivatePayCategory(int businessId, int id, ReactivatePayCategoryApiRequest request)
        {
            ApiRequest($"/business/{businessId}/paycategory/{id}/reactivate", request, Method.Post);
        }

        /// <summary>
        /// Reactivate Pay Category
        /// </summary>
        /// <remarks>
        /// Reactivates the pay category, optionally cascading to its linked pay categories.
        /// </remarks>
        public Task ReactivatePayCategoryAsync(int businessId, int id, ReactivatePayCategoryApiRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/paycategory/{id}/reactivate", request, Method.Post, cancellationToken);
        }
    }
}

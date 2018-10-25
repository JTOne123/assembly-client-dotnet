using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class SubjectsResource : Resource
	{
		public SubjectsResource(ApiClient client)
			: base(client)
		{

		}

		/// <summary>
		/// List Subjects
		/// </summary>
		/// <remarks>
		/// Returns a list of the Assembly Platform&#39;s subjects.
		/// </remarks>
		/// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="perPage">Number of results to return (optional, default to 100)</param>
		/// <param name="page">Page number to return (optional, default to 1)</param>
		/// <returns>List&lt;Subject&gt;</returns>
		public async Task<List<Subject>> List(
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<Subject>($"/subjects", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public SubjectsResource Subjects => new SubjectsResource(this);
	}
}

using System.Data;
using AzureWebApps.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace AzureWebApps.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<Courses> courses = new List<Courses>(); 
        private readonly IConfiguration _configuration;

    public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
    {
            _configuration = configuration;
        _logger = logger;
    }

    public void OnGet()
    {
        // string connectionString = _configuration.GetConnectionString("AzureConnectionString") ?? string.Empty;
        // if(string.IsNullOrEmpty(connectionString))
        // {
        //     throw new Exception("No Connection string in appSettings.json");
        // }
        // var connection = new SqlConnection(connectionString);
        // connection.Open();

        // SqlCommand command = new SqlCommand("select * from courses", connection);
        // using(SqlDataReader sqlDataAdapter = command.ExecuteReader())   
        // {
        //     while(sqlDataAdapter.Read())    
        //     {
        //         courses.Add(new Courses () 
        //         {
                    
        //             CourseId = sqlDataAdapter.GetInt32("id"),
        //             CourseName = sqlDataAdapter.GetString("course_name"),
        //             Rating = sqlDataAdapter.GetString("rating")
        //         });
        //     }
        // }
        // connection.Close();
        


    }
}

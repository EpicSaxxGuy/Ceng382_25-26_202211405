using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Week6FormApp.Models;

namespace Week6FormApp.Pages
{
    public class IndexModel : PageModel
    {
        
        public List<ClassInformationTable> AllClasses { get; set; } = new();

       
        [BindProperty(SupportsGet = true)]
        public string? ClassNameFilter { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Page { get; set; } = 1;

        public int PageSize { get; set; } = 10;
        public int TotalPages { get; set; }

        public void OnGet()
        {
            Console.WriteLine($"PAGE PARAMETER: {Page}");

            var allData = new List<ClassInformationTable>();
            for (int i = 1; i <= 120; i++)
            {
                allData.Add(new ClassInformationTable
                {
                    Id = i,
                    ClassName = $"Class A{i}",
                    StudentCount = 20 + (i % 10),
                    Description = $"Generated Description for Class A{i}"
                });
            }

            
            if (!string.IsNullOrWhiteSpace(ClassNameFilter))
            {
                allData = allData
                    .Where(c => c.ClassName.Contains(ClassNameFilter, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            
            TotalPages = (int)Math.Ceiling(allData.Count / (double)PageSize);

            
            AllClasses = allData
                .Skip((Page - 1) * PageSize)
                .Take(PageSize)
                .ToList();
        }
    }
}

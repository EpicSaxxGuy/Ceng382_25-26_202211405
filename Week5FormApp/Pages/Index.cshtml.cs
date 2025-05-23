using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Week5FormApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace Week5FormApp.Pages
{
    public class IndexModel : PageModel
    {
        public static List<ClassInformationModel> ClassList { get; set; } = new List<ClassInformationModel>();

        [BindProperty]
        public ClassInformationModel ClassInfo { get; set; }

        [BindProperty]
        public int EditId { get; set; }

        public void OnGet()
        {
            ClassInfo = new ClassInformationModel();
        }

        public IActionResult OnPostAdd()
        {
            if (!ModelState.IsValid)
                return Page();

            ClassList.Add(new ClassInformationModel
            {
                ClassName = ClassInfo.ClassName,
                StudentCount = ClassInfo.StudentCount,
                Description = ClassInfo.Description
            });

            return RedirectToPage();
        }

        public IActionResult OnPostDelete(int id)
        {
            var item = ClassList.FirstOrDefault(x => x.Id == id);
            if (item != null)
                ClassList.Remove(item);

            return RedirectToPage();
        }

        public void OnPostEdit(int id)
        {
            var item = ClassList.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                ClassInfo = new ClassInformationModel
                {
                    ClassName = item.ClassName,
                    StudentCount = item.StudentCount,
                    Description = item.Description
                };

                EditId = id;
            }
        }

        public IActionResult OnPostUpdate()
        {
            if (!ModelState.IsValid)
                return Page();

            var item = ClassList.FirstOrDefault(x => x.Id == EditId);
            if (item != null)
            {
                item.ClassName = ClassInfo.ClassName;
                item.StudentCount = ClassInfo.StudentCount;
                item.Description = ClassInfo.Description;
            }

            return RedirectToPage();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEnrolment.Models.ViewModels;
using StudentEnrolment.Models;
using StudentEnrolment.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudentEnrolment.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EnrollmentController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var student = _context.Students.Include(c => c.StudentCourses);
            return View(student);
        }
        public IActionResult Create()
        {
            var student = new Student();
            var courses = _context.Courses.ToList();
            var viewModel = new EnrollmentViewModel
            {
                Student = student,
                Courses = courses
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EnrollmentViewModel viewModel, IFormFile? file)
        {
            string wwwRootPath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads");
            if (file != null)
            {
                string newFileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(wwwRootPath, @"Uploads\Students");
                var loadedImage = file.FileName;
                Path.GetExtension(loadedImage);
                var extension = Path.GetExtension(file.FileName);

                using (var fileStreams = new FileStream(Path.Combine(uploads, newFileName + extension), FileMode.Create))
                {
                    file.CopyTo(fileStreams);
                }
                viewModel.Student.ImageUrl = @"\Uploads\Students\" + newFileName + extension;
            }
            _context.Students.Add(viewModel.Student);
            _context.SaveChanges();
            
            foreach (var courseId in viewModel.SelectedCourseIds)
            {
                _context.StudentCourses.Add(new StudentCourse
                {
                    StudentId = viewModel.Student.Id,
                    CourseId = courseId
                });
            }
            await _context.SaveChangesAsync();
            TempData["success"] = "Student registered successfully";
            return RedirectToAction("Index");


            //return View(viewModel);

        }                    
    private string UploadImage(EnrollmentViewModel model, IFormFile image)
        {
            if (image != null && image.Length > 0)
            {
                var fileName = Path.GetFileNameWithoutExtension(image.FileName);
                var extension = Path.GetExtension(image.FileName);
                var newFileName = fileName + DateTime.Now.ToString("yyyyMMddHHmmssfff") + extension;

                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", newFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(fileStream);
                }
                return newFileName;
            }
            return "No file uploaded";
        }
    }
}

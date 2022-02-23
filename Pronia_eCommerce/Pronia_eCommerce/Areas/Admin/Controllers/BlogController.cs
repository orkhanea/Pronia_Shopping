using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.Models;
using Pronia_eCommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BlogController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.Include(b => b.BlogTagToBlogs).ThenInclude(bt => bt.BlogTag).Include(b => b.Category).Include(b => b.Comments).OrderByDescending(b=>b.CreatedDate).ToList();
            return View(blogs);
        }

        public IActionResult BlogDetail(int? Id)
        {
            if (Id != null)
            {
                VmBlog model2 = new();
                if (_context.Blogs.Find(Id) != null)
                {
                    model2.BlogDetail = _context.Blogs.Include(c => c.Comments)
                                                      .ThenInclude(cu => cu.User)
                                                      .Include(c => c.Comments).ThenInclude(cp => cp.CommentPost).Include(b => b.BlogTagToBlogs).ThenInclude(bt => bt.BlogTag).Include(t => t.Category).FirstOrDefault(b => b.Id == Id);
                    model2.BlogCategories = _context.BlogCategories.ToList();
                    model2.BlogTags = _context.BlogTags.ToList();

                    return View(model2);
                }
                else
                {
                    TempData["BlogError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["BlogError"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        public IActionResult Create()
        {
            ViewBag.Tags = _context.BlogTags.ToList();
            ViewBag.Category = _context.BlogCategories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            if (ModelState.IsValid)
            {
                if (blog.ImageFile != null)
                {
                    if (blog.ImageFile.ContentType == "image/jpeg" || blog.ImageFile.ContentType == "image/png")
                    {
                        if (blog.ImageFile.Length < 3000000)
                        {
                            string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + blog.ImageFile.FileName;
                            string FilePath2 = Path.Combine(_webHostEnvironment.WebRootPath, "img", "blog", ImageName2);

                            using (var Stream = new FileStream(FilePath2, FileMode.Create))
                            {
                                blog.ImageFile.CopyTo(Stream);
                            }

                            blog.Image = ImageName2;
                            blog.CreatedDate = DateTime.Now;
                            blog.VideoLink = null;
                            //blog.CustomUserId = _userManager.GetUserId(User);
                            _context.Blogs.Add(blog);
                            _context.SaveChanges();

                            if (blog.BlogTagToBlogId != null && blog.BlogTagToBlogId.Count > 0)
                            {

                                foreach (var item in blog.BlogTagToBlogId)
                                {
                                    BlogTagToBlog blogTagToBlog = new();
                                    blogTagToBlog.BlogTagId = item;
                                    blogTagToBlog.BlogId = blog.Id;
                                    _context.BlogTagToBlogs.Add(blogTagToBlog);

                                }
                                _context.SaveChanges();

                            }


                            return RedirectToAction("Index");

                        }
                        else
                        {
                            TempData["BlogError3"] = "The size of the Image file must be less than 3 MB";
                            return View(blog);
                        }
                    }
                    else
                    {
                        TempData["BlogError3"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(blog);
                    }
                }
                else if (blog.ImageFile == null && blog.VideoLink!=null)
                {
                    blog.Image = null;
                    blog.CreatedDate = DateTime.Now;
                    //blog.CustomUserId = _userManager.GetUserId(User);
                    _context.Blogs.Add(blog);
                    _context.SaveChanges();

                    if (blog.BlogTagToBlogId != null && blog.BlogTagToBlogId.Count > 0)
                    {

                        foreach (var item in blog.BlogTagToBlogId)
                        {
                            BlogTagToBlog blogTagToBlog = new();
                            blogTagToBlog.BlogTagId = item;
                            blogTagToBlog.BlogId = blog.Id;
                            _context.BlogTagToBlogs.Add(blogTagToBlog);

                        }
                        _context.SaveChanges();

                    }


                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["BlogError3"] = "Image field or Video Link must not be empty. Please choose one of them!";
                    return View(blog);
                }
            }
            else
            {

                ViewBag.Tags = _context.BlogTags.ToList();
                ViewBag.Category = _context.BlogCategories.ToList();
                return View(blog);
            }

        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.Blogs.Find(Id) != null)
                {
                    ViewBag.Tags = _context.BlogTags.ToList();
                    ViewBag.Category = _context.BlogCategories.ToList();
                    Blog blog = _context.Blogs.Include(b => b.Category).Include(b => b.BlogTagToBlogs).ThenInclude(bt => bt.BlogTag).FirstOrDefault(b => b.Id == Id);
                    blog.BlogTagToBlogId = _context.BlogTagToBlogs.Where(bt => bt.BlogId == Id).Select(bb => bb.BlogTagId).ToList();

                    return View(blog);

                }
                else
                {
                    TempData["BlogError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["BlogError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(Blog blog)
        {
            if (ModelState.IsValid)
            {
                if (blog.ImageFile != null)
                {
                    if (blog.ImageFile.ContentType == "image/jpeg" || blog.ImageFile.ContentType == "image/png")
                    {
                        if (blog.ImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(blog.Image))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "blog", blog.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + blog.ImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "blog", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                blog.ImageFile.CopyTo(Stream);
                            }

                            blog.Image = ImageName;
                            blog.VideoLink = null;

                        }
                        else
                        {
                            ViewBag.Tags = _context.BlogTags.ToList();
                            ViewBag.Category = _context.BlogCategories.ToList();
                            TempData["BlogError2"] = "The size of the Image file must be less than 3 MB";
                            return View(blog);
                        }
                    }
                    else
                    {
                        ViewBag.Tags = _context.BlogTags.ToList();
                        ViewBag.Category = _context.BlogCategories.ToList();
                        TempData["BlogError2"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(blog);
                    }

                }
                else if (blog.ImageFile==null && blog.VideoLink !=null)
                {
                    blog.Image = null;
                }
                _context.SaveChanges();

                //Delete old BlogTagToBlog
                List<BlogTagToBlog> blogTagToBlog = _context.BlogTagToBlogs.Where(t => t.BlogId == blog.Id).ToList();
                foreach (var item in blogTagToBlog)
                {
                    _context.BlogTagToBlogs.Remove(item);
                    _context.SaveChanges();
                }

                //Create new BlogTagToBlog
                if (blog.BlogTagToBlogId != null && blog.BlogTagToBlogId.Count > 0)
                {

                    foreach (var item in blog.BlogTagToBlogId)
                    {
                        BlogTagToBlog blogTagToBlog1 = new();
                        blogTagToBlog1.BlogTagId = item;
                        blogTagToBlog1.BlogId = blog.Id;
                        _context.BlogTagToBlogs.Add(blogTagToBlog1);
                        _context.SaveChanges();
                    }

                }

                _context.Blogs.Update(blog);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(blog);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                Blog blog = _context.Blogs.Find(Id);
                if (blog != null)
                {
                    if (!string.IsNullOrEmpty(blog.Image))
                    {
                        string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "blog", blog.Image);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    List<Comment> comments = _context.Comments.Include(c => c.CommentPost).Where(c => c.BlogId == Id).ToList();
                    List<CommentPost> commentPosts = comments.Select(c => c.CommentPost).ToList();

                    foreach (var cp in commentPosts)
                    {
                        _context.CommentPosts.Remove(cp);
                    }

                    foreach (var c in comments)
                    {
                        _context.Comments.Remove(c);
                    }

                    _context.Blogs.Remove(blog);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["BlogError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["BlogError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        public IActionResult DeleteCom(int? Id)
        {
            if (Id != null)
            {
                if (_context.Comments.Find(Id) != null)
                {
                    Comment comment = _context.Comments.Include(c => c.CommentPost).FirstOrDefault(c => c.Id == Id);
                    List<Comment> comment1 = _context.Comments.Include(c => c.CommentPost).Where(c => c.ParentCommentId == comment.Id).ToList();
                    CommentPost commentPost = comment.CommentPost;
                    List<CommentPost> commentPost2 = comment1.Select(c => c.CommentPost).ToList();
                    _context.CommentPosts.Remove(commentPost);
                    foreach (var m in comment1)
                    {
                        _context.Comments.Remove(m);
                    }

                    foreach (var m in commentPost2)
                    {
                        _context.CommentPosts.Remove(m);
                    }

                    _context.Comments.Remove(comment);
                    _context.SaveChanges();
                    return RedirectToAction("BlogDetail", new { Id = (int)TempData["IdForAction"] });
                }
                else
                {
                    TempData["CommentError"] = "Such an id does not exist";
                    return RedirectToAction("BlogDetail", new { Id = (int)TempData["IdForAction"] });
                }
            }
            else
            {
                TempData["CommentError"] = "Id must not be null";
                return RedirectToAction("BlogDetail", new { Id = (int)TempData["IdForAction"] });
            }
        }
    }
}

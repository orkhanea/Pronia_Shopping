using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.Models;
using Pronia_eCommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public BlogController(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index(VmSearch Search)
        {
            
            VmBlog model = new();
            if (Search==null|| Search.Page == null)
            {
                Search.Page = 1;
            }
            double PageItemCount = 6;
            model.LatestBlogs = _context.Blogs.OrderByDescending(b => b.CreatedDate).Where(p => p.Image != null).Take(3).ToList();
            List<Blog> blogs = _context.Blogs.Where(b=>(Search.SearchData != null?b.Title.Contains(Search.SearchData) :true)&&
                                              (Search.SearchCategory != null?b.BlogCategoryId== Search.SearchCategory : true)&&
                                              (Search.SearchTag != null?b.BlogTagToBlogs.Any(bt=>bt.BlogTagId== Search.SearchTag) :true)).OrderByDescending(p=>p.CreatedDate).ToList();

            int pageCount = (int)Math.Ceiling(Convert.ToDecimal(blogs.Count / PageItemCount));

            model.Blogs = blogs.Skip(((int)Search.Page - 1) * (int)PageItemCount).Take((int)PageItemCount).ToList();
            ViewBag.PageCount = pageCount;
            ViewBag.Page = Search.Page;
            model.Search = Search;
            model.Setting = _context.Setting.FirstOrDefault();
            model.SiteSocial = _context.SiteSocials.ToList();
            model.BlogCategories = _context.BlogCategories.ToList();
            model.BlogTags = _context.BlogTags.ToList();
            model.CollectionS = _context.CollectionS.FirstOrDefault();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Title.ToLower() == "all blogs");

            return View(model);
        }

        public IActionResult SingleBlog(int? Id, VmSearch search)
        {
            if (Id!=null)
            {
                VmBlog model2 = new();
                if (_context.Blogs.Find(Id)!=null)
                {
                    model2.LatestBlogs = _context.Blogs.OrderByDescending(b => b.CreatedDate).Where(p => p.Image != null).Take(3).ToList();
                    model2.BlogDetail = _context.Blogs.Include(c => c.Comments)
                                                      .ThenInclude(cu=>cu.User)
                                                      .Include(c=>c.Comments).ThenInclude(cp => cp.CommentPost).Include(b=>b.BlogTagToBlogs).ThenInclude(bt=>bt.BlogTag).Include(t=>t.Category).FirstOrDefault(b=>b.Id==Id);

                    model2.Search = search;
                    model2.Setting = _context.Setting.FirstOrDefault();
                    model2.SiteSocial = _context.SiteSocials.ToList();
                    model2.BlogCategories = _context.BlogCategories.ToList();
                    model2.BlogTags = _context.BlogTags.ToList();
                    model2.CollectionS = _context.CollectionS.FirstOrDefault();
                    model2.Banner = _context.Banners.FirstOrDefault(b => b.Title.ToLower() == "blog detail");

                    return View(model2);
                }

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");


        }

        public IActionResult PostComment(CommentPost commentPost)
        {
            if (ModelState.IsValid)
            {

                _context.CommentPosts.Add(commentPost);
                _context.SaveChanges();

                Comment comment = new();
                comment.BlogId = commentPost.BlogId;
                comment.CommentPostId = commentPost.Id;
                comment.CreatedDate = DateTime.Now;
                comment.Content = commentPost.Content;

                if (commentPost.CommentId > 0)
                {
                    comment.ParentCommentId = commentPost.CommentId;
                }

                _context.Comments.Add(comment);
                _context.SaveChanges();


            }
            else
            {
                if (_signInManager.IsSignedIn(User)&&commentPost.FullName==null&&commentPost.Email==null&&commentPost.Content!=null)
                {
                    commentPost.FullName = "";
                    commentPost.Email = "";
                    _context.CommentPosts.Add(commentPost);
                    _context.SaveChanges();
                    Comment comment = new();
                    comment.BlogId = commentPost.BlogId;
                    comment.CommentPostId = commentPost.Id;
                    comment.UserId = _userManager.GetUserId(User);
                    comment.CreatedDate = DateTime.Now;
                    comment.Content = commentPost.Content;

                    if (commentPost.CommentId > 0)
                    {
                        comment.ParentCommentId = commentPost.CommentId;
                    }

                    _context.Comments.Add(comment);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("SingleBlog", new { Id = commentPost.BlogId });

        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ShopController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {

            List<Product> products = _context.Products
                                             .Include(p => p.ProductImages)
                                             .Include(p => p.ProductSizeToProducts)
                                             .ThenInclude(ps => ps.ProductSize)
                                             .Include(p => p.Ratings).OrderByDescending(p=>p.CreatedDate).Where(p=>p.Archived==false).ToList();

            return View(products);
        }

        [Authorize(Roles = "SuperAdmin")]
        public IActionResult ArchiveIndex()
        {
            List<Product> products = _context.Products
                                                         .Include(p => p.ProductImages)
                                                         .Include(p => p.ProductSizeToProducts)
                                                         .ThenInclude(ps => ps.ProductSize)
                                                         .Include(p => p.Ratings).OrderByDescending(p => p.CreatedDate).Where(p => p.Archived == true).ToList();

            return View(products);
        }

        public IActionResult ProductDetail(int? Id)
        {
            if (Id !=null)
            {
                if (_context.Products.Find(Id) !=null)
                {
                    Product product = _context.Products
                                             .Include(p => p.ProductImages)
                                             .Include(p => p.ProductSizeToProducts)
                                             .ThenInclude(ps => ps.ProductSize)
                                             .Include(p => p.ProductCat)
                                             .Include(p => p.ProductTagToProducts)
                                             .ThenInclude(pt => pt.ProductTag)
                                             .Include(p => p.ProductComments)
                                             .ThenInclude(pc => pc.CommentPost)
                                             .Include(p => p.ProductComments)
                                             .ThenInclude(pc => pc.User)
                                             .Include(p=>p.Ratings)
                                             .FirstOrDefault(p => p.Id == Id);

                    return View(product);
                }
                else
                {
                    TempData["ProductError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ProductError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Create()
        {
            ViewBag.ProdTags = _context.ProductTags.ToList();
            ViewBag.prodCat = _context.ProductCats.ToList();
            VmCreateProduct createProduct = new();
            createProduct.sizes = _context.ProductSizes.ToList();
            return View(createProduct);
        }

        [HttpPost]
        public IActionResult Create(VmCreateProduct vmCreateProduct)
        {
            if (vmCreateProduct.product.Name!=null && vmCreateProduct.product.ShortDesc!=null && vmCreateProduct.product.FullDesc!=null)
            {
                if (vmCreateProduct.productSizeToProduct.Any(ps => ps.Quantity > 0) && vmCreateProduct.productSizeToProduct.Any(ps => ps.Price > 0))
                {
                    if (vmCreateProduct.product.ProductCatId==0)
                    {
                        ViewBag.ProdTags = _context.ProductTags.ToList();
                        ViewBag.prodCat = _context.ProductCats.ToList();
                        vmCreateProduct.sizes = _context.ProductSizes.ToList();
                        TempData["ProductError"] = "Please choose a category";
                        return View(vmCreateProduct);
                    }

                    if (vmCreateProduct.product.ProductTagToProductId==null)
                    {
                        ViewBag.ProdTags = _context.ProductTags.ToList();
                        ViewBag.prodCat = _context.ProductCats.ToList();
                        vmCreateProduct.sizes = _context.ProductSizes.ToList();
                        TempData["ProductError"] = "Please choose at least one tag";
                        return View(vmCreateProduct);
                    }

                    if (vmCreateProduct.productImage != null)
                    {
                        foreach (var testimg in vmCreateProduct.productImage)
                        {
                            if (testimg.ContentType == "image/jpeg" || testimg.ContentType == "image/png")
                            {
                                if (testimg.Length < 3000000)
                                {

                                }
                                else
                                {
                                    ViewBag.ProdTags = _context.ProductTags.ToList();
                                    ViewBag.prodCat = _context.ProductCats.ToList();
                                    vmCreateProduct.sizes = _context.ProductSizes.ToList();
                                    TempData["ProductError"] = "The size of the Image file must be less than 3 MB";
                                    return View(vmCreateProduct);
                                }
                            }
                            else
                            {
                                ViewBag.ProdTags = _context.ProductTags.ToList();
                                ViewBag.prodCat = _context.ProductCats.ToList();
                                vmCreateProduct.sizes = _context.ProductSizes.ToList();
                                TempData["ProductError"] = "The type of Image file can only be jpeg/jpg or png";
                                return View(vmCreateProduct);
                            }
                        }

                        List<string> prImages = new();

                        foreach (var img in vmCreateProduct.productImage)
                        {
                            string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + img.FileName;
                            string FilePath2 = Path.Combine(_webHostEnvironment.WebRootPath, "img", "products", ImageName2);
                            using (var Stream = new FileStream(FilePath2, FileMode.Create))
                            {
                                img.CopyTo(Stream);
                            }
                            prImages.Add(ImageName2);
                        }

                        Product newProduct = new();
                        newProduct.CreatedDate = DateTime.Now;
                        newProduct.FullDesc = vmCreateProduct.product.FullDesc;
                        newProduct.ShortDesc = vmCreateProduct.product.ShortDesc;
                        newProduct.Name = vmCreateProduct.product.Name;
                        newProduct.ProductCatId = vmCreateProduct.product.ProductCatId;
                        Random rnd = new Random();
                        int myRandomNo = rnd.Next(00000000, 99999999);
                        newProduct.SKU = vmCreateProduct.product.Name.Substring(0,3).ToUpper() + "-" + myRandomNo;

                        _context.Products.Add(newProduct);
                        _context.SaveChanges();

                        foreach (var imgs in prImages)
                        {
                            ProductImage primg = new();
                            primg.Image = imgs;
                            primg.ProductId = newProduct.Id;
                            _context.ProductImages.Add(primg);
                            _context.SaveChanges();
                        }

                        if (vmCreateProduct.product.ProductTagToProductId != null && vmCreateProduct.product.ProductTagToProductId.Count > 0)
                        {
                            foreach (var item in vmCreateProduct.product.ProductTagToProductId)
                            {
                                ProductTagToProduct productTagToProduct = new();
                                productTagToProduct.ProductTagId = item;
                                productTagToProduct.ProductId = newProduct.Id;
                                _context.ProductTagToProducts.Add(productTagToProduct);

                            }
                            _context.SaveChanges();
                        }

                        foreach (var psp in vmCreateProduct.productSizeToProduct)
                        {
                            ProductSizeToProduct productSizeToProduct = new();
                            productSizeToProduct.Price = psp.Price;
                            productSizeToProduct.ProductId = newProduct.Id;
                            productSizeToProduct.ProductSizeId = psp.ProductSizeId;
                            productSizeToProduct.Quantity = psp.Quantity;
                            _context.ProductSizeToProducts.Add(productSizeToProduct);
                            _context.SaveChanges();
                        }

                        _context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.ProdTags = _context.ProductTags.ToList();
                        ViewBag.prodCat = _context.ProductCats.ToList();
                        vmCreateProduct.sizes = _context.ProductSizes.ToList();
                        TempData["ProductError"] = "You should choose at least 1 image!";
                        return View(vmCreateProduct);
                    }
                }
                else
                {
                    ViewBag.ProdTags = _context.ProductTags.ToList();
                    ViewBag.prodCat = _context.ProductCats.ToList();
                    vmCreateProduct.sizes = _context.ProductSizes.ToList();
                    TempData["ProductError"] = "At least one size and quantity should choosen!";
                    return View(vmCreateProduct);
                }
            }
            else
            {
                ViewBag.ProdTags = _context.ProductTags.ToList();
                ViewBag.prodCat = _context.ProductCats.ToList();
                vmCreateProduct.sizes = _context.ProductSizes.ToList();
                TempData["ProductError"] = "Please fill in the fields marked with an asterisk(*)";
                return View(vmCreateProduct);
            }
        }
    
        public IActionResult Update(int? Id)
        {
            if (Id!=null)
            {
                if (_context.Products.Find(Id)!=null)
                {
                    ViewBag.ProdTags = _context.ProductTags.ToList();
                    ViewBag.prodCat = _context.ProductCats.ToList();
                    VmCreateProduct createProduct = new();
                    createProduct.sizes = _context.ProductSizes.ToList();
                    createProduct.product = _context.Products
                                             .Include(p => p.ProductImages)
                                             .Include(p => p.ProductSizeToProducts)
                                             .ThenInclude(ps => ps.ProductSize)
                                             .Include(p => p.ProductCat)
                                             .Include(p => p.ProductTagToProducts)
                                             .ThenInclude(pt => pt.ProductTag)
                                             .Include(p => p.ProductComments)
                                             .ThenInclude(pc => pc.CommentPost)
                                             .Include(p => p.ProductComments)
                                             .ThenInclude(pc => pc.User)
                                             .Include(p => p.Ratings)
                                             .FirstOrDefault(p => p.Id == Id);
                    createProduct.product.ProductTagToProductId = _context.ProductTagToProducts.Where(bt => bt.ProductId == Id).Select(bb => bb.ProductTagId).ToList();

                    return View(createProduct);
                }
                else
                {
                    TempData["ProductError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ProductError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(VmCreateProduct vmCreateProduct)
        {


            if (ModelState.IsValid)
            {
                if (vmCreateProduct.product.Name != null && vmCreateProduct.product.ShortDesc != null && vmCreateProduct.product.FullDesc != null)
                {
                    if (vmCreateProduct.productSizeToProduct.Any(ps => ps.Quantity > 0) && vmCreateProduct.productSizeToProduct.Any(ps => ps.Price > 0))
                    {
                        if (vmCreateProduct.productImage != null)
                        {
                            foreach (var testimg in vmCreateProduct.productImage)
                            {
                                if (testimg.ContentType == "image/jpeg" || testimg.ContentType == "image/png")
                                {
                                    if (testimg.Length < 3000000)
                                    {

                                    }
                                    else
                                    {
                                        ViewBag.ProdTags = _context.ProductTags.ToList();
                                        ViewBag.prodCat = _context.ProductCats.ToList();
                                        vmCreateProduct.sizes = _context.ProductSizes.ToList();
                                        vmCreateProduct.product.ProductSizeToProducts = vmCreateProduct.productSizeToProduct;
                                        TempData["UpdateProductError"] = "The size of the Image file must be less than 3 MB";
                                        return View(vmCreateProduct);
                                    }
                                }
                                else
                                {
                                    ViewBag.ProdTags = _context.ProductTags.ToList();
                                    ViewBag.prodCat = _context.ProductCats.ToList();
                                    vmCreateProduct.sizes = _context.ProductSizes.ToList();
                                    vmCreateProduct.product.ProductSizeToProducts = vmCreateProduct.productSizeToProduct;
                                    TempData["UpdateProductError"] = "The type of Image file can only be jpeg/jpg or png";
                                    return View(vmCreateProduct);
                                }
                            }

                            foreach (var oldimg in _context.ProductImages.Where(i => i.ProductId == vmCreateProduct.product.Id).ToList())
                            {
                                if (!string.IsNullOrEmpty(oldimg.Image))
                                {
                                    string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "products", oldimg.Image);
                                    if (System.IO.File.Exists(oldImagePath))
                                    {
                                        System.IO.File.Delete(oldImagePath);
                                    }
                                }
                            }
                            _context.SaveChanges();

                            //Delete Old Images
                            List<ProductImage> productImage1 = _context.ProductImages.Where(pi => pi.ProductId == vmCreateProduct.product.Id).ToList();
                            foreach (var pi2 in productImage1)
                            {
                                _context.ProductImages.Remove(pi2);
                                _context.SaveChanges();
                            }

                            //Create new Images
                            List<string> prImages2 = new();
                            foreach (var img in vmCreateProduct.productImage)
                            {
                                string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + img.FileName;
                                string FilePath2 = Path.Combine(_webHostEnvironment.WebRootPath, "img", "products", ImageName2);
                                using (var Stream = new FileStream(FilePath2, FileMode.Create))
                                {
                                    img.CopyTo(Stream);
                                }
                                prImages2.Add(ImageName2);
                            }

                            foreach (var imgs in prImages2)
                            {
                                ProductImage primg = new();
                                primg.Image = imgs;
                                primg.ProductId = vmCreateProduct.product.Id;
                                _context.ProductImages.Add(primg);
                                _context.SaveChanges();
                            }
                        }

                        //Delete old BlogTagToBlog
                        List<ProductTagToProduct> productTagToProducts = _context.ProductTagToProducts.Where(t => t.ProductId == vmCreateProduct.product.Id).ToList();
                        foreach (var item in productTagToProducts)
                        {
                            _context.ProductTagToProducts.Remove(item);
                            _context.SaveChanges();
                        }

                        //Create new BlogTagToBlog
                        if (vmCreateProduct.product.ProductTagToProductId != null && vmCreateProduct.product.ProductTagToProductId.Count > 0)
                        {

                            foreach (var item in vmCreateProduct.product.ProductTagToProductId)
                            {
                                ProductTagToProduct productTagToProduct2 = new();
                                productTagToProduct2.ProductTagId = item;
                                productTagToProduct2.ProductId = vmCreateProduct.product.Id;
                                _context.ProductTagToProducts.Add(productTagToProduct2);
                                _context.SaveChanges();
                            }

                        }

                        List<ProductSizeToProduct> pstp = _context.ProductSizeToProducts.Where(ps => ps.ProductId == vmCreateProduct.product.Id).ToList();

                        foreach (var item in pstp)
                        {
                            _context.ProductSizeToProducts.Remove(item);
                            _context.SaveChanges();
                        }

                        foreach (var psp in vmCreateProduct.productSizeToProduct)
                        {
                            if (psp.Price > 0)
                            {
                                ProductSizeToProduct productSizeToProduct = new();
                                productSizeToProduct.Price = psp.Price;
                                productSizeToProduct.ProductId = vmCreateProduct.product.Id;
                                productSizeToProduct.ProductSizeId = psp.ProductSizeId;
                                productSizeToProduct.Quantity = psp.Quantity;
                                _context.ProductSizeToProducts.Add(productSizeToProduct);
                                _context.SaveChanges();
                            }
                        }

                        _context.Products.Update(vmCreateProduct.product);
                        _context.SaveChanges();
                        return RedirectToAction("Index");

                    }
                    else
                    {
                        ViewBag.ProdTags = _context.ProductTags.ToList();
                        ViewBag.prodCat = _context.ProductCats.ToList();
                        vmCreateProduct.sizes = _context.ProductSizes.ToList();
                        vmCreateProduct.product.ProductSizeToProducts = vmCreateProduct.productSizeToProduct;
                        TempData["ProductError"] = "At least one size and quantity should choosen!";
                        return View(vmCreateProduct);
                    }
                }
                else
                {
                    ViewBag.ProdTags = _context.ProductTags.ToList();
                    ViewBag.prodCat = _context.ProductCats.ToList();
                    vmCreateProduct.sizes = _context.ProductSizes.ToList();
                    TempData["ProductError"] = "Please fill in the fields marked with an asterisk(*)";
                    return View(vmCreateProduct);
                }
            }
            else
            {
                ViewBag.ProdTags = _context.ProductTags.ToList();
                ViewBag.prodCat = _context.ProductCats.ToList();
                vmCreateProduct.sizes = _context.ProductSizes.ToList();
                vmCreateProduct.product.ProductSizeToProducts = vmCreateProduct.productSizeToProduct;
                return View(vmCreateProduct);
            }
        }

        [Authorize(Roles = "SuperAdmin")]
        public IActionResult Delete(int? Id)
        {
            if (Id!=null)
            {
                Product product = _context.Products.Find(Id);
                if (product!=null)
                {
                    product.Archived = true;
                    _context.Products.Update(product);
                    _context.SaveChanges();
                    return RedirectToAction("Index");


                }
                else
                {
                    TempData["ProductError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ProductError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        [Authorize(Roles = "SuperAdmin")]
        public IActionResult UnArchive(int? Id)
        {
            if (Id != null)
            {
                Product product = _context.Products.Find(Id);
                if (product != null)
                {
                    product.Archived = false;
                    _context.Products.Update(product);
                    _context.SaveChanges();
                    return RedirectToAction("ArchiveIndex");


                }
                else
                {
                    TempData["ArchivedProductError"] = "Such an id does not exist";
                    return RedirectToAction("ArchiveIndex");
                }
            }
            else
            {
                TempData["ArchivedProductError"] = "Id must not be null";
                return RedirectToAction("ArchiveIndex");
            }
        }
    }
}

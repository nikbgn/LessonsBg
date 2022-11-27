namespace LessonsBg.Core.Services
{
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Data;
	using LessonsBg.Core.Data.Models;
	using LessonsBg.Core.Models;

	using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Configuration;



	/// <summary>
	/// Manipulates blog post data.
	/// </summary>

	public class BlogService : IBlogService
	{
		private readonly IConfiguration config;
		private readonly ApplicationDbContext context;

		/// <summary>
		/// Inversion of control.
		/// </summary>
		/// <param name="_config">Application configuration.</param>

		public BlogService(IConfiguration _config,
			ApplicationDbContext _context)
		{
			config = _config;
			context = _context;
		}

		/// <summary>
		/// Adds a new blog post
		/// </summary>
		/// <returns></returns>

		public async Task AddAsync(BlogPostModel model)
		{
			var blogPost = new BlogPost()
			{
				Title = model.Title,
				PostText = model.PostText,
				CreatedOn = DateTime.Now.Date,
				PostThumbnailURL = model.PostThumbnailURL,
				PostTextHeadingImageURL = model.PostTextHeadingImageURL
			};

			await context.BlogPosts.AddAsync(blogPost);
			await context.SaveChangesAsync();
		}


		/// <summary>
		/// Adds a comment to a blog post
		/// </summary>
		/// <param name="model"></param>
		/// <param name="authorId"></param>
		/// <param name="blogPostId"></param>
		/// <returns></returns>

		public async Task AddCommentAsync(BlogCommentModel model, string authorId, Guid blogPostId)
		{
			var author = await context.Users.FirstOrDefaultAsync(u => u.Id == authorId);
			var blogPost = await context.BlogPosts.FirstOrDefaultAsync(bp => bp.Id == blogPostId);

			if(blogPost != null && author != null) 
			{
				var comment = new BlogComment()
				{
					CommentText = model.CommentText,
					AuthorId = authorId,
					BlogPostId = blogPostId,
					CreatedOn = DateTime.Now,
					Author = author,
					BlogPost = blogPost
				};

				await context.BlogComments.AddAsync(comment);
				await context.SaveChangesAsync();
			}
			else
			{
				throw new ArgumentNullException("Invalid author id or blog post id");
			}

		}



		/// <summary>
		/// Deletes a comment from a blog post
		/// </summary>
		/// <param name="blogPostId"></param>
		/// <returns></returns>

		public async Task DeleteCommentAsync(Guid blogPostId, int commentId)
		{
			var comment = await context.BlogComments.FirstOrDefaultAsync(c => c.BlogPostId == blogPostId && c.Id == commentId);

			if(comment == null)
			{
				throw new ArgumentException("Comment does not exist");
			}

			context.BlogComments.Remove(comment);
			await context.SaveChangesAsync();



		}

		/// <summary>
		/// Gets all blog posts.
		/// </summary>
		/// <returns>List of blog posts.</returns>

		public async Task<IEnumerable<BlogPostModel>> GetAllAsync()
			=> await context.BlogPosts
				.Select(bp => new BlogPostModel()
				{
					Id = bp.Id,
					Title = bp.Title,
					PostThumbnailURL = bp.PostThumbnailURL,
					PostText = bp.PostText.Substring(0, 10),
					CreatedOn = bp.CreatedOn
				}).ToListAsync();



		/// <summary>
		/// Gets a specific blog post by ID
		/// </summary>
		/// <param name="blogPostId"></param>
		/// <returns></returns>

		public async Task<BlogPostModel> GetPostAsync(Guid blogPostId)
		{
			var postComments = await context.BlogComments
				.Where(bc => bc.BlogPostId == blogPostId)
				.Include(a => a.Author)
				.ToListAsync();

			var post = await context.BlogPosts
				.Where(bp => bp.Id == blogPostId)
				.Select(bp => new BlogPostModel()
				{
					Id = bp.Id,
					Title = bp.Title,
					PostText = bp.PostText,
					PostTextHeadingImageURL = bp.PostTextHeadingImageURL,
					PostThumbnailURL = bp.PostThumbnailURL,
					CreatedOn = bp.CreatedOn,
					BlogComments = postComments
				}).FirstOrDefaultAsync();

			if(post == null)
			{
				throw new ArgumentException("Invalid post ID!");
			}

			return post;

		}


		/// <summary>
		/// Deletes a blog post
		/// </summary>
		/// <param name="blogPostId"></param>
		/// <returns></returns>

		public async Task RemoveAsync(Guid blogPostId)
		{
			//Get post
			var post = context.BlogPosts.FirstOrDefault(bp => bp.Id == blogPostId);
			var postComments = context.BlogComments.Where(c => c.BlogPostId == blogPostId).ToList();
			if (post != null)
			{
				foreach (var comment in postComments)
				{
					context.BlogComments.Remove(comment);
				}
				context.Remove(post);
				await context.SaveChangesAsync();
			}
		}
	}
}

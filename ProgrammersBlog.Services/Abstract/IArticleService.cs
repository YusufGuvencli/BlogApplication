using System.Collections.Generic;
using System.Threading.Tasks;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;

namespace ProgrammersBlog.Services.Abstract
{
    public interface IArticleService
    {
        Task<IDataResult<ArticleDto>> Get(int articleId);

        Task<IDataResult<IList<ArticleListDto>>> GetAll();
        Task<IDataResult<IList<ArticleListDto>>> GetAllByNonDeleted();
        Task<IDataResult<IList<ArticleListDto>>> GetAllByNonDeletedAndActive();
        Task<IDataResult<IList<ArticleListDto>>> GetAllByCategory(int categoryId);
        Task<IResult> Add(ArticleAddDto articleAddDto, string createdByName);
        Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName);
        Task<IResult> Delete(int articleId, string modifiedByName);
        Task<IResult> HardDelete(int categoryId);
    }
}

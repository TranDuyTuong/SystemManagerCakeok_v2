using Library.DataTable.TableComment;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Comment_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class CommentRepository : GenericRepository<T_Comment>, ICommentRepository
    {
        public CommentRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}

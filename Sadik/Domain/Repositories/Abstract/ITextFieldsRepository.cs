using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sadik.Domain.Entities;

namespace Sadik.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string codeWord);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}

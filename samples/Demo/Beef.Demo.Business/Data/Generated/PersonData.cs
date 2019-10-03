/*
 * This file is automatically generated; any changes will be lost. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Business;
using Beef.Data.Database;
using Beef.Data.EntityFrameworkCore;
using Beef.Entities;
using Beef.Mapper;
using Beef.Mapper.Converters;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Business.Data
{
    /// <summary>
    /// Provides the Person data access.
    /// </summary>
    public partial class PersonData : IPersonData
    {
        #region Private

        private readonly Func<Person, IDatabaseArgs, Task> _createOnBeforeAsync = null;
        private readonly Func<Person, Task> _createOnAfterAsync = null;
        private readonly Action<Exception> _createOnException = null;

        private readonly Func<Guid, IDatabaseArgs, Task> _deleteOnBeforeAsync = null;
        private readonly Func<Guid, Task> _deleteOnAfterAsync = null;
        private readonly Action<Exception> _deleteOnException = null;

        private readonly Func<Guid, IDatabaseArgs, Task> _getOnBeforeAsync = null;
        private readonly Func<Person, Guid, Task> _getOnAfterAsync = null;
        private readonly Action<Exception> _getOnException = null;

        private readonly Func<Person, IDatabaseArgs, Task> _updateOnBeforeAsync = null;
        private readonly Func<Person, Task> _updateOnAfterAsync = null;
        private readonly Action<Exception> _updateOnException = null;

        private readonly Action<DatabaseParameters, IDatabaseArgs> _getAllOnQuery = null;
        private readonly Func<IDatabaseArgs, Task> _getAllOnBeforeAsync = null;
        private readonly Func<PersonCollectionResult, Task> _getAllOnAfterAsync = null;
        private readonly Action<Exception> _getAllOnException = null;

        private readonly Action<DatabaseParameters, IDatabaseArgs> _getAll2OnQuery = null;
        private readonly Func<IDatabaseArgs, Task> _getAll2OnBeforeAsync = null;
        private readonly Func<PersonCollectionResult, Task> _getAll2OnAfterAsync = null;
        private readonly Action<Exception> _getAll2OnException = null;

        private readonly Action<DatabaseParameters, PersonArgs, IDatabaseArgs> _getByArgsOnQuery = null;
        private readonly Func<PersonArgs, IDatabaseArgs, Task> _getByArgsOnBeforeAsync = null;
        private readonly Func<PersonCollectionResult, PersonArgs, Task> _getByArgsOnAfterAsync = null;
        private readonly Action<Exception> _getByArgsOnException = null;

        private readonly Action<Exception> _getDetailByArgsOnException = null;

        private readonly Action<Exception> _mergeOnException = null;

        private readonly Action<Exception> _markOnException = null;

        private readonly Action<Exception> _getDetailOnException = null;

        private readonly Action<Exception> _updateDetailOnException = null;

        private readonly Func<IQueryable<EfModel.Person>, PersonArgs, IEfDbArgs, IQueryable<EfModel.Person>> _getByArgsWithEfOnQuery = null;
        private readonly Func<PersonArgs, IEfDbArgs, Task> _getByArgsWithEfOnBeforeAsync = null;
        private readonly Func<PersonCollectionResult, PersonArgs, Task> _getByArgsWithEfOnAfterAsync = null;
        private readonly Action<Exception> _getByArgsWithEfOnException = null;

        private readonly Func<Guid, IEfDbArgs, Task> _getWithEfOnBeforeAsync = null;
        private readonly Func<Person, Guid, Task> _getWithEfOnAfterAsync = null;
        private readonly Action<Exception> _getWithEfOnException = null;

        private readonly Func<Person, IEfDbArgs, Task> _createWithEfOnBeforeAsync = null;
        private readonly Func<Person, Task> _createWithEfOnAfterAsync = null;
        private readonly Action<Exception> _createWithEfOnException = null;

        private readonly Func<Person, IEfDbArgs, Task> _updateWithEfOnBeforeAsync = null;
        private readonly Func<Person, Task> _updateWithEfOnAfterAsync = null;
        private readonly Action<Exception> _updateWithEfOnException = null;

        private readonly Func<Guid, IEfDbArgs, Task> _deleteWithEfOnBeforeAsync = null;
        private readonly Func<Guid, Task> _deleteWithEfOnAfterAsync = null;
        private readonly Action<Exception> _deleteWithEfOnException = null;

        #endregion

        /// <summary>
        /// Creates the <see cref="Person"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Person"/> object.</param>
        /// <returns>A refreshed <see cref="Person"/> object.</returns>
        public Task<Person> CreateAsync(Person value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                Person __result = null;
                var __dataArgs = DbMapper.Default.CreateArgs("[Demo].[spPersonCreate]");
                if (_createOnBeforeAsync != null) await _createOnBeforeAsync(value, __dataArgs);
                __result = Database.Default.Create(__dataArgs, value);
                if (_createOnAfterAsync != null) await _createOnAfterAsync(__result);
                return __result;
            }, new BusinessInvokerArgs { ExceptionHandler = _createOnException });
        }

        /// <summary>
        /// Deletes the <see cref="Person"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        public Task DeleteAsync(Guid id)
        {
            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                var __dataArgs = DbMapper.Default.CreateArgs("[Demo].[spPersonDelete]");
                if (_deleteOnBeforeAsync != null) await _deleteOnBeforeAsync(id, __dataArgs);
                Database.Default.Delete(__dataArgs, id);
                if (_deleteOnAfterAsync != null) await _deleteOnAfterAsync(id);
            }, new BusinessInvokerArgs { ExceptionHandler = _deleteOnException });
        }

        /// <summary>
        /// Gets the <see cref="Person"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The selected <see cref="Person"/> object where found; otherwise, <c>null</c>.</returns>
        public Task<Person> GetAsync(Guid id)
        {
            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                Person __result = null;
                var __dataArgs = DbMapper.Default.CreateArgs("[Demo].[spPersonGet]");
                if (_getOnBeforeAsync != null) await _getOnBeforeAsync(id, __dataArgs);
                __result = Database.Default.Get(__dataArgs, id);
                if (_getOnAfterAsync != null) await _getOnAfterAsync(__result, id);
                return __result;
            }, new BusinessInvokerArgs { ExceptionHandler = _getOnException });
        }

        /// <summary>
        /// Updates the <see cref="Person"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Person"/> object.</param>
        /// <returns>A refreshed <see cref="Person"/> object.</returns>
        public Task<Person> UpdateAsync(Person value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                Person __result = null;
                var __dataArgs = DbMapper.Default.CreateArgs("[Demo].[spPersonUpdate]");
                if (_updateOnBeforeAsync != null) await _updateOnBeforeAsync(value, __dataArgs);
                __result = Database.Default.Update(__dataArgs, value);
                if (_updateOnAfterAsync != null) await _updateOnAfterAsync(__result);
                return __result;
            }, new BusinessInvokerArgs { ExceptionHandler = _updateOnException });
        }

        /// <summary>
        /// Gets the <see cref="Person"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>A <see cref="PersonCollectionResult"/>.</returns>
        public Task<PersonCollectionResult> GetAllAsync(PagingArgs paging)
        {
            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                PersonCollectionResult __result = new PersonCollectionResult(paging);
                var __dataArgs = DbMapper.Default.CreateArgs("[Demo].[spPersonGetAll]", __result.Paging);
                if (_getAllOnBeforeAsync != null) await _getAllOnBeforeAsync(__dataArgs);
                __result.Result = Database.Default.Query(__dataArgs, p => _getAllOnQuery?.Invoke(p, __dataArgs)).SelectQuery<PersonCollection>();
                if (_getAllOnAfterAsync != null) await _getAllOnAfterAsync(__result);
                return __result;
            }, new BusinessInvokerArgs { ExceptionHandler = _getAllOnException });
        }

        /// <summary>
        /// Gets the <see cref="Person"/> collection object that matches the selection criteria.
        /// </summary>
        /// <returns>A <see cref="PersonCollectionResult"/>.</returns>
        public Task<PersonCollectionResult> GetAll2Async()
        {
            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                PersonCollectionResult __result = new PersonCollectionResult();
                var __dataArgs = DbMapper.Default.CreateArgs("[Demo].[spPersonGetAll]");
                if (_getAll2OnBeforeAsync != null) await _getAll2OnBeforeAsync(__dataArgs);
                __result.Result = Database.Default.Query(__dataArgs, p => _getAll2OnQuery?.Invoke(p, __dataArgs)).SelectQuery<PersonCollection>();
                if (_getAll2OnAfterAsync != null) await _getAll2OnAfterAsync(__result);
                return __result;
            }, new BusinessInvokerArgs { ExceptionHandler = _getAll2OnException });
        }

        /// <summary>
        /// Gets the <see cref="Person"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="PersonArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>A <see cref="PersonCollectionResult"/>.</returns>
        public Task<PersonCollectionResult> GetByArgsAsync(PersonArgs args, PagingArgs paging)
        {
            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                PersonCollectionResult __result = new PersonCollectionResult(paging);
                var __dataArgs = DbMapper.Default.CreateArgs("[Demo].[spPersonGetByArgs]", __result.Paging);
                if (_getByArgsOnBeforeAsync != null) await _getByArgsOnBeforeAsync(args, __dataArgs);
                __result.Result = Database.Default.Query(__dataArgs, p => _getByArgsOnQuery?.Invoke(p, args, __dataArgs)).SelectQuery<PersonCollection>();
                if (_getByArgsOnAfterAsync != null) await _getByArgsOnAfterAsync(__result, args);
                return __result;
            }, new BusinessInvokerArgs { ExceptionHandler = _getByArgsOnException });
        }

        /// <summary>
        /// Gets the <see cref="PersonDetail"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="PersonArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>A <see cref="PersonDetailCollectionResult"/>.</returns>
        public Task<PersonDetailCollectionResult> GetDetailByArgsAsync(PersonArgs args, PagingArgs paging)
        {
            return DataInvoker.Default.InvokeAsync(this, () => GetDetailByArgsOnImplementationAsync(args, paging),
                new BusinessInvokerArgs { ExceptionHandler = _getDetailByArgsOnException });
        }

        /// <summary>
        /// Merge first <see cref="Person"/> into second.
        /// </summary>
        /// <param name="fromId">The from <see cref="Person"/> identifier.</param>
        /// <param name="toId">The to <see cref="Person"/> identifier.</param>
        /// <returns>A resultant <see cref="Person"/>.</returns>
        public Task<Person> MergeAsync(Guid fromId, Guid toId)
        {
            return DataInvoker.Default.InvokeAsync(this, () => MergeOnImplementationAsync(fromId, toId),
                new BusinessInvokerArgs { ExceptionHandler = _mergeOnException });
        }

        /// <summary>
        /// Mark <see cref="Person"/>.
        /// </summary>
        public Task MarkAsync()
        {
            return DataInvoker.Default.InvokeAsync(this, () => MarkOnImplementationAsync(),
                new BusinessInvokerArgs { ExceptionHandler = _markOnException });
        }

        /// <summary>
        /// Gets the <see cref="PersonDetail"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The selected <see cref="PersonDetail"/> object where found; otherwise, <c>null</c>.</returns>
        public Task<PersonDetail> GetDetailAsync(Guid id)
        {
            return DataInvoker.Default.InvokeAsync(this, () => GetDetailOnImplementationAsync(id),
                new BusinessInvokerArgs { ExceptionHandler = _getDetailOnException });
        }

        /// <summary>
        /// Updates the <see cref="PersonDetail"/> object.
        /// </summary>
        /// <param name="value">The <see cref="PersonDetail"/> object.</param>
        /// <returns>A refreshed <see cref="PersonDetail"/> object.</returns>
        public Task<PersonDetail> UpdateDetailAsync(PersonDetail value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return DataInvoker.Default.InvokeAsync(this, () => UpdateDetailOnImplementationAsync(value),
                new BusinessInvokerArgs { ExceptionHandler = _updateDetailOnException });
        }

        /// <summary>
        /// Gets the <see cref="Person"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="PersonArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>A <see cref="PersonCollectionResult"/>.</returns>
        public Task<PersonCollectionResult> GetByArgsWithEfAsync(PersonArgs args, PagingArgs paging)
        {
            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                PersonCollectionResult __result = new PersonCollectionResult(paging);
                var __dataArgs = EfMapper.Default.CreateArgs(__result.Paging);
                if (_getByArgsWithEfOnBeforeAsync != null) await _getByArgsWithEfOnBeforeAsync(args, __dataArgs);
                __result.Result = EfDb.Default.Query(__dataArgs, q => _getByArgsWithEfOnQuery == null ? q : _getByArgsWithEfOnQuery(q, args, __dataArgs)).SelectQuery<PersonCollection>();
                if (_getByArgsWithEfOnAfterAsync != null) await _getByArgsWithEfOnAfterAsync(__result, args);
                return __result;
            }, new BusinessInvokerArgs { ExceptionHandler = _getByArgsWithEfOnException });
        }

        /// <summary>
        /// Gets the <see cref="Person"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The selected <see cref="Person"/> object where found; otherwise, <c>null</c>.</returns>
        public Task<Person> GetWithEfAsync(Guid id)
        {
            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                Person __result = null;
                var __dataArgs = EfMapper.Default.CreateArgs();
                if (_getWithEfOnBeforeAsync != null) await _getWithEfOnBeforeAsync(id, __dataArgs);
                __result = await EfDb.Default.GetAsync(__dataArgs, id);
                if (_getWithEfOnAfterAsync != null) await _getWithEfOnAfterAsync(__result, id);
                return __result;
            }, new BusinessInvokerArgs { ExceptionHandler = _getWithEfOnException });
        }

        /// <summary>
        /// Creates the <see cref="Person"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Person"/> object.</param>
        /// <returns>A refreshed <see cref="Person"/> object.</returns>
        public Task<Person> CreateWithEfAsync(Person value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                Person __result = null;
                var __dataArgs = EfMapper.Default.CreateArgs();
                if (_createWithEfOnBeforeAsync != null) await _createWithEfOnBeforeAsync(value, __dataArgs);
                __result = await EfDb.Default.CreateAsync(__dataArgs, value);
                if (_createWithEfOnAfterAsync != null) await _createWithEfOnAfterAsync(__result);
                return __result;
            }, new BusinessInvokerArgs { ExceptionHandler = _createWithEfOnException });
        }

        /// <summary>
        /// Updates the <see cref="Person"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Person"/> object.</param>
        /// <returns>A refreshed <see cref="Person"/> object.</returns>
        public Task<Person> UpdateWithEfAsync(Person value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                Person __result = null;
                var __dataArgs = EfMapper.Default.CreateArgs();
                if (_updateWithEfOnBeforeAsync != null) await _updateWithEfOnBeforeAsync(value, __dataArgs);
                __result = await EfDb.Default.UpdateAsync(__dataArgs, value);
                if (_updateWithEfOnAfterAsync != null) await _updateWithEfOnAfterAsync(__result);
                return __result;
            }, new BusinessInvokerArgs { ExceptionHandler = _updateWithEfOnException });
        }

        /// <summary>
        /// Deletes the <see cref="Person"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        public Task DeleteWithEfAsync(Guid id)
        {
            return DataInvoker.Default.InvokeAsync(this, async () =>
            {
                var __dataArgs = EfMapper.Default.CreateArgs();
                if (_deleteWithEfOnBeforeAsync != null) await _deleteWithEfOnBeforeAsync(id, __dataArgs);
                await EfDb.Default.DeleteAsync(__dataArgs, id);
                if (_deleteWithEfOnAfterAsync != null) await _deleteWithEfOnAfterAsync(id);
            }, new BusinessInvokerArgs { ExceptionHandler = _deleteWithEfOnException });
        }

        /// <summary>
        /// Provides the <see cref="Person"/> entity and database property mapping.
        /// </summary>
        public partial class DbMapper : DatabaseMapper<Person, DbMapper>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DbMapper"/> class.
            /// </summary>
            public DbMapper()
            {
                Property(s => s.Id, "PersonId").SetUniqueKey(true);
                Property(s => s.FirstName);
                Property(s => s.LastName);
                Property(s => s.UniqueCode);
                Property(s => s.Gender, "GenderId").SetConverter(ReferenceDataNullableGuidIdConverter<RefDataNamespace.Gender>.Default);
                Property(s => s.EyeColorSid, "EyeColorCode");
                Property(s => s.Birthday);
                Property(s => s.Address).SetMapper(AddressData.DbMapper.Default);
                AddStandardProperties();
                DbMapperCtor();
            }
            
            /// <summary>
            /// Enables the <see cref="DbMapper"/> constructor to be extended.
            /// </summary>
            partial void DbMapperCtor();
        }

        /// <summary>
        /// Provides the <see cref="Person"/> entity and Entity Framework <see cref="EfModel.Person"/> property mapping.
        /// </summary>
        public partial class EfMapper : EfDbMapper<Person, EfModel.Person, EfMapper>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="EfMapper"/> class.
            /// </summary>
            public EfMapper()
            {
                Property(s => s.Id, d => d.PersonId).SetUniqueKey(true);
                Property(s => s.FirstName, d => d.FirstName);
                Property(s => s.LastName, d => d.LastName);
                Property(s => s.UniqueCode, d => d.UniqueCode);
                Property(s => s.Gender, d => d.GenderId).SetConverter(ReferenceDataNullableGuidIdConverter<RefDataNamespace.Gender>.Default);
                Property(s => s.EyeColorSid, d => d.EyeColorCode);
                Property(s => s.Birthday, d => d.Birthday);
                AddStandardProperties();
                EfMapperCtor();
            }
            
            /// <summary>
            /// Enables the <see cref="EfMapper"/> constructor to be extended.
            /// </summary>
            partial void EfMapperCtor();
        }
    }
}

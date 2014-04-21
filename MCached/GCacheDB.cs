using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Threading.Tasks;
using System.Diagnostics;
using Com.Fadong.CommonInterface;

namespace Com.Fadong.MCached {
    /// <summary>
    /// 
    /// </summary>
    public class GCacheDB<TEntity> : GCache<TEntity> where TEntity : class {

        #region "public GCacheDB(DbContext ctx)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctx"></param>
        public GCacheDB(DbContext ctx) {
            this.BaseType = typeof(TEntity);
            this.Context = ctx;
        }
        #endregion

        #region "public void LoadDB()"
        /// <summary>
        /// 
        /// </summary>
        public virtual void LoadDB() {
            try {
                this.Entities = this.Context.Set<TEntity>();
                Logger.Info(this, this.ToString());
            } catch (Exception err) {
                Logger.Error(this, err);
            }
        }
        #endregion

        #region "public TEntity GetById(int id)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity GetById(int id){
            return this.Entities.Find(id);
        }
        #endregion

        #region "public TEntity Create()"
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public TEntity Create() {
            return this.Entities.Create();
        }
        #endregion

        #region "public bool Insert(TEntity tentity)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tentity"></param>
        /// <returns></returns>
        public bool Insert(TEntity tentity) {
            try {
                string tablename = typeof(TEntity).Name;
                this.Entities.Add(tentity);
                int chgcnt = this.Context.SaveChanges();
                return chgcnt > 0 ? true : false;
            } catch (Exception err) {
                Logger.Error(this, err.Message);
                return false;
            }
        }
        #endregion

        #region "public bool Update(TEntity tentity)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tentity"></param>
        /// <returns></returns>
        public bool Update(TEntity tentity) {
            try {
                string tablename = typeof(TEntity).Name;
                this.Entities.Add(tentity);
                int chgcnt = this.Context.SaveChanges();
                return chgcnt > 0 ? true : false;
            } catch (Exception err) {
                Logger.Error(this, err.Message);
                return false;
            }
        }
        #endregion

        #region "public bool Delete(TEntity tentity)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tentity"></param>
        /// <returns></returns>
        public bool Delete(TEntity tentity) {
            try {
                string tablename = typeof(TEntity).Name;
                this.Entities.Remove(tentity);
                int chgcnt = this.Context.SaveChanges();
                return chgcnt > 0 ? true : false;
            } catch (Exception err) {
                Logger.Error(this, err.Message);
                return false;
            }
        }
        #endregion

        #region "public bool Delete(int id)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id) {
            try {
                this.Entities.Remove(GetById(id));
                int chgcnt = this.Context.SaveChanges();
                return chgcnt > 0 ? true : false;
            } catch (Exception err) {
                Logger.Error(this, err.Message);
                return false;
            }
        }
        #endregion

        #region "public IEnumerable<TEntity> Query(Func<TEntity, bool> query)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> Query(Func<TEntity, bool> query) {
            return this.Entities.Where(query);
        }
        #endregion

        #region "public IEnumerable<TEntity> QueryFromDB(Func<TEntity, bool> query)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> QueryFromDB(Func<TEntity, bool> query) {
            using (Entities ctx = new Entities()) {
                return ctx.Set<TEntity>().Where(query);
            }
        }
        #endregion

        #region "public IEnumerable<TEntity> QueryFromDic(string qdickey)"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="qdickey"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> QueryFromDic(string qdickey) {
            return Query(_querydic[qdickey]);
        }
        #endregion

        #region "public override string ToString()"
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return this.Entities.Count() + "개";
        }
        #endregion

        #region "public Type BaseType"
        /// <summary>
        /// 
        /// </summary>
        public Type BaseType {
            get;
            internal set;
        }
        #endregion

        #region "public DbContext Context"
        /// <summary>
        /// 
        /// </summary>
        public DbContext Context {
            get;
            internal set;
        }
        #endregion

        #region "public IDbSet<TEntity> Entities"
        /// <summary>
        /// 
        /// </summary>
        public IDbSet<TEntity> Entities {
            get;
            internal set;
        }
        #endregion

        //private IDbSet<TEntity> _entities = null;
        private Dictionary<string, Func<TEntity, bool>> _querydic = new Dictionary<string, Func<TEntity, bool>>();
        
    }
}
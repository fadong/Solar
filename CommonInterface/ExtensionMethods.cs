using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ComponentModel;
using ServiceStack.Text;

namespace Com.Fadong.CommonInterface {
    public static class ExtensionMethods
    {
        #region "InvokeEx<T> (CrossThread 문제를 해결하기 위한 ExtensionMethods)"
        /// <summary>
        /// CrossThread 문제를 해결하기 위한 ExtentionMethods
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <param name="action"></param>
        public static void InvokeEx<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke {
            if (@this.InvokeRequired) {
                @this.Invoke(action, new object[] { @this });
            } else {
                action(@this);
            }
        }
        #endregion

        #region "CreateFaultException (WCF 에러전송을 위한 FaultException 생성 ExtensionMethods)"
        /// <summary>
        /// WCF 에러전송을 위한 FaultException 생성 ExtensionMethods
        /// </summary>
        /// <param name="err"></param>
        /// <returns></returns>
        public static FaultException CreateFaultException(this Exception @err, string exstr = "") {
            Exception e = @err;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n=> {0}", e.Message);
            while (e.InnerException != null) {
                e = e.InnerException;
                sb.AppendFormat("\n=> {0}", e.Message);
            }
            return new FaultException(sb.ToString(), new FaultCode(sb.ToString(), exstr));
        }
        #endregion

        #region "SplitIntoChunks (배열입력파라미터를 주어진 크기(chunkSize)로 분할하여 Return해주는 ExtensionMethods)"
        /// <summary>
        /// 배열입력파라미터를 주어진 크기(chunkSize)로 분할하여 Return해주는 ExtensionMethods
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="chunkSize"></param>
        /// <returns></returns>
        public static List<List<T>> SplitIntoChunks<T>(List<T> list, int chunkSize) where T : class {
            if (chunkSize <= 0) {
                throw new ArgumentException("chunkSize must be greater than 0.");
            }

            List<List<T>> retVal = new List<List<T>>();
            int index = 0;
            while (index < list.Count) {
                int count = list.Count - index > chunkSize ? chunkSize : list.Count - index;
                retVal.Add(list.GetRange(index, count));

                index += chunkSize;
            }
            return retVal;
        }
        #endregion

        public static List<T> Trans2Poco<T>(this List<string> @list) where T : class {
            return @list.Select(k => JsonSerializer.DeserializeFromString<T>(k)).ToList<T>();
        }
    }
}

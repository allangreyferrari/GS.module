namespace GS.module.logic.Common
{
    using data.access.Common;
    using entities.Base;
    using entities.Primary;
    using System;
    using System.Collections.Generic;
    public class blCommon
    {
        #region String
        public StringTwoCollection ListarStringTwo(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            StringTwoCollection ocol;
            try
            {
                da = new daCommon();
                ocol = da.ListarStringTwo(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new StringTwoCollection(transaction);
                return ocol;
            }
        }
        public StringFiveCollection ListarStringFive(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            StringFiveCollection ocol;
            try
            {
                da = new daCommon();
                ocol = da.ListarStringFive(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new StringFiveCollection(transaction);
                return ocol;
            }
        }
        public StringTenCollection ListarStringTen(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            StringTenCollection ocol;
            try
            {
                da = new daCommon();
                ocol = da.ListarStringTen(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new StringTenCollection(transaction);
                return ocol;
            }
        }
        public StringTwentyCollection ListarStringTwenty(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            StringTwentyCollection ocol;
            try
            {
                da = new daCommon();
                ocol = da.ListarStringTwenty(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new StringTwentyCollection(transaction);
                return ocol;
            }
        }
        public StringThirtyCollection ListarStringThirty(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            StringThirtyCollection ocol;
            try
            {
                da = new daCommon();
                ocol = da.ListarStringThirty(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new StringThirtyCollection(transaction);
                return ocol;
            }
        }
        public StringFiftyCollection ListarStringFifty(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            StringFiftyCollection ocol;
            try
            {
                da = new daCommon();
                ocol = da.ListarStringFifty(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new StringFiftyCollection(transaction);
                return ocol;
            }
        }
        public StringSeventyCollection ListarStringSeventy(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            StringSeventyCollection ocol;
            try
            {
                da = new daCommon();
                ocol = da.ListarStringSeventy(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new StringSeventyCollection(transaction);
                return ocol;
            }
        }
        public StringHundredCollection ListarStringHundred(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            StringHundredCollection ocol;
            try
            {
                da = new daCommon();
                ocol =  da.ListarStringHundred(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new StringHundredCollection(transaction);
                return ocol;
            }
        }
        #endregion

        #region Basic
        public BasicTwoCollection ListarBasicTwo(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            BasicTwoCollection ocol;
            try
            {
                da = new daCommon();
                ocol = da.ListarBasicTwo(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new BasicTwoCollection(transaction);
                return ocol;
            }
        }
        public BasicFiveCollection ListarBasicFive(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            BasicFiveCollection ocol;
            try
            {
                da = new daCommon();
                ocol = da.ListarBasicFive(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new BasicFiveCollection(transaction);
                return ocol;
            }
        }
        public BasicTenCollection ListarBasicTen(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            BasicTenCollection ocol;
            try
            {
                da = new daCommon();
                ocol = da.ListarBasicTen(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new BasicTenCollection(transaction);
                return ocol;
            }
        }
        public BasicTwentyCollection ListarBasicTwenty(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            BasicTwentyCollection ocol;
            try
            {
                da = new daCommon();
                ocol = da.ListarBasicTwenty(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new BasicTwentyCollection(transaction);
                return ocol;
            }
        }
        public BasicThirtyCollection ListarBasicThirty(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            BasicThirtyCollection ocol;
            try
            {
                da = new daCommon();
                ocol = da.ListarBasicThirty(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new BasicThirtyCollection(transaction);
                return ocol;
            }
        }
        public BasicFiftyCollection ListarBasicFifty(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            BasicFiftyCollection ocol;
            try
            {
                da = new daCommon();
                ocol = da.ListarBasicFifty(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new BasicFiftyCollection(transaction);
                return ocol;
            }
        }
        public BasicSeventyCollection ListarBasicSeventy(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            BasicSeventyCollection ocol;
            try
            {
                da = new daCommon();
                ocol = da.ListarBasicSeventy(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new BasicSeventyCollection(transaction);
                return ocol;
            }
        }
        public BasicHundredCollection ListarBasicHundred(string key, List<object> parametros, List<object> cryp = null)
        {
            Transaction transaction;
            daCommon da;
            BasicHundredCollection ocol;
            try
            {
                da = new daCommon();
                ocol = da.ListarBasicHundred(key, parametros, cryp);
                transaction = Helper.GetTransaction(TypeTransaction.OK, "");
                ocol.Transaction = transaction;
                return ocol;
            }
            catch (Exception ex)
            {
                da = null;
                transaction = Helper.GetTransaction(TypeTransaction.ERR, ex.Message);
                ocol = new BasicHundredCollection(transaction);
                return ocol;
            }
        }

        ~blCommon() { }
        #endregion
    }
}


namespace GS.module.data.access.Common
{
    using entities.Internal;
    using entities.Primary;
    using Configuration;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using entities.Base;
    using System.Configuration;

    public class daCommon
    {
        public Query InitDB(string key)
        {
            string parameter = Helper.Desencriptar("@@" + ConfigurationManager.AppSettings["cryp"].ToString() + "@@", key);
            object[] input = { parameter };
            Query query = new Query();
            using (IDataReader dr = new dao().GetCollectionIReader("configuration", "getInitDB", input))
            {
                while (dr.Read())
                { 
                    query.Connection = Helper.Desencriptar(dr["Key"].ToString(), dr["Conexion"].ToString());
                    query.Method = dr["Metodo"].ToString();
                    query.Timeout = Convert.ToInt32(dr["TiempoEspera"]);
                    query.Password = Helper.Desencriptar(dr["Key"].ToString(), dr["Password"].ToString()); 
                    if(query.Password != Helper.Desencriptar(dr["Key"].ToString(), ConfigurationManager.AppSettings[string.Format("pass-{0}", dr["IdSistema"].ToString())].ToString()))
                        throw new System.ArgumentException("No es posible a la base de datos, porque el password de configuracion no coincide");
                }
            }
            return query;
        }
        
        #region String
        public StringTwoCollection ListarStringTwo(string key, List<object> input, List<object> cryp = null)
        {
            StringTwoCollection ocol;
            StringTwo be;
            Query query;
            try
            {
                ocol = new StringTwoCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new StringTwo();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        public StringFiveCollection ListarStringFive(string key, List<object> input, List<object> cryp = null)
        {
            StringFiveCollection ocol;
            StringFive be;
            Query query;
            try
            {
                ocol = new StringFiveCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new StringFive();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        public StringTenCollection ListarStringTen(string key, List<object> input, List<object> cryp = null)
        {
            StringTenCollection ocol;
            StringTen be;
            Query query;
            try
            {
                ocol = new StringTenCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new StringTen();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        public StringTwentyCollection ListarStringTwenty(string key, List<object> input, List<object> cryp = null)
        {
            StringTwentyCollection ocol;
            StringTwenty be;
            Query query;
            try
            {
                ocol = new StringTwentyCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new StringTwenty();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        public StringThirtyCollection ListarStringThirty(string key, List<object> input, List<object> cryp = null)
        {
            StringThirtyCollection ocol;
            StringThirty be;
            Query query;
            try
            {
                ocol = new StringThirtyCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new StringThirty();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        public StringFiftyCollection ListarStringFifty(string key, List<object> input, List<object> cryp = null)
        {
            StringFiftyCollection ocol;
            StringFifty be;
            Query query;
            try
            {
                ocol = new StringFiftyCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new StringFifty();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        public StringSeventyCollection ListarStringSeventy(string key, List<object> input, List<object> cryp = null)
        {
            StringSeventyCollection ocol;
            StringSeventy be;
            Query query;
            try
            {
                ocol = new StringSeventyCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new StringSeventy();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        public StringHundredCollection ListarStringHundred(string key, List<object> input, List<object> cryp = null)
        {
            StringHundredCollection ocol;
            StringHundred be;
            Query query;
            try
            {
                ocol = new StringHundredCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new StringHundred();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        #endregion

        #region Basic
        public BasicTwoCollection ListarBasicTwo(string key, List<object> input, List<object> cryp = null)
        {
            BasicTwoCollection ocol;
            BasicTwo be;
            Query query;
            try
            {
                ocol = new BasicTwoCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Encriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new BasicTwo();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        public BasicFiveCollection ListarBasicFive(string key, List<object> input, List<object> cryp = null)
        {
            BasicFiveCollection ocol;
            BasicFive be;
            Query query;
            try
            {
                ocol = new BasicFiveCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new BasicFive();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        public BasicTenCollection ListarBasicTen(string key, List<object> input, List<object> cryp = null)
        {
            BasicTenCollection ocol;
            BasicTen be;
            Query query;
            try
            {
                ocol = new BasicTenCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new BasicTen();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        public BasicTwentyCollection ListarBasicTwenty(string key, List<object> input, List<object> cryp = null)
        {
            BasicTwentyCollection ocol;
            BasicTwenty be;
            Query query;
            try
            {
                ocol = new BasicTwentyCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new BasicTwenty();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        public BasicThirtyCollection ListarBasicThirty(string key, List<object> input, List<object> cryp = null)
        {
            BasicThirtyCollection ocol;
            BasicThirty be;
            Query query;
            try
            {
                ocol = new BasicThirtyCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new BasicThirty();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        public BasicFiftyCollection ListarBasicFifty(string key, List<object> input, List<object> cryp = null)
        {
            BasicFiftyCollection ocol;
            BasicFifty be;
            Query query;
            try
            {
                ocol = new BasicFiftyCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new BasicFifty();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        public BasicSeventyCollection ListarBasicSeventy(string key, List<object> input, List<object> cryp = null)
        {
            BasicSeventyCollection ocol;
            BasicSeventy be;
            Query query;
            try
            {
                ocol = new BasicSeventyCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new BasicSeventy();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        public BasicHundredCollection ListarBasicHundred(string key, List<object> input, List<object> cryp = null)
        {
            BasicHundredCollection ocol;
            BasicHundred be;
            Query query;
            try
            {
                ocol = new BasicHundredCollection();
                query = InitDB(key);
                query.Input = input;
                foreach (var value in cryp)
                    query.Input.Add(Helper.Desencriptar(query.Password, value.ToString()));
                using (IDataReader dr = new dao().GetCollectionIReader(query))
                {
                    ocol.NroColumns = dr.FieldCount;
                    for (int idx = 0; idx < ocol.NroColumns; idx++)
                    {
                        ocol.Columns.Add(new Column()
                        {
                            campo = string.Format("v{0}", (idx + 1).ToString().PadLeft(2, '0')),
                            key = dr.GetName(idx),
                            index = idx,
                        });
                    }
                    int rows = 0;
                    while (dr.Read())
                    {
                        be = new BasicHundred();
                        foreach (Column c in ocol.Columns)
                            be.GetValue(c.campo, dr[ocol.Columns[c.index].index].ToString());
                        ocol.Rows.Add(be);
                        rows++;
                    }
                    ocol.NroRows = rows;
                }
                return ocol;
            }
            catch (Exception ex)
            {
                ocol = null;
                be = null;
                query = null;
                throw new System.ArgumentException(ex.Message);
            }
        }
        #endregion

        ~daCommon() { }
    }
}

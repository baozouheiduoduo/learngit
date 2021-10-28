using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;

namespace MES_BASE.DAL
{
    class SqlServrDbase
    {

        private static string DB_Source = "";
        //服务器名Server或Data Source，数据库名 Database或initial catalog,设置为Windows登录,需使用Integrated Security = TRUE(或者：SSPI)来进行登录
        public string connString = @"Data Source='" + DB_Source + "';Initial Catalog=;Integrated Security=SSPI;";
        public string sql = "";
        public SqlConnection conn = null;
        private SqlCommand cmd = null;



        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="source"></param>
        public SqlServrDbase(string source)
        {
            DB_Source = source;
            connString = @"Data Source='" + DB_Source + "';Initial Catalog=;Integrated Security=SSPI;";
        }



        // 执行对数据表中数据的查询操作
        public DataSet GetSysDatabases()
        {

            sql = "SELECT Name FROM Master..SysDatabases ORDER BY Name";//获取所有数据库名: 
            conn = new SqlConnection(connString);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();      //打开数据库
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                adp.Fill(ds);
            }
            catch (SqlException ae)
            {
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();      //关闭数据库
            }
            return ds;
        }


        /// 返回DataSet,可以填充DataView等
        public DataSet GetDataSet(string sql)
        {
            SqlConnection Conn = new SqlConnection(connString);
            try
            {
                DataSet ds = new DataSet();
                Conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(sql, Conn);
                sqlDa.Fill(ds);
                return ds;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }
        }

        /// 按sql语句返回DataTable
        public DataTable GetDataTable(string sql)
        {
            SqlConnection Conn = new SqlConnection(connString);
            Conn.Open();
            DataSet ds = new DataSet();
            try
            {
                ds = GetDataSet(sql);
                return ds.Tables[0];
            }

            finally
            {
                ds.Dispose();
                Conn.Close();
                Conn.Dispose();
            }
        }


        public int ExcuteSQL(string sql)
        {
            int i = 0;
            SqlConnection Conn = new SqlConnection(connString);
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, Conn);
            try
            {
                //判断是否开启事务
                if (sql != null)
                {
                    i = cmd.ExecuteNonQuery();
                }
            }

            finally
            {
                Conn.Close();
                Conn.Dispose();
            }
            return i;
        }



        public void ExcuteNonSQL(string sql)
        {
            int i = 0;
            SqlConnection Conn = new SqlConnection(connString);
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, Conn);
            try
            {
                //判断是否开启事务
                if (sql != null)
                {
                    i = cmd.ExecuteNonQuery();
                }
            }

            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

        }



        #region IsDBExist-判断数据库是否存在
        /// <summary>
        /// 判断数据库是否存在
        /// </summary>
        /// <param name="db">数据库的名称</param>
        /// <returns>true:表示数据库已经存在；false，表示数据库不存在</returns>
        public Boolean IsDBExist(string db)
        {
            string sql = " select * from master.dbo.sysdatabases where name " + "= '" + db + "'";
            DataTable dt = GetDataTable(sql);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region CreateDataBase-创建数据库
        /// <summary>
        /// 创建数据库
        /// </summary>
        /// <param name="DB_NAME">数据库名称</param>
        /// <param name="DB_PATH">数据库文件路径</param>
        public void CreateDataBase(string DB_NAME, string DB_PATH)
        {
            //符号变量，判断数据库是否存在
            Boolean flag = IsDBExist(DB_NAME);

            //如果数据库存在，则抛出
            if (flag == true)
            {
                //throw new Exception("数据库已经存在！");
            }
            else
            {
                try
                {
                    //创建路径
                    DirectoryExist(DB_PATH);
                    //数据库不存在，创建数据库
                    conn = new SqlConnection(connString);
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    string sql = "if not exists(select * From master.dbo.sysdatabases where name='" + DB_NAME + "')" +
                        "CREATE DATABASE " + DB_NAME + " ON PRIMARY" + "(name=" + DB_NAME + ",filename = '" + DB_PATH + DB_NAME + ".mdf', size=5mb," +
                        "maxsize=100mb,filegrowth=10%)log on" + "(name=" + DB_NAME + "_log,filename='" + DB_PATH + DB_NAME + "_log.ldf',size=2mb," + "maxsize=20MB,filegrowth=1mb)";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    throw new Exception(sqle.Message.ToString());
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Dispose();
                }

            }
        }
        #endregion


        #region IsTableExist-判断数据库表是否存在
        /// <summary>
        /// 判断数据库表是否存在
        /// </summary>
        /// <param name="db">数据库</param>
        /// <param name="tb">数据库表名</param>
        /// <returns></returns>
        public Boolean IsTableExist(string db, string tb)
        {
            string sql = "use " + db + " select * from sysobjects where id = object_id('" + tb + "') and type ='U'";
            //在指定的数据库中 查找该表是否存在
            DataTable dt = GetDataTable(sql);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion



        #region CreateDataTable-在指定的数据库中，创建数据库表

        //================CreateDataTable使用说明=======================
        //Dictionary<string, string> dic=new Dictionary<string, string>();
        //   dic.Add("ID int", "primary key IDENTITY (1,1)");
        //   dic.Add("A datetime", "not null");
        //   dic.Add("B char(7)", "null");
        //   SqlData.CreateDataTable("SB", "studuct", dic);
        //===============================================================

        /// <summary>
        ///在指定的数据库中，创建数据库表
        /// </summary>
        /// <param name="db">指定的数据库</param>
        /// <param name="dt">要创建的数据库表</param>
        /// <param name="dic">数据表中的字段及其数据类型</param>
        public void CreateDataTable(string db, string dt, Dictionary<string, string> dic)
        {

            //判断数据库是否存在
            if (IsDBExist(db) == false)
            {
                throw new Exception("数据库不存在！");
            }
            //如果数据库表存在，则抛出错误
            if (IsTableExist(db, dt) == true)
            {
                //throw new Exception("数据库表已经存在！");
            }
            //数据库表不存在，创建表
            else
            {
                //拼接字符串，该串为创建内容
                string content = "";
                //取出dic中的内容，进行拼接
                List<string> test = new List<string>(dic.Keys);
                for (int i = 0; i < dic.Count(); i++)
                {
                    if (i == 0)
                    {
                        content = test[i] + " " + dic[test[i]];
                    }
                    else
                    {
                        content = content + " , " + test[i] + " " + dic[test[i]];
                    }
                }

                //其后判断数据库表是否存在，然创建表
                string sql = "use " + db + " create table " + dt + "(" + content + ")";
                ExcuteNonSQL(sql);
            }


        }
        #endregion


        //===========
        /// <summary>
        /// 创建数据库
        /// </summary>
        /// <param name="name">数据库名字</param>
        /// <param name="path">数据库路径</param>
        public void CreateDBTemplate(string DB_NAME)
        {

            string strGetCurrentDirectory = Directory.GetCurrentDirectory();//获取应用程序的当前工作目录
            string DB_PATH = Path.Combine(strGetCurrentDirectory, @"Data\");//通过Path类的Combine方法可以合并路径
            DirectoryExist(DB_PATH);                                                              //服务器名Server或Data Source，数据库名 Database或initial catalog,设置为Windows登录,需使用Integrated Security = TRUE(或者：SSPI)来进行登录
            string ConnectionString = @"Integrated Security=SSPI;Initial Catalog=;Data Source='" + DB_Source + "';";
            conn = new SqlConnection(ConnectionString);
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string sql = "if not exists(select * From master.dbo.sysdatabases where name='" + DB_NAME + "')" + "CREATE DATABASE " + DB_NAME + " ON PRIMARY" + "(name=" + DB_NAME + ",filename = '" + DB_PATH + DB_NAME + ".mdf', size=5mb," +
            "maxsize=100mb,filegrowth=10%)log on" + "(name=" + DB_NAME + "_log,filename='" + DB_PATH + DB_NAME + "_log.ldf',size=2mb," + "maxsize=20MB,filegrowth=1mb)";

            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqle)
            {
                Console.WriteLine(sqle.Message.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Dispose();
            }

        }

        /// <summary>
        /// 判断某路径是否存在，不存在创建该路径
        /// </summary>
        private void DirectoryExist(string path)
        {
            if (!Directory.Exists(path))//判断是否存在
            {
                Directory.CreateDirectory(path);//创建新路径
            }
        }



        /// <summary>
        /// 从数程序据库里读取数据到数据集里
        /// </summary>
        /// <param name="Sqlstr"></param>
        /// <param name="DBName"></param> //数据库名称
        /// <returns></returns>
        public DataSet GetDataFromDB(string Sqlstr, string DBName)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            SqlConnection conn = new SqlConnection(connStr);
            try
            {

                conn.Open();
                SqlDataAdapter myAdapter = new SqlDataAdapter(Sqlstr, conn);
                DataSet myDataSet = new DataSet();
                myDataSet.Clear();
                myAdapter.Fill(myDataSet);

                if (myDataSet.Tables[0].Rows.Count != 0)
                {
                    return myDataSet;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
                throw new Exception(e.Message);

            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }


        /// <summary>
        /// 返回DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable GetHistoryOrder(string sql, string DBName)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            SqlConnection conn = new SqlConnection(connStr);
            DataTable dt = new DataTable();
            try
            {

                conn.Open();
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, conn);
                DataSet myDataSet = new DataSet();
                myDataSet.Clear();
                myAdapter.Fill(myDataSet);
                dt = myDataSet.Tables[0];
            }
            catch (Exception e)
            {
                //throw new Exception(e.Message);
            }
            finally
            {

                conn.Close();
                conn.Dispose();
            }
            return dt;
        }

        /// <summary>
        /// 从数据库表里查询是否存在某条记录
        /// DBName:数据库名；tableName：表名称；columnName：列名；record：记录名
        /// </summary>
        /// <param name="Sqlstr"></param>
        /// <returns></returns>
        /// 
        public bool FindRecord(string DBName, string tableName, string columnName, string record)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            string strsql = "select * from " + tableName + " where " + columnName + "='" + record + "' ";
            SqlConnection conn = new SqlConnection(connStr);
            bool successState = false;
            try
            {
                conn.Open();
                SqlDataAdapter myAdapter = new SqlDataAdapter(strsql, conn);
                DataSet myDataSet = new DataSet();
                myDataSet.Clear();
                myAdapter.Fill(myDataSet);

                if (myDataSet.Tables[0].Rows.Count > 0)
                {
                    successState = true;
                }
                else
                {
                    successState = false;
                }
            }
            catch (Exception e)
            {
                successState = false;
                throw new Exception(e.Message);

            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return successState;
        }

        /// <summary>
        /// 执行数据SQL语句
        /// </summary>
        /// <param name="Sqlstr"></param>
        public bool DataSQL(string Sqlstr, string DBName)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            SqlConnection conn = new SqlConnection(connStr);
            bool successState = false;
            try
            {

                conn.Open();
                SqlCommand mysqlComand = new SqlCommand(Sqlstr, conn);
                mysqlComand.CommandType = CommandType.Text;
                mysqlComand.ExecuteNonQuery();
                successState = true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }


            finally
            {

                conn.Close();
                conn.Dispose();
            }

            return successState;
        }


        /// <summary>
        /// 执行SQL语句，返回 DataReader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlDataReader ReturnDataReader(String sql, string DBName)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return dataReader;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// 执行SQL语句，返回记录数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ReturnRecordCount(string sql, string DBName)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            SqlConnection conn = new SqlConnection(connStr);
            int recordCount = 0;
            try
            {

                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    recordCount++;
                }
                dataReader.Close();
            }
            catch (Exception e)
            {
                //throw new Exception(e.Message);

            }

            finally
            {

                conn.Close();
                conn.Dispose();
            }
            return recordCount;
        }


        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool EditDatabase(string sql, string DBName)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            SqlConnection conn = new SqlConnection(connStr);
            bool successState = false;
            conn.Open();
            SqlTransaction myTrans = conn.BeginTransaction();
            SqlCommand command = new SqlCommand(sql, conn, myTrans);
            try
            {
                command.ExecuteNonQuery();
                myTrans.Commit();
                successState = true;
            }
            catch (Exception e)
            {

                myTrans.Rollback();
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return successState;
        }


        /// <summary>
        /// 将数据集快速写入数据库里
        /// </summary>
        /// <param name="dt"></param>
        public void DataTableToSQLServer(DataTable dt, string tableName, string DBName)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            using (SqlConnection destinationConnection = new SqlConnection(connStr))
            {
                try
                {
                    destinationConnection.Open();

                    SqlBulkCopy bulkCopy = new SqlBulkCopy(destinationConnection);


                    bulkCopy.DestinationTableName = tableName;//要插入的表的表名
                    bulkCopy.BatchSize = dt.Rows.Count;
                    bulkCopy.ColumnMappings.Add("PCode", "PCode");//映射字段名 DataTable列名 ,数据库 对应的列名  
                    bulkCopy.ColumnMappings.Add("PName", "PName");
                    bulkCopy.ColumnMappings.Add("SCode", "SCode");
                    bulkCopy.ColumnMappings.Add("SName", "SName");

                    bulkCopy.WriteToServer(dt);
                    //System.Windows.Forms.MessageBox.Show("插入成功");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    destinationConnection.Close();
                    destinationConnection.Dispose();
                }
            }

        }


        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">多条SQL语句</param>        
        public int ExecuteSqlTran(string DBName, List<String> SQLStringList)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlTransaction tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    int count = 0;
                    for (int n = 0; n < SQLStringList.Count; n++)
                    {
                        string strsql = SQLStringList[n];
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                    return count;
                }
                catch
                {
                    tx.Rollback();
                    return 0;
                }
            }
        }


        /// <summary>
        /// sql数据库备份
        /// </summary>
        /// <param name="DBName"></param>
        /// <param name="path"></param>
        public void backupSql(string DBName, string path)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            string sql = " BACKUP DATABASE [" + DBName + "] to DISK ='" + @path + "' WITH NOFORMAT, NOINIT,  NAME = N'" + DBName + "-完整 数据库 备份', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("备份数据库出错" + ex);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }

        }


        /// <summary>
        /// 还原数据库
        /// </summary>
        /// <param name="path">还原文件路径及名称</param>
        /// <returns>成功返回true,否侧返回false</returns>
        public bool RestoreDataBase(string path, string DBName)
        {
            string sql = string.Empty;
            conn = new SqlConnection();
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dr;
            ArrayList list = new ArrayList();
            try
            {
                //string dataBase = connString.Split(';')[1].Split('=')[1].Trim();
                string dataBase = DBName;
                string conn1 = string.Format("{0};Initial Catalog=master;{1};{2}",
                     connString.Split(';')[0], connString.Split(';')[2], connString.Split(';')[3]);
                sql = string.Format(@"SELECT spid FROM sysprocesses ,sysdatabases 
                    WHERE sysprocesses.dbid=sysdatabases.dbid AND sysdatabases.Name='{0}'", dataBase);
                conn = new SqlConnection(conn1);
                cmd = new SqlCommand(sql, conn);

                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(dr.GetInt16(0));
                }
                dr.Close();
                conn.Close();
                //con.ConnectionString = conn;
                for (int i = 0; i < list.Count; i++)
                {
                    cmd = new SqlCommand(string.Format("KILL {0}", list[i].ToString()), conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                string BACKUP = String.Format("RESTORE DATABASE [{0}] FROM DISK = '{1}' WITH REPLACE", dataBase, path);
                conn = new SqlConnection(conn1);
                cmd = new SqlCommand(BACKUP, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw (new Exception(e.Message));
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }

        }

        #region 执行带参数的SQL语句

        //==========================带参数SQL语句使用方法============================
        //string sql = "insert into Students (StudentName,Age,Gender,Birthday,";
        //sql += "CardNo,ClassId,StudentIdNo,PhoneNumber,StudentAddress,StuImage) ";
        //sql += " Values(@StudentName,@Age,@Gender,@Birthday,@CardNo,@ClassId,";
        //sql += "@StudentIdNo,@PhoneNumber,@StudentAddress,@StuImage)";
        ////创建参数数组
        //SqlParameter[] parameter = new SqlParameter[]
        //{
        //    new SqlParameter("@StudentName",objStudent.StudentName),
        //    new SqlParameter("@Age",objStudent.Age),
        //    new SqlParameter("@Gender",objStudent.Gender),
        //    new SqlParameter("@Birthday",objStudent.Birthday),
        //    new SqlParameter("@CardNo",objStudent.CardNo),
        //    new SqlParameter("@ClassId",objStudent.ClassId),
        //    new SqlParameter("@StudentIdNo",objStudent.StudentIdNo),
        //    new SqlParameter("@PhoneNumber",objStudent.PhoneNumber),
        //    new SqlParameter("@StudentAddress",objStudent.StudentAddress),
        //    new SqlParameter("@StuImage",objStudent.StuImage)
        //};
        //try
        //{                           //调用带参数方法
        //    return ExecuteSql(sql,parameter);
        //}
        //catch (Exception ex)
        //{
        //    throw new Exception("出现问题" + ex.Message);
        //}
        //===========================================================================


        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public int ExecuteSql(string DBName, string SQLString, params SqlParameter[] cmdParms)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        int rows = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public object GetSingle(string DBName, string SQLString, params SqlParameter[] cmdParms)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行查询语句，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader ExecuteReader(string DBName, string SQLString, params SqlParameter[] cmdParms)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            SqlConnection connection = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            try
            {
                PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return myReader;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw e;
            }
            finally
            {
                cmd.Dispose();
                connection.Close();
            }

        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public DataSet Query(string DBName, string SQLString, params SqlParameter[] cmdParms)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "ds");
                        cmd.Parameters.Clear();
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    return ds;
                }
            }
        }


        private void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, string cmdText, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null)
            {


                foreach (SqlParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }

        #endregion


        #region 存储过程操作

        /// <summary>
        /// 执行存储过程，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader RunProcedure(string DBName, string storedProcName, IDataParameter[] parameters)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            SqlConnection connection = new SqlConnection(connStr);
            SqlDataReader returnReader;
            connection.Open();
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.CommandType = CommandType.StoredProcedure;
            returnReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return returnReader;

        }


        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <returns>DataSet</returns>
        public DataSet RunProcedure(string DBName, string storedProcName, IDataParameter[] parameters, string tableName)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                DataSet dataSet = new DataSet();
                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                sqlDA.Fill(dataSet, tableName);
                connection.Close();
                return dataSet;
            }
        }
        public DataSet RunProcedure(string DBName, string storedProcName, IDataParameter[] parameters, string tableName, int Times)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                DataSet dataSet = new DataSet();
                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                sqlDA.SelectCommand.CommandTimeout = Times;
                sqlDA.Fill(dataSet, tableName);
                connection.Close();
                return dataSet;
            }
        }


        /// <summary>
        /// 构建 SqlCommand 对象(用来返回一个结果集，而不是一个整数值)
        /// </summary>
        /// <param name="connection">数据库连接</param>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand</returns>
        private SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in parameters)
            {
                if (parameter != null)
                {
                    // 检查未分配值的输出参数,将其分配以DBNull.Value.
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    command.Parameters.Add(parameter);
                }
            }

            return command;
        }

        /// <summary>
        /// 执行存储过程，返回影响的行数        
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="rowsAffected">影响的行数</param>
        /// <returns></returns>
        public int RunProcedure(string DBName, string storedProcName, IDataParameter[] parameters, out int rowsAffected)
        {
            string connStr = @"server ='" + DB_Source + "';database ='" + DBName + "';integrated security =SSPI";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                int result;
                connection.Open();
                SqlCommand command = BuildIntCommand(connection, storedProcName, parameters);
                rowsAffected = command.ExecuteNonQuery();
                result = (int)command.Parameters["ReturnValue"].Value;
                //Connection.Close();
                return result;
            }
        }

        /// <summary>
        /// 创建 SqlCommand 对象实例(用来返回一个整数值)    
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand 对象实例</returns>
        private SqlCommand BuildIntCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.Parameters.Add(new SqlParameter("ReturnValue",
                SqlDbType.Int, 4, ParameterDirection.ReturnValue,
                false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return command;
        }
        #endregion

    }
}

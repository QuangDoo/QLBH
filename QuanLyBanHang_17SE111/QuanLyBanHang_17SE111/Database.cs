﻿using QuanLyBanHang_17SE111.DanhMuc;
using QuanLyBanHang_17SE111.HeThong;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_17SE111
{
    public class Database : IDisposable
    {
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        string connectionString = string.Empty;
        public void Dispose()
        {
            if (cnn != null)
            {
                cnn.Dispose();
                cnn = null;
            }
            if (cmd != null)
            {
                cmd.Dispose();
                cmd = null;
            }
            if (da != null)
            {
                da.Dispose();
                da = null;
            }
        }
        public Database()
        {

            connectionString = @"server= DESKTOP-68FP9AM\NGUYENHUY ;database = DatabaseBanHang; Integrated Security = true;";
            cnn = new SqlConnection(connectionString);
        }
        public DataTable GetDataTable(ref string err, string sql, CommandType ct, params SqlParameter[] parameters)
        {
            DataTable table = null;
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();

                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 6000;
                if (parameters != null)
                {
                    foreach (SqlParameter item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                table = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(table);
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return table;
        }

        public bool MyExcuteNonQuery(ref string err, ref int count, string sql, CommandType ct, params SqlParameter[] parameters)
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();

                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 6000;
                if (parameters != null)
                {
                    foreach (SqlParameter item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                count = cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return false;
        }
        public bool MyExcuteNonQuery(ref string err, string sql, CommandType ct, params SqlParameter[] parameters)
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();

                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 6000;
                if (parameters != null)
                {
                    foreach (SqlParameter item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return false;
        }
        public object MyExecuteScalar(ref string err, string sql, CommandType ct, params SqlParameter[] parameters)
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();

                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 6000;
                if (parameters != null)
                {
                    foreach (SqlParameter item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                return cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return null;
        }
    }
}

using CodeGeneratore_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static CodeGeneratore_Business.clsCodeGeneratore;

namespace CodeGeneratore_Business
{
    public class clsCodeGeneratore
    {

        public struct stColumnInfo
        {
            public string Name;
            public string DataType;

            public bool AllowNull;
        }


        private List<stColumnInfo> ListColumnsInfo = new List<stColumnInfo>();

        public string Server { get; set; }
        public string DataBase { get; set; }
        public string UserId { get; set; }

        public string Password { get; set; }

        private string _ClassName = "";

        private string _SelectedTable = "";
        public string SelectedTable
        {
            set
            {
                _ClassName = _SelectedTable = value;
                DataTable dtColumns = clsCodeGeneratoreData.GetColumnsInfoForTable(_SelectedTable);
                stColumnInfo ColumnInfo = new stColumnInfo();
                ListColumnsInfo.Clear();
                foreach (DataRow row in dtColumns.Rows)
                {
                    ColumnInfo.Name = row["COLUMN_NAME"].ToString();
                    ColumnInfo.DataType = _GetDataTypeFromSqlDataType(row["DATA_TYPE"].ToString());
                    ColumnInfo.AllowNull = (row["Is_NULLABLE"].ToString() == "YES");
                    ListColumnsInfo.Add(ColumnInfo);
                }
                _ClassName = _ClassName.Remove(_ClassName.Length - 1, 1);
            }
            get
            {
                return _SelectedTable;
            }
        }
        private string _GetDataTypeFromSqlDataType(string SqlDataType)
        {
            switch (SqlDataType)
            {
                case "bigint":
                case "int":
                case "smallint":
                    return "int";

                case "tinyint":
                    return "short";

                case "smalldatetime":
                case "date":
                case "datetime":
                    return "DateTime";

                case "bit":
                    return "bool";

                case "decimal":
                case "numeric":
                case "money":
                case "smallmoney":
                case "float":
                case "real":
                    return "float";

                case "char":
                case "varchar":
                case "text":
                case "nchar":
                case "nvarchar":
                case "ntext":
                    return "string";

                default:
                    return "string";
            }
        }

        public void SetConnection()
        {
            clsDataAccessSettings.SetConnectionString(this.Server, this.DataBase, this.UserId, this.Password);
        }
        public string ConnectionString
        {
            get
            {
                return clsDataAccessSettings.GetConnectionString();
            }
        }
        public bool IsConnectionValide()
        {
            return clsCodeGeneratoreData.IsConnectionValide();
        }

        public clsCodeGeneratore(string Server, string DataBase, string UserId, string Password)
        {
            this.Server = Server;
            this.UserId = UserId;
            this.Password = Password;
            this.DataBase = DataBase;
            SetConnection();
        }
        public static DataTable GetAllTables()
        {
            return clsCodeGeneratoreData.GetAllTables();
        }

        private string _GetDefaultValueForDataType(string DataType, bool AllowNull)
        {
            if (AllowNull || (DataType == "string"))
                return "null";

            switch (DataType)
            {
                case "bool":
                    return "false";
                case "int":
                    return "-1";
                case "short":
                    return "1";
                case "float":
                    return "0";
                case "DateTime":
                    return "DateTime.Now";
                default:
                    return "null";
            }

        }
        private string _GenerateProperty()
        {
            if (ListColumnsInfo == null)
                return "";



            StringBuilder sb = new StringBuilder();
            string MarkIsNullableDataType = "?";

            foreach (stColumnInfo ColumnInfo in ListColumnsInfo)
            {

                if (!ColumnInfo.AllowNull || ColumnInfo.DataType == "string")
                    MarkIsNullableDataType = "";
                else
                    MarkIsNullableDataType = "?";

                sb.AppendLine($"\t         public {ColumnInfo.DataType}{MarkIsNullableDataType} {ColumnInfo.Name}  {{get; set;}} ");
            }
            return sb.ToString();
        }
        private string _GeneratePublicConstructor()
        {
            if (ListColumnsInfo == null)
                return "";

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"\t         public cls{_ClassName}()\r\n\t         {{");
            foreach (stColumnInfo ColumnInfo in ListColumnsInfo)
            {
                sb.AppendLine($"\t                  {ColumnInfo.Name} = {_GetDefaultValueForDataType(ColumnInfo.DataType, ColumnInfo.AllowNull)};");
            }
            sb.AppendLine("\t                  Mode = enMode.AddNew;");
            sb.AppendLine($"\t         }}");
            return sb.ToString();
        }

        private string _GetListParametersWithDataType(bool ByRef=false)
        {
            StringBuilder sb = new StringBuilder();

            string Ref = (ByRef) ? "ref" : "";

            string MarkIsAlowNull = "?";

            foreach (stColumnInfo ColumnInfo in ListColumnsInfo)
            {
                if (ColumnInfo.DataType != "string" && ColumnInfo.AllowNull)
                    MarkIsAlowNull = "?";
                else
                    MarkIsAlowNull = "";
                sb.Append($"{Ref} {ColumnInfo.DataType}{MarkIsAlowNull} {ColumnInfo.Name} , ");
            }
            return sb.Remove(sb.Length - 2, 1).ToString();

        }

        private string _GeneratePrivateConstructor()
        {
            if (ListColumnsInfo == null)
                return "";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\t         private cls{_ClassName}({_GetListParametersWithDataType()})\r\n\t         {{");

            foreach (stColumnInfo ColumnInfo in ListColumnsInfo)
            {
                sb.AppendLine($"\t                  this.{ColumnInfo.Name} = {ColumnInfo.Name};");
            }
            sb.AppendLine("\t                  Mode = enMode.Update;");
            sb.AppendLine($"\t         }}");
            return sb.ToString();
        }

        private string _GetListProperty(bool WithID = true, bool ByRef = false)
        {
            StringBuilder sb = new StringBuilder();
            int start = (WithID) ? 0 : 1;
            string Ref = (ByRef) ? "ref" : "";

            for (int i = start; i < ListColumnsInfo.Count; i++)
            {
                sb.Append($"{Ref} {ListColumnsInfo[i].Name} , ");
            }

            return sb.Remove(sb.Length - 2, 1).ToString();
        }
        private string _GenerateAddNewMethode()
        {
            if (ListColumnsInfo == null)
                return "";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"private bool _AddNew{_ClassName}()\r\n\t         {{");

            sb.AppendLine($"this.{_ClassName}ID =cls{_ClassName}Data.AddNew{_ClassName}({_GetListProperty(false)}); \r\n");
            sb.AppendLine($"return (this.{_ClassName}ID != -1);");
            sb.AppendLine($"}}");
            return sb.ToString();
        }
        private string _GenerateUpdateMethode()
        {
            if (ListColumnsInfo == null)
                return "";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"private bool _Update{_ClassName}()\r\n\t         {{");

            sb.AppendLine($"return cls{_ClassName}Data.Update{_ClassName}({_GetListProperty(true)}); \r\n");
            sb.AppendLine($"}}");
            return sb.ToString();
        }
        private string _GenerateSaveMethode()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"	         public bool Save()
                           {
                                switch (Mode)
                                {
                                    case enMode.AddNew:
                                        if (_AddNew" + $"{_ClassName}()" + @")
                                        {
                                             Mode = enMode.Update;
                                             return true;
                                         }
                                         else
                                              return false;
                                    case enMode.Update:
                                          return _Update" + $"{_ClassName}()" + @";
                                  }
                                  return false;
                             }");
            return sb.ToString();
        }

        private string _GenerateDeleteMethode()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"	         public static bool Delete" + $"{_ClassName}" + @"(int " + $"{_ClassName}ID" + @")
                          {
                                                return cls" + $"{_ClassName}Data.Delete{_ClassName}({_ClassName}ID)" + @";
                          }");
            return sb.ToString();
        }
        private string _GenerateGetAllMethode()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"	         public static DataTable GetAll" + $"{_ClassName}s(" + @")
                           {
                                                return cls" + $"{_ClassName}Data.GetAll{_ClassName}s()" + @";
                           }");
            return sb.ToString();
        }

        private string _GenerateISExistMethode()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"	         public static bool Is" + $"{_ClassName}Exist(int {_ClassName}ID" + @")
                          {
                                                return cls" + $"{_ClassName}Data.Is{_ClassName}Exist({_ClassName}ID)" + @";
                          }");
            return sb.ToString();
        }

        private string _GetAllVaribleDeclared()
        {
            StringBuilder sb = new StringBuilder();

            foreach (stColumnInfo ColumnInfo in ListColumnsInfo)
            {
                sb.Append($"{ColumnInfo.DataType} {ColumnInfo.Name} = {_GetDefaultValueForDataType(ColumnInfo.DataType, ColumnInfo.AllowNull)} ; ");
            }
            return sb.Remove(sb.Length - 2, 1).ToString();
        }

        private string _GenerateFindMethode()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"public static cls" + $"{_ClassName} Find(int {_ClassName}ID)" + @"
                          {

                             " + $"{_GetAllVaribleDeclared()}" + @"

                             if (cls" + $"{_ClassName}Data.Get{_ClassName}InfoByID({_GetListProperty(true, true)}))" + @"
                             {
                                     return new cls" + $"{_ClassName}({_GetListProperty(true, false)})" + @";

                             }
                            return null;

                         }");
            return sb.ToString();
        }

        public string GenerateBusinessLayer()
        {
            StringBuilder sbBusinessLayer = new StringBuilder();
            
            sbBusinessLayer.AppendLine($"public enum enMode {{ AddNew = 0, Update = 1 }};\r\nprivate enMode Mode = enMode.AddNew;");
            sbBusinessLayer.AppendLine(_GenerateProperty());

            sbBusinessLayer.AppendLine(_GeneratePrivateConstructor());

            sbBusinessLayer.AppendLine(_GeneratePublicConstructor());

            sbBusinessLayer.AppendLine(_GenerateFindMethode());

            sbBusinessLayer.AppendLine(_GenerateAddNewMethode());

            sbBusinessLayer.AppendLine(_GenerateUpdateMethode());

            sbBusinessLayer.AppendLine(_GenerateSaveMethode());

            sbBusinessLayer.AppendLine(_GenerateDeleteMethode());

            sbBusinessLayer.AppendLine(_GenerateGetAllMethode());

            sbBusinessLayer.AppendLine(_GenerateISExistMethode());


            return sbBusinessLayer.ToString();
        }

        private string _GetCommandParameters()
        {
            StringBuilder sb = new StringBuilder();

            foreach (stColumnInfo ColumnInfo in ListColumnsInfo)
            {
                if(ColumnInfo.AllowNull)
                {
                    sb.AppendLine(@"if ("+$"{ColumnInfo.Name}!= null)"+ @"
                                          Command.Parameters.AddWithValue("+$"\"@{ ColumnInfo.Name}\", {ColumnInfo.Name});"+@"
                                  else
                                          Command.Parameters.AddWithValue("+ $"\"@{ColumnInfo.Name}\""+", DBNull.Value);");
                }
                else
                   sb.AppendLine($"Command.Parameters.AddWithValue(\"@{ColumnInfo.Name}\", {ColumnInfo.Name});");
            }
            return sb.ToString();
        }

        private string _ReadParametersFromDataBase()
        {
            StringBuilder sb = new StringBuilder();

            foreach (stColumnInfo ColumnInfo in ListColumnsInfo)
            {
                if (ColumnInfo.AllowNull)
                {
                  
                    sb.AppendLine($"{ColumnInfo.Name} = (Reader[\"{ColumnInfo.Name}\"] == DBNull.Value) ? \"  : ({ColumnInfo.DataType})Reader[\"{ColumnInfo.Name}\"];");
                }
                else
                    sb.AppendLine($"{ColumnInfo.Name} = ({ColumnInfo.DataType})Reader[\"{ColumnInfo.Name}\"];");
            }
            return sb.ToString();
        }

        private string _GenerateAddNewDataMethode()
        {
            
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"public static int AddNew" + $"{_ClassName}({_GetListParametersWithDataType()})" + @"
                          {
                                                  int " + $"{_ClassName}ID = -1;" + @"
                                                  try
                                                  {
                                                         using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                                                         {
                                                                 Connection.Open();
                                                                 using (SqlCommand Command = new SqlCommand(""SP_AddNew" + $"{_ClassName}\"" + @", Connection))
                                                                 {
                                                                         Command.CommandType = CommandType.StoredProcedure;
                                                                         " + $"{_GetCommandParameters()}"+@"

                                                                         SqlParameter outputIdParam = new SqlParameter(""@New" + $"{_ClassName}ID\"" + @", SqlDbType.Int)
                                                                         {
                                                                              Direction = ParameterDirection.Output
                                                                          };
                                                                           Command.Parameters.Add(outputIdParam);


                                                                           Command.ExecuteNonQuery();

                                                                           " + $"{_ClassName}ID" + @" = (int)outputIdParam.Value;

                                                                    }
                                                              }
                                                           
                                                        }
                                                       catch (Exception Ex)
                                                       {
                                                               clsEventLogData.WriteEvent($"" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}"", EventLogEntryType.Error);
                                                                 " + $"{_ClassName}ID" + @"= -1;
                                                        }
                                                        return "+$"{_ClassName}ID"+@";
                          }");
            return sb.ToString();
        }
        private string _GenerateUpdateDataMethode()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"public static bool Update" + $"{_ClassName}({_GetListParametersWithDataType()})" + @"
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(""SP_Update" + $"{_ClassName}\"" + @", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        "+$"{_GetCommandParameters()}"+@"


                        RowsEffected = Command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($"" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}"", EventLogEntryType.Error);
                RowsEffected = 0;
            }

            return RowsEffected > 0;
        }");
            return sb.ToString();
        }
        private string _GenerateDeleteDataMethode()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"public static bool Delete" + $"{_ClassName}(int {_ClassName}ID)" + @"
        {
            int RowsEffected = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(""SP_Delete" + $"{_ClassName}\"" + @", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("+$"\"@{_ClassName}ID\", {_ClassName}ID);" + @"


                        RowsEffected = Command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($"" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}"", EventLogEntryType.Error);
                RowsEffected = 0;
            }

            return RowsEffected > 0;
        }");
            return sb.ToString();
        }
        private string _GenerateGetAllDataMethode()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"public static DataTable GetAll"+$"{_ClassName}s"+ @"()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(""SP_GetAll" + $"{_ClassName}s\"" + @", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dt.Load(Reader);
                        }


                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($"" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}"", EventLogEntryType.Error);
            
            }

            return dt;
        }");
            return sb.ToString();
        }
        private string _GenerateIsExistDataMethode()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"public static bool Is"+$"{_ClassName}Exist(int "+$"{_ClassName}ID)"+ @"
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(""SP_Is"+$"{_ClassName}ExistByID\""+@", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue(" + $"\"@{_ClassName}ID\", {_ClassName}ID);" + @"
                        SqlParameter IsFoundParam = new SqlParameter(""@IsFound"", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(IsFoundParam);

                        Command.ExecuteNonQuery();
                        IsFound = ((int)IsFoundParam.Value == 1);

                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($"" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}"", EventLogEntryType.Error);
                IsFound = false;
            }
            return IsFound;
        }");
            return sb.ToString();
        }

        private string _GenerateGetInfoByIDDataMethode()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"public static bool Get"+$"{_ClassName}InfoByID({_GetListParametersWithDataType(true)})" + @"
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(""SP_Get"+$"{_ClassName}InfoByID\", Connection))"+@"
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("+$"\"@{_ClassName}ID\", {_ClassName}ID);" + @"
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                 IsFound = true;
                                 " + $"{_ReadParametersFromDataBase()}"+@"
                               
                            }
                            else
                                IsFound = false;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                clsEventLogData.WriteEvent($"" Message : {Ex.Message} \n\n Source : {Ex.Source} \n\n Target Site :  {Ex.TargetSite} \n\n Stack Trace :  {Ex.StackTrace}"", EventLogEntryType.Error);
                IsFound = false;
            }
            return IsFound;
            
        }
");
            return sb.ToString();
        }

        public string GenerateDataAccessLayer()
        {
            StringBuilder sbDataAccessLayer = new StringBuilder();
            
            
            sbDataAccessLayer.AppendLine(_GenerateAddNewDataMethode());
            sbDataAccessLayer.AppendLine(_GenerateUpdateDataMethode());
            sbDataAccessLayer.AppendLine(_GenerateDeleteDataMethode());
            sbDataAccessLayer.AppendLine(_GenerateGetAllDataMethode());
            sbDataAccessLayer.AppendLine(_GenerateIsExistDataMethode());
            sbDataAccessLayer.AppendLine(_GenerateGetInfoByIDDataMethode());
            return sbDataAccessLayer.ToString();
        }

        private string _GenerateSP_AddNew()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");

            return sb.ToString();
        }
        

    }
}

//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace OpenDentBusiness.WebTypes.WebForms.Crud{
	public class WebForms_PreferenceCrud {
		///<summary>Gets one WebForms_Preference object from the database using the primary key.  Returns null if not found.</summary>
		public static WebForms_Preference SelectOne(long dentalOfficeID) {
			string command="SELECT * FROM webforms_preference "
				+"WHERE DentalOfficeID = "+POut.Long(dentalOfficeID);
			List<WebForms_Preference> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one WebForms_Preference object from the database using a query.</summary>
		public static WebForms_Preference SelectOne(string command) {
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<WebForms_Preference> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of WebForms_Preference objects from the database using a query.</summary>
		public static List<WebForms_Preference> SelectMany(string command) {
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<WebForms_Preference> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<WebForms_Preference> TableToList(DataTable table) {
			List<WebForms_Preference> retVal=new List<WebForms_Preference>();
			WebForms_Preference webForms_Preference;
			foreach(DataRow row in table.Rows) {
				webForms_Preference=new WebForms_Preference();
				webForms_Preference.DentalOfficeID   = PIn.Long  (row["DentalOfficeID"].ToString());
				webForms_Preference.ColorBorder      = Color.FromArgb(PIn.Int(row["ColorBorder"].ToString()));
				webForms_Preference.CultureName      = PIn.String(row["CultureName"].ToString());
				webForms_Preference.DisableSignatures= PIn.Bool  (row["DisableSignatures"].ToString());
				retVal.Add(webForms_Preference);
			}
			return retVal;
		}

		///<summary>Converts a list of WebForms_Preference into a DataTable.</summary>
		public static DataTable ListToTable(List<WebForms_Preference> listWebForms_Preferences,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="WebForms_Preference";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("DentalOfficeID");
			table.Columns.Add("ColorBorder");
			table.Columns.Add("CultureName");
			table.Columns.Add("DisableSignatures");
			foreach(WebForms_Preference webForms_Preference in listWebForms_Preferences) {
				table.Rows.Add(new object[] {
					POut.Long  (webForms_Preference.DentalOfficeID),
					POut.Int   (webForms_Preference.ColorBorder.ToArgb()),
					            webForms_Preference.CultureName,
					POut.Bool  (webForms_Preference.DisableSignatures),
				});
			}
			return table;
		}

		///<summary>Inserts one WebForms_Preference into the database.  Returns the new priKey.</summary>
		public static long Insert(WebForms_Preference webForms_Preference) {
			return Insert(webForms_Preference,false);
		}

		///<summary>Inserts one WebForms_Preference into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(WebForms_Preference webForms_Preference,bool useExistingPK) {
			string command="INSERT INTO webforms_preference (";
			if(useExistingPK) {
				command+="DentalOfficeID,";
			}
			command+="ColorBorder,CultureName,DisableSignatures) VALUES(";
			if(useExistingPK) {
				command+=POut.Long(webForms_Preference.DentalOfficeID)+",";
			}
			command+=
				     POut.Int   (webForms_Preference.ColorBorder.ToArgb())+","
				+"'"+POut.String(webForms_Preference.CultureName)+"',"
				+    POut.Bool  (webForms_Preference.DisableSignatures)+")";
			if(useExistingPK) {
				Db.NonQ(command);
			}
			else {
				webForms_Preference.DentalOfficeID=Db.NonQ(command,true,"DentalOfficeID","webForms_Preference");
			}
			return webForms_Preference.DentalOfficeID;
		}

		///<summary>Inserts one WebForms_Preference into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(WebForms_Preference webForms_Preference) {
			return InsertNoCache(webForms_Preference,false);
		}

		///<summary>Inserts one WebForms_Preference into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(WebForms_Preference webForms_Preference,bool useExistingPK) {
			string command="INSERT INTO webforms_preference (";
			if(useExistingPK) {
				command+="DentalOfficeID,";
			}
			command+="ColorBorder,CultureName,DisableSignatures) VALUES(";
			if(useExistingPK) {
				command+=POut.Long(webForms_Preference.DentalOfficeID)+",";
			}
			command+=
				     POut.Int   (webForms_Preference.ColorBorder.ToArgb())+","
				+"'"+POut.String(webForms_Preference.CultureName)+"',"
				+    POut.Bool  (webForms_Preference.DisableSignatures)+")";
			if(useExistingPK) {
				Db.NonQ(command);
			}
			else {
				webForms_Preference.DentalOfficeID=Db.NonQ(command,true,"DentalOfficeID","webForms_Preference");
			}
			return webForms_Preference.DentalOfficeID;
		}

		///<summary>Updates one WebForms_Preference in the database.</summary>
		public static void Update(WebForms_Preference webForms_Preference) {
			string command="UPDATE webforms_preference SET "
				+"ColorBorder      =  "+POut.Int   (webForms_Preference.ColorBorder.ToArgb())+", "
				+"CultureName      = '"+POut.String(webForms_Preference.CultureName)+"', "
				+"DisableSignatures=  "+POut.Bool  (webForms_Preference.DisableSignatures)+" "
				+"WHERE DentalOfficeID = "+POut.Long(webForms_Preference.DentalOfficeID);
			Db.NonQ(command);
		}

		///<summary>Updates one WebForms_Preference in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(WebForms_Preference webForms_Preference,WebForms_Preference oldWebForms_Preference) {
			string command="";
			if(webForms_Preference.ColorBorder != oldWebForms_Preference.ColorBorder) {
				if(command!="") { command+=",";}
				command+="ColorBorder = "+POut.Int(webForms_Preference.ColorBorder.ToArgb())+"";
			}
			if(webForms_Preference.CultureName != oldWebForms_Preference.CultureName) {
				if(command!="") { command+=",";}
				command+="CultureName = '"+POut.String(webForms_Preference.CultureName)+"'";
			}
			if(webForms_Preference.DisableSignatures != oldWebForms_Preference.DisableSignatures) {
				if(command!="") { command+=",";}
				command+="DisableSignatures = "+POut.Bool(webForms_Preference.DisableSignatures)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE webforms_preference SET "+command
				+" WHERE DentalOfficeID = "+POut.Long(webForms_Preference.DentalOfficeID);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(WebForms_Preference,WebForms_Preference) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(WebForms_Preference webForms_Preference,WebForms_Preference oldWebForms_Preference) {
			if(webForms_Preference.ColorBorder != oldWebForms_Preference.ColorBorder) {
				return true;
			}
			if(webForms_Preference.CultureName != oldWebForms_Preference.CultureName) {
				return true;
			}
			if(webForms_Preference.DisableSignatures != oldWebForms_Preference.DisableSignatures) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one WebForms_Preference from the database.</summary>
		public static void Delete(long dentalOfficeID) {
			string command="DELETE FROM webforms_preference "
				+"WHERE DentalOfficeID = "+POut.Long(dentalOfficeID);
			Db.NonQ(command);
		}

	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OpenDentBusiness {
	///<summary>When a general message is sent for an appointment a record of that send is stored here. This is used to prevent re-sends of the same message.</summary>
	[Serializable, CrudTable(HasBatchWriteMethods = true)]
	public class ApptGeneralMessageSent:TableBase {
		///<summary>Primary key.</summary>
		[CrudColumn(IsPriKey=true)]
		public long ApptGeneralMessageSentNum;
		///<summary>FK to appointment.AptNum.</summary>
		public long ApptNum;
		///<summary>FK to patient.PatNum for the corresponding patient.</summary>
		public long PatNum;
		///<summary>FK to clinic.ClinicNum for the corresponding appointment.</summary>
		public long ClinicNum;
		///<summary>Generated by OD. Timestamp when row is created.</summary>
		[CrudColumn(SpecialType=CrudSpecialColType.DateTEntry)]
		public DateTime DateTimeEntry;
		///<summary>This was the TSPrior used to send this reminder. </summary>
		[XmlIgnore]
		[CrudColumn(SpecialType=CrudSpecialColType.TimeSpanLong)]
		public TimeSpan TSPrior;
		///<summary>FK to apptreminderrule.ApptReminderRuleNum. Allows us to look up the rules to determine how to send this apptcomm out.</summary>
		public long ApptReminderRuleNum;
		///<summary>Enum:AutoCommStatus Generated by HQ. Indicates whether or not we were able to send the text message.</summary>
		public AutoCommStatus SmsSendStatus;
		///<summary>Enum:AutoCommStatus Generated by HQ. Indicates whether or not we were able to send the e-mail.</summary>
		public AutoCommStatus EmailSendStatus;
	}
}

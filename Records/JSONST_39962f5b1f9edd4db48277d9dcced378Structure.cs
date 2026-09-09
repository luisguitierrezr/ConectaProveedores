using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesReport48_6Approval
public class JSONST_39962f5b1f9edd4db48277d9dcced378Structure : AbstractRESTStructure<ST_39962f5b1f9edd4db48277d9dcced378Structure> {
[JsonProperty("ApprovingUsers")]
[JsonPropertyName("ApprovingUsers")]
public string AttrApprovingUsers;

[JsonProperty("InvoiceApprovalDate")]
[JsonPropertyName("InvoiceApprovalDate")]
public String AttrInvoiceApprovalDate;

[JsonProperty("ApprovalArea")]
[JsonPropertyName("ApprovalArea")]
public string AttrApprovalArea;

[JsonProperty("AccountingUser")]
[JsonPropertyName("AccountingUser")]
public string AttrAccountingUser;

public JSONST_39962f5b1f9edd4db48277d9dcced378Structure() { }

public JSONST_39962f5b1f9edd4db48277d9dcced378Structure (ST_39962f5b1f9edd4db48277d9dcced378Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovingUsers = ConvertToRestWithoutDefaults(s.ssApprovingUsers, "");
AttrInvoiceApprovalDate = ConvertDateToRestWithoutDefaults(s.ssInvoiceApprovalDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrApprovalArea = ConvertToRestWithoutDefaults(s.ssApprovalArea, "");
AttrAccountingUser = ConvertToRestWithoutDefaults(s.ssAccountingUser, "");
  } else {
AttrApprovingUsers = s.ssApprovingUsers;
AttrInvoiceApprovalDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssInvoiceApprovalDate);
AttrApprovalArea = s.ssApprovalArea;
AttrAccountingUser = s.ssAccountingUser;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_39962f5b1f9edd4db48277d9dcced378Structure, ST_39962f5b1f9edd4db48277d9dcced378Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_39962f5b1f9edd4db48277d9dcced378Structure s) => ToStructure(s, config);
}
public static ST_39962f5b1f9edd4db48277d9dcced378Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_39962f5b1f9edd4db48277d9dcced378Structure obj, IBehaviorsConfiguration config) { 
  ST_39962f5b1f9edd4db48277d9dcced378Structure s = new ST_39962f5b1f9edd4db48277d9dcced378Structure();
  if(obj != null) {
  s.ssApprovingUsers = obj.AttrApprovingUsers == null ? "" : obj.AttrApprovingUsers;
  s.ssInvoiceApprovalDate = obj.AttrInvoiceApprovalDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrInvoiceApprovalDate);
  s.ssApprovalArea = obj.AttrApprovalArea == null ? "" : obj.AttrApprovalArea;
  s.ssAccountingUser = obj.AttrAccountingUser == null ? "" : obj.AttrAccountingUser;
  }
  return s;
}

public static Func<ST_39962f5b1f9edd4db48277d9dcced378Structure, ssConectaProveedores.RestRecords.JSONST_39962f5b1f9edd4db48277d9dcced378Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_39962f5b1f9edd4db48277d9dcced378Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_39962f5b1f9edd4db48277d9dcced378Structure FromStructure(ST_39962f5b1f9edd4db48277d9dcced378Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_39962f5b1f9edd4db48277d9dcced378Structure(s, config);
}

}



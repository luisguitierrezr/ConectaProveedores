using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceApprovalLevelRecord
public class RESTRC_a542803a75b19356be8279fb269e55fb : AbstractRESTStructure<RC_a542803a75b19356be8279fb269e55fb> {
[JsonProperty("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

public RESTRC_a542803a75b19356be8279fb269e55fb() { }

public RESTRC_a542803a75b19356be8279fb269e55fb (RC_a542803a75b19356be8279fb269e55fb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
  } else {
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
  }
}

public static RC_a542803a75b19356be8279fb269e55fb ToStructure(ssConectaProveedores.RestRecords.RESTRC_a542803a75b19356be8279fb269e55fb obj) { 
  RC_a542803a75b19356be8279fb269e55fb s = new RC_a542803a75b19356be8279fb269e55fb();
  if(obj != null) {
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel);
  }
  return s;
}

public static Func<RC_a542803a75b19356be8279fb269e55fb, ssConectaProveedores.RestRecords.RESTRC_a542803a75b19356be8279fb269e55fb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a542803a75b19356be8279fb269e55fb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a542803a75b19356be8279fb269e55fb FromStructure(RC_a542803a75b19356be8279fb269e55fb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a542803a75b19356be8279fb269e55fb(s, config);
}

}



using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceStatusHistoryRecord
public class RESTRC_a2551032116fa7acb5fb1896fd9acdf2 : AbstractRESTStructure<RC_a2551032116fa7acb5fb1896fd9acdf2> {
[JsonProperty("InvoiceStatusHistory")]
public ssConectaProveedores.RestRecords.RESTEN_9edea2a401b6983c9ad50261c300f6d7EntityRecord AttrInvoiceStatusHistory;

public RESTRC_a2551032116fa7acb5fb1896fd9acdf2() { }

public RESTRC_a2551032116fa7acb5fb1896fd9acdf2 (RC_a2551032116fa7acb5fb1896fd9acdf2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceStatusHistory = ConvertToRestWithoutDefaults(s.ssENInvoiceStatusHistory, new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9edea2a401b6983c9ad50261c300f6d7EntityRecord.FromStructure, config);
  } else {
AttrInvoiceStatusHistory = ssConectaProveedores.RestRecords.RESTEN_9edea2a401b6983c9ad50261c300f6d7EntityRecord.FromStructure(s.ssENInvoiceStatusHistory, config);
  }
}

public static RC_a2551032116fa7acb5fb1896fd9acdf2 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a2551032116fa7acb5fb1896fd9acdf2 obj) { 
  RC_a2551032116fa7acb5fb1896fd9acdf2 s = new RC_a2551032116fa7acb5fb1896fd9acdf2();
  if(obj != null) {
  s.ssENInvoiceStatusHistory = ssConectaProveedores.RestRecords.RESTEN_9edea2a401b6983c9ad50261c300f6d7EntityRecord.ToStructure(obj.AttrInvoiceStatusHistory);
  }
  return s;
}

public static Func<RC_a2551032116fa7acb5fb1896fd9acdf2, ssConectaProveedores.RestRecords.RESTRC_a2551032116fa7acb5fb1896fd9acdf2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a2551032116fa7acb5fb1896fd9acdf2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a2551032116fa7acb5fb1896fd9acdf2 FromStructure(RC_a2551032116fa7acb5fb1896fd9acdf2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a2551032116fa7acb5fb1896fd9acdf2(s, config);
}

}



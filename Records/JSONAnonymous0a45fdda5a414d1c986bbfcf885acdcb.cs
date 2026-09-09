using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceStatusHistoryRecord
public class JSONRC_a2551032116fa7acb5fb1896fd9acdf2 : AbstractRESTStructure<RC_a2551032116fa7acb5fb1896fd9acdf2> {
[JsonProperty("InvoiceStatusHistory")]
[JsonPropertyName("InvoiceStatusHistory")]
public ssConectaProveedores.RestRecords.JSONEN_9edea2a401b6983c9ad50261c300f6d7EntityRecord AttrInvoiceStatusHistory;

public JSONRC_a2551032116fa7acb5fb1896fd9acdf2() { }

public JSONRC_a2551032116fa7acb5fb1896fd9acdf2 (RC_a2551032116fa7acb5fb1896fd9acdf2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceStatusHistory = ConvertToRestWithoutDefaults(s.ssENInvoiceStatusHistory, new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9edea2a401b6983c9ad50261c300f6d7EntityRecord.FromStructure, config);
  } else {
AttrInvoiceStatusHistory = ssConectaProveedores.RestRecords.JSONEN_9edea2a401b6983c9ad50261c300f6d7EntityRecord.FromStructure(s.ssENInvoiceStatusHistory, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a2551032116fa7acb5fb1896fd9acdf2, RC_a2551032116fa7acb5fb1896fd9acdf2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a2551032116fa7acb5fb1896fd9acdf2 s) => ToStructure(s, config);
}
public static RC_a2551032116fa7acb5fb1896fd9acdf2 ToStructure(ssConectaProveedores.RestRecords.JSONRC_a2551032116fa7acb5fb1896fd9acdf2 obj, IBehaviorsConfiguration config) { 
  RC_a2551032116fa7acb5fb1896fd9acdf2 s = new RC_a2551032116fa7acb5fb1896fd9acdf2();
  if(obj != null) {
  s.ssENInvoiceStatusHistory = ssConectaProveedores.RestRecords.JSONEN_9edea2a401b6983c9ad50261c300f6d7EntityRecord.ToStructure(obj.AttrInvoiceStatusHistory, config);
  }
  return s;
}

public static Func<RC_a2551032116fa7acb5fb1896fd9acdf2, ssConectaProveedores.RestRecords.JSONRC_a2551032116fa7acb5fb1896fd9acdf2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a2551032116fa7acb5fb1896fd9acdf2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a2551032116fa7acb5fb1896fd9acdf2 FromStructure(RC_a2551032116fa7acb5fb1896fd9acdf2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a2551032116fa7acb5fb1896fd9acdf2(s, config);
}

}



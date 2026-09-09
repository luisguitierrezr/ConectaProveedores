using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingEntriesRecord
public class JSONRC_85ff79276420f97ef98dc48e2b262e60 : AbstractRESTStructure<RC_85ff79276420f97ef98dc48e2b262e60> {
[JsonProperty("InvoiceAccountingEntries")]
[JsonPropertyName("InvoiceAccountingEntries")]
public ssConectaProveedores.RestRecords.JSONEN_66fb76d3fab58a693a3c750c022bd4efEntityRecord AttrInvoiceAccountingEntries;

public JSONRC_85ff79276420f97ef98dc48e2b262e60() { }

public JSONRC_85ff79276420f97ef98dc48e2b262e60 (RC_85ff79276420f97ef98dc48e2b262e60 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingEntries = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingEntries, new EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_66fb76d3fab58a693a3c750c022bd4efEntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingEntries = ssConectaProveedores.RestRecords.JSONEN_66fb76d3fab58a693a3c750c022bd4efEntityRecord.FromStructure(s.ssENInvoiceAccountingEntries, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_85ff79276420f97ef98dc48e2b262e60, RC_85ff79276420f97ef98dc48e2b262e60> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_85ff79276420f97ef98dc48e2b262e60 s) => ToStructure(s, config);
}
public static RC_85ff79276420f97ef98dc48e2b262e60 ToStructure(ssConectaProveedores.RestRecords.JSONRC_85ff79276420f97ef98dc48e2b262e60 obj, IBehaviorsConfiguration config) { 
  RC_85ff79276420f97ef98dc48e2b262e60 s = new RC_85ff79276420f97ef98dc48e2b262e60();
  if(obj != null) {
  s.ssENInvoiceAccountingEntries = ssConectaProveedores.RestRecords.JSONEN_66fb76d3fab58a693a3c750c022bd4efEntityRecord.ToStructure(obj.AttrInvoiceAccountingEntries, config);
  }
  return s;
}

public static Func<RC_85ff79276420f97ef98dc48e2b262e60, ssConectaProveedores.RestRecords.JSONRC_85ff79276420f97ef98dc48e2b262e60> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_85ff79276420f97ef98dc48e2b262e60 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_85ff79276420f97ef98dc48e2b262e60 FromStructure(RC_85ff79276420f97ef98dc48e2b262e60 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_85ff79276420f97ef98dc48e2b262e60(s, config);
}

}



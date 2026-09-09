using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// InvoiceUsageRecord
public class JSONRC_2512cd3cc7f986e36b4d5edf290d4383 : AbstractRESTStructure<RC_2512cd3cc7f986e36b4d5edf290d4383> {
[JsonProperty("InvoiceUsage")]
[JsonPropertyName("InvoiceUsage")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord AttrInvoiceUsage;

public JSONRC_2512cd3cc7f986e36b4d5edf290d4383() { }

public JSONRC_2512cd3cc7f986e36b4d5edf290d4383 (RC_2512cd3cc7f986e36b4d5edf290d4383 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceUsage = ConvertToRestWithoutDefaults(s.ssENInvoiceUsage, new EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord.FromStructure, config);
  } else {
AttrInvoiceUsage = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord.FromStructure(s.ssENInvoiceUsage, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2512cd3cc7f986e36b4d5edf290d4383, RC_2512cd3cc7f986e36b4d5edf290d4383> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2512cd3cc7f986e36b4d5edf290d4383 s) => ToStructure(s, config);
}
public static RC_2512cd3cc7f986e36b4d5edf290d4383 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2512cd3cc7f986e36b4d5edf290d4383 obj, IBehaviorsConfiguration config) { 
  RC_2512cd3cc7f986e36b4d5edf290d4383 s = new RC_2512cd3cc7f986e36b4d5edf290d4383();
  if(obj != null) {
  s.ssENInvoiceUsage = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord.ToStructure(obj.AttrInvoiceUsage, config);
  }
  return s;
}

public static Func<RC_2512cd3cc7f986e36b4d5edf290d4383, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2512cd3cc7f986e36b4d5edf290d4383> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2512cd3cc7f986e36b4d5edf290d4383 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2512cd3cc7f986e36b4d5edf290d4383 FromStructure(RC_2512cd3cc7f986e36b4d5edf290d4383 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_2512cd3cc7f986e36b4d5edf290d4383(s, config);
}

}



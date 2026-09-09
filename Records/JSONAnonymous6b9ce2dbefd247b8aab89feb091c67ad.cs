using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingProcessResponseRecord
public class JSONRC_8d2c7f494e763d54feb138104c341adb : AbstractRESTStructure<RC_8d2c7f494e763d54feb138104c341adb> {
[JsonProperty("InvoiceAccountingProcessResponse")]
[JsonPropertyName("InvoiceAccountingProcessResponse")]
public ssConectaProveedores.RestRecords.JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord AttrInvoiceAccountingProcessResponse;

public JSONRC_8d2c7f494e763d54feb138104c341adb() { }

public JSONRC_8d2c7f494e763d54feb138104c341adb (RC_8d2c7f494e763d54feb138104c341adb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingProcessResponse = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcessResponse, new EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingProcessResponse = ssConectaProveedores.RestRecords.JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord.FromStructure(s.ssENInvoiceAccountingProcessResponse, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8d2c7f494e763d54feb138104c341adb, RC_8d2c7f494e763d54feb138104c341adb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8d2c7f494e763d54feb138104c341adb s) => ToStructure(s, config);
}
public static RC_8d2c7f494e763d54feb138104c341adb ToStructure(ssConectaProveedores.RestRecords.JSONRC_8d2c7f494e763d54feb138104c341adb obj, IBehaviorsConfiguration config) { 
  RC_8d2c7f494e763d54feb138104c341adb s = new RC_8d2c7f494e763d54feb138104c341adb();
  if(obj != null) {
  s.ssENInvoiceAccountingProcessResponse = ssConectaProveedores.RestRecords.JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcessResponse, config);
  }
  return s;
}

public static Func<RC_8d2c7f494e763d54feb138104c341adb, ssConectaProveedores.RestRecords.JSONRC_8d2c7f494e763d54feb138104c341adb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8d2c7f494e763d54feb138104c341adb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8d2c7f494e763d54feb138104c341adb FromStructure(RC_8d2c7f494e763d54feb138104c341adb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8d2c7f494e763d54feb138104c341adb(s, config);
}

}



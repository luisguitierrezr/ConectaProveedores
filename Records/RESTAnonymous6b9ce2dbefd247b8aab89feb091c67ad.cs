using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingProcessResponseRecord
public class RESTRC_8d2c7f494e763d54feb138104c341adb : AbstractRESTStructure<RC_8d2c7f494e763d54feb138104c341adb> {
[JsonProperty("InvoiceAccountingProcessResponse")]
public ssConectaProveedores.RestRecords.RESTEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord AttrInvoiceAccountingProcessResponse;

public RESTRC_8d2c7f494e763d54feb138104c341adb() { }

public RESTRC_8d2c7f494e763d54feb138104c341adb (RC_8d2c7f494e763d54feb138104c341adb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingProcessResponse = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcessResponse, new EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingProcessResponse = ssConectaProveedores.RestRecords.RESTEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord.FromStructure(s.ssENInvoiceAccountingProcessResponse, config);
  }
}

public static RC_8d2c7f494e763d54feb138104c341adb ToStructure(ssConectaProveedores.RestRecords.RESTRC_8d2c7f494e763d54feb138104c341adb obj) { 
  RC_8d2c7f494e763d54feb138104c341adb s = new RC_8d2c7f494e763d54feb138104c341adb();
  if(obj != null) {
  s.ssENInvoiceAccountingProcessResponse = ssConectaProveedores.RestRecords.RESTEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcessResponse);
  }
  return s;
}

public static Func<RC_8d2c7f494e763d54feb138104c341adb, ssConectaProveedores.RestRecords.RESTRC_8d2c7f494e763d54feb138104c341adb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8d2c7f494e763d54feb138104c341adb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8d2c7f494e763d54feb138104c341adb FromStructure(RC_8d2c7f494e763d54feb138104c341adb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8d2c7f494e763d54feb138104c341adb(s, config);
}

}



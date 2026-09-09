using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedReceiverRecord
public class JSONRC_466f18b870f78193989904128fc2d15c : AbstractRESTStructure<RC_466f18b870f78193989904128fc2d15c> {
[JsonProperty("InvoiceExtendedReceiver")]
[JsonPropertyName("InvoiceExtendedReceiver")]
public ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord AttrInvoiceExtendedReceiver;

public JSONRC_466f18b870f78193989904128fc2d15c() { }

public JSONRC_466f18b870f78193989904128fc2d15c (RC_466f18b870f78193989904128fc2d15c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedReceiver = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedReceiver, new EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedReceiver = ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord.FromStructure(s.ssENInvoiceExtendedReceiver, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_466f18b870f78193989904128fc2d15c, RC_466f18b870f78193989904128fc2d15c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_466f18b870f78193989904128fc2d15c s) => ToStructure(s, config);
}
public static RC_466f18b870f78193989904128fc2d15c ToStructure(ssConectaProveedores.RestRecords.JSONRC_466f18b870f78193989904128fc2d15c obj, IBehaviorsConfiguration config) { 
  RC_466f18b870f78193989904128fc2d15c s = new RC_466f18b870f78193989904128fc2d15c();
  if(obj != null) {
  s.ssENInvoiceExtendedReceiver = ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord.ToStructure(obj.AttrInvoiceExtendedReceiver, config);
  }
  return s;
}

public static Func<RC_466f18b870f78193989904128fc2d15c, ssConectaProveedores.RestRecords.JSONRC_466f18b870f78193989904128fc2d15c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_466f18b870f78193989904128fc2d15c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_466f18b870f78193989904128fc2d15c FromStructure(RC_466f18b870f78193989904128fc2d15c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_466f18b870f78193989904128fc2d15c(s, config);
}

}



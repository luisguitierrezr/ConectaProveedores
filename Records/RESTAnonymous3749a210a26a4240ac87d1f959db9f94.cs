using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedReceiverRecord
public class RESTRC_466f18b870f78193989904128fc2d15c : AbstractRESTStructure<RC_466f18b870f78193989904128fc2d15c> {
[JsonProperty("InvoiceExtendedReceiver")]
public ssConectaProveedores.RestRecords.RESTEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord AttrInvoiceExtendedReceiver;

public RESTRC_466f18b870f78193989904128fc2d15c() { }

public RESTRC_466f18b870f78193989904128fc2d15c (RC_466f18b870f78193989904128fc2d15c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedReceiver = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedReceiver, new EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedReceiver = ssConectaProveedores.RestRecords.RESTEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord.FromStructure(s.ssENInvoiceExtendedReceiver, config);
  }
}

public static RC_466f18b870f78193989904128fc2d15c ToStructure(ssConectaProveedores.RestRecords.RESTRC_466f18b870f78193989904128fc2d15c obj) { 
  RC_466f18b870f78193989904128fc2d15c s = new RC_466f18b870f78193989904128fc2d15c();
  if(obj != null) {
  s.ssENInvoiceExtendedReceiver = ssConectaProveedores.RestRecords.RESTEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord.ToStructure(obj.AttrInvoiceExtendedReceiver);
  }
  return s;
}

public static Func<RC_466f18b870f78193989904128fc2d15c, ssConectaProveedores.RestRecords.RESTRC_466f18b870f78193989904128fc2d15c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_466f18b870f78193989904128fc2d15c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_466f18b870f78193989904128fc2d15c FromStructure(RC_466f18b870f78193989904128fc2d15c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_466f18b870f78193989904128fc2d15c(s, config);
}

}



using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedIssuerRecord
public class JSONRC_bceddfb85670aa95e44aa049194f2b7c : AbstractRESTStructure<RC_bceddfb85670aa95e44aa049194f2b7c> {
[JsonProperty("InvoiceExtendedIssuer")]
[JsonPropertyName("InvoiceExtendedIssuer")]
public ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord AttrInvoiceExtendedIssuer;

public JSONRC_bceddfb85670aa95e44aa049194f2b7c() { }

public JSONRC_bceddfb85670aa95e44aa049194f2b7c (RC_bceddfb85670aa95e44aa049194f2b7c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedIssuer = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedIssuer, new EN_1ca446167f1a5fee035306f622895668EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedIssuer = ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord.FromStructure(s.ssENInvoiceExtendedIssuer, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_bceddfb85670aa95e44aa049194f2b7c, RC_bceddfb85670aa95e44aa049194f2b7c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_bceddfb85670aa95e44aa049194f2b7c s) => ToStructure(s, config);
}
public static RC_bceddfb85670aa95e44aa049194f2b7c ToStructure(ssConectaProveedores.RestRecords.JSONRC_bceddfb85670aa95e44aa049194f2b7c obj, IBehaviorsConfiguration config) { 
  RC_bceddfb85670aa95e44aa049194f2b7c s = new RC_bceddfb85670aa95e44aa049194f2b7c();
  if(obj != null) {
  s.ssENInvoiceExtendedIssuer = ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord.ToStructure(obj.AttrInvoiceExtendedIssuer, config);
  }
  return s;
}

public static Func<RC_bceddfb85670aa95e44aa049194f2b7c, ssConectaProveedores.RestRecords.JSONRC_bceddfb85670aa95e44aa049194f2b7c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bceddfb85670aa95e44aa049194f2b7c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_bceddfb85670aa95e44aa049194f2b7c FromStructure(RC_bceddfb85670aa95e44aa049194f2b7c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_bceddfb85670aa95e44aa049194f2b7c(s, config);
}

}



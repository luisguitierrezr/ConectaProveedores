using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IVAExceptionM9SuppliersRecord
public class JSONRC_7eea8dd886abe2f5de3217d378b871fd : AbstractRESTStructure<RC_7eea8dd886abe2f5de3217d378b871fd> {
[JsonProperty("IVAExceptionM9Suppliers")]
[JsonPropertyName("IVAExceptionM9Suppliers")]
public ssConectaProveedores.RestRecords.JSONEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord AttrIVAExceptionM9Suppliers;

public JSONRC_7eea8dd886abe2f5de3217d378b871fd() { }

public JSONRC_7eea8dd886abe2f5de3217d378b871fd (RC_7eea8dd886abe2f5de3217d378b871fd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIVAExceptionM9Suppliers = ConvertToRestWithoutDefaults(s.ssENIVAExceptionM9Suppliers, new EN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord.FromStructure, config);
  } else {
AttrIVAExceptionM9Suppliers = ssConectaProveedores.RestRecords.JSONEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord.FromStructure(s.ssENIVAExceptionM9Suppliers, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7eea8dd886abe2f5de3217d378b871fd, RC_7eea8dd886abe2f5de3217d378b871fd> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7eea8dd886abe2f5de3217d378b871fd s) => ToStructure(s, config);
}
public static RC_7eea8dd886abe2f5de3217d378b871fd ToStructure(ssConectaProveedores.RestRecords.JSONRC_7eea8dd886abe2f5de3217d378b871fd obj, IBehaviorsConfiguration config) { 
  RC_7eea8dd886abe2f5de3217d378b871fd s = new RC_7eea8dd886abe2f5de3217d378b871fd();
  if(obj != null) {
  s.ssENIVAExceptionM9Suppliers = ssConectaProveedores.RestRecords.JSONEN_7ab1bebf348d8c1167cca3d44f0d19b4EntityRecord.ToStructure(obj.AttrIVAExceptionM9Suppliers, config);
  }
  return s;
}

public static Func<RC_7eea8dd886abe2f5de3217d378b871fd, ssConectaProveedores.RestRecords.JSONRC_7eea8dd886abe2f5de3217d378b871fd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7eea8dd886abe2f5de3217d378b871fd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7eea8dd886abe2f5de3217d378b871fd FromStructure(RC_7eea8dd886abe2f5de3217d378b871fd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7eea8dd886abe2f5de3217d378b871fd(s, config);
}

}



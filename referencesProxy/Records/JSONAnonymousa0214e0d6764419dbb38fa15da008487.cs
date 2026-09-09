using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SupplierRecord
public class JSONRC_4934ec74dc6a80637b84c0985f5b12ce : AbstractRESTStructure<RC_4934ec74dc6a80637b84c0985f5b12ce> {
[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public JSONRC_4934ec74dc6a80637b84c0985f5b12ce() { }

public JSONRC_4934ec74dc6a80637b84c0985f5b12ce (RC_4934ec74dc6a80637b84c0985f5b12ce s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrSupplier = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4934ec74dc6a80637b84c0985f5b12ce, RC_4934ec74dc6a80637b84c0985f5b12ce> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4934ec74dc6a80637b84c0985f5b12ce s) => ToStructure(s, config);
}
public static RC_4934ec74dc6a80637b84c0985f5b12ce ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4934ec74dc6a80637b84c0985f5b12ce obj, IBehaviorsConfiguration config) { 
  RC_4934ec74dc6a80637b84c0985f5b12ce s = new RC_4934ec74dc6a80637b84c0985f5b12ce();
  if(obj != null) {
  s.ssENSupplier = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  }
  return s;
}

public static Func<RC_4934ec74dc6a80637b84c0985f5b12ce, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4934ec74dc6a80637b84c0985f5b12ce> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4934ec74dc6a80637b84c0985f5b12ce s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4934ec74dc6a80637b84c0985f5b12ce FromStructure(RC_4934ec74dc6a80637b84c0985f5b12ce s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4934ec74dc6a80637b84c0985f5b12ce(s, config);
}

}



using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ShapeRecord
public class JSONRC_0a89eeb60fa1f44b6316ca69b462007b : AbstractRESTStructure<RC_0a89eeb60fa1f44b6316ca69b462007b> {
[JsonProperty("Shape")]
[JsonPropertyName("Shape")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d11562be18a7e40ca777aa336c946163EntityRecord AttrShape;

public JSONRC_0a89eeb60fa1f44b6316ca69b462007b() { }

public JSONRC_0a89eeb60fa1f44b6316ca69b462007b (RC_0a89eeb60fa1f44b6316ca69b462007b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrShape = ConvertToRestWithoutDefaults(s.ssENShape, new EN_d11562be18a7e40ca777aa336c946163EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d11562be18a7e40ca777aa336c946163EntityRecord.FromStructure, config);
  } else {
AttrShape = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d11562be18a7e40ca777aa336c946163EntityRecord.FromStructure(s.ssENShape, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0a89eeb60fa1f44b6316ca69b462007b, RC_0a89eeb60fa1f44b6316ca69b462007b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0a89eeb60fa1f44b6316ca69b462007b s) => ToStructure(s, config);
}
public static RC_0a89eeb60fa1f44b6316ca69b462007b ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0a89eeb60fa1f44b6316ca69b462007b obj, IBehaviorsConfiguration config) { 
  RC_0a89eeb60fa1f44b6316ca69b462007b s = new RC_0a89eeb60fa1f44b6316ca69b462007b();
  if(obj != null) {
  s.ssENShape = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d11562be18a7e40ca777aa336c946163EntityRecord.ToStructure(obj.AttrShape, config);
  }
  return s;
}

public static Func<RC_0a89eeb60fa1f44b6316ca69b462007b, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0a89eeb60fa1f44b6316ca69b462007b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0a89eeb60fa1f44b6316ca69b462007b s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0a89eeb60fa1f44b6316ca69b462007b FromStructure(RC_0a89eeb60fa1f44b6316ca69b462007b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0a89eeb60fa1f44b6316ca69b462007b(s, config);
}

}



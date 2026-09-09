using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// RetentionTypesRecord
public class JSONRC_d25c749e180f28d5d6211e73984f17d9 : AbstractRESTStructure<RC_d25c749e180f28d5d6211e73984f17d9> {
[JsonProperty("RetentionTypes")]
[JsonPropertyName("RetentionTypes")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord AttrRetentionTypes;

public JSONRC_d25c749e180f28d5d6211e73984f17d9() { }

public JSONRC_d25c749e180f28d5d6211e73984f17d9 (RC_d25c749e180f28d5d6211e73984f17d9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRetentionTypes = ConvertToRestWithoutDefaults(s.ssENRetentionTypes, new EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord.FromStructure, config);
  } else {
AttrRetentionTypes = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord.FromStructure(s.ssENRetentionTypes, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_d25c749e180f28d5d6211e73984f17d9, RC_d25c749e180f28d5d6211e73984f17d9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_d25c749e180f28d5d6211e73984f17d9 s) => ToStructure(s, config);
}
public static RC_d25c749e180f28d5d6211e73984f17d9 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_d25c749e180f28d5d6211e73984f17d9 obj, IBehaviorsConfiguration config) { 
  RC_d25c749e180f28d5d6211e73984f17d9 s = new RC_d25c749e180f28d5d6211e73984f17d9();
  if(obj != null) {
  s.ssENRetentionTypes = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord.ToStructure(obj.AttrRetentionTypes, config);
  }
  return s;
}

public static Func<RC_d25c749e180f28d5d6211e73984f17d9, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_d25c749e180f28d5d6211e73984f17d9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d25c749e180f28d5d6211e73984f17d9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_d25c749e180f28d5d6211e73984f17d9 FromStructure(RC_d25c749e180f28d5d6211e73984f17d9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_d25c749e180f28d5d6211e73984f17d9(s, config);
}

}



using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RetentionTypesRecord
public class RESTRC_d25c749e180f28d5d6211e73984f17d9 : AbstractRESTStructure<RC_d25c749e180f28d5d6211e73984f17d9> {
[JsonProperty("RetentionTypes")]
public ssConectaProveedores.RestRecords.RESTEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord AttrRetentionTypes;

public RESTRC_d25c749e180f28d5d6211e73984f17d9() { }

public RESTRC_d25c749e180f28d5d6211e73984f17d9 (RC_d25c749e180f28d5d6211e73984f17d9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRetentionTypes = ConvertToRestWithoutDefaults(s.ssENRetentionTypes, new EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord.FromStructure, config);
  } else {
AttrRetentionTypes = ssConectaProveedores.RestRecords.RESTEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord.FromStructure(s.ssENRetentionTypes, config);
  }
}

public static RC_d25c749e180f28d5d6211e73984f17d9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_d25c749e180f28d5d6211e73984f17d9 obj) { 
  RC_d25c749e180f28d5d6211e73984f17d9 s = new RC_d25c749e180f28d5d6211e73984f17d9();
  if(obj != null) {
  s.ssENRetentionTypes = ssConectaProveedores.RestRecords.RESTEN_5d244f83ca27f76a4c8e3850b885554fEntityRecord.ToStructure(obj.AttrRetentionTypes);
  }
  return s;
}

public static Func<RC_d25c749e180f28d5d6211e73984f17d9, ssConectaProveedores.RestRecords.RESTRC_d25c749e180f28d5d6211e73984f17d9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d25c749e180f28d5d6211e73984f17d9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d25c749e180f28d5d6211e73984f17d9 FromStructure(RC_d25c749e180f28d5d6211e73984f17d9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d25c749e180f28d5d6211e73984f17d9(s, config);
}

}



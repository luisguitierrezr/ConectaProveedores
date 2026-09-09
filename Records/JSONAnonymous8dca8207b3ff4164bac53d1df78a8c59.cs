using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BooleanTypesRecord
public class JSONRC_1ea63146d7f1d969afc206832e751192 : AbstractRESTStructure<RC_1ea63146d7f1d969afc206832e751192> {
[JsonProperty("BooleanTypes")]
[JsonPropertyName("BooleanTypes")]
public ssConectaProveedores.RestRecords.JSONEN_1e2af88601c0491260411e1369eb104cEntityRecord AttrBooleanTypes;

public JSONRC_1ea63146d7f1d969afc206832e751192() { }

public JSONRC_1ea63146d7f1d969afc206832e751192 (RC_1ea63146d7f1d969afc206832e751192 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBooleanTypes = ConvertToRestWithoutDefaults(s.ssENBooleanTypes, new EN_1e2af88601c0491260411e1369eb104cEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1e2af88601c0491260411e1369eb104cEntityRecord.FromStructure, config);
  } else {
AttrBooleanTypes = ssConectaProveedores.RestRecords.JSONEN_1e2af88601c0491260411e1369eb104cEntityRecord.FromStructure(s.ssENBooleanTypes, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1ea63146d7f1d969afc206832e751192, RC_1ea63146d7f1d969afc206832e751192> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1ea63146d7f1d969afc206832e751192 s) => ToStructure(s, config);
}
public static RC_1ea63146d7f1d969afc206832e751192 ToStructure(ssConectaProveedores.RestRecords.JSONRC_1ea63146d7f1d969afc206832e751192 obj, IBehaviorsConfiguration config) { 
  RC_1ea63146d7f1d969afc206832e751192 s = new RC_1ea63146d7f1d969afc206832e751192();
  if(obj != null) {
  s.ssENBooleanTypes = ssConectaProveedores.RestRecords.JSONEN_1e2af88601c0491260411e1369eb104cEntityRecord.ToStructure(obj.AttrBooleanTypes, config);
  }
  return s;
}

public static Func<RC_1ea63146d7f1d969afc206832e751192, ssConectaProveedores.RestRecords.JSONRC_1ea63146d7f1d969afc206832e751192> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1ea63146d7f1d969afc206832e751192 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1ea63146d7f1d969afc206832e751192 FromStructure(RC_1ea63146d7f1d969afc206832e751192 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1ea63146d7f1d969afc206832e751192(s, config);
}

}



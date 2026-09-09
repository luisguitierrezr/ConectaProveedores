using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ManualsManualFileRecord
public class JSONRC_367437e31e499bf19d13607cb372e4f5 : AbstractRESTStructure<RC_367437e31e499bf19d13607cb372e4f5> {
[JsonProperty("Manuals")]
[JsonPropertyName("Manuals")]
public ssConectaProveedores.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord AttrManuals;

[JsonProperty("ManualFile")]
[JsonPropertyName("ManualFile")]
public ssConectaProveedores.RestRecords.JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord AttrManualFile;

public JSONRC_367437e31e499bf19d13607cb372e4f5() { }

public JSONRC_367437e31e499bf19d13607cb372e4f5 (RC_367437e31e499bf19d13607cb372e4f5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrManuals = ConvertToRestWithoutDefaults(s.ssENManuals, new EN_f9557b941e05ea8155a182da4f23a896EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord.FromStructure, config);
AttrManualFile = ConvertToRestWithoutDefaults(s.ssENManualFile, new EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord.FromStructure, config);
  } else {
AttrManuals = ssConectaProveedores.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord.FromStructure(s.ssENManuals, config);
AttrManualFile = ssConectaProveedores.RestRecords.JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord.FromStructure(s.ssENManualFile, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_367437e31e499bf19d13607cb372e4f5, RC_367437e31e499bf19d13607cb372e4f5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_367437e31e499bf19d13607cb372e4f5 s) => ToStructure(s, config);
}
public static RC_367437e31e499bf19d13607cb372e4f5 ToStructure(ssConectaProveedores.RestRecords.JSONRC_367437e31e499bf19d13607cb372e4f5 obj, IBehaviorsConfiguration config) { 
  RC_367437e31e499bf19d13607cb372e4f5 s = new RC_367437e31e499bf19d13607cb372e4f5();
  if(obj != null) {
  s.ssENManuals = ssConectaProveedores.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord.ToStructure(obj.AttrManuals, config);
  s.ssENManualFile = ssConectaProveedores.RestRecords.JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord.ToStructure(obj.AttrManualFile, config);
  }
  return s;
}

public static Func<RC_367437e31e499bf19d13607cb372e4f5, ssConectaProveedores.RestRecords.JSONRC_367437e31e499bf19d13607cb372e4f5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_367437e31e499bf19d13607cb372e4f5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_367437e31e499bf19d13607cb372e4f5 FromStructure(RC_367437e31e499bf19d13607cb372e4f5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_367437e31e499bf19d13607cb372e4f5(s, config);
}

}



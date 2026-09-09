using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IT_ATTACHMENTRecord
public class JSONRC_df25272b507942fc4acdb95756118e7f : AbstractRESTStructure<RC_df25272b507942fc4acdb95756118e7f> {
[JsonProperty("IT_ATTACHMENT")]
[JsonPropertyName("IT_ATTACHMENT")]
public ssConectaProveedores.RestRecords.JSONST_7816c3c943d129234de46d39c32a618eStructure AttrIT_ATTACHMENT;

public JSONRC_df25272b507942fc4acdb95756118e7f() { }

public JSONRC_df25272b507942fc4acdb95756118e7f (RC_df25272b507942fc4acdb95756118e7f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIT_ATTACHMENT = ConvertToRestWithoutDefaults(s.ssSTIT_ATTACHMENT, new ST_7816c3c943d129234de46d39c32a618eStructure(), ssConectaProveedores.RestRecords.JSONST_7816c3c943d129234de46d39c32a618eStructure.FromStructure, config);
  } else {
AttrIT_ATTACHMENT = ssConectaProveedores.RestRecords.JSONST_7816c3c943d129234de46d39c32a618eStructure.FromStructure(s.ssSTIT_ATTACHMENT, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_df25272b507942fc4acdb95756118e7f, RC_df25272b507942fc4acdb95756118e7f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_df25272b507942fc4acdb95756118e7f s) => ToStructure(s, config);
}
public static RC_df25272b507942fc4acdb95756118e7f ToStructure(ssConectaProveedores.RestRecords.JSONRC_df25272b507942fc4acdb95756118e7f obj, IBehaviorsConfiguration config) { 
  RC_df25272b507942fc4acdb95756118e7f s = new RC_df25272b507942fc4acdb95756118e7f();
  if(obj != null) {
  s.ssSTIT_ATTACHMENT = ssConectaProveedores.RestRecords.JSONST_7816c3c943d129234de46d39c32a618eStructure.ToStructure(obj.AttrIT_ATTACHMENT, config);
  }
  return s;
}

public static Func<RC_df25272b507942fc4acdb95756118e7f, ssConectaProveedores.RestRecords.JSONRC_df25272b507942fc4acdb95756118e7f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_df25272b507942fc4acdb95756118e7f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_df25272b507942fc4acdb95756118e7f FromStructure(RC_df25272b507942fc4acdb95756118e7f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_df25272b507942fc4acdb95756118e7f(s, config);
}

}



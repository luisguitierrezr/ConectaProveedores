using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IT_ATTACHMENTRecord
public class RESTRC_df25272b507942fc4acdb95756118e7f : AbstractRESTStructure<RC_df25272b507942fc4acdb95756118e7f> {
[JsonProperty("IT_ATTACHMENT")]
public ssConectaProveedores.RestRecords.RESTST_7816c3c943d129234de46d39c32a618eStructure AttrIT_ATTACHMENT;

public RESTRC_df25272b507942fc4acdb95756118e7f() { }

public RESTRC_df25272b507942fc4acdb95756118e7f (RC_df25272b507942fc4acdb95756118e7f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIT_ATTACHMENT = ConvertToRestWithoutDefaults(s.ssSTIT_ATTACHMENT, new ST_7816c3c943d129234de46d39c32a618eStructure(), ssConectaProveedores.RestRecords.RESTST_7816c3c943d129234de46d39c32a618eStructure.FromStructure, config);
  } else {
AttrIT_ATTACHMENT = ssConectaProveedores.RestRecords.RESTST_7816c3c943d129234de46d39c32a618eStructure.FromStructure(s.ssSTIT_ATTACHMENT, config);
  }
}

public static RC_df25272b507942fc4acdb95756118e7f ToStructure(ssConectaProveedores.RestRecords.RESTRC_df25272b507942fc4acdb95756118e7f obj) { 
  RC_df25272b507942fc4acdb95756118e7f s = new RC_df25272b507942fc4acdb95756118e7f();
  if(obj != null) {
  s.ssSTIT_ATTACHMENT = ssConectaProveedores.RestRecords.RESTST_7816c3c943d129234de46d39c32a618eStructure.ToStructure(obj.AttrIT_ATTACHMENT);
  }
  return s;
}

public static Func<RC_df25272b507942fc4acdb95756118e7f, ssConectaProveedores.RestRecords.RESTRC_df25272b507942fc4acdb95756118e7f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_df25272b507942fc4acdb95756118e7f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_df25272b507942fc4acdb95756118e7f FromStructure(RC_df25272b507942fc4acdb95756118e7f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_df25272b507942fc4acdb95756118e7f(s, config);
}

}



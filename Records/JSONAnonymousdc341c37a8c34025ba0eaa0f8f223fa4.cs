using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EmailsNotifStringRecord
public class JSONRC_dade6177501c5e7875e9a6382991b5bd : AbstractRESTStructure<RC_dade6177501c5e7875e9a6382991b5bd> {
[JsonProperty("EmailsNotifString")]
[JsonPropertyName("EmailsNotifString")]
public ssConectaProveedores.RestRecords.JSONST_ec0355ea9ae479e83019f837aa06cae8Structure AttrEmailsNotifString;

public JSONRC_dade6177501c5e7875e9a6382991b5bd() { }

public JSONRC_dade6177501c5e7875e9a6382991b5bd (RC_dade6177501c5e7875e9a6382991b5bd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEmailsNotifString = ConvertToRestWithoutDefaults(s.ssSTEmailsNotifString, new ST_ec0355ea9ae479e83019f837aa06cae8Structure(), ssConectaProveedores.RestRecords.JSONST_ec0355ea9ae479e83019f837aa06cae8Structure.FromStructure, config);
  } else {
AttrEmailsNotifString = ssConectaProveedores.RestRecords.JSONST_ec0355ea9ae479e83019f837aa06cae8Structure.FromStructure(s.ssSTEmailsNotifString, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_dade6177501c5e7875e9a6382991b5bd, RC_dade6177501c5e7875e9a6382991b5bd> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_dade6177501c5e7875e9a6382991b5bd s) => ToStructure(s, config);
}
public static RC_dade6177501c5e7875e9a6382991b5bd ToStructure(ssConectaProveedores.RestRecords.JSONRC_dade6177501c5e7875e9a6382991b5bd obj, IBehaviorsConfiguration config) { 
  RC_dade6177501c5e7875e9a6382991b5bd s = new RC_dade6177501c5e7875e9a6382991b5bd();
  if(obj != null) {
  s.ssSTEmailsNotifString = ssConectaProveedores.RestRecords.JSONST_ec0355ea9ae479e83019f837aa06cae8Structure.ToStructure(obj.AttrEmailsNotifString, config);
  }
  return s;
}

public static Func<RC_dade6177501c5e7875e9a6382991b5bd, ssConectaProveedores.RestRecords.JSONRC_dade6177501c5e7875e9a6382991b5bd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dade6177501c5e7875e9a6382991b5bd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_dade6177501c5e7875e9a6382991b5bd FromStructure(RC_dade6177501c5e7875e9a6382991b5bd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_dade6177501c5e7875e9a6382991b5bd(s, config);
}

}



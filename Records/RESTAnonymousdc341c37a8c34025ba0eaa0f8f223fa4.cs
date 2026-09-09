using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EmailsNotifStringRecord
public class RESTRC_dade6177501c5e7875e9a6382991b5bd : AbstractRESTStructure<RC_dade6177501c5e7875e9a6382991b5bd> {
[JsonProperty("EmailsNotifString")]
public ssConectaProveedores.RestRecords.RESTST_ec0355ea9ae479e83019f837aa06cae8Structure AttrEmailsNotifString;

public RESTRC_dade6177501c5e7875e9a6382991b5bd() { }

public RESTRC_dade6177501c5e7875e9a6382991b5bd (RC_dade6177501c5e7875e9a6382991b5bd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEmailsNotifString = ConvertToRestWithoutDefaults(s.ssSTEmailsNotifString, new ST_ec0355ea9ae479e83019f837aa06cae8Structure(), ssConectaProveedores.RestRecords.RESTST_ec0355ea9ae479e83019f837aa06cae8Structure.FromStructure, config);
  } else {
AttrEmailsNotifString = ssConectaProveedores.RestRecords.RESTST_ec0355ea9ae479e83019f837aa06cae8Structure.FromStructure(s.ssSTEmailsNotifString, config);
  }
}

public static RC_dade6177501c5e7875e9a6382991b5bd ToStructure(ssConectaProveedores.RestRecords.RESTRC_dade6177501c5e7875e9a6382991b5bd obj) { 
  RC_dade6177501c5e7875e9a6382991b5bd s = new RC_dade6177501c5e7875e9a6382991b5bd();
  if(obj != null) {
  s.ssSTEmailsNotifString = ssConectaProveedores.RestRecords.RESTST_ec0355ea9ae479e83019f837aa06cae8Structure.ToStructure(obj.AttrEmailsNotifString);
  }
  return s;
}

public static Func<RC_dade6177501c5e7875e9a6382991b5bd, ssConectaProveedores.RestRecords.RESTRC_dade6177501c5e7875e9a6382991b5bd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dade6177501c5e7875e9a6382991b5bd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_dade6177501c5e7875e9a6382991b5bd FromStructure(RC_dade6177501c5e7875e9a6382991b5bd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_dade6177501c5e7875e9a6382991b5bd(s, config);
}

}



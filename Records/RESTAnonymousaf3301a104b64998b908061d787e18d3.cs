using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ForeignInvoiceUsResultRecord
public class RESTRC_bafaeb2b78c21ab9180984166a89be29 : AbstractRESTStructure<RC_bafaeb2b78c21ab9180984166a89be29> {
[JsonProperty("ForeignInvoiceUsResult")]
public ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure AttrForeignInvoiceUsResult;

public RESTRC_bafaeb2b78c21ab9180984166a89be29() { }

public RESTRC_bafaeb2b78c21ab9180984166a89be29 (RC_bafaeb2b78c21ab9180984166a89be29 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrForeignInvoiceUsResult = ConvertToRestWithoutDefaults(s.ssSTForeignInvoiceUsResult, new ST_6f620840109ac6f721328b723ec0152cStructure(), ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.FromStructure, config);
  } else {
AttrForeignInvoiceUsResult = ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.FromStructure(s.ssSTForeignInvoiceUsResult, config);
  }
}

public static RC_bafaeb2b78c21ab9180984166a89be29 ToStructure(ssConectaProveedores.RestRecords.RESTRC_bafaeb2b78c21ab9180984166a89be29 obj) { 
  RC_bafaeb2b78c21ab9180984166a89be29 s = new RC_bafaeb2b78c21ab9180984166a89be29();
  if(obj != null) {
  s.ssSTForeignInvoiceUsResult = ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.ToStructure(obj.AttrForeignInvoiceUsResult);
  }
  return s;
}

public static Func<RC_bafaeb2b78c21ab9180984166a89be29, ssConectaProveedores.RestRecords.RESTRC_bafaeb2b78c21ab9180984166a89be29> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bafaeb2b78c21ab9180984166a89be29 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_bafaeb2b78c21ab9180984166a89be29 FromStructure(RC_bafaeb2b78c21ab9180984166a89be29 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_bafaeb2b78c21ab9180984166a89be29(s, config);
}

}



using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ForeignInvoiceUsResultRecord
public class JSONRC_bafaeb2b78c21ab9180984166a89be29 : AbstractRESTStructure<RC_bafaeb2b78c21ab9180984166a89be29> {
[JsonProperty("ForeignInvoiceUsResult")]
[JsonPropertyName("ForeignInvoiceUsResult")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6f620840109ac6f721328b723ec0152cStructure AttrForeignInvoiceUsResult;

public JSONRC_bafaeb2b78c21ab9180984166a89be29() { }

public JSONRC_bafaeb2b78c21ab9180984166a89be29 (RC_bafaeb2b78c21ab9180984166a89be29 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrForeignInvoiceUsResult = ConvertToRestWithoutDefaults(s.ssSTForeignInvoiceUsResult, new ST_6f620840109ac6f721328b723ec0152cStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6f620840109ac6f721328b723ec0152cStructure.FromStructure, config);
  } else {
AttrForeignInvoiceUsResult = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6f620840109ac6f721328b723ec0152cStructure.FromStructure(s.ssSTForeignInvoiceUsResult, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_bafaeb2b78c21ab9180984166a89be29, RC_bafaeb2b78c21ab9180984166a89be29> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_bafaeb2b78c21ab9180984166a89be29 s) => ToStructure(s, config);
}
public static RC_bafaeb2b78c21ab9180984166a89be29 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_bafaeb2b78c21ab9180984166a89be29 obj, IBehaviorsConfiguration config) { 
  RC_bafaeb2b78c21ab9180984166a89be29 s = new RC_bafaeb2b78c21ab9180984166a89be29();
  if(obj != null) {
  s.ssSTForeignInvoiceUsResult = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6f620840109ac6f721328b723ec0152cStructure.ToStructure(obj.AttrForeignInvoiceUsResult, config);
  }
  return s;
}

public static Func<RC_bafaeb2b78c21ab9180984166a89be29, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_bafaeb2b78c21ab9180984166a89be29> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bafaeb2b78c21ab9180984166a89be29 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_bafaeb2b78c21ab9180984166a89be29 FromStructure(RC_bafaeb2b78c21ab9180984166a89be29 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_bafaeb2b78c21ab9180984166a89be29(s, config);
}

}



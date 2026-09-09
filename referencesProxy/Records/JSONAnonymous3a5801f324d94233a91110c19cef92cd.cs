using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SpecialPostDeliveryAuthorizationRecord
public class JSONRC_a18bcaa92353126e3b75741517eabbdb : AbstractRESTStructure<RC_a18bcaa92353126e3b75741517eabbdb> {
[JsonProperty("SpecialPostDeliveryAuthorization")]
[JsonPropertyName("SpecialPostDeliveryAuthorization")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord AttrSpecialPostDeliveryAuthorization;

public JSONRC_a18bcaa92353126e3b75741517eabbdb() { }

public JSONRC_a18bcaa92353126e3b75741517eabbdb (RC_a18bcaa92353126e3b75741517eabbdb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSpecialPostDeliveryAuthorization = ConvertToRestWithoutDefaults(s.ssENSpecialPostDeliveryAuthorization, new EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord.FromStructure, config);
  } else {
AttrSpecialPostDeliveryAuthorization = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord.FromStructure(s.ssENSpecialPostDeliveryAuthorization, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a18bcaa92353126e3b75741517eabbdb, RC_a18bcaa92353126e3b75741517eabbdb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a18bcaa92353126e3b75741517eabbdb s) => ToStructure(s, config);
}
public static RC_a18bcaa92353126e3b75741517eabbdb ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a18bcaa92353126e3b75741517eabbdb obj, IBehaviorsConfiguration config) { 
  RC_a18bcaa92353126e3b75741517eabbdb s = new RC_a18bcaa92353126e3b75741517eabbdb();
  if(obj != null) {
  s.ssENSpecialPostDeliveryAuthorization = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord.ToStructure(obj.AttrSpecialPostDeliveryAuthorization, config);
  }
  return s;
}

public static Func<RC_a18bcaa92353126e3b75741517eabbdb, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a18bcaa92353126e3b75741517eabbdb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a18bcaa92353126e3b75741517eabbdb s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a18bcaa92353126e3b75741517eabbdb FromStructure(RC_a18bcaa92353126e3b75741517eabbdb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_a18bcaa92353126e3b75741517eabbdb(s, config);
}

}



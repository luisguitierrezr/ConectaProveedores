using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SpecialPostDeliveryAuthorizationRecord
public class RESTRC_a18bcaa92353126e3b75741517eabbdb : AbstractRESTStructure<RC_a18bcaa92353126e3b75741517eabbdb> {
[JsonProperty("SpecialPostDeliveryAuthorization")]
public ssConectaProveedores.RestRecords.RESTEN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord AttrSpecialPostDeliveryAuthorization;

public RESTRC_a18bcaa92353126e3b75741517eabbdb() { }

public RESTRC_a18bcaa92353126e3b75741517eabbdb (RC_a18bcaa92353126e3b75741517eabbdb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSpecialPostDeliveryAuthorization = ConvertToRestWithoutDefaults(s.ssENSpecialPostDeliveryAuthorization, new EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord.FromStructure, config);
  } else {
AttrSpecialPostDeliveryAuthorization = ssConectaProveedores.RestRecords.RESTEN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord.FromStructure(s.ssENSpecialPostDeliveryAuthorization, config);
  }
}

public static RC_a18bcaa92353126e3b75741517eabbdb ToStructure(ssConectaProveedores.RestRecords.RESTRC_a18bcaa92353126e3b75741517eabbdb obj) { 
  RC_a18bcaa92353126e3b75741517eabbdb s = new RC_a18bcaa92353126e3b75741517eabbdb();
  if(obj != null) {
  s.ssENSpecialPostDeliveryAuthorization = ssConectaProveedores.RestRecords.RESTEN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord.ToStructure(obj.AttrSpecialPostDeliveryAuthorization);
  }
  return s;
}

public static Func<RC_a18bcaa92353126e3b75741517eabbdb, ssConectaProveedores.RestRecords.RESTRC_a18bcaa92353126e3b75741517eabbdb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a18bcaa92353126e3b75741517eabbdb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a18bcaa92353126e3b75741517eabbdb FromStructure(RC_a18bcaa92353126e3b75741517eabbdb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a18bcaa92353126e3b75741517eabbdb(s, config);
}

}



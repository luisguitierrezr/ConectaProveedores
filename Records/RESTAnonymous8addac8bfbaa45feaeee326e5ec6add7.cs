using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NewDirectionIdNewDivisionIdNewRegionIdRecord
public class RESTRC_957af43c68dca2b8260b54a010c3971e : AbstractRESTStructure<RC_957af43c68dca2b8260b54a010c3971e> {
[JsonProperty("NewDirectionId")]
public ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrNewDirectionId;

[JsonProperty("NewDivisionId")]
public ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrNewDivisionId;

[JsonProperty("NewRegionId")]
public ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrNewRegionId;

public RESTRC_957af43c68dca2b8260b54a010c3971e() { }

public RESTRC_957af43c68dca2b8260b54a010c3971e (RC_957af43c68dca2b8260b54a010c3971e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNewDirectionId = ConvertToRestWithoutDefaults(s.ssSTNewDirectionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrNewDivisionId = ConvertToRestWithoutDefaults(s.ssSTNewDivisionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrNewRegionId = ConvertToRestWithoutDefaults(s.ssSTNewRegionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
  } else {
AttrNewDirectionId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTNewDirectionId, config);
AttrNewDivisionId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTNewDivisionId, config);
AttrNewRegionId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTNewRegionId, config);
  }
}

public static RC_957af43c68dca2b8260b54a010c3971e ToStructure(ssConectaProveedores.RestRecords.RESTRC_957af43c68dca2b8260b54a010c3971e obj) { 
  RC_957af43c68dca2b8260b54a010c3971e s = new RC_957af43c68dca2b8260b54a010c3971e();
  if(obj != null) {
  s.ssSTNewDirectionId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrNewDirectionId);
  s.ssSTNewDivisionId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrNewDivisionId);
  s.ssSTNewRegionId = ssConectaProveedores.RestRecords.RESTST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrNewRegionId);
  }
  return s;
}

public static Func<RC_957af43c68dca2b8260b54a010c3971e, ssConectaProveedores.RestRecords.RESTRC_957af43c68dca2b8260b54a010c3971e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_957af43c68dca2b8260b54a010c3971e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_957af43c68dca2b8260b54a010c3971e FromStructure(RC_957af43c68dca2b8260b54a010c3971e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_957af43c68dca2b8260b54a010c3971e(s, config);
}

}



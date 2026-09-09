using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NewDirectionIdNewDivisionIdNewRegionIdRecord
public class JSONRC_957af43c68dca2b8260b54a010c3971e : AbstractRESTStructure<RC_957af43c68dca2b8260b54a010c3971e> {
[JsonProperty("NewDirectionId")]
[JsonPropertyName("NewDirectionId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrNewDirectionId;

[JsonProperty("NewDivisionId")]
[JsonPropertyName("NewDivisionId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrNewDivisionId;

[JsonProperty("NewRegionId")]
[JsonPropertyName("NewRegionId")]
public ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure AttrNewRegionId;

public JSONRC_957af43c68dca2b8260b54a010c3971e() { }

public JSONRC_957af43c68dca2b8260b54a010c3971e (RC_957af43c68dca2b8260b54a010c3971e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNewDirectionId = ConvertToRestWithoutDefaults(s.ssSTNewDirectionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrNewDivisionId = ConvertToRestWithoutDefaults(s.ssSTNewDivisionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
AttrNewRegionId = ConvertToRestWithoutDefaults(s.ssSTNewRegionId, new ST_52a0b4b2bb66d62c40848f2d472a3986Structure(), ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure, config);
  } else {
AttrNewDirectionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTNewDirectionId, config);
AttrNewDivisionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTNewDivisionId, config);
AttrNewRegionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.FromStructure(s.ssSTNewRegionId, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_957af43c68dca2b8260b54a010c3971e, RC_957af43c68dca2b8260b54a010c3971e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_957af43c68dca2b8260b54a010c3971e s) => ToStructure(s, config);
}
public static RC_957af43c68dca2b8260b54a010c3971e ToStructure(ssConectaProveedores.RestRecords.JSONRC_957af43c68dca2b8260b54a010c3971e obj, IBehaviorsConfiguration config) { 
  RC_957af43c68dca2b8260b54a010c3971e s = new RC_957af43c68dca2b8260b54a010c3971e();
  if(obj != null) {
  s.ssSTNewDirectionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrNewDirectionId, config);
  s.ssSTNewDivisionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrNewDivisionId, config);
  s.ssSTNewRegionId = ssConectaProveedores.RestRecords.JSONST_52a0b4b2bb66d62c40848f2d472a3986Structure.ToStructure(obj.AttrNewRegionId, config);
  }
  return s;
}

public static Func<RC_957af43c68dca2b8260b54a010c3971e, ssConectaProveedores.RestRecords.JSONRC_957af43c68dca2b8260b54a010c3971e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_957af43c68dca2b8260b54a010c3971e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_957af43c68dca2b8260b54a010c3971e FromStructure(RC_957af43c68dca2b8260b54a010c3971e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_957af43c68dca2b8260b54a010c3971e(s, config);
}

}


